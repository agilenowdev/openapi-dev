using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Api;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.ApiOrganizations.Test.Api;
using Xunit;
using Xunit.Abstractions;

namespace Agile.Now.AccessHub.Test.ApiTestsWithHelper {
    public class DepartmentsApiTests {
        readonly ApiTest test;

        public DepartmentsApiTests(ITestOutputHelper testOutputHelper) {
            var api = new DepartmentsApi(Settings.Connections[0]);
            test = new(
                entity: new EntityTest<
                    Department, string,
                    DepartmentInsertData, DepartmentUpdateData, DepartmentData>(

                    id: new("Id", entity => entity.Id, (entity, id) => entity.Id = id),
                    updatedId: entity => entity.Id,
                    uniqueAttributes: new Attribute<Department, string, DepartmentInsertData>[] {
                        new("ExternalId", data => data.ExternalId, (data, value) => data.ExternalId = value),
                        new("Name", data => data.Name, (data, value) => data.Name = value),
                    },
                    methods: new(
                        create: data => api.CreateDepartment(data),
                        delete: (id, name) => api.DeleteDepartment(id, name),
                        get: (id, name) => api.GetDepartment(id, name),
                        update: (id, data, name) => api.UpdateDepartment(id, data, name),
                        upsert: data => api.UpsertDepartment(data)),
                    testData: new(
                        getCreateData: () => DepartmentTestData.CreateDepartmentData(),
                        getUpdateData: data => data.ToDepartmentUpdateData(),
                        getUpsertData: data => data.ToDepartmentData(),
                        update: data => data.Update(),
                        assertEqual: (data, entity) => data.AssertEqual(entity))));
        }

        [Fact]
        public void Test_Department_Create() => test.Entity.Test_Create();

        [Fact]
        public void Test_Department_Create_WithUniqueAttributes() => test.Entity.Test_Create_WithUniqueAttributes();

        [Fact]
        public void Test_Department_Delete_ById() => test.Entity.Test_Delete_ById();

        [Fact]
        public void Test_Department_Delete_ByUniqueAttributes() => test.Entity.Test_Delete_ByUniqueAttributes();

        [Fact]
        public void Test_Department_Update() => test.Entity.Test_Update_ById();

        [Fact]
        public void Test_Department_Update_ByUniqueAttributes() => test.Entity.Test_Update_ByUniqueAttributes();

        [Fact]
        public void Test_Department_Upsert() => test.Entity.Test_Upsert();

        [Fact]
        public void Test_Department_Get_ById() => test.Entity.Test_Get_ById();

        [Fact]
        public void Test_Department_Get_ByUniqueAttributes() => test.Entity.Test_Get_ByUniqueAttributes();
    }
}
