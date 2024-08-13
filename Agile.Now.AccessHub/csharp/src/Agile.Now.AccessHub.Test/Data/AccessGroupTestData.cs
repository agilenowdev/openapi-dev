using System.Linq;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Data;

namespace Agile.Now.ApiAccessGroups.Test.Api;

internal static class AccessGroupTestData
{
    public static string[] Applications = new[] {
        "15478BAE-C17D-4966-8288-F2F743A4B0EA",
        "5BEE1686-32A5-4469-958C-EFF31CB9EC07",
        "F32007E7-C34E-4043-8E6E-5EB75B7240FB"
    };

    public static string ParentApplication = "3B594DDA-3F5D-431A-A532-A3EDFFA9BD98";

    public static int[] Groups = new[] { 6626, 6625, 6624 };

    public static AccessGroupData CreateAccessGroupData(string suffix = null)
    {
        var name = CommonTestData.NamePrefix + "access-group" + suffix;
        return new
        (
            name: name.MakeUnique(),
            description: name,
            accessGroupTypeId: EnumAccessGroupType.Departments
        );
    }

    public static AccessGroupData[] CreateAccessGroupDataList(int count) =>
        Enumerable.Range(0, count).Select(i => CreateAccessGroupData(i.ToString())).ToArray();

    public static void UpdateAccessGroupData(AccessGroupData accessGroupInsertData)
    {
        const string updated = "-updated";
        accessGroupInsertData.Description += updated;
        accessGroupInsertData.AccessGroupTypeId =
            accessGroupInsertData.AccessGroupTypeId == EnumAccessGroupType.Departments ?
                EnumAccessGroupType.Locations : EnumAccessGroupType.Departments;
    }
}
