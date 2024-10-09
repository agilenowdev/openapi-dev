namespace Agile.Now.Api.Test;

public abstract class TestData<TResponse, TRequest> {
    public abstract IEnumerable<TRequest> GenerateRequestData();
    public abstract void AssertEqualToRequest(TRequest expected, TResponse actual);
    public abstract void AssertEqualToResponse(TResponse expected, TResponse actual);
    public virtual void Update(TRequest data) { }

    protected string CreateTestEntityName(string s, string suffix) => $"unit-test-{s}{suffix}";
}

public static class TestData__Extension {
    public static string MakeUnique(this string s) => $"{s}-{DateTime.Now:yyyy-MM-dd-HH-mm-ss-fff}";
    public static string MarkUpdated(this string s) => "updated-" + s;
}
