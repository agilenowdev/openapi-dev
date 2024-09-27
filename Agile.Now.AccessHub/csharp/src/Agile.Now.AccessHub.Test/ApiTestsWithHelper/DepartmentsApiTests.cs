using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.AccessHub.Test.Data;
using Agile.Now.Api.Test;
using Agile.Now.ApiOrganizations.Test.Api;
using Xunit;
using Xunit.Abstractions;

namespace Agile.Now.AccessHub.Test.ApiTestsWithHelper {
    public class DepartmentsApiTests {
        readonly EntityTests<Department, string, DepartmentInsertData> department;
        readonly SubEntityTests<string, User, int, UserData1> department_User;

        public DepartmentsApiTests(ITestOutputHelper testOutputHelper) {
            var api = new DepartmentsApi(Settings.Connections[0]);
            department = new(
                id: new(nameof(Department.Id), entity => entity.Id, (entity, id) => entity.Id = id),
                testData: new(
                    generateInsertData: () => DepartmentTestData.CreateDepartmentDatas(),
                    assertEqual: (data, entity) => data.AssertEqual(entity),
                    update: data => data.Update()),
                uniqueAttributes: new Attribute<Department, string, DepartmentInsertData>[] {
                    new(nameof(Department.ExternalId), data => data.ExternalId, (data, value) => data.ExternalId = value),
                    new(nameof(Department.Name), data => data.Name, (data, value) => data.Name = value),
                },
                list: (filters, currentPage, pageSize) =>
                    api.ListDepartments(filters: filters, currentPage: currentPage, pageSize: pageSize).Data,
                get: (id, name) => api.GetDepartment(id, name),
                create: data => api.CreateDepartment(data),
                update: (id, data, name) => api.UpdateDepartment(id, DepartmentTestData.ToDepartmentUpdateData(data), name),
                upsert: data => api.UpsertDepartment(DepartmentTestData.ToDepartmentData(data)),
                delete: (id, name) => api.DeleteDepartment(id, name));

            department_User = new(department,
                id: new(nameof(User.Id), entity => entity.Id, (entity, id) => entity.Id = id.ToString()),
                testData: new(
                    generateInsertData: () => UserTestData.CreateUserData1s(),
                    assertEqual: (expected, actual) => { }),
                list: (id) => api.ListDepartmentUsers(id).Data,
                upsert: (id, data) => api.UpsertDepartmentUser(id, data),
                delete: (id, subId) => api.DeleteDepartmentUser(id, subId.ToString(), subName: "UserId"));
        }

        [Fact] public void Test_Department_List_ById() => department.Test_List_ById();
        [Fact] public void Test_Department_List_ByUniqueAttributes() => department.Test_List_ByUniqueAttributes();
        [Fact] public void Test_Department_List_Paging() => department.Test_List_Paging();
        [Fact] public void Test_Department_Get_ById() => department.Test_Get_ById();
        [Fact] public void Test_Department_Get_ByUniqueAttributes() => department.Test_Get_ByUniqueAttributes();
        [Fact] public void Test_Department_Create() => department.Test_Create();
        [Fact] public void Test_Department_Create_WithUniqueAttributes() => department.Test_Create_WithUniqueAttributes();
        [Fact] public void Test_Department_Update() => department.Test_Update_ById();
        [Fact] public void Test_Department_Update_WithUniqueAttributes() => department.Test_Update_WithUniqueAttributes();
        [Fact] public void Test_Department_Update_ByUniqueAttributes() => department.Test_Update_ByUniqueAttributes();
        [Fact] public void Test_Department_Upsert() => department.Test_Upsert();
        [Fact] public void Test_Department_Delete_ById() => department.Test_Delete_ById();
        [Fact] public void Test_Department_Delete_ByUniqueAttributes() => department.Test_Delete_ByUniqueAttributes();

        [Fact] public void Test_Department_User_List_ById() => department_User.Test_List_ById();
        [Fact] public void Test_Department_User_Upsert() => department_User.Test_Upsert();
        [Fact] public void Test_Department_User_Delete() => department_User.Test_Delete_ById();
    }
}
