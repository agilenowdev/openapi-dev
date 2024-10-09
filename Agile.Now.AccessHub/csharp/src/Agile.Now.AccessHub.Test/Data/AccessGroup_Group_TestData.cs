using System.Collections.Generic;
using Agile.Now.AccessHub.Model;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.AccessHub.Test.Data;

public class AccessGroup_Group_TestData : TestData<Group, GroupData> {
    public override void AssertEqualToRequest(GroupData data0, Group data1) =>
        Assert.Equal(data0.GroupId.Value, data1.Id.ToString());

    public override void AssertEqualToResponse(Group data0, Group data1) {
        Assert.Equal(data0.Id, data0?.Id);
        Assert.Equal(data0.Name, data1.Name);
        Assert.Equal(data0.Description, data1.Description);
    }

    public override IEnumerable<GroupData> GenerateRequestData() => UserTestData.CreateGroupDatas();
    public override void Update(GroupData data) { }
}

public static class AccessGroup_Group_TestData_Extensions {
    public static GroupText ToGroupText(this GroupData groupData) => new GroupText(groupData.GroupId.Value);
}
