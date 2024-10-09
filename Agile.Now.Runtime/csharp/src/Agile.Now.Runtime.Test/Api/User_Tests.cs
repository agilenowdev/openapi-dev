using System.Collections.Generic;
using Agile.Now.Api.Test;
using Agile.Now.Runtime.Api;
using Agile.Now.Runtime.Model;
using Agile.Now.Runtime.Test.Data;
using Xunit;

namespace Agile.Now.Runtime.Test.Api;

public class User_Tests : EntityTests<User, int, object> {
    readonly UsersApi api;

    public User_Tests()
        : base(
            testData: new User_TestData(),
            id: new(nameof(User.Id), entity => entity.Id, null),
            uniqueAttributes: new Attribute<User, string, object>[] {
                new(nameof(User.ExternalId), data => data.ExternalId, null),
                new(nameof(User.Name), data => data.Name, null),
            }) {

        api = new UsersApi(Settings.Connections[0]);
    }

    protected override List<User> List(string filters, string orders, int currentPage, int pageSize) =>
        api.ListUsers(filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    protected override User Get(string id, string name) => api.GetUser(id, name);

    protected override User Create(object data) => data as User;

    [Fact] public void Test_User_List_ById() => Test_List_ById();
    [Fact] public void Test_User_List_ByUniqueAttributes() => Test_List_ByUniqueAttributes();
    [Fact] public void Test_User_List_Paging() => Test_List_Paging();
    [Fact] public void Test_User_List_OrderAscending() => Test_List_OrderAscending();
    [Fact] public void Test_User_List_OrderDecending() => Test_List_OrderDecending();

    [Fact] public void Test_User_Get_ById() => Test_Get_ById();
    [Fact] public void Test_User_Get_ByUniqueAttributes() => Test_Get_ByUniqueAttributes();
}
