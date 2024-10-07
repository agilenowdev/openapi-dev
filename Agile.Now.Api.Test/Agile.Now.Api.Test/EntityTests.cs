using Xunit;

namespace Agile.Now.Api.Test;

public class EntityTests<TResponse, TId, TRequest> : EntityTestsBase<TResponse, TId, TRequest> {
    public readonly Func<string, string, int, int, List<TResponse>> List;
    public readonly Func<string, string, TResponse> Get;
    public readonly Func<TRequest, TResponse> Create;
    public readonly Func<string, TRequest, string, TResponse> Update;
    public readonly Func<TRequest, TResponse> Upsert;
    public readonly Func<List<TRequest>, IEnumerable<TResponse>> Patch;
    public readonly Action<string, string> Delete;

    public EntityTests(
        Attribute<TResponse, TId, TRequest> id,
        TestData<TResponse, TRequest> testData,
        Attribute<TResponse, string, TRequest>[] uniqueAttributes = null,

        Func<string, string, int, int, List<TResponse>> list = null,
        Func<string, string, TResponse> get = null,
        Func<TRequest, TResponse> create = null,
        Func<string, TRequest, string, TResponse> update = null,
        Func<TRequest, TResponse> upsert = null,
        Func<List<TRequest>, IEnumerable<TResponse>> patch = null,
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

    TResponse[] GenerateEntities(int count) =>
        testData.GenerateInsertData().Take(count).Select(i => Create(i)).ToArray();

    void DeleteEntities(params TResponse[] entities) {
        foreach(var i in entities)
            Delete(id.Get(i).ToString(), id.Name);
    }

    string CreateFilters<TValue>(Attribute<TResponse, TValue, TRequest> attribute, IEnumerable<TResponse> entities) =>
        $"{attribute.Name} In {string.Join(attribute.GetSeparator(), entities.Select(i => attribute.Get(i)))}";

    void Test_List<TValue>(params Attribute<TResponse, TValue, TRequest>[] attributes) {
        var created = GenerateEntities(2);
        try {
            foreach(var i in attributes) {
                var existing = List(CreateFilters(i, created), null, 0, testData.DefaultPageSize);
                Assert.Equal(created.Length, existing.GroupBy(i => id.Get(i)).Count());
            }
        }
        finally {
            DeleteEntities(created);
        }
    }

    public void Test_List_ById() => Test_List(id);
    public void Test_List_ByUniqueAttributes() => Test_List(uniqueAttributes);

    public void Test_List_Paging() {
        var created = GenerateEntities(3);
        try {
            var filters = CreateFilters(id, created);
            var pageSize = 2;
            var pages = new[] {
                List(filters, null, 0, pageSize),
                List(filters, null, 1, pageSize),
            };
            Assert.Equal(pageSize, pages[0].Count);
            Assert.Equal(1, pages[1].Count);
            Assert.Equal(created.Length, pages[0].Concat(pages[1]).GroupBy(i => id.Get(i)).Count());
        }
        finally {
            DeleteEntities(created);
        }
    }

    void Test_List_Order(Func<IEnumerable<TId>, IOrderedEnumerable<TId>> f, string order) {
        var created = GenerateEntities(3);
        try {
            var ordered = List(CreateFilters(id, created), $"{id.Name} {order}", 0, created.Length);
            Assert.True(ordered.Select(i => id.Get(i))
                .SequenceEqual(f(created.Select(i => id.Get(i)))));
        }
        finally {
            DeleteEntities(created);
        }
    }

    public void Test_List_OrderAscending() => Test_List_Order(x => x.Order(), "ASC");
    public void Test_List_OrderDecending() => Test_List_Order(x => x.OrderDescending(), "DESC");

    void Test_Get<TValue>(params Attribute<TResponse, TValue, TRequest>[] attributes) {
        var created = GenerateEntities(1).First();
        try {
            foreach(var i in attributes) {
                Assert.Null(Record.Exception(() => {
                    var existing = Get(i.Get(created).ToString(), i.Name);
                    testData.AssertEqualResponses(created, existing);
                    return existing;
                }));
            }
        }
        finally {
            DeleteEntities(created);
        }
    }

    public void Test_Get_ById() => Test_Get(id);
    public void Test_Get_ByUniqueAttributes() => Test_Get(uniqueAttributes);

    public void Test_Create() {
        var data = testData.GenerateInsertData().First();
        var created = Create(data);
        try {
            testData.AssertEqualRequestResponse(data, created);
        }
        finally {
            Delete(id.Get(created).ToString(), id.Name);
        }
    }

    public void Test_Create_WithUniqueAttributes() {
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

    public void Test_Update_ById() {
        var data = testData.GenerateInsertData().First();
        var created = Create(data);
        try {
            testData.Update(data);
            var updated = Update(id.Get(created).ToString(), data, id.Name);
            Assert.Equal(id.Get(created), id.Get(updated));
            testData.AssertEqualRequestResponse(data, updated);
        }
        finally {
            Delete(id.Get(created).ToString(), id.Name);
        }
    }

    public void Test_Update_WithUniqueAttributes() {
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

    public void Test_Update_ByUniqueAttributes() {
        var data = testData.GenerateInsertData().First();
        var created = Create(data);
        try {
            foreach(var uniqueAttribute in uniqueAttributes) {
                testData.Update(data);
                var updated = Update(
                    uniqueAttribute.Get(created), data, uniqueAttribute.Name);
                Assert.Equal(id.Get(created), id.Get(updated));
                testData.AssertEqualRequestResponse(data, updated);
            }
        }
        finally {
            Delete(id.Get(created).ToString(), id.Name);
        }
    }

    public void Test_Upsert() {
        var data = testData.GenerateInsertData().First();
        var created = Upsert(data);
        try {
            testData.AssertEqualRequestResponse(data, created);
            testData.Update(data);
            id.Set(data, id.Get(created));
            var updated = Upsert(data);
            Assert.Equal(id.Get(created), id.Get(updated));
            testData.AssertEqualRequestResponse(data, updated);
        }
        finally {
            Delete(id.Get(created).ToString(), id.Name);
        }
    }

    public void Test_Patch() {
        throw new NotImplementedException();
    }

    public void Test_Delete_ById() {
        var created = Create(testData.GenerateInsertData().First());
        Delete(id.Get(created).ToString(), id.Name);
        Assert.ThrowsAny<Exception>(() => Get(id.Get(created).ToString(), ""));
    }

    public void Test_Delete_ByUniqueAttributes() {
        foreach(var uniqueAttribute in uniqueAttributes) {
            var created = Create(testData.GenerateInsertData().First());
            Delete(uniqueAttribute.Get(created), uniqueAttribute.Name);
            Assert.ThrowsAny<Exception>(() => Get(id.Get(created).ToString(), ""));
        }
    }
}
