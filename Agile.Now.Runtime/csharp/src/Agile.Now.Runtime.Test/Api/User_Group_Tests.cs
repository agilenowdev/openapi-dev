using System.Collections.Generic;
using System.Linq;
using Agile.Now.Api.Test;
using Agile.Now.Runtime.Api;
using Agile.Now.Runtime.Model;
using Agile.Now.Runtime.Test.Data;
using Xunit;

namespace Agile.Now.Runtime.Test.Api;

public class User_Group_Tests : SubEntityTests<User, User, Group, GroupData> {
    readonly UsersApi api;

    public User_Group_Tests()
        : base(new User_Tests(),
            testData: new Group_TestData(),
            id: new(nameof(Group.Id), entity => entity.Id.ToString(), isString: false),
            uniqueAttributes: new Attribute<Group, GroupData>[] {
                new(nameof(Group.Name), data => data.Name) }) {

        api = new UsersApi(Settings.Connections[0]);
    }

    protected override string EntityName => "Group_";

    protected override List<Group> List(Context<User, User> context,
        string filters, string orders, int currentPage, int pageSize) =>

        api.ListUserGroups(id: context.ParentId, name: context.Parent.Id.Name,
            filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    protected override Group Upsert(Context<User, User> context, GroupData data) =>
        api.UpsertUserGroup(context.ParentId, data);

    protected override Group[] Patch(Context<User, User> context, GroupData[] data, string deleteNotExists) =>
        api.PatchUserGroups(context.ParentId,
            groupsData: new GroupsData(groups: data.Select(i => i.ToGroupText()).ToList()),
            deleteNotExists: deleteNotExists).Data.ToArray();

    protected override Group Delete(Context<User, User> context, string id, string name) =>
        api.DeleteUserGroup(context.ParentId, id, context.Parent.Id.Name, name);

    [Fact] public void Test_User_Group_List_ById() => Test_List_ById();
    //[Fact] public void Test_User_Group_List_ByUniqueAttributes() => Test_List_ByUniqueAttributes();
    [Fact] public void Test_User_Group_List_Paging() => Test_List_Paging();
    [Fact] public void Test_User_Group_List_OrderAscending() => Test_List_OrderAscending();
    [Fact] public void Test_User_Group_List_OrderDecending() => Test_List_OrderDecending();

    [Fact] public void Test_User_Group_Upsert() => Test_Upsert();

    [Fact] public void Test_User_Group_Patch() => Test_Patch();
    [Fact] public void Test_User_Group_Patch_DeleteNotExists() => Test_Patch_DeleteNotExists();

    [Fact] public void Test_User_Group_Delete_ById() => Test_Delete_ById();
    //[Fact] public void Test_User_Group_Delete_ByUniqueAttributes() => Test_Delete_ByUniqueAttributes();
}