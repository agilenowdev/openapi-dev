using System;

namespace Agile.Now.AccessHub.Test.Common {
    public class Attribute<TEntity, TId, TInsertData> {
        public readonly string Name;
        public readonly Func<TEntity, TId> Get;
        public readonly Action<TInsertData, TId> Set;

        public Attribute(string name, Func<TEntity, TId> get, Action<TInsertData, TId> set) {
            Name = name;
            Get = get;
            Set = set;
        }
    }
}
