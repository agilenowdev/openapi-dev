using System;
using System.Collections.Generic;

namespace Agile.Now.AccessHub.Test.Common {
    public class TestData<TReadData, TInsertData, TUpdateData, TUpsertData, TPatchData>
        where TUpdateData : class
        where TUpsertData : class {

        public readonly Func<IEnumerable<TInsertData>> GetInsertData;
        public readonly Action<TInsertData, TReadData> AssertEqual;
        public readonly Func<TInsertData, TUpdateData> ToUpdateData;
        public readonly Func<TInsertData, TUpsertData> ToUpsertData;
        public readonly Func<TInsertData, TPatchData> ToPatchData;
        public readonly Action<TInsertData> Update;

        public TestData(
            Func<IEnumerable<TInsertData>> getInsertData,
            Action<TInsertData, TReadData> assertEqual,
            Func<TInsertData, TUpdateData> toUpdateData = null,
            Func<TInsertData, TUpsertData> toUpsertData = null,
            Func<TInsertData, TPatchData> toPatchData = null,
            Action<TInsertData> update = null) {

            GetInsertData = getInsertData;
            AssertEqual = assertEqual;
            ToUpdateData = toUpdateData ?? (data => data as TUpdateData);
            ToUpsertData = toUpsertData ?? (data => data as TUpsertData);
            ToPatchData = toPatchData;
            Update = update;
        }
    }
}
