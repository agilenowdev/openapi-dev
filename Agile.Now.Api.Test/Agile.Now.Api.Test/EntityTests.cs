using Xunit;

namespace Agile.Now.Api.Test;

public class EntityTests<TResponse, TId, TRequest> : EntityTestsBase<TResponse, TId, TRequest> {
    public EntityTests(
        TestData<TResponse, TRequest> testData,
        Attribute<TResponse, TId, TRequest> id,
        Attribute<TResponse, string, TRequest>[] uniqueAttributes = null)

        : base(testData, id, uniqueAttributes) {
    }

    protected virtual List<TResponse> List(string filters, string orders, int currentPage, int pageSize) => default;
    protected virtual TResponse Get(string id, string name) => default;
    protected virtual TResponse Create(TRequest data) => default;
    protected virtual TResponse Update(string id, TRequest data, string name) => default;
    protected virtual TResponse Upsert(TRequest data) => default;
    protected virtual IEnumerable<TResponse> Patch(List<TRequest> data) => default;
    protected virtual TResponse Delete(string id, string name) => default;

    public override TId CreateInternal() => id.Get(Create(testData.GenerateRequestData().First()));

    public override void DeleteInternal(string id) => Delete(id, this.id.Name);

    TResponse[] GenerateEntities(int count) =>
        testData.GenerateRequestData().Take(count).Select(i => Create(i)).ToArray();

    void Delete(params TResponse[] entities) {
        foreach(var i in entities)
            Delete(id.Get(i).ToString(), id.Name);
    }

    void Test_List<TValue>(params Attribute<TResponse, TValue, TRequest>[] attributes) {
        var created = GenerateEntities(2);
        try {
            foreach(var i in attributes) {
                var existing = List(i.CreateFilters(created), null, 0, testData.DefaultPageSize);
                Assert.Equal(created.Length, existing.GroupBy(i => id.Get(i)).Count());
            }
        }
        finally {
            Delete(created);
        }
    }

    public void Test_List_ById() => Test_List(id);
    public void Test_List_ByUniqueAttributes() => Test_List(uniqueAttributes);

    public void Test_List_Paging() {
        var created = GenerateEntities(3);
        try {
            var filters = id.CreateFilters(created);
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
            Delete(created);
        }
    }

    void Test_List_Order(Func<IEnumerable<TId>, IOrderedEnumerable<TId>> f, string order) {
        var created = GenerateEntities(3);
        try {
            var ordered = List(id.CreateFilters(created), $"{id.Name} {order}", 0, created.Length);
            Assert.True(ordered.Select(i => id.Get(i))
                .SequenceEqual(f(created.Select(i => id.Get(i)))));
        }
        finally {
            Delete(created);
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
                    testData.AssertEqual(created, existing);
                    return existing;
                }));
            }
        }
        finally {
            Delete(created);
        }
    }

    public void Test_Get_ById() => Test_Get(id);
    public void Test_Get_ByUniqueAttributes() => Test_Get(uniqueAttributes);

    public void Test_Create() {
        var data = testData.GenerateRequestData().First();
        var created = Create(data);
        try {
            testData.AssertEqual(data, created);
        }
        finally {
            Delete(created);
        }
    }

    public void Test_Create_WithUniqueAttributes() {
        var created = GenerateEntities(1).First();
        try {
            foreach(var i in uniqueAttributes) {
                var data = testData.GenerateRequestData().First();
                i.Set(data, i.Get(created));
                Assert.ThrowsAny<Exception>(() => Create(data));
            }
        }
        finally {
            Delete(created);
        }
    }

    public void Test_Update_ById() {
        var data = testData.GenerateRequestData().First();
        var created = Create(data);
        try {
            testData.Update(data);
            var updated = Update(id.Get(created).ToString(), data, id.Name);
            Assert.Equal(id.Get(created), id.Get(updated));
            testData.AssertEqual(data, updated);
        }
        finally {
            Delete(created);
        }
    }

    public void Test_Update_ByUniqueAttributes() {
        var data = testData.GenerateRequestData().First();
        var created = Create(data);
        try {
            foreach(var i in uniqueAttributes) {
                testData.Update(data);
                var updated = Update(i.Get(created), data, i.Name);
                Assert.Equal(id.Get(created), id.Get(updated));
                testData.AssertEqual(data, updated);
            }
        }
        finally {
            Delete(created);
        }
    }

    public void Test_Upsert() {
        var data = testData.GenerateRequestData().First();
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
            Delete(created);
        }
    }

    public void Test_Patch() {
        throw new NotImplementedException();
    }

    public void Test_Delete_ById() {
        var created = GenerateEntities(1).First();
        var deleted = Delete(id.Get(created).ToString(), id.Name);
        testData.AssertEqual(created, deleted);
        Assert.ThrowsAny<Exception>(() => Get(id.Get(created).ToString(), id.Name));
    }

    public void Test_Delete_ByUniqueAttributes() {
        foreach(var i in uniqueAttributes) {
            var created = GenerateEntities(1).First();
            Delete(created);
            Assert.ThrowsAny<Exception>(() => Get(id.Get(created).ToString(), i.Name));
        }
    }
}
