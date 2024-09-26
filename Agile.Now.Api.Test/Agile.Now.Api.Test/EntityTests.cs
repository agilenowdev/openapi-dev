using Xunit;

namespace Agile.Now.Api.Test;

public class EntityTests<TReadData, TReadDataId, TInsertData, TUpdateData, TUpsertData, TPatchData>
    : EntityTestsBase<TReadData, TReadDataId, TInsertData, TUpdateData, TUpsertData, TPatchData>

    where TUpdateData : class
    where TUpsertData : class {

    public readonly Func<string, int, int, List<TReadData>> List;
    public readonly Func<string, string, TReadData> Get;
    public readonly Func<TInsertData, TReadData> Create;
    public readonly Func<string, TUpdateData, string, TReadData> Update;
    public readonly Func<TUpsertData, TReadData> Upsert;
    public readonly Func<List<TPatchData>, IEnumerable<TReadData>> Patch;
    public readonly Action<string, string> Delete;

    public EntityTests(
        Attribute<TReadData, TReadDataId, TInsertData> id,
        TestData<TReadData, TInsertData, TUpdateData, TUpsertData, TPatchData> testData,
        Attribute<TReadData, string, TInsertData>[] uniqueAttributes = null,

        Func<string, int, int, List<TReadData>> list = null,
        Func<string, string, TReadData> get = null,
        Func<TInsertData, TReadData> create = null,
        Func<string, TUpdateData, string, TReadData> update = null,
        Func<TUpsertData, TReadData> upsert = null,
        Func<List<TPatchData>, IEnumerable<TReadData>> patch = null,
        Action<string, string> delete = null)

        : base(id, testData, uniqueAttributes) {

        List = list;
        Get = get;
        Create = create;
        Update = update;
        Upsert = upsert;
        Patch = patch;
        Delete = delete;
    }

    public override TReadDataId CreateInternal() => id.Get(Create(testData.GenerateInsertData().First()));

    public override void DeleteInternal(string id) => Delete(id, this.id.Name);

    public override void Test_List_ById() {
        var created = testData.GenerateInsertData().Take(2).Select(i => Create(i)).ToArray();
        try {
            var existing = List(
                $"{id.Name} In {string.Join(id.GetSeparator(), created.Select(i => id.Get(i)))}", 0, 50);
            Assert.Equal(created.Length, existing.Count);
        }
        finally {
            foreach(var i in created)
                Delete(id.Get(i).ToString(), id.Name);
        }
    }

    public override void Test_List_ByUniqueAttributes() {
        var created = testData.GenerateInsertData().Take(2).Select(i => Create(i)).ToArray();
        try {
            foreach(var uniqueAttribute in uniqueAttributes) {
                var existing = List(
                    $"{uniqueAttribute.Name} In {string.Join(uniqueAttribute.GetSeparator(), created.Select(i => uniqueAttribute.Get(i)))}",
                    0, 50);
                Assert.Equal(created.Length, existing.Count);
            }
        }
        finally {
            foreach(var i in created)
                Delete(id.Get(i).ToString(), id.Name);
        }
    }

    public override void Test_List_Paging() {
        var created = testData.GenerateInsertData().Take(3).Select(i => Create(i)).ToArray();
        try {
            var filters = $"{id.Name} In {string.Join(id.GetSeparator(), created.Select(i => id.Get(i)))}";
            var pageSize = 2;
            var pages = new[] {
                List(filters, 0, pageSize),
                List(filters, 1, pageSize),
            };
            Assert.Equal(pageSize, pages[0].Count);
            Assert.Equal(1, pages[1].Count);
            Assert.Equal(created.Length, pages[0].Concat(pages[1]).GroupBy(i => id.Get(i)).Count());
        }
        finally {
            foreach(var i in created)
                Delete(id.Get(i).ToString(), id.Name);
        }
    }

    public override void Test_Get_ById() {
        var created = Create(testData.GenerateInsertData().First());
        try {
            Assert.Null(Record.Exception(() => {
                var existing = Get(id.Get(created).ToString(), id.Name);
                Assert.Equal(id.Get(created), id.Get(existing));
                return existing;
            }));
        }
        finally {
            Delete(id.Get(created).ToString(), id.Name);
        }
    }

    public override void Test_Get_ByUniqueAttributes() {
        var created = Create(testData.GenerateInsertData().First());
        try {
            foreach(var uniqueAttribute in uniqueAttributes) {
                Assert.Null(Record.Exception(() => {
                    var existing = Get(uniqueAttribute.Get(created), uniqueAttribute.Name);
                    Assert.Equal(id.Get(created), id.Get(existing));
                    return existing;
                }));
            }
        }
        finally {
            Delete(id.Get(created).ToString(), id.Name);
        }
    }

    public override void Test_Create() {
        var data = testData.GenerateInsertData().First();
        var created = Create(data);
        try {
            testData.AssertEqual(data, created);
        }
        finally {
            Delete(id.Get(created).ToString(), id.Name);
        }
    }

    public override void Test_Create_WithUniqueAttributes() {
        var created = Create(testData.GenerateInsertData().First());
        try {
            foreach(var uniqueAttribute in uniqueAttributes) {
                var data = testData.GenerateInsertData().First();
                uniqueAttribute.Set(data, uniqueAttribute.Get(created));
                Assert.Throws<Exception>(() => Create(data));
            }
        }
        finally {
            Delete(id.Get(created).ToString(), id.Name);
        }
    }

    public override void Test_Update_ById() {
        var data = testData.GenerateInsertData().First();
        var created = Create(data);
        try {
            testData.Update(data);
            var updated = Update(id.Get(created).ToString(), testData.ToUpdateData(data), id.Name);
            Assert.Equal(id.Get(created), id.Get(updated));
            testData.AssertEqual(data, updated);
        }
        finally {
            Delete(id.Get(created).ToString(), id.Name);
        }
    }

    public override void Test_Update_WithUniqueAttributes() {
        var created = Create(testData.GenerateInsertData().First());
        try {
            var data = testData.GenerateInsertData().First();
            var toUpdate = Create(data);
            try {
                foreach(var uniqueAttribute in uniqueAttributes) {
                    data = testData.GenerateInsertData().First();
                    uniqueAttribute.Set(data, uniqueAttribute.Get(created));
                    Assert.Throws<Exception>(() =>
                    Update(id.Get(toUpdate).ToString(), testData.ToUpdateData(data), id.Name));
                }
            }
            finally {
                Delete(id.Get(toUpdate).ToString(), id.Name);
            }
        }
        finally {
            Delete(id.Get(created).ToString(), id.Name);
        }
    }

    public override void Test_Update_ByUniqueAttributes() {
        var data = testData.GenerateInsertData().First();
        var created = Create(data);
        try {
            foreach(var uniqueAttribute in uniqueAttributes) {
                testData.Update(data);
                var updated = Update(
                    uniqueAttribute.Get(created), testData.ToUpdateData(data), uniqueAttribute.Name);
                Assert.Equal(id.Get(created), id.Get(updated));
                testData.AssertEqual(data, updated);
            }
        }
        finally {
            Delete(id.Get(created).ToString(), id.Name);
        }
    }

    public override void Test_Upsert() {
        var data = testData.GenerateInsertData().First();
        var created = Upsert(testData.ToUpsertData(data));
        try {
            testData.AssertEqual(data, created);
            testData.Update(data);
            id.Set(data, id.Get(created));
            var updated = Upsert(testData.ToUpsertData(data));
            Assert.Equal(id.Get(created), id.Get(updated));
            testData.AssertEqual(data, updated);
        }
        finally {
            Delete(id.Get(created).ToString(), id.Name);
        }
    }

    public override void Test_Patch() {
        throw new NotImplementedException();
    }

    public override void Test_Delete_ById() {
        var created = Create(testData.GenerateInsertData().First());
        Delete(id.Get(created).ToString(), id.Name);
        Assert.Throws<Exception>(() => Get(id.Get(created).ToString(), ""));
    }

    public override void Test_Delete_ByUniqueAttributes() {
        foreach(var uniqueAttribute in uniqueAttributes) {
            var created = Create(testData.GenerateInsertData().First());
            Delete(uniqueAttribute.Get(created), uniqueAttribute.Name);
            Assert.Throws<Exception>(() => Get(id.Get(created).ToString(), ""));
        }
    }
}
