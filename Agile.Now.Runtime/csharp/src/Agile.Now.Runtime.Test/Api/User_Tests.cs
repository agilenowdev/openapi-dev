using System.Collections.Generic;
using Agile.Now.Api.Test;
using Agile.Now.Runtime.Api;
using Agile.Now.Runtime.Model;
using Agile.Now.Runtime.Test.Data;
using Xunit;

namespace Agile.Now.Runtime.Test.Api;

public class User_Tests : EntityTests<User, User> {
    readonly UsersApi api;

    public User_Tests()
        : base(
            testData: new User_TestData(),
            id: new(nameof(User.Id), entity => entity.Id.ToString(), isString: false),
            uniqueAttributes: new Attribute<User, User>[] {
                new("External_Id", data => data.ExternalId),
                //new(nameof(User.Username), data => data.Username)
            }) {

        api = new UsersApi(Settings.Connections[0]);
    }

    protected override List<User> List(Context<User, User> context,
        string filters, string orders, int currentPage, int pageSize) =>

        api.ListUsers(filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    protected override User Get(Context<User, User> context, string id, string name) =>
        api.GetUser(id, name);

    protected override User Create(Context<User, User> context, User data) => data;

    [Fact] public void Test_User_List_ById() => Test_List_ById();
    [Fact] public void Test_User_List_ByUniqueAttributes() => Test_List_ByUniqueAttributes();
    [Fact] public void Test_User_List_Paging() => Test_List_Paging();
    [Fact] public void Test_User_List_OrderAscending() => Test_List_OrderAscending();
    [Fact] public void Test_User_List_OrderDecending() => Test_List_OrderDecending();

    [Fact] public void Test_User_Get_ById() => Test_Get_ById();
    [Fact] public void Test_User_Get_ByUniqueAttributes() => Test_Get_ByUniqueAttributes();
}
