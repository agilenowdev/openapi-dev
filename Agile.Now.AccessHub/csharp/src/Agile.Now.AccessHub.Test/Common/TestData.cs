using System;

namespace Agile.Now.AccessHub.Test.Api {
    public class TestData<TEntity, TCreateData, TUpdateData, TUpsertData> {
        public readonly Func<TCreateData> GetCreateData;
        public readonly Func<TCreateData, TUpdateData> GetUpdateData;
        public readonly Func<TCreateData, TUpsertData> GetUpsertData;
        public readonly Action<TCreateData> Update;
        public readonly Action<TCreateData, TEntity> AssertEqual;

        public TestData(
            Func<TCreateData> getCreateData,
            Func<TCreateData, TUpdateData> getUpdateData,
            Func<TCreateData, TUpsertData> getUpsertData,
            Action<TCreateData> update,
            Action<TCreateData, TEntity> assertEqual) {

            GetCreateData = getCreateData;
            GetUpdateData = getUpdateData;
            GetUpsertData = getUpsertData;
            Update = update;
            AssertEqual = assertEqual;
        }
    }
}
