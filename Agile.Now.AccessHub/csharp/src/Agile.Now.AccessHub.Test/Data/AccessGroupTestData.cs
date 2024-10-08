using System;
using System.Collections.Generic;
using System.Linq;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Data;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.ApiAccessGroups.Test.Api;

public class AccessGroupTestData2 : TestData<AccessGroup, AccessGroupData> {
    public override void AssertEqual(AccessGroupData data0, AccessGroup data1) => data0.AssertEqual(data1);
    public override void AssertEqual(AccessGroup data0, AccessGroup data1) => data0.AssertEqual(data1);
    public override IEnumerable<AccessGroupData> GenerateRequestData() => AccessGroupTestData.CreateAccessGroupDatas();
    public override void Update(AccessGroupData data) => data.Update();
}

public class AccessGroupApplicationTestData : TestData<Application, ApplicationData> {
    public override void AssertEqual(ApplicationData data0, Application data1) { }
    public override void AssertEqual(Application data0, Application data1) { }
    public override IEnumerable<ApplicationData> GenerateRequestData() => AccessGroupTestData.CreateApplicationDatas();
    public override void Update(ApplicationData data) { }
}

public class AccessGroupPermissionTestData : TestData<Permission, PermissionData> {
    public override void AssertEqual(PermissionData data0, Permission data1) { }
    public override void AssertEqual(Permission data0, Permission data1) { }
    public override IEnumerable<PermissionData> GenerateRequestData() => AccessGroupTestData.CreatePermissionDatas();
    public override void Update(PermissionData data) { }
}

public class AccessGroupGroupTestData : TestData<Group, GroupData> {
    public override void AssertEqual(GroupData data0, Group data1) { }
    public override void AssertEqual(Group data0, Group data1) { }
    public override IEnumerable<GroupData> GenerateRequestData() => UserTestData.CreateGroupDatas();
    public override void Update(GroupData data) { }
}

public class AccessGroupUserTestData : TestData<User, UserData> {
    public override void AssertEqual(UserData data0, User data1) { }
    public override void AssertEqual(User data0, User data1) { }
    public override IEnumerable<UserData> GenerateRequestData() => UserTestData.CreateUserDatas();
    public override void Update(UserData data) { }
}

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

    public static readonly string AccessRole = "32E61509-0071-4001-BE32-9E9D0DB255CB";

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

    public static IEnumerable<AccessGroupData> CreateAccessGroupDatas() =>
        Enumerable.Range(0, 4).Select(i => CreateAccessGroupData(i.ToString()));

    public static void Update(this AccessGroupData accessGroupInsertData) {
        accessGroupInsertData.Description = accessGroupInsertData.Description.MarkUpdated();
        accessGroupInsertData.AccessGroupTypeId =
            accessGroupInsertData.AccessGroupTypeId == EnumAccessGroupType.Departments ?
                EnumAccessGroupType.Locations : EnumAccessGroupType.Departments;
    }

    public static void AssertEqual(this AccessGroupData accessGroupInsertData, AccessGroup accessGroup) {
        Assert.Equal(accessGroupInsertData.Name, accessGroup.Name);
        Assert.Equal(accessGroupInsertData.Description, accessGroup.Description);
        Assert.Equal(accessGroupInsertData.IsActive, accessGroup.IsActive);
        Assert.Equal(accessGroupInsertData.AccessGroupTypeId,
            EnumAccessGroupTypeValueConverter.FromString(accessGroup.AccessGroupTypeId.Id));
    }

    public static void AssertEqual(this AccessGroup accessGroupInsertData, AccessGroup accessGroup) {
        Assert.Equal(accessGroupInsertData.Name, accessGroup.Name);
        Assert.Equal(accessGroupInsertData.Description, accessGroup.Description);
        Assert.Equal(accessGroupInsertData.IsActive, accessGroup.IsActive);
        Assert.Equal(accessGroupInsertData.AccessGroupTypeId.Id, accessGroup.AccessGroupTypeId.Id);
    }

    public static ApplicationData CreateApplicationData(string id) => new(
        parentApplicationId: new("Id", ParentApplication),
        accessApplicationId: new("Id", id));

    public static IEnumerable<ApplicationData> CreateApplicationDatas() =>
        Applications.Select(i => CreateApplicationData(i));

    public static ApplicationText CreateApplicationText(string accessApplicationId) => new(
        parentApplicationId: ParentApplication,
        accessApplicationId: accessApplicationId);

    public static PermissionData CreatePermissionData(EnumPermissionType id) => new(permissionId: id);

    public static IEnumerable<PermissionData> CreatePermissionDatas() {
        yield return new PermissionData(
            accessRoleId: new("Id", AccessRole),
            permissionId: EnumPermissionType.Create);
        yield return new PermissionData(
            accessRoleId: new("Id", AccessRole),
            permissionId: EnumPermissionType.Generic);
        yield return new PermissionData(
            accessRoleId: new("Id", AccessRole),
            permissionId: EnumPermissionType.Delete);
    }
}
