using System;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Data;
using Xunit;

namespace Agile.Now.ApiAccessGroups.Test.Api;

internal static class AccessGroupTestData {
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

    public static AccessGroupData CreateAccessGroupData(string suffix = null) {
        var name = CommonTestData.CreateTestEntityName("access-group", suffix);
        return new AccessGroupData
        (
            externalId: Guid.NewGuid().ToString(),
            name: name.MakeUnique(),
            description: name,
            isActive: true,
            accessGroupTypeId: EnumAccessGroupType.Departments
        );
    }

    public static void Update(this AccessGroupData accessGroupInsertData) {
        accessGroupInsertData.Description = accessGroupInsertData.Description.MarkUpdated();
        accessGroupInsertData.AccessGroupTypeId =
            accessGroupInsertData.AccessGroupTypeId == EnumAccessGroupType.Departments ?
                EnumAccessGroupType.Locations : EnumAccessGroupType.Departments;
    }

    public static void AssertEqual(this AccessGroupData accessGroupInsertData, AccessGroup AccessGroup) {
        Assert.Equal(accessGroupInsertData.Name, AccessGroup.Name);
        Assert.Equal(accessGroupInsertData.Description, AccessGroup.Description);
        Assert.Equal(accessGroupInsertData.IsActive, AccessGroup.IsActive);
        Assert.Equal(accessGroupInsertData.AccessGroupTypeId,
            EnumAccessGroupTypeValueConverter.FromString(AccessGroup.AccessGroupTypeId.Id));
    }

    public static ApplicationData CreateApplicationData(string id) => new(
        parentApplicationId: new("Id", ParentApplication),
        accessApplicationId: new("Id", id));

    public static ApplicationText CreateApplicationText(string accessApplicationId, string id = default) => new(
        parentApplicationId: ParentApplication,
        accessApplicationId: accessApplicationId,
        id: id);

    public static PermissionData CreatePermissionData(EnumPermissionType id) => new(permissionId: id);
}
