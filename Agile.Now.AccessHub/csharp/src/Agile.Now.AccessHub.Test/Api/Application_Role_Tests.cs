using System.Collections.Generic;
using System.Linq;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.AccessHub.Test.Data;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.AccessHub.Test.Api;

public class Application_Role_Tests : SubEntityTests<Application1, string, ApplicationData1, Role, string, RoleData> {
    readonly ApplicationsApi api;

    public Application_Role_Tests()
        : base(new Application_Tests(),
            testData: new Role_TestData(),
            id: new(nameof(Role.Id), entity => entity.Id),
            uniqueAttributes: new Attribute<Role, string, RoleData>[] {
                new(nameof(Role.Name), data => data.Name, (data, value) => data.Name = value),
                new(nameof(Role.ExternalId), data => data.ExternalId, (data, value) => data.ExternalId = value),
                new(nameof(Role.RoleKey), data => data.RoleKey, (data, value) => data.RoleKey = value)
            }) {

        api = new ApplicationsApi(Settings.Connections[0]);
    }

    protected override string EntityName => "";

    protected override List<Role> List(
        string id, string name, string filters, string orders, int currentPage, int pageSize) =>

        api.ListApplicationRoles(
            id: id, name: name, filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    protected override Role Upsert(string id, RoleData data) => api.UpsertApplicationRole(id, data);

    protected override Role Delete(string id, string subId, string name, string subName) =>
        api.DeleteApplicationRole(id, subId, name: name, subName: subName);

    [Fact] public void Test_Application_Role_List_ById() => Test_List_ById();
    //[Fact] public void Test_Application_Role_List_ByUniqueAttributes() => Test_List_ByUniqueAttributes();
    [Fact] public void Test_Application_Role_List_Paging() => Test_List_Paging();
    [Fact] public void Test_Application_Role_List_OrderAscending() => Test_List_OrderAscending();
    [Fact] public void Test_Application_Role_List_OrderDecending() => Test_List_OrderDecending();

    [Fact] public void Test_Application_Role_Upsert() => Test_Upsert();

    [Fact] public void Test_Application_Role_Delete_ById() => Test_Delete_ById();
    //[Fact] public void Test_Application_Role_Delete_ByUniqueAttributes() => Test_Delete_ByUniqueAttributes();
}
