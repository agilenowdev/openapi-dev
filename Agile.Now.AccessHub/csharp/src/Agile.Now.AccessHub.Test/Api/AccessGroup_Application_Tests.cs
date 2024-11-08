using System.Collections.Generic;
using System.Linq;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.AccessHub.Test.Data;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.AccessHub.Test.Api;

public class AccessGroup_Application_Tests
    : SubEntityTests<AccessGroup, AccessGroupInsertData, Application, ApplicationData> {

    readonly AccessGroupsApi api;

    public AccessGroup_Application_Tests()
        : base(
            parent: new AccessGroup_Tests(),
            testData: new Application_TestData(),
            id: new(nameof(Application.Id), entity => entity.Id)) {

        api = new AccessGroupsApi(Settings.Connections[0]);
    }

    protected override string EntityName => "AccessApplication";

    protected override List<Application> List(Context<AccessGroup, AccessGroupInsertData> context,
        string filters, string orders, int currentPage, int pageSize) =>

        api.ListAccessGroupApplications(id: context.ParentId, name: context.Parent.Id.Name,
            filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    protected override Application Upsert(Context<AccessGroup, AccessGroupInsertData> context, ApplicationData data) =>
        api.UpsertAccessGroupApplication(context.ParentId, data);

    protected override Application[] Patch(Context<AccessGroup, AccessGroupInsertData> context,
        ApplicationData[] data, string deleteNotExists) =>

        api.PatchAccessGroupApplications(context.ParentId,
            applicationsData: new(applications: data.Select(i => i.ToApplicationText()).ToList()),
            deleteNotExists: deleteNotExists).Data.ToArray();

    protected override Application Delete(Context<AccessGroup, AccessGroupInsertData> context, string id, string name) =>
        api.DeleteAccessGroupApplication(context.ParentId, id, context.Parent.Id.Name, name);

    [Fact] public void Test_AccessGroup_Application_List_ById() => Test_List_ById();
    //[Fact] public void Test_AccessGroup_Application_List_ByUniqueAttributes() => Test_List_ByUniqueAttributes();
    [Fact] public void Test_AccessGroup_Application_List_Paging() => Test_List_Paging();
    [Fact] public void Test_AccessGroup_Application_List_OrderAscending() => Test_List_OrderAscending();
    [Fact] public void Test_AccessGroup_Application_List_OrderDecending() => Test_List_OrderDecending();

    [Fact] public void Test_AccessGroup_Application_Upsert() => Test_Upsert();

    [Fact] public void Test_AccessGroup_Application_Patch() => Test_Patch();
    //[Fact] public void Test_AccessGroup_Application_Patch_DeleteNotExists() => Test_Patch_DeleteNotExists();

    [Fact] public void Test_AccessGroup_Application_Delete_ById() => Test_Delete_ById();
    //[Fact] public void Test_AccessGroup_Application_Delete_ByUniqueAttributes() => Test_Delete_ByUniqueAttributes();
}
