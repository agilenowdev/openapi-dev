using System;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Data;

namespace Agile.Now.ApiAccessGroups.Test.Api;

internal static class AccessGroupTestData
{
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

    public static AccessGroupData CreateAccessGroupData(string suffix = null)
    {
        var name = CommonTestData.CreateTestEntityName("access-group", suffix);
        return new
        (
            name: name.MakeUnique(),
            description: name,
            accessGroupTypeId: EnumAccessGroupType.Departments
        );
    }

    public static void UpdateAccessGroupData(AccessGroupData accessGroupInsertData)
    {
        accessGroupInsertData.Description = accessGroupInsertData.Description.MarkUpdated();
        accessGroupInsertData.AccessGroupTypeId =
            accessGroupInsertData.AccessGroupTypeId == EnumAccessGroupType.Departments ?
                EnumAccessGroupType.Locations : EnumAccessGroupType.Departments;
    }

    public static AccessGroupUpdateData ToAccessGroupUpdateData(this AccessGroupInsertData accessGroupInsertData) =>
        new AccessGroupUpdateData(
            name: accessGroupInsertData.Name,
            description: accessGroupInsertData.Description,
            accessGroupTypeId: accessGroupInsertData.AccessGroupTypeId
        );

    public static AccessGroupData ToAccessGroupData(this AccessGroupInsertData accessGroupInsertData) =>
        new AccessGroupData(
            name: accessGroupInsertData.Name,
            externalId: accessGroupInsertData.ExternalId,
            description: accessGroupInsertData.Description,
            accessGroupTypeId: accessGroupInsertData.AccessGroupTypeId
        );

    public static ApplicationData CreateApplicationData(string id) => new(
        parentApplicationId: new("Id", ParentApplication),
        accessApplicationId: new("Id", id));

    public static PermissionData CreatePermissionData(EnumPermissionType id) => new( permissionId: id);
}
