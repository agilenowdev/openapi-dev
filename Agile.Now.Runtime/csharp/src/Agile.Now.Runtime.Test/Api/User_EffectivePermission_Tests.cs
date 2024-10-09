using System.Collections.Generic;
using Agile.Now.Api.Test;
using Agile.Now.Runtime.Api;
using Agile.Now.Runtime.Model;
using Xunit;

namespace Agile.Now.Runtime.Test.Api;

public class User_EffectivePermission_Tests : SubEntityTests<User, int, object, EffectivePermission, string, object>
{
    readonly UsersApi api;

    public User_EffectivePermission_Tests()
        : base(new User_Tests(),
            id: new(nameof(EffectivePermission.Id), entity => entity.Id, null),
            testData: null)
    {

        api = new UsersApi(Settings.Connections[0]);
    }

    protected override List<EffectivePermission> List(
        string id, string name, string filters, string orders, int currentPage, int pageSize) =>

        api.ListUserEffectivePermissions(id.ToString()).Data;

    [Fact]
    public void Test_User_EffectivePermission_Test_List_ById()
    {
        var parentEntity = Parent.GenerateEntity();
        var id = Parent.Id.Get(parentEntity);
        try
        {
            Assert.Null(Record.Exception(() =>
            {
                List(id.ToString(), Parent.Id.Name, null, null, 0, DefaultPageSize);
            }));
        }
        finally
        {
            Parent.Delete(parentEntity);
        }
    }
}
