using System;
using System.Collections.Generic;
using System.Linq;
using Agile.Now.AccessHub.Model;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.AccessHub.Test.Data;

public class AccessGroup_TestData : TestData<AccessGroup, AccessGroupData> {
    public override IEnumerable<AccessGroupData> GenerateRequestData() =>
        Enumerable.Range(0, 4).Select(i => {
            var name = CreateTestEntityName("access-group", i.ToString());
            return new AccessGroupData
            (
                externalId: Guid.NewGuid().ToString(),
                name: name.MakeUnique(),
                description: name,
                isActive: true,
                accessGroupTypeId: EnumAccessGroupType.Departments
            );
        });

    public override void Update(AccessGroupData data) {
        data.Description = data.Description.MarkUpdated();
        data.AccessGroupTypeId =
            data.AccessGroupTypeId == EnumAccessGroupType.Departments ?
                EnumAccessGroupType.Locations : EnumAccessGroupType.Departments;
    }

    public override void AssertEqualToRequest(AccessGroupData data0, AccessGroup data1) {
        Assert.Equal(data0.Name, data1.Name);
        Assert.Equal(data0.Description, data1.Description);
        Assert.Equal(data0.IsActive, data1.IsActive);
        Assert.Equal(data0.AccessGroupTypeId,
            EnumAccessGroupTypeValueConverter.FromString(data1.AccessGroupTypeId.Id));
    }

    public override void AssertEqualToResponse(AccessGroup data0, AccessGroup data1) {
        Assert.Equal(data0.Name, data1.Name);
        Assert.Equal(data0.Description, data1.Description);
        Assert.Equal(data0.IsActive, data1.IsActive);
        Assert.Equal(data0.AccessGroupTypeId.Id, data1.AccessGroupTypeId.Id);
    }
}

public static class AccessGroupTestData {
    public static readonly string[] Applications = new[] {
        "15478BAE-C17D-4966-8288-F2F743A4B0EA",
        "5BEE1686-32A5-4469-958C-EFF31CB9EC07",
        "F32007E7-C34E-4043-8E6E-5EB75B7240FB"
    };

    public static readonly EnumPermissionType[] Permissions = new[] {
        EnumPermissionType.Import,
        EnumPermissionType.Export,
        EnumPermissionType.Delete
    };

    public static readonly string ParentApplication = "3B594DDA-3F5D-431A-A532-A3EDFFA9BD98";

    public static ApplicationText CreateApplicationText(string accessApplicationId) => new(
        parentApplicationId: ParentApplication,
        accessApplicationId: accessApplicationId);
}
