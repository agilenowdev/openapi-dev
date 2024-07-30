using System;
using System.Linq;
using Agile.Now.ApiAccessGroups.Model;

namespace Agile.Now.ApiAccessGroups.Test.Api;

internal static class TestGroupData
{
    public static GroupData CreateGroupData(string suffix = null)
    {
        var name = "unit-test-group" + suffix;
        var uniqueName = $"{name}-{DateTime.Now:yyyy-MM-dd-HH-mm-ss-fff}";
        return new GroupData();
    }

    public static GroupData[] CreateGroupDataList(int count) =>
        Enumerable.Range(0, count).Select(i => CreateGroupData(i.ToString())).ToArray();

    public static void UpdateGroupData(GroupData GroupInsertData, long? id = null)
    {
        if (id != null)
            GroupInsertData.Id = id.Value;
        const string updated = "updated";
    }
}
