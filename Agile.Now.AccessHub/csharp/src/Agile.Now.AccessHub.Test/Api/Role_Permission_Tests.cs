using System.Collections.Generic;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.AccessHub.Test.Data;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.AccessHub.Test.Api;

public class Role_Permission_Tests : SubEntityTests<Role1, string, RoleData1, Permission1, long, PermissionData1> {
    readonly RolesApi api;

    public Role_Permission_Tests()
        : base(new Role_Tests(),
            testData: new Permission1_TestData(),
            id: new(nameof(Permission.Id), entity => entity.Id)) {

        api = new RolesApi(Settings.Connections[0]);
    }

    protected override string EntityName => "";

    protected override List<Permission1> List(
        string id, string name, string filters, string orders, int currentPage, int pageSize) =>

        api.ListRolePermissions(
            id: id, name: name, filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    protected override Permission1 Upsert(string id, PermissionData1 data) => api.UpsertRolePermission(id, data);

    protected override Permission1 Delete(string id, string subId, string name, string subName) =>
        api.DeleteRolePermission(id, subId, name: name, subName: subName);

    [Fact] public void Test_Role1_Permission_List_ById() => Test_List_ById();
    //[Fact] public void Test_Role1_Permission_List_ByUniqueAttributes() => Test_List_ByUniqueAttributes();
    [Fact] public void Test_Role1_Permission_List_Paging() => Test_List_Paging();
    [Fact] public void Test_Role1_Permission_List_OrderAscending() => Test_List_OrderAscending();
    [Fact] public void Test_Role1_Permission_List_OrderDecending() => Test_List_OrderDecending();

    [Fact] public void Test_Role1_Permission_Upsert() => Test_Upsert();

    [Fact] public void Test_Role1_Permission_Delete_ById() => Test_Delete_ById();
    //[Fact] public void Test_Role1_Permission_Delete_ByUniqueAttributes() => Test_Delete_ByUniqueAttributes();
}
