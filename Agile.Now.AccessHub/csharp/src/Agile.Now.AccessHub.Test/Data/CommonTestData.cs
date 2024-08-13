using System;
using System.Linq;

namespace Agile.Now.AccessHub.Test.Data
{
    public static class CommonTestData
    {
        public static string MakeUnique(this string s) => $"{s}-{DateTime.Now:yyyy-MM-dd-HH-mm-ss-fff}";
        public static string MarkUpdated(this string s) => "updated-" + s;
        public const string NamePrefix = "unit-test-";

        public static T[] CreateTestDataList<T>(int count, Func<string, T> createTestData) =>
            Enumerable.Range(0, count).Select(i => createTestData(i.ToString())).ToArray();
    }
}
