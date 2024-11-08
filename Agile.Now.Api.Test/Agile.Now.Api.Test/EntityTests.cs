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

    protected override TResponse CreateInternal(Context<TResponse, TRequest> context, TRequest request) => 
        Create(context, request);
}
