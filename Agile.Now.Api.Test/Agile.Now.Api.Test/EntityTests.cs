using Xunit;

namespace Agile.Now.Api.Test;

public class EntityTests<TResponse, TId, TRequest> : EntityTestsBase<TResponse, TId, TRequest> {
    public EntityTests(
        TestData<TResponse, TRequest> testData,
        Attribute<TResponse, TId, TRequest> id,
        Attribute<TResponse, string, TRequest>[] uniqueAttributes = null)

        : base(testData, id, uniqueAttributes) {
    }

    protected virtual List<TResponse> List(
        string filters, string orders = default, int currentPage = default, int pageSize = DefaultPageSize) => default;

    protected virtual TResponse Get(string id, string name) => default;
    protected virtual TResponse Create(TRequest data) => default;
    protected virtual TResponse Update(string id, TRequest data, string name) => default;
    protected virtual TResponse Upsert(TRequest data) => default;
    protected virtual IEnumerable<TResponse> Patch(List<TRequest> data) => default;
    protected virtual TResponse Delete(string id, string name) => default;

    public TResponse[] GenerateEntities(int count) =>
        testData.GenerateRequestData().Take(count).Select(i => Create(i)).ToArray();

    public TResponse GenerateEntity() => GenerateEntities(1).First();

    public void Delete(params TResponse[] entities) {
        foreach(var i in entities)
            Delete(Id.Get(i).ToString(), Id.Name);
    }

    void Test_List<TValue>(params Attribute<TResponse, TValue, TRequest>[] attributes) {
        var created = GenerateEntities(2);
        try {
            foreach(var i in attributes) {
                var existing = List(i.CreateFilters(created));
                AssertCollectionsEqual(created, existing);
            }
        }
        finally {
            Delete(created);
        }
    }

    public void Test_List_ById() => Test_List(Id);
    public void Test_List_ByUniqueAttributes() => Test_List(uniqueAttributes);

    public void Test_List_Paging() {
        var created = GenerateEntities(3);
        try {
            var filters = Id.CreateFilters(created);
            var pageSize = 2;
            var pages = new[] {
                List(filters, null, 0, pageSize),
                List(filters, null, 1, pageSize),
            };
            Assert.Equal(pageSize, pages[0].Count);
            Assert.Equal(1, pages[1].Count);
            Assert.Equal(created.Length, pages[0].Concat(pages[1]).GroupBy(i => Id.Get(i)).Count());
        }
        finally {
            Delete(created);
        }
    }

    void Test_List_Order(Func<IEnumerable<TId>, IOrderedEnumerable<TId>> f, string order) {
        var created = GenerateEntities(3);
        try {
            var actual = List(Id.CreateFilters(created), $"{Id.Name} {order}");
            var expected = f(created.Select(i => Id.Get(i)));
            Assert.True(actual.Select(i => Id.Get(i)).SequenceEqual(expected));
        }
        finally {
            Delete(created);
        }
    }

    public void Test_List_OrderAscending() => Test_List_Order(x => x.Order(), "ASC");
    public void Test_List_OrderDecending() => Test_List_Order(x => x.OrderDescending(), "DESC");

    void Test_Get<TValue>(params Attribute<TResponse, TValue, TRequest>[] attributes) {
        var created = GenerateEntity();
        try {
            foreach(var i in attributes) {
                Assert.Null(Record.Exception(() => {
                    var existing = Get(i.Get(created).ToString(), i.Name);
                    testData.AssertEqualToResponse(created, existing);
                }));
            }
        }
        finally {
            Delete(created);
        }
    }

    public void Test_Get_ById() => Test_Get(Id);
    public void Test_Get_ByUniqueAttributes() => Test_Get(uniqueAttributes);

    public void Test_Create() {
        var data = testData.GenerateRequestData().First();
        var created = Create(data);
        try {
            testData.AssertEqualToRequest(data, created);
        }
        finally {
            Delete(created);
        }
    }

    public void Test_Create_WithUniqueAttributes() {
        var created = GenerateEntity();
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
            var updated = Update(Id.Get(created).ToString(), data, Id.Name);
            Assert.Equal(Id.Get(created), Id.Get(updated));
            testData.AssertEqualToRequest(data, updated);
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
                Assert.ThrowsAny<Exception>(() => Update(i.Get(created), data, i.Name));
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
            testData.AssertEqualToRequest(data, created);
            testData.Update(data);
            Id.Set(data, Id.Get(created));
            var updated = Upsert(data);
            Assert.Equal(Id.Get(created), Id.Get(updated));
            testData.AssertEqualToRequest(data, updated);
        }
        finally {
            Delete(created);
        }
    }

    public void Test_Patch() {
        throw new NotImplementedException();
    }

    public void Test_Delete_ById() {
        var created = GenerateEntity();
        var deleted = Delete(Id.Get(created).ToString(), Id.Name);
        testData.AssertEqualToResponse(created, deleted);
        Assert.ThrowsAny<Exception>(() => Get(Id.Get(created).ToString(), Id.Name));
    }

    public void Test_Delete_ByUniqueAttributes() {
        foreach(var i in uniqueAttributes) {
            var created = GenerateEntity();
            Delete(i.Get(created), i.Name);
            Assert.ThrowsAny<Exception>(() => Get(Id.Get(created).ToString(), Id.Name));
        }
    }
}
