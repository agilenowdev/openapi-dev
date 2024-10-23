using System;
using System.Collections.Generic;
using System.Linq;
using Agile.Now.AccessHub.Model;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.AccessHub.Test.Data;

public class AccessGroup_TestData : TestData<AccessGroup, AccessGroupInsertData> {
    public override IEnumerable<AccessGroupInsertData> GenerateRequestData() =>
        Enumerable.Range(0, 4).Select(i => {
            var name = CreateTestEntityName("access-group", i.ToString());
            return new AccessGroupInsertData
            (
                name: name.MakeUnique(),
                externalId: Guid.NewGuid().ToString(),
                description: name,
                accessGroupTypeId: EnumAccessGroupType.Departments
            );
        });

    public override void Update(AccessGroupInsertData data) {
        data.Description = data.Description.MarkUpdated();
        data.AccessGroupTypeId = data.AccessGroupTypeId == EnumAccessGroupType.Departments ?
            EnumAccessGroupType.Locations : EnumAccessGroupType.Departments;
    }

    public override void AssertEqualToRequest(AccessGroupInsertData expected, AccessGroup actual) {
        Assert.Equal(expected.Name, actual.Name);
        Assert.Equal(expected.ExternalId, actual.ExternalId);
        Assert.Equal(expected.Description, actual.Description);
        Assert.Equal(expected.AccessGroupTypeId,
            EnumAccessGroupTypeValueConverter.FromString(actual.AccessGroupTypeId.Id));
    }

    public override void AssertEqualToResponse(AccessGroup expected, AccessGroup actual) {
        Assert.Equal(expected.Name, actual.Name);
        Assert.Equal(expected.ExternalId, actual.ExternalId);
        Assert.Equal(expected.Description, actual.Description);
        Assert.Equal(expected.AccessGroupTypeId.Id, actual.AccessGroupTypeId.Id);
    }

    public const string SystemAccessGroup = "B776FDF5-9790-473D-A75B-2A1A3C44A13D";
}

public static class AccessGroup_TestData_Extension {
    public static AccessGroupUpdateData ToAccessGroupUpdateData(this AccessGroupInsertData accessGroupInsertData) => new(
        name: accessGroupInsertData.Name,
        externalId: accessGroupInsertData.ExternalId,
        description: accessGroupInsertData.Description,
        isActive: accessGroupInsertData.IsActive,
        accessGroupTypeId: accessGroupInsertData.AccessGroupTypeId);

    public static AccessGroupData ToAccessGroupData(this AccessGroupInsertData accessGroupInsertData) => new(
        name: accessGroupInsertData.Name,
        externalId: accessGroupInsertData.ExternalId,
        description: accessGroupInsertData.Description,
        isActive: accessGroupInsertData.IsActive,
        accessGroupTypeId: accessGroupInsertData.AccessGroupTypeId);
}
