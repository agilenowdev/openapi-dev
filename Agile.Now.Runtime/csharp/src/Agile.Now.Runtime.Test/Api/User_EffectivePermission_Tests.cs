using System.Collections.Generic;
using Agile.Now.Api.Test;
using Agile.Now.Runtime.Api;
using Agile.Now.Runtime.Model;
using Agile.Now.Runtime.Test.Data;
using Xunit;

namespace Agile.Now.Runtime.Test.Api;

public class User_EffectivePermission_Tests : SubEntityTests<User, User, EffectivePermission, object> {
    readonly UsersApi api;

    public User_EffectivePermission_Tests()
        : base(new User_Tests(),
            id: new(nameof(EffectivePermission.Id), entity => entity.Id),
            testData: null) {

        api = new UsersApi(Settings.Connections[0]);
    }

    protected override List<EffectivePermission> List(Context<User, User> context, 
        string filters = default, string orders = default, int currentPage = default, int pageSize = DefaultPageSize) =>

        api.ListUserEffectivePermissions(id: context.ParentId, name: context.Parent.Id.Name,
            filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    [Fact]
    public void Test_User_EffectivePermission_Test_List_ById() {
        using var context = CreateContext();
        var existing = List(context, User_TestData.UserWithEffectivePermissions.ToString(), Parent.Id.Name);
        Assert.NotEmpty(existing);
    }
}
