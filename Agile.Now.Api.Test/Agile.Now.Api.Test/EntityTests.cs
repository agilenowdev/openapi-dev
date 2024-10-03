using Xunit;

namespace Agile.Now.Api.Test;

public class EntityTests<TResponseData, TId, TRequestData> : EntityTestsBase<TResponseData, TId, TRequestData> {
    public readonly Func<string, int, int, List<TResponseData>> List;
    public readonly Func<string, string, TResponseData> Get;
    public readonly Func<TRequestData, TResponseData> Create;
    public readonly Func<string, TRequestData, string, TResponseData> Update;
    public readonly Func<TRequestData, TResponseData> Upsert;
    public readonly Func<List<TRequestData>, IEnumerable<TResponseData>> Patch;
    public readonly Action<string, string> Delete;

    public EntityTests(
        Attribute<TResponseData, TId, TRequestData> id,
        TestData<TResponseData, TRequestData> testData,
        Attribute<TResponseData, string, TRequestData>[] uniqueAttributes = null,

        Func<string, int, int, List<TResponseData>> list = null,
        Func<string, string, TResponseData> get = null,
        Func<TRequestData, TResponseData> create = null,
        Func<string, TRequestData, string, TResponseData> update = null,
        Func<TRequestData, TResponseData> upsert = null,
        Func<List<TRequestData>, IEnumerable<TResponseData>> patch = null,
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

    public override TId CreateInternal() => id.Get(Create(testData.GenerateInsertData().First()));

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
                Assert.ThrowsAny<Exception>(() => Create(data));
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
            var updated = Update(id.Get(created).ToString(), data, id.Name);
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
                    Assert.ThrowsAny<Exception>(() =>
                    Update(id.Get(toUpdate).ToString(), data, id.Name));
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
                    uniqueAttribute.Get(created), data, uniqueAttribute.Name);
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
        var created = Upsert(data);
        try {
            testData.AssertEqual(data, created);
            testData.Update(data);
            id.Set(data, id.Get(created));
            var updated = Upsert(data);
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
        Assert.ThrowsAny<Exception>(() => Get(id.Get(created).ToString(), ""));
    }

    public override void Test_Delete_ByUniqueAttributes() {
        foreach(var uniqueAttribute in uniqueAttributes) {
            var created = Create(testData.GenerateInsertData().First());
            Delete(uniqueAttribute.Get(created), uniqueAttribute.Name);
            Assert.ThrowsAny<Exception>(() => Get(id.Get(created).ToString(), ""));
        }
    }
}
