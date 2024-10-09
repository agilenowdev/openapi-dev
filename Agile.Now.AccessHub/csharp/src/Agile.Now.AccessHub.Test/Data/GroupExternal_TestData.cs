using System.Collections.Generic;
using System.Linq;
using Agile.Now.AccessHub.Model;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.AccessHub.Test.Data;

public class GroupExternal_TestData : TestData<GroupExternal, GroupExternalData> {
    public override void AssertEqualToRequest(GroupExternalData data0, GroupExternal data1) {
        Assert.Equal(data0.Id, data1.Id);
        Assert.Equal(data0.Name, data1.Name);
        Assert.Equal(data0.Description, data1.Description);
    }

    public override void AssertEqualToResponse(GroupExternal data0, GroupExternal data1) {
        Assert.Equal(data0.Id, data1.Id);
        Assert.Equal(data0.Name, data1.Name);
        Assert.Equal(data0.Description, data1.Description);
    }

    public override void Update(GroupExternalData data) {
        data.Description = data.Description.MarkUpdated();
    }

    public override IEnumerable<GroupExternalData> GenerateRequestData() =>
        Enumerable.Range(0, 4).Select(i => {
            var name = CreateTestEntityName("group-external", i.ToString());
            return new GroupExternalData
            (
                name: name.MakeUnique(),
                description: name
            );
        });
}

public static class GroupExternal_TestData_Extention {
    public static void Update(this GroupExternalData data) {
        data.Description = data.Description.MarkUpdated();
    }

    public static GroupExternalText ToGroupExternalText(this GroupExternalData groupExternalData) => new(
        id: groupExternalData.Id,
        name: groupExternalData.Name,
        description: groupExternalData.Description);

    public static bool DataEqual(this GroupExternalData groupExternalData, GroupExternal groupExternal) =>
        groupExternalData.Name == groupExternal.Name &&
        groupExternalData.Description == groupExternal.Description;
}
