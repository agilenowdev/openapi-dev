using Xunit;

namespace Agile.Now.Api.Test;

public class SubEntityTests<TParentResponse, TParentRequest, TResponse, TRequest>
    : EntityTestsBase<TParentResponse, TParentRequest, TResponse, TRequest> {

    protected readonly EntityTests<TParentResponse, TParentRequest> Parent;

    public SubEntityTests(
        EntityTests<TParentResponse, TParentRequest> parent,
        TestData<TResponse, TRequest> testData,
        Attribute<TResponse, TRequest> id,
        Attribute<TResponse, TRequest>[] uniqueAttributes = null)

        : base(testData, id, uniqueAttributes) {

        Parent = parent;
    }

    public override Context<TParentResponse, TParentRequest> CreateContext(string parentId = default) =>
        new Context<TParentResponse, TParentRequest>(Parent, parentId);

    protected virtual TResponse[] Patch(string id, List<TRequest> data, string deleteNotExists) => default;

    protected override TResponse Create2(Context<TParentResponse, TParentRequest> context, TRequest request) =>
        Upsert(context, request);

    public void Test_Patch() {
        using var context = CreateContext();
        var data = TestData.GenerateRequestData().Take(3).ToArray();
        var created = data.Take(2).Select(i => Upsert(context, i)).ToArray();
        try {
            var patched = Patch(context.ParentId, data.Skip(1).Take(2).ToList(), null);
            created = created.UnionBy(patched, i => Id.Get(i)).ToArray();
            try {
                var existing = List(context, EntityName + CreateFilters(context, Id, created));
                AssertCollectionsEqual(existing, created);
            }
            finally {
                Delete(context, created);
                created = null;
            }
        }
        finally {
            if(created != null)
                Delete(context, created);
        }
    }

    public void Test_Patch_DeleteNotExists() {
        using var context = CreateContext();
        var data = TestData.GenerateRequestData().Take(3).ToArray();
        var created = data.Take(2).Select(i => Upsert(context, i)).ToArray();
        try {
            var patched = Patch(context.ParentId, data.Skip(2).Take(1).ToList(), true.ToString());
            var existing = List(context);
            AssertCollectionsEqual(existing, patched);
            created = patched;
        }
        finally {
            Delete(context, created);
        }
    }

    public void Test_Delete_ById() {
        using var context = CreateContext();
        var created = GenerateEntities(context, 1).First();
        var deleted = Delete(context, Id.Get(created).ToString(), $"{EntityName}{Id.Name}");
        TestData.AssertEqualToResponse(created, deleted);
        var existing = List(context, EntityName + CreateFilters(context, Id, created));
        Assert.Empty(existing);
    }

    public void Test_Delete_ByUniqueAttributes() {
        using var context = CreateContext();
        foreach(var i in UniqueAttributes) {
            var created = GenerateEntities(context, 1).First();
            Delete(context, i.Get(created), Parent.Id.Name, i.Name);
            var existing = List(context, EntityName + CreateFilters(context, Id, created));
            Assert.Empty(existing);
        }
    }
}
