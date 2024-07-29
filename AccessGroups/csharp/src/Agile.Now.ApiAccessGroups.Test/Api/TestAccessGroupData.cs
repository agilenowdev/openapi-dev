using System.Linq;
using System;
using Agile.Now.ApiAccessGroups.Model;

namespace Agile.Now.ApiAccessGroups.Test.Api;

internal static class TestAccessGroupData
{
    public static string[] TestApplications = new[] {
        "15478BAE-C17D-4966-8288-F2F743A4B0EA", 
        "5BEE1686-32A5-4469-958C-EFF31CB9EC07" };

    public static AccessGroupData CreateAccessGroupData(string suffix = null)
    {
        var name = "unit-test-access-group" + suffix;
        var uniqueName = $"{name}-{DateTime.Now:yyyy-MM-dd-HH-mm-ss-fff}";
        return new
        (
            name: uniqueName,
            description: name,
            accessGroupTypeId: EnumAccessGroupType.Departments
        );
    }

    public static AccessGroupData[] CreateAccessGroupDataList(int count) =>
        Enumerable.Range(0, count).Select(i => CreateAccessGroupData(i.ToString())).ToArray();

    public static void UpdateAccessGroupData(AccessGroupData accessGroupInsertData, string id = null)
    {
        if (id != null)
            accessGroupInsertData.Id = id;
        const string updated = "updated";
        accessGroupInsertData.Description += updated;
        accessGroupInsertData.AccessGroupTypeId = 
            accessGroupInsertData.AccessGroupTypeId == EnumAccessGroupType.Departments ?
                EnumAccessGroupType.Locations : EnumAccessGroupType.Departments;
    }
}
