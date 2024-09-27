namespace Agile.Now.Api.Test;

public class TestData<TResponseData, TRequestData> {
    public readonly Func<IEnumerable<TRequestData>> GenerateInsertData;
    public readonly Action<TRequestData, TResponseData> AssertEqual;
    public readonly Action<TRequestData> Update;

    public TestData(
        Func<IEnumerable<TRequestData>> generateInsertData,
        Action<TRequestData, TResponseData> assertEqual,
        Action<TRequestData> update = null) {

        GenerateInsertData = generateInsertData;
        AssertEqual = assertEqual;
        Update = update;
    }
}
