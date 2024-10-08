using System.Collections.Generic;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.Api.Test;
using Agile.Now.ApiOrganizations.Test.Api;
using Xunit;
using Xunit.Abstractions;

namespace Agile.Now.AccessHub.Test.ApiTestsWithHelper;

class DepartmentTests : EntityTests<Department, string, DepartmentInsertData> {
    readonly DepartmentsApi api;

    public DepartmentTests(DepartmentsApi api)
        : base(
            testData: new DepartmentTestData2(),
            id: new(nameof(Department.Id), entity => entity.Id, (entity, id) => entity.Id = id),
            uniqueAttributes: new Attribute<Department, string, DepartmentInsertData>[] {
                new(nameof(Department.ExternalId), data => data.ExternalId, (data, value) => data.ExternalId = value),
                new(nameof(Department.Name), data => data.Name, (data, value) => data.Name = value),
            }) {

        this.api = api;
    }

    protected override List<Department> List(string filters, string orders, int currentPage, int pageSize) =>
        api.ListDepartments(filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    protected override Department Get(string id, string name) => api.GetDepartment(id, name);
    protected override Department Create(DepartmentInsertData data) => api.CreateDepartment(data);

    protected override Department Update(string id, DepartmentInsertData data, string name) =>
        api.UpdateDepartment(id, DepartmentTestData.ToDepartmentUpdateData(data), name);

    protected override Department Upsert(DepartmentInsertData data) =>
        api.UpsertDepartment(DepartmentTestData.ToDepartmentData(data));

    protected override Department Delete(string id, string name) => api.DeleteDepartment(id, name);
}

class DepartmentUserTests : SubEntityTests<string, User, int, UserData> {
    readonly DepartmentsApi api;

    public DepartmentUserTests(DepartmentsApi api, EntityTestsBase<string> parent)
        : base(parent,
            id: new(nameof(User.Id), entity => entity.Id, null),
            testData: new DepartmentUserTestData()) {

        this.api = api;
    }

    protected override List<User> List(string id) => api.ListDepartmentUsers(id).Data;
    protected override User Upsert(string id, UserData data) => api.UpsertDepartmentUser(id, data);
    protected override void Delete(string id, int subId) => api.DeleteDepartmentUser(id, subId.ToString(), subName: "UserId");
}

public class DepartmentsApiTests {
    readonly DepartmentTests department;
    readonly DepartmentUserTests department_User;

    public DepartmentsApiTests(ITestOutputHelper testOutputHelper) {
        var api = new DepartmentsApi(Settings.Connections[0]);
        department = new DepartmentTests(api);
        department_User = new DepartmentUserTests(api, department);
    }

    [Fact] public void Test_Department_List_ById() => department.Test_List_ById();
    [Fact] public void Test_Department_List_ByUniqueAttributes() => department.Test_List_ByUniqueAttributes();
    [Fact] public void Test_Department_List_Paging() => department.Test_List_Paging();
    [Fact] public void Test_Department_List_OrderAscending() => department.Test_List_OrderAscending();
    [Fact] public void Test_Department_List_OrderDecending() => department.Test_List_OrderDecending();

    [Fact] public void Test_Department_Get_ById() => department.Test_Get_ById();
    [Fact] public void Test_Department_Get_ByUniqueAttributes() => department.Test_Get_ByUniqueAttributes();

    [Fact] public void Test_Department_Create() => department.Test_Create();
    [Fact] public void Test_Department_Create_WithUniqueAttributes() => department.Test_Create_WithUniqueAttributes();
    [Fact] public void Test_Department_Update() => department.Test_Update_ById();
    [Fact] public void Test_Department_Update_ByUniqueAttributes() => department.Test_Update_ByUniqueAttributes();
    [Fact] public void Test_Department_Upsert() => department.Test_Upsert();
    [Fact] public void Test_Department_Delete_ById() => department.Test_Delete_ById();
    [Fact] public void Test_Department_Delete_ByUniqueAttributes() => department.Test_Delete_ByUniqueAttributes();

    [Fact] public void Test_Department_User_List_ById() => department_User.Test_List_ById();
    [Fact] public void Test_Department_User_Upsert() => department_User.Test_Upsert();
    [Fact] public void Test_Department_User_Delete() => department_User.Test_Delete_ById();
}
