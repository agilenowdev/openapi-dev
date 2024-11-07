using Xunit;

namespace Agile.Now.Api.Test;

public abstract class EntityTestsBase<TParentResponse, TParentRequest, TResponse, TRequest> {
    protected readonly TestData<TResponse, TRequest> TestData;
    public readonly Attribute<TResponse, TRequest> Id;
    protected readonly Attribute<TResponse, TRequest>[] UniqueAttributes;

    public EntityTestsBase(
        TestData<TResponse, TRequest> testData,
        Attribute<TResponse, TRequest> id,
        Attribute<TResponse, TRequest>[] uniqueAttributes) {

        TestData = testData;
        Id = id;
        UniqueAttributes = uniqueAttributes;
    }

    protected virtual string EntityName => typeof(TResponse).Name;
    protected bool NoCleanUp;
    protected const int DefaultPageSize = 50;

    string GetSubName(Context<TParentResponse, TParentRequest> context, Attribute<TResponse, TRequest> attribute) {
        var name = attribute.Name;
        if(context?.Parent != null && name == "Id")
            name = EntityName + name;
        return name;
    }

    public string CreateFilters(
        Context<TParentResponse, TParentRequest> context,
        Attribute<TResponse, TRequest> attribute,
        params string[] ids) {

        return $"{GetSubName(context, attribute)} In {string.Join(attribute.GetSeparator(), ids)}";
    }

    public string CreateFilters(
        Context<TParentResponse, TParentRequest> context,
        Attribute<TResponse, TRequest> attribute,
        params TResponse[] entities) =>

        CreateFilters(context, attribute, entities.Select(i => attribute.Get(i)).ToArray());

    public void AssertCollectionsEqual(IEnumerable<TResponse> expected, IEnumerable<TResponse> actual) =>
        Assert.Collection(
            expected.OrderBy(i => Id.Get(i)),
            actual.OrderBy(i => Id.Get(i))
                .Select(actualItem =>
                    new Action<TResponse>(expectedItem =>
                        TestData.AssertEqualToResponse(actualItem, expectedItem))).ToArray());

    public abstract Context<TParentResponse, TParentRequest> CreateContext(string parentId = default);

    protected virtual List<TResponse> List(Context<TParentResponse, TParentRequest> context,
        string filters = default, string orders = default, int currentPage = default, int pageSize = DefaultPageSize) => default;

    protected virtual TResponse Get(Context<TParentResponse, TParentRequest> context, string id, string name) => default;
    protected virtual TResponse Delete(Context<TParentResponse, TParentRequest> context, string id, string name) => default;
    protected virtual TResponse Create(Context<TParentResponse, TParentRequest> context, TRequest data) => default;

    protected virtual TResponse Update(Context<TParentResponse, TParentRequest> context,
        string id, TRequest data, string name) => default;

    protected virtual TResponse Upsert(Context<TParentResponse, TParentRequest> context, TRequest data) => default;

    protected abstract TResponse Create2(Context<TParentResponse, TParentRequest> context, TRequest request);

    public TResponse[] GenerateEntities(Context<TParentResponse, TParentRequest> context, int count) =>
        TestData.GenerateRequestData().Take(count).Select(i => Create2(context, i)).ToArray();

    public TResponse GenerateEntity(Context<TParentResponse, TParentRequest> context) => GenerateEntities(context, 1).First();

    public void Delete(Context<TParentResponse, TParentRequest> context, params TResponse[] entities) =>
        Delete(context, entities.Select(i => Id.Get(i)).ToArray());

    public void Delete(Context<TParentResponse, TParentRequest> context, params string[] ids) {
        var name = GetSubName(context, Id);
        foreach(var i in ids)
            Delete(context, i, $"{name}");
    }

    public void Test_List(params Attribute<TResponse, TRequest>[] attributes) {
        using var context = CreateContext();
        var created = GenerateEntities(context, 2);
        try {
            foreach(var i in attributes) {
                var existing = List(context, filters: CreateFilters(context, i, created));
                AssertCollectionsEqual(created, existing);
            }
        }
        finally {
            if(!NoCleanUp)
                Delete(context, created);
        }
    }

    public void Test_List_ById() => Test_List(Id);
    public void Test_List_ByUniqueAttributes() => Test_List(UniqueAttributes);

    public void Test_List_Paging() {
        using var context = CreateContext();
        var created = GenerateEntities(context, 3);
        try {
            var filters = CreateFilters(context, Id, created);
            var pageSize = 2;
            var pages = new[] {
                List(context, filters: filters, currentPage: 0, pageSize: pageSize),
                List(context, filters: filters, currentPage: 1, pageSize: pageSize),
            };
            Assert.Equal(pageSize, pages[0].Count);
            Assert.Equal(1, pages[1].Count);
            Assert.Equal(created.Length, pages[0].Concat(pages[1]).GroupBy(i => Id.Get(i)).Count());
        }
        finally {
            Delete(context, created);
        }
    }

    void Test_List_Order(Func<IEnumerable<string>, IOrderedEnumerable<string>> ordered, string order) {
        using var context = CreateContext();
        var created = GenerateEntities(context, 3);
        try {
            var actual = List(context,
                filters: CreateFilters(context, Id, created),
                orders: $"{GetSubName(context, Id)} {order}");
            var expected = ordered(created.Select(i => Id.Get(i)));
            Assert.True(actual.Select(i => Id.Get(i)).SequenceEqual(expected));
        }
        finally {
            Delete(context, created);
        }
    }

    public void Test_List_OrderAscending() => Test_List_Order(x => x.Order(), "ASC");
    public void Test_List_OrderDecending() => Test_List_Order(x => x.OrderDescending(), "DESC");

    public void Test_List_NoAccess(params string[] ids) {
        using var context = CreateContext();
        var existing = List(context, filters: CreateFilters(context, Id, ids));
        Assert.Empty(existing);
    }

    public void Test_List_SubEntities_NoAccess(params string[] parentIds) {
        foreach(var i in parentIds) {
            using var context = CreateContext(i);
            Assert.ThrowsAny<Exception>(() => List(context));
        }
    }

    void Test_Get(params Attribute<TResponse, TRequest>[] attributes) {
        using var context = CreateContext();
        var created = GenerateEntity(context);
        try {
            foreach(var i in attributes) {
                Assert.Null(Record.Exception(() => {
                    var existing = Get(context, i.Get(created), i.Name);
                    TestData.AssertEqualToResponse(created, existing);
                }));
            }
        }
        finally {
            Delete(context, created);
        }
    }

    public void Test_Get_ById() => Test_Get(Id);
    public void Test_Get_ByUniqueAttributes() => Test_Get(UniqueAttributes);

    public void Test_Get_NoAccess(params string[] ids) {
        using var context = CreateContext();
        foreach(var i in ids)
            Assert.ThrowsAny<Exception>(() => Get(context, i, Id.Name));
    }

    public void Test_Create() {
        using var context = CreateContext();
        var data = TestData.GenerateRequestData().First();
        var created = Create(context, data);
        try {
            TestData.AssertEqualToRequest(data, created);
        }
        finally {
            Delete(context, created);
        }
    }

    public void Test_Create_WithUniqueAttributes() {
        using var context = CreateContext();
        var created = GenerateEntity(context);
        try {
            foreach(var i in UniqueAttributes) {
                var data = TestData.GenerateRequestData().First();
                i.Set(data, i.Get(created));
                Assert.ThrowsAny<Exception>(() => Create(context, data));
            }
        }
        finally {
            Delete(context, created);
        }
    }

    public void Test_Update_ById() {
        using var context = CreateContext();
        var data = TestData.GenerateRequestData().First();
        var created = Create(context, data);
        try {
            TestData.Update(data);
            var updated = Update(context, Id.Get(created), data, Id.Name);
            Assert.Equal(Id.Get(created), Id.Get(updated));
            TestData.AssertEqualToRequest(data, updated);
        }
        finally {
            Delete(null, created);
        }
    }

    public void Test_Update_ByUniqueAttributes() {
        using var context = CreateContext();
        var data = TestData.GenerateRequestData().First();
        var created = Create(context, data);
        try {
            foreach(var i in UniqueAttributes) {
                TestData.Update(data);
                Assert.Null(Record.Exception(() => Update(context, i.Get(created), data, i.Name)));
            }
        }
        finally {
            Delete(null, created);
        }
    }

    public void Test_Upsert() {
        using var context = CreateContext();
        var data = TestData.GenerateRequestData().First();
        var created = Upsert(context, data);
        try {
            TestData.AssertEqualToRequest(data, created);
            if(context.Parent == null) {
                TestData.Update(data);
                Id.Set(data, Id.Get(created));
                var updated = Upsert(context, data);
                Assert.Equal(Id.Get(created), Id.Get(updated));
                TestData.AssertEqualToRequest(data, updated);
            }
        }
        finally {
            if(!NoCleanUp)
                Delete(null, created);
        }
    }
}
