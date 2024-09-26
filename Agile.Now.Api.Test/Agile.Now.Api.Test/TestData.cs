namespace Agile.Now.Api.Test;

public class TestData<TReadData, TInsertData, TUpdateData, TUpsertData, TPatchData>
    where TUpdateData : class
    where TUpsertData : class {

    public readonly Func<IEnumerable<TInsertData>> GenerateInsertData;
    public readonly Action<TInsertData, TReadData> AssertEqual;
    public readonly Action<TInsertData> Update;

    public readonly Func<TInsertData, TUpdateData> ToUpdateData;
    public readonly Func<TInsertData, TUpsertData> ToUpsertData;
    public readonly Func<TInsertData, TPatchData> ToPatchData;

    public TestData(
        Func<IEnumerable<TInsertData>> generateInsertData,
        Action<TInsertData, TReadData> assertEqual,
        Action<TInsertData> update = null,

        Func<TInsertData, TUpdateData> toUpdateData = null,
        Func<TInsertData, TUpsertData> toUpsertData = null,
        Func<TInsertData, TPatchData> toPatchData = null) {

        GenerateInsertData = generateInsertData;
        AssertEqual = assertEqual;
        Update = update;

        ToUpdateData = toUpdateData ?? (data => data as TUpdateData);
        ToUpsertData = toUpsertData ?? (data => data as TUpsertData);
        ToPatchData = toPatchData;
    }
}
