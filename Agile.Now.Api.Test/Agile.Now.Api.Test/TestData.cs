using Xunit;

namespace Agile.Now.Api.Test;

public class TestData<TResponse, TRequest> {
    public readonly Func<IEnumerable<TRequest>> GenerateInsertData;
    public readonly Action<TRequest, TResponse> AssertEqualRequestResponse;
    public readonly Action<TResponse, TResponse> AssertEqualResponses;
    public readonly Action<TRequest> Update;

    public TestData(
        Func<IEnumerable<TRequest>> generateInsertData,
        Action<TRequest, TResponse> assertEqualRequestResponse,
        Action<TResponse, TResponse> assertEqualResponses,
        Action<TRequest> update = null) {

        GenerateInsertData = generateInsertData;
        AssertEqualRequestResponse = assertEqualRequestResponse;
        AssertEqualResponses = assertEqualResponses;
        Update = update;
    }

    public readonly int DefaultPageSize = 50;

    public void AssertCollectionsEqual(IEnumerable<TResponse> expected, IEnumerable<TResponse> actual) =>
        Assert.Collection(expected, actual
            .Select(actualItem =>
                new Action<TResponse>(expectedItem =>
                    AssertEqualResponses(actualItem, expectedItem))).ToArray());
}
