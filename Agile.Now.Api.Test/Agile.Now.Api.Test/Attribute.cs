namespace Agile.Now.Api.Test;

public class Attribute<TResponseData, TId, TRequestData> {
    public readonly string Name;
    public readonly Func<TResponseData, TId> Get;
    public readonly Action<TRequestData, TId> Set;

    public Attribute(string name, Func<TResponseData, TId> get, Action<TRequestData, TId> set) {
        Name = name;
        Get = get;
        Set = set;
    }

    public char GetSeparator() => typeof(TId) == typeof(int) ? ',' : ';';
}
