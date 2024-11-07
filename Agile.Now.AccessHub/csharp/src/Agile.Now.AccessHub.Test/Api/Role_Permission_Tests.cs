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

    protected override Permission1[] Patch(string id, List<PermissionData1> data, string deleteNotExists) =>
        api.PatchRolePermissions(id: id,
            permissionsData1: new PermissionsData1(permissions: data.Select(i => i.ToPermissionText1()).ToList()),
            deleteNotExists: deleteNotExists).Data.ToArray();

    protected override Permission1 Delete(Context<Role1, RoleData1> context, string id, string name) =>
        api.DeleteRolePermission(context.ParentId, id, context.Parent.Id.Name, name);

    [Fact] public void Test_Role_Permission_List_ById() => Test_List_ById();
    //[Fact] public void Test_Role_Permission_List_ByUniqueAttributes() => Test_List_ByUniqueAttributes();
    [Fact] public void Test_Role_Permission_List_Paging() => Test_List_Paging();
    [Fact] public void Test_Role_Permission_List_OrderAscending() => Test_List_OrderAscending();
    [Fact] public void Test_Role_Permission_List_OrderDecending() => Test_List_OrderDecending();

    [Fact] public void Test_Role_Permission_List_NoAccess() => 
        Test_List_SubEntities_NoAccess(Role1_TestData.RolesWithNoAccess);

    [Fact] public void Test_Role_Permission_Upsert() => Test_Upsert();

    [Fact]
    public void Test_Role_Permission_Upsert_ReadOnly_Custom() {
        foreach(var i in new[] {
            Role1_TestData.ReadOnlyRole,
            Role1_TestData.CustomRole
        }) {
            using var context = CreateContext(i);
            Assert.ThrowsAny<Exception>(() => Upsert(context, TestData.GenerateRequestData().First()));
        }
    }

    [Fact]
    public void Test_Role_Permission_Patch() {
        using var context = CreateContext();
        var data = TestData.GenerateRequestData().Take(3).ToArray();
        var created = data.Take(2).Select(i => Upsert(context, i)).ToArray();
        try {
            var patched = Patch(context.ParentId, data.Skip(2).Take(1).ToList(), null);
            created = created.UnionBy(patched, i => Id.Get(i)).ToArray();
            try {
                var existing = List(context, EntityName + CreateFilters(context, Id, created));
                AssertCollectionsEqual(existing, created);
            }
            finally {
                Delete(context, created);
                created = null;
            }
        }
        finally {
            if(created != null)
                Delete(context, created);
        }
    }

    //[Fact]
    //public void Test_Role_Permission_Patch_DeleteNotExists() {
    //    var parentEntity = Parent.GenerateEntity();
    //    var id = Parent.Id.Get(parentEntity);
    //    try {
    //        var data = TestData.GenerateRequestData().Take(3).ToArray();
    //        var created = data.Take(2).Select(i => Upsert(id, i)).ToArray();
    //        try {
    //            var patched = Patch(id, data.Skip(2).Take(1).ToList(), true.ToString());
    //            var existing = List(id.ToString(), Parent.Id.Name);
    //            AssertCollectionsEqual(existing, patched);
    //            created = patched;
    //        }
    //        finally {
    //            Delete(parentEntity, created);
    //        }
    //    }
    //    finally {
    //        Parent.Delete(parentEntity);
    //    }
    //}

    [Fact] public void Test_Role_Permission_Delete_ById() => Test_Delete_ById();
    //[Fact] public void Test_Role_Permission_Delete_ByUniqueAttributes() => Test_Delete_ByUniqueAttributes();
}
