namespace Agile.Now.Api.Test;

public class Attribute<TResponse, TRequest> {
    public readonly string Name;
    readonly bool isString;
    public readonly Func<TResponse, string> Get;
    public readonly Action<TRequest, string> Set;

    public Attribute(string name, Func<TResponse, string> get, Action<TRequest, string> set = default, bool isString = true) {
        Name = name;
        this.isString = isString;
        Get = get;
        Set = set;
    }

    public char GetSeparator() => isString ? ';' : ',';
}
