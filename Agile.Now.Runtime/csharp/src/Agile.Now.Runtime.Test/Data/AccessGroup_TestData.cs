using System.Collections.Generic;
using System.Linq;
using Agile.Now.Api.Test;
using Agile.Now.Runtime.Model;
using Xunit;

namespace Agile.Now.Runtime.Test.Data;

public class AccessGroup_TestData : TestData<AccessGroup, AccessGroupData> {
    public override void AssertEqualToRequest(AccessGroupData data0, AccessGroup data1) {
        Assert.Equal(data0.AccessGroupId.Value, data1.Id);
    }

    public override void AssertEqualToResponse(AccessGroup data0, AccessGroup data1) {
        Assert.Equal(data0.Id, data1.Id);
        Assert.Equal(data0.Name, data1.Name);
        Assert.Equal(data0.ExternalId, data1.ExternalId);
        Assert.Equal(data0.Description, data1.Description);
        Assert.Equal(data0.IsSystem, data1.IsSystem);
        Assert.Equal(data0.AccessGroupTypeId.Id, data1.AccessGroupTypeId.Id);
    }

    public static readonly string[] AccessGroups = new[] {
        "254DE5D5-6FE0-4E0E-BDAE-F88557FFE79D",
        "471B0202-9B3A-4761-85A6-961260685251",
        "0CB75B96-B072-4F32-BECB-6CF69887DC80"
    };

    public override IEnumerable<AccessGroupData> GenerateRequestData() =>
        AccessGroups.Select(i => new AccessGroupData(accessGroupId: new("Id", i)));

    public override void Update(AccessGroupData data) { }
}
