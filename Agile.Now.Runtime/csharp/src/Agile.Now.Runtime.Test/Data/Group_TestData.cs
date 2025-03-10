﻿using System.Collections.Generic;
using System.Linq;
using Agile.Now.Api.Test;
using Agile.Now.Runtime.Model;
using Xunit;

namespace Agile.Now.Runtime.Test.Data;

public class Group_TestData : TestData<Group, GroupData> {
    public override void AssertEqualToRequest(GroupData data0, Group data1) =>
        Assert.Equal(data0.GroupId.Value, data1.Id.ToString());

    public override void AssertEqualToResponse(Group data0, Group data1) {
        Assert.Equal(data0.Id, data0.Id);
        Assert.Equal(data0.Name, data1.Name);
        Assert.Equal(data0.Description, data1.Description);
    }

    public static readonly int[] Groups = new[] { 6626, 6625, 6624 };

    public override IEnumerable<GroupData> GenerateRequestData() =>
        Groups.Select(i => new GroupData(groupId: new("Id", i.ToString())));
}

public static class Group_TestData_Extensions {
    public static GroupText ToGroupText(this GroupData groupData) =>
        new GroupText(groupId: groupData.GroupId.Value);
}
