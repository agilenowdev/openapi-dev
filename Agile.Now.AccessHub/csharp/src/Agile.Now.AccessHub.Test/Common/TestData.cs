using System;

namespace Agile.Now.AccessHub.Test.Common {
    public class TestData<TReadData, TInsertData, TUpdateData, TUpsertData> {
        public readonly Func<TInsertData> GetInsertData;
        public readonly Action<TInsertData, TReadData> AssertEqual;
        public readonly Func<TInsertData, TUpdateData> ToUpdateData;
        public readonly Func<TInsertData, TUpsertData> ToUpsertData;
        public readonly Action<TInsertData> Update;

        public TestData(
            Func<TInsertData> getInsertData,
            Func<TInsertData, TUpdateData> toUpdateData,
            Func<TInsertData, TUpsertData> toUpsertData,
            Action<TInsertData, TReadData> assertEqual = null,
            Action<TInsertData> update = null) {

            GetInsertData = getInsertData;
            AssertEqual = assertEqual;
            ToUpdateData = toUpdateData;
            ToUpsertData = toUpsertData;
            Update = update;
        }
    }
}
