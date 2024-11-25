using System;
using System.Collections.Generic;
using System.Linq;
using Agile.Now.AccessHub.Model;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.AccessHub.Test.Data;

public class Role1_TestData : TestData<Role1, RoleData1> {
    public override void AssertEqualToRequest(RoleData1 expected, Role1 actual) {
        Assert.Equal(expected.Name, actual.Name);
        Assert.Equal(expected.RoleKey, actual.RoleKey);
        Assert.Equal(expected.FullName, actual.FullName);
        Assert.Equal(expected.Description, actual.Description);
        Assert.Equal(expected.ExternalId, actual.ExternalId);
        Assert.Equal(expected.AccessApplicationId.Value, actual.AccessApplicationId.Id);
    }

    public override void AssertEqualToResponse(Role1 expected, Role1 actual) {
        Assert.Equal(expected.Id, actual.Id);
        Assert.Equal(expected.Name, actual.Name);
        Assert.Equal(expected.RoleKey, actual.RoleKey);
        Assert.Equal(expected.FullName, actual.FullName);
        Assert.Equal(expected.Description, actual.Description);
        Assert.Equal(expected.ExternalId, actual.ExternalId);
        Assert.Equal(expected.AccessApplicationId.Id, actual.AccessApplicationId.Id);
    }

    public override IEnumerable<RoleData1> GenerateRequestData() =>
        Enumerable.Range(0, 4).Select(i => {
            var name = CreateTestEntityName("role", i.ToString());
            return new RoleData1(
                name: name.MakeUnique(),
                roleKey: Guid.NewGuid().ToString(),
                fullName: name,
                externalId: Guid.NewGuid().ToString(),
                description: name,
                accessApplicationId: new("Id", Application_TestData.Applications[0])
            );
        });

    public static readonly string ReadOnlyRole = "41E20BDD-CD75-42CF-B23B-B5136BE897B4";
    public static readonly string CustomRole = "E0E66277-877B-490C-9F48-0C0D0D767ECF";

    public static readonly string[] RolesReadDenied = new[] { ReadOnlyRole, CustomRole };
    public static readonly string[] RolesWriteDenied = RolesReadDenied;

    public static readonly string[] ApplicationsRoleWriteDenied = new[] {
        Application1_TestData.TestAppApplication,
        Application1_TestData.ReadOnlyApplication
    };
}
