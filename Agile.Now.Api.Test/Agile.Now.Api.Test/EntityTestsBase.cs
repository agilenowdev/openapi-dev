namespace Agile.Now.Api.Test;

public abstract class EntityTestsBase<TId> {
    public abstract TId CreateInternal();
    public abstract void DeleteInternal(string id);
}

public abstract class EntityTestsBase<TResponse, TId, TRequest> : EntityTestsBase<TId> {
    protected readonly TestData<TResponse, TRequest> testData;
    protected readonly Attribute<TResponse, TId, TRequest> id;
    protected readonly Attribute<TResponse, string, TRequest>[] uniqueAttributes;

    public EntityTestsBase(
        TestData<TResponse, TRequest> testData,
        Attribute<TResponse, TId, TRequest> id,
        Attribute<TResponse, string, TRequest>[] uniqueAttributes) {

        this.testData = testData;
        this.id = id;
        this.uniqueAttributes = uniqueAttributes;
    }
}
