using System.Collections.Generic;
using Agile.Now.Api.Test;
using Agile.Now.Runtime.Api;
using Agile.Now.Runtime.Model;
using Agile.Now.Runtime.Test.Data;
using Xunit;

namespace Agile.Now.Runtime.Test.Api;

public class User_AccessGroup_Tests : SubEntityTests<User, User, AccessGroup, AccessGroupData> {
    readonly UsersApi api;

    public User_AccessGroup_Tests()
        : base(new User_Tests(),
            testData: new AccessGroup_TestData(),
            id: new(nameof(AccessGroup.Id), entity => entity.Id),
            uniqueAttributes: new Attribute<AccessGroup, AccessGroupData>[] {
                new(nameof(AccessGroup.ExternalId), data => data.ExternalId),
                new(nameof(AccessGroup.Name), data => data.Name) }) {

        api = new UsersApi(Settings.Connections[0]);
    }

    protected override List<AccessGroup> List(Context<User, User> context, 
        string filters, string orders, int currentPage, int pageSize) =>

        api.ListUserAccessGroups(id: context.ParentId, name: context.Parent.Id.Name,
            filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    protected override AccessGroup Upsert(Context<User, User> context, AccessGroupData data) =>
        api.UpsertUserAccessGroup(context.ParentId, data);

    protected override AccessGroup Delete(Context<User, User> context, string id, string name) =>
        api.DeleteUserAccessGroup(context.ParentId, id, context.Parent.Id.Name, name);

    [Fact] public void Test_User_AccessGroup_List_ById() => Test_List_ById();
    //[Fact] public void Test_User_AccessGroup_List_ByUniqueAttributes() => Test_List_ByUniqueAttributes();
    [Fact] public void Test_User_AccessGroup_List_Paging() => Test_List_Paging();
    [Fact] public void Test_User_AccessGroup_List_OrderAscending() => Test_List_OrderAscending();
    [Fact] public void Test_User_AccessGroup_List_OrderDecending() => Test_List_OrderDecending();

    [Fact] public void Test_User_AccessGroup_Upsert() => Test_Upsert();

    [Fact] public void Test_User_AccessGroup_Delete_ById() => Test_Delete_ById();
    //[Fact] public void Test_User_AccessGroup_Delete_ByUniqueAttributes() => Test_Delete_ByUniqueAttributes();
}