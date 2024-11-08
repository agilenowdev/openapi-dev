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

    protected override TResponse CreateInternal(Context<TParentResponse, TParentRequest> context, TRequest request) =>
        Upsert(context, request);
}
