using System.Collections.Generic;
using System.Linq;
using Agile.Now.AccessHub.Model;
using Agile.Now.Api.Test;

namespace Agile.Now.AccessHub.Test.Data;

public class GroupExternal_UserExternal_TestData : TestData<UserExternal, UserExternalData> {
    public override void AssertEqualToRequest(UserExternalData data0, UserExternal data1) { }
    public override void AssertEqualToResponse(UserExternal data0, UserExternal data1) { }
    public override void Update(UserExternalData data) { }

    public override IEnumerable<UserExternalData> GenerateRequestData() =>
        UserTestData.Users.Select(i => new UserExternalData(userId: new("Id", i.ToString())));
}
public static class GroupExternal_UserExternal_TestData_Extensions {
    public static UserExternalText ToUserExternalText(this UserExternalData userExternalData) =>
        new UserExternalText(userExternalData.UserId.Value);
}

