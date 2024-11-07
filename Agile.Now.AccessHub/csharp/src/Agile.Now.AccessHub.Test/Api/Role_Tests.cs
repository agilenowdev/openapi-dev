using System;
using System.Collections.Generic;
using System.Linq;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.AccessHub.Test.Data;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.AccessHub.Test.Api;

public class Role_Tests : EntityTests<Role1, RoleData1> {
    readonly RolesApi api;

    public Role_Tests()
        : base(
            testData: new Role1_TestData(),
            id: new(nameof(Role1.Id), entity => entity.Id, (entity, id) => entity.Id = id),
            uniqueAttributes: new Attribute<Role1, RoleData1>[] {
                new(nameof(Role1.Name), data => data.Name, (data, value) => data.Name = value),
                new(nameof(Role1.RoleKey),
                    data => data.RoleKey, (data, value) => data.RoleKey = value)
            }) {

        api = new RolesApi(Settings.Connections[0]);
    }

    protected override List<Role1> List(Context<Role1, RoleData1> context,
        string filters = default, string orders = default, int currentPage = default, int pageSize = DefaultPageSize) =>

        api.ListRoles(filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    protected override Role1 Get(Context<Role1, RoleData1> context, string id, string name) => api.GetRole(id, name);
    protected override Role1 Create(Context<Role1, RoleData1> context, RoleData1 data) => api.CreateRole(data);

    protected override Role1 Update(Context<Role1, RoleData1> context, string id, RoleData1 data, string name) =>
        api.UpdateRole(id, data, name);

    protected override Role1 Upsert(RoleData1 data) => api.UpsertRole(data);
    protected override Role1 Delete(Context<Role1, RoleData1> context, string id, string name) => api.DeleteRole(id, name);

    [Fact] public void Test_Role_List_ById() => Test_List_ById();
    [Fact] public void Test_Role_List_ByUniqueAttributes() => Test_List_ByUniqueAttributes();
    [Fact] public void Test_Role_List_Paging() => Test_List_Paging();
    [Fact] public void Test_Role_List_OrderAscending() => Test_List_OrderAscending();
    [Fact] public void Test_Role_List_OrderDecending() => Test_List_OrderDecending();
    [Fact] public void Test_Role_List_NoAccess() => Test_List_NoAccess(Role1_TestData.RolesWithNoAccess);

    [Fact] public void Test_Role_Get_ById() => Test_Get_ById();
    [Fact] public void Test_Role_Get_ByUniqueAttributes() => Test_Get_ByUniqueAttributes();
    [Fact] public void Test_Role_Get_NoAccess() => Test_Get_NoAccess(Role1_TestData.RolesWithNoAccess);

    [Fact] public void Test_Role_Create() => Test_Create();
    [Fact] public void Test_Role_Create_WithUniqueAttributes() => Test_Create_WithUniqueAttributes();

    [Fact] public void Test_Role_Update() => Test_Update_ById();
    [Fact] public void Test_Role_Update_ByUniqueAttributes() => Test_Update_ByUniqueAttributes();

    [Fact]
    public void Test_Role_Update_ReadOnly_TestApp_System() {
        using var context = CreateContext();
        foreach(var i in new[] {
            Role1_TestData.ReadOnlyRole,
            Role1_TestData.CustomRole
        })
            Assert.ThrowsAny<Exception>(() => Update(context, i, TestData.GenerateRequestData().First(), Id.Name));
    }

    [Fact] public void Test_Role_Upsert() => Test_Upsert();

    [Fact] public void Test_Role_Delete_ById() => Test_Delete_ById();
    [Fact] public void Test_Role_Delete_ByUniqueAttributes() => Test_Delete_ByUniqueAttributes();

    [Fact]
    public void Test_Role_Delete_ReadOnly_TestApp_System() {
        using var context = CreateContext();
        foreach(var i in new[] {
            Role1_TestData.ReadOnlyRole,
            Role1_TestData.CustomRole
        })
            Assert.ThrowsAny<Exception>(() => Delete(context, i));
    }
}
