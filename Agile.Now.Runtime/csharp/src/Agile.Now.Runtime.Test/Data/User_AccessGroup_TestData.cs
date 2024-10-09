using System.Collections.Generic;
using System.Linq;
using Agile.Now.Api.Test;
using Agile.Now.Runtime.Model;
using Xunit;

namespace Agile.Now.Runtime.Test.Data;

public class User_AccessGroup_TestData : TestData<AccessGroup, AccessGroupData> {
    public override void AssertEqualToRequest(AccessGroupData data0, AccessGroup data1) {
        Assert.Equal(data0.AccessGroupId.Value, data1.Id);
    }

    public override void AssertEqualToResponse(AccessGroup data0, AccessGroup data1) {
        Assert.Equal(data0.Name, data1.Name);
        Assert.Equal(data0.Description, data1.Description);
        Assert.Equal(data0.IsActive, data1.IsActive);
        Assert.Equal(data0.AccessGroupTypeId.Id, data1.AccessGroupTypeId.Id);
    }

    public override IEnumerable<AccessGroupData> GenerateRequestData() => CreateAccessGroupDatas();

    public static AccessGroupData CreateAccessGroupData(string id) => new(
        accessGroupId: new("Id", id));

    public static readonly string[] AccessGroups = new[] {
        "254DE5D5-6FE0-4E0E-BDAE-F88557FFE79D",
        "471B0202-9B3A-4761-85A6-961260685251"
    };

    public static IEnumerable<AccessGroupData> CreateAccessGroupDatas() =>
        AccessGroups.Select(i => CreateAccessGroupData(i));

    public override void Update(AccessGroupData data) { }
}
