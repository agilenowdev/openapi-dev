using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.ApiOrganizations.Test.Api;
using Xunit;
using Xunit.Abstractions;

namespace Agile.Now.AccessHub.Test.ApiTestsWithHelper {
    public class DepartmentsApiTests {
        readonly EntityTestsBase<string> departmentsTests;

        public DepartmentsApiTests(ITestOutputHelper testOutputHelper) {
            var api = new DepartmentsApi(Settings.Connections[0]);
            departmentsTests = new EntityTests<
                Department, string,
                DepartmentInsertData, DepartmentUpdateData, DepartmentData>(

                id: new("Id", entity => entity.Id, (entity, id) => entity.Id = id),
                testData: new(
                    getInsertData: () => DepartmentTestData.CreateDepartmentData(),
                    toUpdateData: data => data.ToDepartmentUpdateData(),
                    toUpsertData: data => data.ToDepartmentData(),
                    assertEqual: (data, entity) => data.AssertEqual(entity),
                    update: data => data.Update()),
                uniqueAttributes: new Attribute<Department, string, DepartmentInsertData>[] {
                    new("ExternalId", data => data.ExternalId, (data, value) => data.ExternalId = value),
                    new("Name", data => data.Name, (data, value) => data.Name = value),
                },
                create: data => api.CreateDepartment(data),
                delete: (id, name) => api.DeleteDepartment(id, name),
                get: (id, name) => api.GetDepartment(id, name),
                update: (id, data, name) => api.UpdateDepartment(id, data, name),
                upsert: data => api.UpsertDepartment(data));
        }

        [Fact]
        public void Test_Department_Create() => departmentsTests.Test_Create();

        [Fact]
        public void Test_Department_Create_WithUniqueAttributes() => departmentsTests.Test_Create_WithUniqueAttributes();

        [Fact]
        public void Test_Department_Delete_ById() => departmentsTests.Test_Delete_ById();

        [Fact]
        public void Test_Department_Delete_ByUniqueAttributes() => departmentsTests.Test_Delete_ByUniqueAttributes();

        [Fact]
        public void Test_Department_Update() => departmentsTests.Test_Update_ById();

        [Fact]
        public void Test_Department_Update_ByUniqueAttributes() => departmentsTests.Test_Update_ByUniqueAttributes();

        [Fact]
        public void Test_Department_Upsert() => departmentsTests.Test_Upsert();

        [Fact]
        public void Test_Department_Get_ById() => departmentsTests.Test_Get_ById();

        [Fact]
        public void Test_Department_Get_ByUniqueAttributes() => departmentsTests.Test_Get_ByUniqueAttributes();
    }
}
