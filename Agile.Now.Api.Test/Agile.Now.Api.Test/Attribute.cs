namespace Agile.Now.Api.Test;

public class Attribute<TReadData, TId, TInsertData> {
    public readonly string Name;
    public readonly Func<TReadData, TId> Get;
    public readonly Action<TInsertData, TId> Set;

    public Attribute(string name, Func<TReadData, TId> get, Action<TInsertData, TId> set) {
        Name = name;
        Get = get;
        Set = set;
    }

    public char GetSeparator() => typeof(TId) == typeof(int) ? ',' : ';';
}
