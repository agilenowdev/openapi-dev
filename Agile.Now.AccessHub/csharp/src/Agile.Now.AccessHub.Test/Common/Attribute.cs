using System;

namespace Agile.Now.AccessHub.Test.Api {
    public class Attribute<TEntity, TId, TCreateData> {
        public readonly string Name;
        public readonly Func<TEntity, TId> Get;
        public readonly Action<TCreateData, string> Set;

        public Attribute(string name, Func<TEntity, TId> get, Action<TCreateData, string> set) {
            this.Name = name;
            this.Get = get;
            this.Set = set;
        }
    }
}
