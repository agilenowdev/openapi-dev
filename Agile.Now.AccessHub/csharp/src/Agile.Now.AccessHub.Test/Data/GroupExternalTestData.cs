using System.Collections.Generic;
using System.Linq;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Data;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.ApiAccessGroups.Test.Api;

public class GroupExternalTestData2 : TestData<GroupExternal, GroupExternalData> {
    public override void AssertEqual(GroupExternalData data0, GroupExternal data1) => data0.AssertEqual(data1);
    public override void AssertEqual(GroupExternal data0, GroupExternal data1) => data0.AssertEqual(data1);
    public override IEnumerable<GroupExternalData> GenerateRequestData() => GroupExternalTestData.CreateGroupExternalDatas();
    public override void Update(GroupExternalData data) => data.Update();
}

public class GroupExternalUserExternalTestData : TestData<UserExternal, UserExternalData> {
    public override void AssertEqual(UserExternalData data0, UserExternal data1) { }
    public override void AssertEqual(UserExternal data0, UserExternal data1) { }
    public override IEnumerable<UserExternalData> GenerateRequestData() => GroupExternalTestData.CreateUserExternalDatas();
    public override void Update(UserExternalData data) { }
}

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

    public static void AssertEqual(this GroupExternal data, GroupExternal group) {
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
