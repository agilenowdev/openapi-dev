using System.Collections.Generic;
using System.Linq;
using Agile.Now.AccessHub.Model;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.AccessHub.Test.Data;

public class Permission1_TestData : TestData<Permission1, PermissionData1> {
    public override void AssertEqualToRequest(PermissionData1 expected, Permission1 actual) {
        Assert.Equal(expected.PermissionId.Value, EnumPermissionTypeValueConverter.FromString(actual.PermissionId.Id));
    }

    public override void AssertEqualToResponse(Permission1 expected, Permission1 actual) {
        Assert.Equal(expected.Id, actual.Id);
        Assert.Equal(expected.PermissionId.Id, actual.PermissionId.Id);
    }

    public static readonly string AccessRole = "32E61509-0071-4001-BE32-9E9D0DB255CB";

    public override IEnumerable<PermissionData1> GenerateRequestData() =>
        PermissionTypes.Select(i => new PermissionData1(permissionId: i));

    public static readonly EnumPermissionType[] PermissionTypes = new[] {
        EnumPermissionType.Create,
        EnumPermissionType.Export,
        EnumPermissionType.Generic
};
}

public static class Permission1_TestData_Extensions {
    public static PermissionText1 ToPermissionText1(this PermissionData1 permissionData) =>
        new PermissionText1(permissionId: permissionData.PermissionId.ToString());
}
