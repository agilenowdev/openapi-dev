using System.Collections.Generic;
using System.Linq;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.AccessHub.Test.Data;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.AccessHub.Test.Api;

public class Role_Permission_Tests : SubEntityTests<Role1, RoleData1, Permission1, PermissionData1> {
    readonly RolesApi api;

    public Role_Permission_Tests()
        : base(new Role_Tests(),
            testData: new Permission1_TestData(),
            id: new(nameof(Permission.Id), entity => entity.Id.ToString(), isString: false)) {

        api = new RolesApi(Settings.Connections[0]);
    }

    protected override string EntityName => "";

    protected override List<Permission1> List(Context<Role1, RoleData1> context,
        string filters = default, string orders = default, int currentPage = default, int pageSize = DefaultPageSize) =>

        api.ListRolePermissions(id: context.ParentId, name: context.Parent.Id.Name,
            filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    protected override Permission1 Upsert(Context<Role1, RoleData1> context, PermissionData1 data) =>
        api.UpsertRolePermission(context.ParentId, data);

    protected override Permission1[] Patch(Context<Role1, RoleData1> context,
        PermissionData1[] data, string deleteNotExists) =>

        api.PatchRolePermissions(context.ParentId,
            permissionsData1: new PermissionsData1(permissions: data.Select(i => i.ToPermissionText1()).ToList()),
            deleteNotExists: deleteNotExists).Data.ToArray();

    protected override Permission1 Delete(Context<Role1, RoleData1> context, string id, string name) =>
        api.DeleteRolePermission(context.ParentId, id, context.Parent.Id.Name, name);

    [Fact] public void Test_Role_Permission_List_ById() => Test_List_ById();
    //[Fact] public void Test_Role_Permission_List_ByUniqueAttributes() => Test_List_ByUniqueAttributes();
    [Fact] public void Test_Role_Permission_List_Paging() => Test_List_Paging();
    [Fact] public void Test_Role_Permission_List_OrderAscending() => Test_List_OrderAscending();
    [Fact] public void Test_Role_Permission_List_OrderDecending() => Test_List_OrderDecending();

    [Fact]
    public void Test_Role_Permission_List_ReadDenied() =>
        Test_List_SubEntities_ReadDenied(Role1_TestData.RolesReadDenied);

    [Fact] public void Test_Role_Permission_Upsert() => Test_Upsert();

    [Fact]
    public void Test_Role_Permission_Upsert_WriteDenied() =>
        Test_Upsert_SubEntities_WriteDenied(Role1_TestData.RolesWriteDenied);

    [Fact] public void Test_Role_Permission_Delete_ById() => Test_Delete_ById();
    //[Fact] public void Test_Role_Permission_Delete_ByUniqueAttributes() => Test_Delete_ByUniqueAttributes();

    [Fact]
    public void Test_Role_Permission_Delete_WriteDenied() =>
        Test_Delete_SubEntities_WriteDenied(Role1_TestData.RolesWriteDenied);
}
