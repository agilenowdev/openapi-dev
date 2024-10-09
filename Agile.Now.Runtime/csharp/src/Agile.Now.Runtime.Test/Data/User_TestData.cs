using System.Collections.Generic;
using Agile.Now.Api.Test;
using Agile.Now.Runtime.Model;
using Xunit;

namespace Agile.Now.Runtime.Test.Data;

public class User_TestData : TestData<User, object> {
    public override void AssertEqualToRequest(object data0, User data1) { }

    public override void AssertEqualToResponse(User data0, User data1) {
        Assert.Equal(data0.Id, data1.Id);
        Assert.Equal(data0?.Name, data1.Name);
        Assert.Equal(data0.Username, data1.Username);
        Assert.Equal(data0.ExternalId, data1.ExternalId);
    }

    public override IEnumerable<User> GenerateRequestData() {
        yield return new User(
            id: 16862,
            name: "test test",
            username: "test@fieldio.io",
            externalId: "0edea317-dc4b-428a-9341-78640cfd9552");
        yield return new User(
            id: 14996,
            name: "Rui Test",
            username: "r.mota.soares@outlook.pt",
            externalId: "09fe0e1c-3f29-4482-9438-b4ba5a4f03ed");
        yield return new User(
            id: 29788,
            name: "Demo Test",
            username: "test.demo@esystems.fi",
            externalId: "3f43bb10-b01f-4994-a041-da095e77c907");
        yield return new User(
            id: 41196,
            name: "lastName3 unit-test-account3",
            username: "unit-test-account3-2024-09-12-19-15-17-764@agilenow.io",
            externalId: "398086fc-bc3b-41ed-85fa-15e91517f6c4");
    }
}

public class User_TestData_Extensions {
    public static readonly (int Id, string Name)[] Users = new[] {
        (29788, "Demo Test"),
        (16862, "test test"),
        (14996, "Rui Test"),
        (41196, "lastName3 unit-test-account3")
    };

    public const int UserWithApplications = 17068;
    public const int UserWithEffectivePermissions = 17068;
    public const int UserWithAccessRoles = 17068;












}
