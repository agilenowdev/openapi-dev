using Xunit;

namespace Agile.Now.Api.Test;

public abstract class TestData<TResponse, TRequest> {
    public abstract IEnumerable<TRequest> GenerateRequestData();
    public abstract void AssertEqual(TRequest expected, TResponse actual);
    public abstract void AssertEqual(TResponse expected, TResponse actual);
    public abstract void Update(TRequest data);

    public readonly int DefaultPageSize = 50;

    public void AssertCollectionsEqual(IEnumerable<TResponse> expected, IEnumerable<TResponse> actual) =>
        Assert.Collection(expected, actual
            .Select(actualItem =>
                new Action<TResponse>(expectedItem =>
                    AssertEqual(actualItem, expectedItem))).ToArray());
}
