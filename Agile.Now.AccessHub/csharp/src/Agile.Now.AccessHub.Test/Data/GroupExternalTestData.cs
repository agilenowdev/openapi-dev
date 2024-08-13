using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Data;

namespace Agile.Now.ApiAccessGroups.Test.Api;

internal static class GroupExternalTestData
{
    public static GroupExternalData CreateGroupExternalData(string suffix = null)
    {
        var name = CommonTestData.CreateTestEntityName("group-external", suffix);
        return new GroupExternalData
        (
            name: name.MakeUnique(),
            description: name
        );
    }

    public static void UpdateGroupExternalData(GroupExternalData groupExternalData)
    {
        groupExternalData.Description = groupExternalData.Description.MarkUpdated();
    }

    public static GroupExternalText ToGroupExternalText(this GroupExternalData groupExternalData) => new(
        id: groupExternalData.Id,
        name: groupExternalData.Name,
        description: groupExternalData.Description);

    public static bool DataEqual(this GroupExternalData groupExternalData, GroupExternal groupExternal) =>
        groupExternalData.Name == groupExternal.Name &&
        groupExternalData.Description == groupExternal.Description;

    public static UserExternalData CreateUserExternalData(int id) => new(userId: new("Id", id.ToString()));
}
