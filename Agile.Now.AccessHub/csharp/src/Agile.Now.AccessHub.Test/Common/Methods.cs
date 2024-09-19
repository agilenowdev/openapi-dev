using System;

namespace Agile.Now.AccessHub.Test.Api {
    public class Methods<TEntity, TId, TCreateData, TUpdateData, TUpsertData> {
        public readonly Func<TCreateData, TEntity> Create;
        public readonly Action<TId, string> Delete;
        public readonly Func<TId, string, TEntity> Get;
        public readonly Func<TId, TUpdateData, string, TEntity> Update;
        public readonly Func<TUpsertData, TEntity> Upsert;

        public Methods(
            Func<TCreateData, TEntity> create,
            Action<TId, string> delete,
            Func<TId, string, TEntity> get,
            Func<TId, TUpdateData, string, TEntity> update,
            Func<TUpsertData, TEntity> upsert) {

            Create = create;
            Delete = delete;
            Get = get;
            Update = update;
            Upsert = upsert;
        }
    }
}
