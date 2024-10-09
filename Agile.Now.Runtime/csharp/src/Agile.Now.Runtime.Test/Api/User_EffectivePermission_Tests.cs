using System.Collections.Generic;
using Agile.Now.Api.Test;
using Agile.Now.Runtime.Api;
using Agile.Now.Runtime.Model;
using Agile.Now.Runtime.Test.Data;
using Xunit;

namespace Agile.Now.Runtime.Test.Api;

public class User_EffectivePermission_Tests : SubEntityTests<User, int, User, EffectivePermission, string, object> {
    readonly UsersApi api;

    public User_EffectivePermission_Tests()
        : base(new User_Tests(),
            id: new(nameof(EffectivePermission.Id), entity => entity.Id),
            testData: null) {

        api = new UsersApi(Settings.Connections[0]);
    }

    protected override List<EffectivePermission> List(string id, string name,
        string filters = default, string orders = default, int currentPage = default, int pageSize = DefaultPageSize) =>

        api.ListUserEffectivePermissions(id.ToString()).Data;

    [Fact]
    public void Test_User_EffectivePermission_Test_List_ById() {
        var existing = List(User_TestData.UserWithEffectivePermissions.ToString(), Parent.Id.Name);
        Assert.NotEmpty(existing);
    }
}
