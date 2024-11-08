using System.Collections.Generic;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.AccessHub.Test.Data;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.AccessHub.Test.Api;

public class Application_Tests : EntityTests<Application1, ApplicationData1> {
    readonly ApplicationsApi api;

    public Application_Tests()
        : base(
            testData: new Application1_TestData(),
            id: new(nameof(Application.Id), entity => entity.Id, (entity, id) => entity.Id = id),
            uniqueAttributes: new Attribute<Application1, ApplicationData1>[] {
                new(nameof(Application.Name), data => data.Name, (data, value) => data.Name = value),
                new(nameof(Application.ExternalId), data => data.ExternalId, (data, value) => data.ExternalId = value),
                new(nameof(Application.ApplicationKey),
                    data => data.ApplicationKey, (data, value) => data.ApplicationKey = value)
            }) {

        api = new ApplicationsApi(Settings.Connections[0]);
    }

    protected override List<Application1> List(Context<Application1, ApplicationData1> context,
        string filters = default, string orders = default, int currentPage = default, int pageSize = DefaultPageSize) =>

        api.ListApplications(filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    protected override Application1 Get(Context<Application1, ApplicationData1> context, string id, string name) =>
        api.GetApplication(id, name);

    protected override Application1 Create(Context<Application1, ApplicationData1> context, ApplicationData1 data) =>
        api.CreateApplication(data);

    protected override Application1 Update(Context<Application1, ApplicationData1> context,
        string id, ApplicationData1 data, string name) =>

        api.UpdateApplication(id, data, name);

    protected override Application1 Upsert(Context<Application1, ApplicationData1> context, ApplicationData1 data) =>
        api.UpsertApplication(data);

    protected override Application1 Delete(Context<Application1, ApplicationData1> context, string id, string name) =>
        api.DeleteApplication(id, name);

    [Fact] public void Test_Application_List_ById() => Test_List_ById();
    [Fact] public void Test_Application_List_ByUniqueAttributes() => Test_List_ByUniqueAttributes();
    [Fact] public void Test_Application_List_Paging() => Test_List_Paging();
    [Fact] public void Test_Application_List_OrderAscending() => Test_List_OrderAscending();
    [Fact] public void Test_Application_List_OrderDecending() => Test_List_OrderDecending();
    [Fact] public void Test_Application_List_ReadDenied() => Test_List_ReadDenied(Application1_TestData.ApplicationsReadDenied);

    [Fact] public void Test_Application_Get_ById() => Test_Get_ById();
    [Fact] public void Test_Application_Get_ByUniqueAttributes() => Test_Get_ByUniqueAttributes();
    [Fact] public void Test_Application_Get_ReadDenied() => Test_Get_ReadDenied(Application1_TestData.ApplicationsReadDenied);

    [Fact] public void Test_Application_Create() => Test_Create();
    [Fact] public void Test_Application_Create_WithUniqueAttributes() => Test_Create_WithUniqueAttributes();

    [Fact] public void Test_Application_Update() => Test_Update_ById();
    [Fact] public void Test_Application_Update_ByUniqueAttributes() => Test_Update_ByUniqueAttributes();

    [Fact] public void Test_Application_Upsert() => Test_Upsert();

    [Fact] public void Test_Application_Delete_ById() => Test_Delete_ById();
    [Fact] public void Test_Application_Delete_ByUniqueAttributes() => Test_Delete_ByUniqueAttributes();

    [Fact]
    public void Test_Application_Delete_WriteDenied() =>
        Test_Delete_WriteDenied(Application1_TestData.ApplicationsWriteDenied);
}
