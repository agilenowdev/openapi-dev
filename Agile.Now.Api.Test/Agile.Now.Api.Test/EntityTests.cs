using Xunit;

namespace Agile.Now.Api.Test;

public class EntityTests<TResponse, TRequest> : EntityTestsBase<TResponse, TRequest, TResponse, TRequest> {
    public EntityTests(
        TestData<TResponse, TRequest> testData,
        Attribute<TResponse, TRequest> id,
        Attribute<TResponse, TRequest>[] uniqueAttributes = null)

        : base(testData, id, uniqueAttributes) {
    }

    public override Context<TResponse, TRequest> CreateContext(string parentId = default) => 
        new Context<TResponse, TRequest>(null);

    protected virtual TResponse Upsert(TRequest data) => default;
    protected virtual IEnumerable<TResponse> Patch(List<TRequest> data, string deleteNotExists) => default;

    protected override TResponse Create2(Context<TResponse, TRequest> context, TRequest request) => Create(context, request);

    public void Test_Patch() {
        using var context = CreateContext();
        var data = TestData.GenerateRequestData().Take(3).ToArray();
        var created = data.Take(2).Select(i => Upsert(i)).ToArray();
        try {
            var patched = Patch(data.Skip(1).Take(2).ToList(), null);
            created = created.UnionBy(patched, i => Id.Get(i)).ToArray();
            try {
                var existing = List(context, CreateFilters(context, Id, created));
                AssertCollectionsEqual(existing, created);
            }
            finally {
                Delete(null, created);
                created = null;
            }
        }
        finally {
            if(created != null)
                Delete(null, created);
        }
    }

    public void Test_Delete_ById() {
        using var context = CreateContext();
        var created = GenerateEntity(context);
        var deleted = Delete(context, Id.Get(created), Id.Name);
        TestData.AssertEqualToResponse(created, deleted);
        Assert.ThrowsAny<Exception>(() => Get(context, Id.Get(created), Id.Name));
    }

    public void Test_Delete_ByUniqueAttributes() {
        using var context = CreateContext();
        foreach(var i in UniqueAttributes) {
            var created = GenerateEntity(context);
            Delete(context, i.Get(created), i.Name);
            Assert.ThrowsAny<Exception>(() => Get(context, Id.Get(created), Id.Name));
        }
    }
}
