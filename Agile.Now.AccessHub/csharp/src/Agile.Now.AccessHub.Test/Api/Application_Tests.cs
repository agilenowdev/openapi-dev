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

public class Application_Tests : EntityTests<Application1, string, ApplicationData1> {
    readonly ApplicationsApi api;

    public Application_Tests()
        : base(
            testData: new Application1_TestData(),
            id: new(nameof(Application.Id), entity => entity.Id, (entity, id) => entity.Id = id),
            uniqueAttributes: new Attribute<Application1, string, ApplicationData1>[] {
                new(nameof(Application.Name), data => data.Name, (data, value) => data.Name = value),
                new(nameof(Application.ExternalId), data => data.ExternalId, (data, value) => data.ExternalId = value),
                new(nameof(Application.ApplicationKey),
                    data => data.ApplicationKey, (data, value) => data.ApplicationKey = value)
            }) {

        api = new ApplicationsApi(Settings.Connections[0]);
    }

    protected override List<Application1> List(
        string filters = default, string orders = default, int currentPage = default, int pageSize = DefaultPageSize) =>
        api.ListApplications(filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    protected override Application1 Get(string id, string name = "Id") => api.GetApplication(id, name);
    protected override Application1 Create(ApplicationData1 data) => api.CreateApplication(data);

    protected override Application1 Update(string id, ApplicationData1 data, string name = "Id") =>
        api.UpdateApplication(id, data, name);

    protected override Application1 Upsert(ApplicationData1 data) => api.UpsertApplication(data);
    protected override Application1 Delete(string id, string name = "Id") => api.DeleteApplication(id, name);

    [Fact] public void Test_Application_List_ById() => Test_List_ById();
    [Fact] public void Test_Application_List_ByUniqueAttributes() => Test_List_ByUniqueAttributes();
    [Fact] public void Test_Application_List_Paging() => Test_List_Paging();
    [Fact] public void Test_Application_List_OrderAscending() => Test_List_OrderAscending();
    [Fact] public void Test_Application_List_OrderDecending() => Test_List_OrderDecending();

    [Fact]
    public void Test_Application_List_ReadOnly_TestApp() {
        var existing = List(filters: Id.CreateFilters(
            Application1_TestData.ReadOnlyApplication,
            Application1_TestData.TestAppApplication));
        Assert.Empty(existing);
    }

    [Fact] public void Test_Application_Get_ById() => Test_Get_ById();
    [Fact] public void Test_Application_Get_ByUniqueAttributes() => Test_Get_ByUniqueAttributes();

    [Fact]
    public void Test_Application_Get_ReadOnly_TestApp() {
        Assert.ThrowsAny<Exception>(() => Get(Application1_TestData.ReadOnlyApplication));
        Assert.ThrowsAny<Exception>(() => Get(Application1_TestData.TestAppApplication));
    }

    [Fact] public void Test_Application_Create() => Test_Create();
    [Fact] public void Test_Application_Create_WithUniqueAttributes() => Test_Create_WithUniqueAttributes();

    [Fact] public void Test_Application_Update() => Test_Update_ById();
    [Fact] public void Test_Application_Update_ByUniqueAttributes() => Test_Update_ByUniqueAttributes();

    [Fact]
    public void Test_Application_Update_ReadOnly_TestApp_System() {
        foreach(var i in new[] {
            Application1_TestData.ReadOnlyApplication,
            Application1_TestData.TestAppApplication,
            Application1_TestData.SystemApplication
        })
            Assert.ThrowsAny<Exception>(() => Update(i, TestData.GenerateRequestData().First()));
    }

    [Fact] public void Test_Application_Upsert() => Test_Upsert();

    [Fact] public void Test_Application_Delete_ById() => Test_Delete_ById();
    [Fact] public void Test_Application_Delete_ByUniqueAttributes() => Test_Delete_ByUniqueAttributes();

    [Fact]
    public void Test_Application_Delete_ReadOnly_TestApp_System() {
        foreach(var i in new[] {
            Application1_TestData.ReadOnlyApplication,
            Application1_TestData.TestAppApplication,
            Application1_TestData.SystemApplication
        })
            Assert.ThrowsAny<Exception>(() => Delete(i));
    }
}
