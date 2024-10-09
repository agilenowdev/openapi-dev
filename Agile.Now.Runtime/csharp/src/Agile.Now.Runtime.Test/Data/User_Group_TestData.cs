using System.Collections.Generic;
using System.Linq;
using Agile.Now.Api.Test;
using Agile.Now.Runtime.Model;
using Xunit;

namespace Agile.Now.Runtime.Test.Data;

public class User_Group_TestData : TestData<Group, GroupData> {
    public override void AssertEqualToRequest(GroupData data0, Group data1) =>
        Assert.Equal(data0.GroupId.Value, data1.Id.ToString());

    public override void AssertEqualToResponse(Group data0, Group data1) {
        Assert.Equal(data0.Id, data0?.Id);
        Assert.Equal(data0.Name, data1.Name);
        Assert.Equal(data0.Description, data1.Description);
    }

    public static readonly int[] Groups = new[] { 6626, 6625, 6624 };
    public static GroupData CreateGroupData(int id) => new(groupId: new("Id", id.ToString()));
    public static IEnumerable<GroupData> CreateGroupDatas() => Groups.Select(i => CreateGroupData(i));

    public override IEnumerable<GroupData> GenerateRequestData() => CreateGroupDatas();


    public override void Update(GroupData data) { }
}
