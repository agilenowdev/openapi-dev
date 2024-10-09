using System.Collections.Generic;
using Agile.Now.Api.Test;
using Agile.Now.Runtime.Api;
using Agile.Now.Runtime.Model;
using Agile.Now.Runtime.Test.Data;
using Xunit;

namespace Agile.Now.Runtime.Test.Api;

public class User_Group_Tests : SubEntityTests<User, int, object, Group, int, GroupData>
{
    readonly UsersApi api;

    public User_Group_Tests()
        : base(new User_Tests(),
            testData: new User_Group_TestData(),
            id: new(nameof(Group.Id), entity => entity.Id, null),
            uniqueAttributes: new Attribute<Group, string, GroupData>[] {
                //new(nameof(Group.ExternalId), data => data.ExternalId, null),
                new(nameof(Group.Name), data => data.Name, null) })
    {

        api = new UsersApi(Settings.Connections[0]);
    }

    protected override List<Group> List(
        string id, string name, string filters, string orders, int currentPage, int pageSize) =>

        api.ListUserGroups(
            id: id, name: name, filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    protected override Group Upsert(int id, GroupData data) => api.UpsertUserGroup(id.ToString(), data);

    protected override Group Delete(string id, string subId, string name, string subName) =>
        api.DeleteUserGroup(id, subId, name: name, subName: subName);

    [Fact] public void Test_User_Group_List_ById() => Test_List_ById();
    [Fact] public void Test_User_Group_List_ByUniqueAttributes() => Test_List_ByUniqueAttributes();
    [Fact] public void Test_User_Group_List_Paging() => Test_List_Paging();
    [Fact] public void Test_User_Group_List_OrderAscending() => Test_List_OrderAscending();
    [Fact] public void Test_User_Group_List_OrderDecending() => Test_List_OrderDecending();

    [Fact] public void Test_User_Group_Upsert() => Test_Upsert();

    [Fact] public void Test_User_Group_Delete_ById() => Test_Delete_ById();
    [Fact] public void Test_User_Group_Delete_ByUniqueAttributes() => Test_Delete_ByUniqueAttributes();
}