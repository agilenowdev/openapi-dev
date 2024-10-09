using System.Collections.Generic;
using System.Linq;
using Agile.Now.AccessHub.Model;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.AccessHub.Test.Data;

public class UserExternal_TestData : TestData<UserExternal, UserExternalData> {
    public override void AssertEqualToRequest(UserExternalData expected, UserExternal actual) {
        Assert.Equal(expected.UserId.Value, actual.Id.ToString());
    }

    public override void AssertEqualToResponse(UserExternal expected, UserExternal actual) {
        Assert.Equal(expected.Id, actual.Id);
        Assert.Equal(expected?.Name, actual.Name);
        Assert.Equal(expected.Username, actual.Username);
        Assert.Equal(expected.Email, actual.Email);
        Assert.Equal(expected.MobilePhone ?? "", actual.MobilePhone ?? "");
        Assert.Equal(expected.ExternalId, actual.ExternalId);
    }

    public override IEnumerable<UserExternalData> GenerateRequestData() =>
        User_TestData.Users.Select(i => new UserExternalData(userId: new("Id", i.ToString())));
}
public static class UserExternal_TestData_Extensions {
    public static UserExternalText ToUserExternalText(this UserExternalData userExternalData) =>
        new UserExternalText(userExternalData.UserId.Value);
}

