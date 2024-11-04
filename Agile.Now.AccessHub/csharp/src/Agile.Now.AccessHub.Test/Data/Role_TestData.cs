using System;
using System.Collections.Generic;
using System.Linq;
using Agile.Now.AccessHub.Model;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.AccessHub.Test.Data;

public class Role_TestData : TestData<Role, RoleData> {
    public override void AssertEqualToRequest(RoleData expected, Role actual) {
        Assert.Equal(expected.Name, actual.Name);
        Assert.Equal(expected.RoleKey, actual.RoleKey);
        Assert.Equal(expected.FullName, actual.FullName);
        Assert.Equal(expected.Description, actual.Description);
        Assert.Equal(expected.ExternalId, actual.ExternalId);
    }

    public override void AssertEqualToResponse(Role expected, Role actual) {
        Assert.Equal(expected.Id, actual.Id);
        Assert.Equal(expected.Name, actual.Name);
        Assert.Equal(expected.RoleKey, actual.RoleKey);
        Assert.Equal(expected.FullName, actual.FullName);
        Assert.Equal(expected.Description, actual.Description);
        Assert.Equal(expected.ExternalId, actual.ExternalId);
    }

    public override IEnumerable<RoleData> GenerateRequestData() =>
        Enumerable.Range(0, 4).Select(i => {
            var name = CreateTestEntityName("role", i.ToString());
            return new RoleData(
                name: name.MakeUnique(),
                roleKey: Guid.NewGuid().ToString(),
                fullName: name,
                externalId: Guid.NewGuid().ToString(),
                description: name
            );
        });
}
