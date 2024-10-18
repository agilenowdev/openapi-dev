using System.Collections.Generic;
using Agile.Now.Api.Test;
using Agile.Now.Runtime.Api;
using Agile.Now.Runtime.Model;
using Agile.Now.Runtime.Test.Data;
using Xunit;

namespace Agile.Now.Runtime.Test.Api;

public class User_AccessGroup_Tests : SubEntityTests<User, int, User, AccessGroup, string, AccessGroupData> {
    readonly UsersApi api;

    public User_AccessGroup_Tests()
        : base(new User_Tests(),
            testData: new AccessGroup_TestData(),
            id: new(nameof(AccessGroup.Id), entity => entity.Id),
            uniqueAttributes: new Attribute<AccessGroup, string, AccessGroupData>[] {
                new(nameof(AccessGroup.ExternalId), data => data.ExternalId),
                new(nameof(AccessGroup.Name), data => data.Name) }) {

        api = new UsersApi(Settings.Connections[0]);
    }

    protected override List<AccessGroup> List(
        string id, string name, string filters, string orders, int currentPage, int pageSize) =>

        api.ListUserAccessGroups(
            id: id, name: name, filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    protected override AccessGroup Upsert(int id, AccessGroupData data) => api.UpsertUserAccessGroup(id.ToString(), data);

    protected override AccessGroup Delete(string id, string subId, string name, string subName) =>
        api.DeleteUserAccessGroup(id, subId, name: name, subName: subName);

    [Fact] public void Test_User_AccessGroup_List_ById() => Test_List_ById();
    //[Fact] public void Test_User_AccessGroup_List_ByUniqueAttributes() => Test_List_ByUniqueAttributes();
    [Fact] public void Test_User_AccessGroup_List_Paging() => Test_List_Paging();
    [Fact] public void Test_User_AccessGroup_List_OrderAscending() => Test_List_OrderAscending();
    //[Fact] public void Test_User_AccessGroup_List_OrderDecending() => Test_List_OrderDecending();

    [Fact] public void Test_User_AccessGroup_Upsert() => Test_Upsert();

    [Fact] public void Test_User_AccessGroup_Delete_ById() => Test_Delete_ById();
    //[Fact] public void Test_User_AccessGroup_Delete_ByUniqueAttributes() => Test_Delete_ByUniqueAttributes();
}