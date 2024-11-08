using System.Collections.Generic;
using Agile.Now.Api.Test;
using Agile.Now.Runtime.Api;
using Agile.Now.Runtime.Model;
using Agile.Now.Runtime.Test.Data;
using Xunit;

namespace Agile.Now.Runtime.Test.Api;

public class User_AccessRole_Tests : SubEntityTests<User, User, AccessRole, object> {
    readonly UsersApi api;

    public User_AccessRole_Tests()
        : base(new User_Tests(),
            id: new(nameof(AccessRole.Id), entity => entity.Id),
            testData: null) {

        api = new UsersApi(Settings.Connections[0]);
    }

    protected override List<AccessRole> List(Context<User, User> context,         
        string filters = default, string orders = default, int currentPage = default, int pageSize = DefaultPageSize) =>

        api.ListUserAccessRoles(id: context.ParentId, name: context.Parent.Id.Name,
            filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    [Fact]
    public void Test_User_AccessRole_Test_List_ById() {
        using var context = CreateContext(User_TestData.UserWithAccessRoles.ToString());
        var existing = List(context);
        Assert.NotEmpty(existing);
    }
}
