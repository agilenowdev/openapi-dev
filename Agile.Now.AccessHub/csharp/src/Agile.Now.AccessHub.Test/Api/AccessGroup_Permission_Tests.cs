using System.Collections.Generic;
using System.Linq;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.AccessHub.Test.Data;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.AccessHub.Test.Api;

public class AccessGroup_Permission_Tests : SubEntityTests<AccessGroup, AccessGroupInsertData, Permission, PermissionData> {
    readonly AccessGroupsApi api;

    public AccessGroup_Permission_Tests()
        : base(
            parent: new AccessGroup_Tests(),
            testData: new Permission_TestData(),
            id: new(nameof(Permission.Id), entity => entity.Id.ToString(), isString: false)) {

        api = new AccessGroupsApi(Settings.Connections[0]);
    }

    protected override string EntityName => "";

    protected override List<Permission> List(Context<AccessGroup, AccessGroupInsertData> context,
        string filters = default, string orders = default, int currentPage = default, int pageSize = DefaultPageSize) =>

        api.ListAccessGroupPermissions(id: context.ParentId, name: context.Parent.Id.Name,
            filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    protected override Permission Upsert(Context<AccessGroup, AccessGroupInsertData> context, PermissionData data) =>
        api.UpsertAccessGroupPermission(context.ParentId, data);

    protected override Permission[] Patch(Context<AccessGroup, AccessGroupInsertData> context,
        PermissionData[] data, string deleteNotExists) =>

        api.PatchAccessGroupPermissions(context.ParentId,
            permissionsData: new(permissions: data.Select(i => i.ToPermissionText()).ToList()),
            deleteNotExists: deleteNotExists).Data.ToArray();

    protected override Permission Delete(Context<AccessGroup, AccessGroupInsertData> context, string id, string name) =>
        api.DeleteAccessGroupPermission(context.ParentId, id, context.Parent.Id.Name, name);

    [Fact] public void Test_AccessGroup_Permission_List_ById() => Test_List_ById();
    //[Fact] public void Test_AccessGroup_Permission_List_ByUniqueAttributes() => Test_List_ByUniqueAttributes();
    [Fact] public void Test_AccessGroup_Permission_List_Paging() => Test_List_Paging();
    [Fact] public void Test_AccessGroup_Permission_List_OrderAscending() => Test_List_OrderAscending();
    [Fact] public void Test_AccessGroup_Permission_List_OrderDecending() => Test_List_OrderDecending();

    [Fact] public void Test_AccessGroup_Permission_Upsert() => Test_Upsert();

    //[Fact] public void Test_AccessGroup_Permission_Patch_DeleteNotExists() => Test_Patch_DeleteNotExists();

    [Fact] public void Test_AccessGroup_Permission_Delete_ById() => Test_Delete_ById();
    //[Fact] public void Test_AccessGroup_Permission_Delete_ByUniqueAttributes() => Test_Delete_ByUniqueAttributes();
}
