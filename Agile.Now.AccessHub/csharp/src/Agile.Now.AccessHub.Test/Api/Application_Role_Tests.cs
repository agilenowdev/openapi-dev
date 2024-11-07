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

public class Application_Role_Tests : SubEntityTests<Application1, ApplicationData1, Role, RoleData> {
    readonly ApplicationsApi api;

    public Application_Role_Tests()
        : base(new Application_Tests(),
            testData: new Role_TestData(),
            id: new(nameof(Role.Id), entity => entity.Id),
            uniqueAttributes: new Attribute<Role, RoleData>[] {
                new(nameof(Role.Name), data => data.Name, (data, value) => data.Name = value),
                new(nameof(Role.ExternalId), data => data.ExternalId, (data, value) => data.ExternalId = value),
                new(nameof(Role.RoleKey), data => data.RoleKey, (data, value) => data.RoleKey = value)
            }) {

        api = new ApplicationsApi(Settings.Connections[0]);
    }

    protected override string EntityName => "";

    protected override List<Role> List(Context<Application1, ApplicationData1> context,
        string filters, string orders, int currentPage, int pageSize) =>

        api.ListApplicationRoles(id: context.ParentId, name: context.Parent.Id.Name,
            filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    protected override Role Upsert(Context<Application1, ApplicationData1> context, RoleData data) =>
        api.UpsertApplicationRole(context.ParentId, data);

    protected override Role Delete(Context<Application1, ApplicationData1> context, string id, string name) =>
        api.DeleteApplicationRole(context.ParentId, id, context.Parent.Id.Name, name);

    [Fact] public void Test_Application_Role_List_ById() => Test_List_ById();
    //[Fact] public void Test_Application_Role_List_ByUniqueAttributes() => Test_List_ByUniqueAttributes();
    [Fact] public void Test_Application_Role_List_Paging() => Test_List_Paging();
    [Fact] public void Test_Application_Role_List_OrderAscending() => Test_List_OrderAscending();
    [Fact] public void Test_Application_Role_List_OrderDecending() => Test_List_OrderDecending();

    [Fact]
    public void Test_Application_Role_List_NoAccess() =>
        Test_List_SubEntities_NoAccess(Application1_TestData.ApplicationsWithNoAccess);

    [Fact] public void Test_Application_Role_Upsert() => Test_Upsert();

    [Fact]
    public void Test_Application_Role_Upsert_ReadOnly_TestApp() {
        foreach(var i in new[] {
            Application1_TestData.ReadOnlyApplication,
            Application1_TestData.TestAppApplication
        }) {
            using var context = CreateContext(i);
            Assert.ThrowsAny<Exception>(() => Upsert(context, TestData.GenerateRequestData().First()));
        }
    }

    [Fact]
    public void Test_Application_Role_Upsert_System() {
        using var context = CreateContext(Application1_TestData.SystemApplication);
        Assert.Null(Record.Exception(() => {
            var created = Upsert(context, TestData.GenerateRequestData().First());
            Delete(context, Application1_TestData.SystemApplication, created.Id);
        }));
    }

    [Fact] public void Test_Application_Role_Delete_ById() => Test_Delete_ById();
    //[Fact] public void Test_Application_Role_Delete_ByUniqueAttributes() => Test_Delete_ByUniqueAttributes();
}
