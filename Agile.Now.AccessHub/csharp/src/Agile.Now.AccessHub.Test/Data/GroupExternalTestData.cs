using System.Collections.Generic;
using System.Linq;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Data;
using Xunit;

namespace Agile.Now.ApiAccessGroups.Test.Api;

internal static class GroupExternalTestData {
    public static GroupExternalData CreateGroupExternalData(string suffix = null) {
        var name = CommonTestData.CreateTestEntityName("group-external", suffix);
        return new GroupExternalData
        (
            name: name.MakeUnique(),
            description: name
        );
    }

    public static IEnumerable<GroupExternalData> CreateGroupExternalDatas() =>
        Enumerable.Range(0, 4).Select(i => CreateGroupExternalData(i.ToString()));

    public static void Update(this GroupExternalData groupExternalData) {
        groupExternalData.Description = groupExternalData.Description.MarkUpdated();
    }

    public static void AssertEqual(this GroupExternalData data, GroupExternal group) {
        Assert.Equal(data.Name, group.Name);
        Assert.Equal(data.Description, group.Description);
    }

    public static GroupExternalText ToGroupExternalText(this GroupExternalData groupExternalData) => new(
        id: groupExternalData.Id,
        name: groupExternalData.Name,
        description: groupExternalData.Description);

    public static bool DataEqual(this GroupExternalData groupExternalData, GroupExternal groupExternal) =>
        groupExternalData.Name == groupExternal.Name &&
        groupExternalData.Description == groupExternal.Description;

    public static UserExternalData CreateUserExternalData(int id) => new(userId: new("Id", id.ToString()));

    public static IEnumerable<UserExternalData> CreateUserExternalDatas() =>
        UserTestData.Users.Select(i => CreateUserExternalData(i));
}
