namespace Agile.Now.Api.Test;

public class Attribute<TResponse, TId, TRequest> {
    public readonly string Name;
    public readonly Func<TResponse, TId> Get;
    public readonly Action<TRequest, TId> Set;

    public Attribute(string name, Func<TResponse, TId> get, Action<TRequest, TId> set) {
        Name = name;
        Get = get;
        Set = set;
    }

    char GetSeparator() => typeof(TId) == typeof(int) ? ',' : ';';

    public string CreateFilters(params TResponse[] entities) =>
        $"{Name} In {string.Join(GetSeparator(), entities.Select(i => Get(i)))}";
}
