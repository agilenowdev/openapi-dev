using Xunit;

namespace Agile.Now.Api.Test;

public abstract class EntityTestsBase<TResponse, TId, TRequest> {
    protected readonly TestData<TResponse, TRequest> TestData;
    public readonly Attribute<TResponse, TId, TRequest> Id;
    protected readonly Attribute<TResponse, string, TRequest>[] UniqueAttributes;

    public EntityTestsBase(
        TestData<TResponse, TRequest> testData,
        Attribute<TResponse, TId, TRequest> id,
        Attribute<TResponse, string, TRequest>[] uniqueAttributes) {

        TestData = testData;
        Id = id;
        UniqueAttributes = uniqueAttributes;
    }

    protected const int DefaultPageSize = 50;

    public void AssertCollectionsEqual(IEnumerable<TResponse> expected, IEnumerable<TResponse> actual) =>
        Assert.Collection(
            expected.OrderBy(i => Id.Get(i)),
            actual.OrderBy(i => Id.Get(i))
                .Select(actualItem =>
                    new Action<TResponse>(expectedItem =>
                        TestData.AssertEqualToResponse(actualItem, expectedItem))).ToArray());

}
