using System;
using System.Linq;
using Agile.Now.AccessHub.Model;

namespace Agile.Now.ApiAccessGroups.Test.Api;

internal static class TestGroupData
{
    public static GroupExternalData CreateGroupData(string suffix = null)
    {
        var name = "unit-test-group" + suffix;
        var uniqueName = $"{name}-{DateTime.Now:yyyy-MM-dd-HH-mm-ss-fff}";
        return new GroupExternalData
        (
            name: uniqueName,
            description: name
        );
    }

    public static GroupExternalData[] CreateGroupDataList(int count) =>
        Enumerable.Range(0, count).Select(i => CreateGroupData(i.ToString())).ToArray();

    public static void UpdateGroupData(GroupExternalData groupData)
    {
        const string updated = "updated";
        groupData.Description += updated;

    }
}
