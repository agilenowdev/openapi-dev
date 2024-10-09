using System.Collections.Generic;
using System.Linq;
using Agile.Now.AccessHub.Model;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.AccessHub.Test.Data;

public class User_TestData : TestData<User, UserData> {
    public override void AssertEqualToRequest(UserData expected, User actual) {
        Assert.Equal(expected.UserId.Value, actual.Id.ToString());
    }

    public override void AssertEqualToResponse(User expected, User actual) {
        Assert.Equal(expected.Id, actual.Id);
        Assert.Equal(expected.Name, actual.Name);
        Assert.Equal(expected.Username, actual.Username);
        Assert.Equal(expected.Email, actual.Email);
        Assert.Equal(expected.MobilePhone, actual.MobilePhone);
        Assert.Equal(expected.ExternalId, actual.ExternalId);
    }

    public static readonly int[] Users = new[] { 35012, 34967, 16862 };

    public override IEnumerable<UserData> GenerateRequestData() =>
        Users.Select(i => new UserData(userId: new("Id", i.ToString())));
}

public static class User_TestData_Extensions {
    public static UserText ToUserText(this UserData userData) => new UserText(userData.UserId.Value);
    public static UserText1 ToUserText1(this UserData userData) => new UserText1(userData.UserId.Value);
}
