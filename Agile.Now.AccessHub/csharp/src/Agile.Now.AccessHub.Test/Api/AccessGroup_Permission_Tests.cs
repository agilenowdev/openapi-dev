using System.Collections.Generic;
using System.Linq;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.AccessHub.Test.Data;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.AccessHub.Test.Api;

public class AccessGroup_Permission_Tests
    : SubEntityTests<AccessGroup, string, AccessGroupData, Permission, long, PermissionData>
{

    readonly AccessGroupsApi api;

    public AccessGroup_Permission_Tests()
        : base(
            parent: new AccessGroup_Tests(),
            testData: new AccessGroup_Permission_TestData(),
            id: new(nameof(Permission.Id), entity => entity.Id, null))
    {

        api = new AccessGroupsApi(Settings.Connections[0]);
    }

    public override string EntityName => "";

    protected override List<Permission> List(
        string id, string name, string filters, string orders, int currentPage, int pageSize) =>

        api.ListAccessGroupPermissions(
            id: id, name: name, filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    protected override Permission Upsert(string id, PermissionData data) => api.UpsertAccessGroupPermission(id, data);

    protected override Permission[] Patch(string id, List<PermissionData> data, string deleteNotExists) =>
        api.PatchAccessGroupPermissions(id: id,
            permissionsData: new(permissions: data.Select(i => i.ToPermissionText()).ToList()),
            deleteNotExists: deleteNotExists).Data.ToArray();

    protected override Permission Delete(string id, string subId, string name, string subName) =>
        api.DeleteAccessGroupPermission(id, subId, subName: subName);

    [Fact] public void Test_AccessGroup_Permission_List_ById() => Test_List_ById();
    [Fact] public void Test_AccessGroup_Permission_List_ByUniqueAttributes() => Test_List_ByUniqueAttributes();
    [Fact] public void Test_AccessGroup_Permission_List_Paging() => Test_List_Paging();
    [Fact] public void Test_AccessGroup_Permission_List_OrderAscending() => Test_List_OrderAscending();
    [Fact] public void Test_AccessGroup_Permission_List_OrderDecending() => Test_List_OrderDecending();

    [Fact] public void Test_AccessGroup_Permission_Upsert() => Test_Upsert();

    [Fact] public void Test_AccessGroup_Permission_Patch() => Test_Patch();
    [Fact] public void Test_AccessGroup_Permission_Patch_DeleteNotExists() => Test_Patch_DeleteNotExists();

    [Fact] public void Test_AccessGroup_Permission_Delete_ById() => Test_Delete_ById();
    [Fact] public void Test_AccessGroup_Permission_Delete_ByUniqueAttributes() => Test_Delete_ByUniqueAttributes();
}
