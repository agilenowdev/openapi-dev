using System.Collections.Generic;
using Agile.Now.AccessHub.Model;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.AccessHub.Test.Data;

public class Permission_TestData : TestData<Permission, PermissionData> {
    public override void AssertEqualToRequest(PermissionData expected, Permission actual) {
        Assert.Equal(expected.AccessRoleId.Value, actual.AccessRoleId.Id);
        Assert.Equal(expected.PermissionId.Value, EnumPermissionTypeValueConverter.FromString(actual.PermissionId.Id));
    }

    public override void AssertEqualToResponse(Permission expected, Permission actual) {
        Assert.Equal(expected.Id, actual.Id);
        Assert.Equal(expected.AccessRoleId.Id, actual.AccessRoleId.Id);
        Assert.Equal(expected.PermissionId.Id, actual.PermissionId.Id);
    }

    public static readonly string AccessRole = "32E61509-0071-4001-BE32-9E9D0DB255CB";

    public override IEnumerable<PermissionData> GenerateRequestData() {
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

public static class Permission_TestData_Extensions {
    public static PermissionText ToPermissionText(this PermissionData permissionData) =>
        new PermissionText(
            accessRoleId: Permission_TestData.AccessRole,
            permissionData.PermissionId.Value.ToString());
}
