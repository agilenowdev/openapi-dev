using System.Collections.Generic;
using System.Linq;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.AccessHub.Test.Data;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.AccessHub.Test.Api;

public class AccessGroup_Group_Tests : SubEntityTests<AccessGroup, AccessGroupInsertData, Group, GroupData> {
    readonly AccessGroupsApi api;

    public AccessGroup_Group_Tests()
        : base(
            parent: new AccessGroup_Tests(),
            testData: new Group_TestData(),
            id: new(nameof(Group.Id), entity => entity.Id.ToString(), isString: false)) {

        api = new AccessGroupsApi(Settings.Connections[0]);
    }

    protected override List<Group> List(Context<AccessGroup, AccessGroupInsertData> context, 
        string filters, string orders, int currentPage, int pageSize) =>

        api.ListAccessGroupGroups(id: context.ParentId, name: context.Parent.Id.Name,
            filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    protected override Group Upsert(Context<AccessGroup, AccessGroupInsertData> context, GroupData data) =>
        api.UpsertAccessGroupGroup(context.ParentId, data);

    protected override Group[] Patch(Context<AccessGroup, AccessGroupInsertData> context, 
        GroupData[] data, string deleteNotExists)  =>

        api.PatchAccessGroupGroups(context.ParentId,
            groupsData: new(groups: data.Select(i => i.ToGroupText()).ToList()),
            deleteNotExists: deleteNotExists).Data.ToArray();

    protected override Group Delete(Context<AccessGroup, AccessGroupInsertData> context, string id, string name) => 
        api.DeleteAccessGroupGroup(context.ParentId, id, context.Parent.Id.Name, name);

    [Fact] public void Test_AccessGroup_Group_List_ById() => Test_List_ById();
    //[Fact] public void Test_AccessGroup_Group_List_ByUniqueAttributes() => Test_List_ByUniqueAttributes();
    [Fact] public void Test_AccessGroup_Group_List_Paging() => Test_List_Paging();
    [Fact] public void Test_AccessGroup_Group_List_OrderAscending() => Test_List_OrderAscending();
    [Fact] public void Test_AccessGroup_Group_List_OrderDecending() => Test_List_OrderDecending();

    [Fact] public void Test_AccessGroup_Group_Upsert() => Test_Upsert();

    [Fact] public void Test_AccessGroup_Group_Patch() => Test_Patch();
    //[Fact] public void Test_AccessGroup_Group_Patch_DeleteNotExists() => Test_Patch_DeleteNotExists();

    [Fact] public void Test_AccessGroup_Group_Delete_ById() => Test_Delete_ById();
    //[Fact] public void Test_AccessGroup_Group_Delete_ByUniqueAttributes() => Test_Delete_ByUniqueAttributes();
}
