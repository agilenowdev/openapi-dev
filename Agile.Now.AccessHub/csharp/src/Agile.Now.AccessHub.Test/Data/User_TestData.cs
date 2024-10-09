using System.Collections.Generic;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Data;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.ApiOrganizations.Test.Api;

public class User_TestData : TestData<User, UserData> {
    public override void AssertEqualToRequest(UserData data0, User data1) {
        Assert.Equal(data0.UserId.Value, data1.Id.ToString());
    }

    public override void AssertEqualToResponse(User data0, User data1) {
        Assert.Equal(data0.Id, data1.Id);
        Assert.Equal(data0.Name, data1.Name);
        Assert.Equal(data0.Username, data1.Username);
        Assert.Equal(data0.Email, data1.Email);
        Assert.Equal(data0.MobilePhone, data1.MobilePhone);
        Assert.Equal(data0.ExternalId, data1.ExternalId);
    }

    public override IEnumerable<UserData> GenerateRequestData() => UserTestData.CreateUserData1s();
}
