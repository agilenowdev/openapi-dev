using System.Collections.Generic;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.AccessHub.Test.Data;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.AccessHub.Test.Api;

public class Department_Tests : EntityTests<Department, string, DepartmentInsertData> {
    readonly DepartmentsApi api;

    public Department_Tests()
        : base(
            testData: new Department_TestData(),
            id: new(nameof(Department.Id), entity => entity.Id, (entity, id) => entity.Id = id),
            uniqueAttributes: new Attribute<Department, string, DepartmentInsertData>[] {
                new(nameof(Department.ExternalId), data => data.ExternalId, (data, value) => data.ExternalId = value),
                new(nameof(Department.Name), data => data.Name, (data, value) => data.Name = value)
            }) {

        api = new DepartmentsApi(Settings.Connections[0]);
    }

    protected override List<Department> List(string filters, string orders, int currentPage, int pageSize) =>
        api.ListDepartments(filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    protected override Department Get(string id, string name) => api.GetDepartment(id, name);
    protected override Department Create(DepartmentInsertData data) => api.CreateDepartment(data);

    protected override Department Update(string id, DepartmentInsertData data, string name) =>
        api.UpdateDepartment(id, data.ToDepartmentUpdateData(), name);

    protected override Department Upsert(DepartmentInsertData data) =>
        api.UpsertDepartment(data.ToDepartmentData());

    protected override Department Delete(string id, string name) => api.DeleteDepartment(id, name);

    [Fact] public void Test_Department_List_ById() => Test_List_ById();
    [Fact] public void Test_Department_List_ByUniqueAttributes() => Test_List_ByUniqueAttributes();
    [Fact] public void Test_Department_List_Paging() => Test_List_Paging();
    [Fact] public void Test_Department_List_OrderAscending() => Test_List_OrderAscending();
    [Fact] public void Test_Department_List_OrderDecending() => Test_List_OrderDecending();

    [Fact] public void Test_Department_Get_ById() => Test_Get_ById();
    [Fact] public void Test_Department_Get_ByUniqueAttributes() => Test_Get_ByUniqueAttributes();

    [Fact] public void Test_Department_Create() => Test_Create();
    [Fact] public void Test_Department_Create_WithUniqueAttributes() => Test_Create_WithUniqueAttributes();

    [Fact] public void Test_Department_Update() => Test_Update_ById();
    [Fact] public void Test_Department_Update_ByUniqueAttributes() => Test_Update_ByUniqueAttributes();

    [Fact] public void Test_Department_Upsert() => Test_Upsert();

    [Fact] public void Test_Department_Delete_ById() => Test_Delete_ById();
    [Fact] public void Test_Department_Delete_ByUniqueAttributes() => Test_Delete_ByUniqueAttributes();
}
