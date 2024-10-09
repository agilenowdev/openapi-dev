using System.Collections.Generic;
using Agile.Now.Api.Test;
using Agile.Now.Runtime.Api;
using Agile.Now.Runtime.Model;
using Agile.Now.Runtime.Test.Data;
using Xunit;

namespace Agile.Now.Runtime.Test.Api;

public class User_Application_Tests : SubEntityTests<User, int, User, Application, string, object> {
    readonly UsersApi api;

    public User_Application_Tests()
        : base(new User_Tests(),
            id: new(nameof(Application.Id), entity => entity.Id),
            testData: null) {

        api = new UsersApi(Settings.Connections[0]);
    }

    protected override List<Application> List(string id, string name,
        string filters = default, string orders = default, int currentPage = default, int pageSize = DefaultPageSize) =>

        api.ListUserApplications(id.ToString()).Data;

    [Fact]
    public void Test_User_Application_Test_List_ById() {
        var existing = List(User_TestData.UserWithApplications.ToString(), Parent.Id.Name);
        Assert.NotEmpty(existing);
    }
}
