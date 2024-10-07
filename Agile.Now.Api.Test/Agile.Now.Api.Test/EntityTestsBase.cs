using Xunit;

namespace Agile.Now.Api.Test;

public abstract class EntityTestsBase<TId> {
    public abstract TId CreateInternal();
    public abstract void DeleteInternal(string id);
}

public abstract class EntityTestsBase<TResponse, TId, TRequest> : EntityTestsBase<TId> {
    protected readonly Attribute<TResponse, TId, TRequest> id;
    protected readonly TestData<TResponse, TRequest> testData;
    protected readonly Attribute<TResponse, string, TRequest>[] uniqueAttributes;

    public EntityTestsBase(
        Attribute<TResponse, TId, TRequest> id,
        TestData<TResponse, TRequest> testData,
        Attribute<TResponse, string, TRequest>[] uniqueAttributes) {

        this.id = id;
        this.testData = testData;
        this.uniqueAttributes = uniqueAttributes;
    }
}

public static class Assert_extention {
}
