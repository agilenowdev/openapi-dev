using System.Collections.Generic;
using Agile.Now.AccessHub.Model;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.AccessHub.Test.Data;

public class AccessGroup_Permission_TestData : TestData<Permission, PermissionData> {
    public override void AssertEqualToRequest(PermissionData data0, Permission data1) {
        Assert.Equal((int)data0.PermissionId.Value, data1.Id);
    }

    public override void AssertEqualToResponse(Permission data0, Permission data1) { }

    public override void Update(PermissionData data) { }

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

public static class AccessGroup_Permission_TestData_Extensions {
    public static PermissionText ToPermissionText(this PermissionData permissionData) =>
        new PermissionText(
            accessRoleId: AccessGroup_Permission_TestData.AccessRole,
            permissionData.PermissionId.Value.ToString());
}
