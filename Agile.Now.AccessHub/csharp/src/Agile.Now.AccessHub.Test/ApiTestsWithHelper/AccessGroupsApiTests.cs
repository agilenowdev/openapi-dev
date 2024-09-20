using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Api;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.ApiAccessGroups.Test.Api;
using Agile.Now.ApiOrganizations.Test.Api;
using Xunit;
using Xunit.Abstractions;

namespace Agile.Now.AccessHub.Test.ApiTestsWithHelper {
    public class AccessGroupsApiTests {
        readonly ApiTest test;

        public AccessGroupsApiTests(ITestOutputHelper testOutputHelper) {
            var api = new AccessGroupsApi(Settings.Connections[0]);
            test = new(
                entity: new EntityTest<
                    AccessGroup, string,
                    AccessGroupData, AccessGroupData, AccessGroupData>(

                    id: new("Id", entity => entity.Id, (entity, id) => entity.Id = id),
                    updatedId: entity => entity.Id,
                    uniqueAttributes: new Attribute<AccessGroup, string, AccessGroupData>[] {
                        new("ExternalId", data => data.ExternalId, (data, value) => data.ExternalId = value),
                        new("Name", data => data.Name, (data, value) => data.Name = value),
                    },
                    methods: new(
                        create: data => api.CreateAccessGroup(data),
                        delete: (id, name) => api.DeleteAccessGroup(id, name),
                        get: (id, name) => api.GetAccessGroup(id, name),
                        update: (id, data, name) => api.UpdateAccessGroup(id, data, name),
                        upsert: data => api.UpsertAccessGroup(data)),
                    testData: new(
                        getCreateData: () => AccessGroupTestData.CreateAccessGroupData(),
                        getUpdateData: data => data,
                        getUpsertData: data => data,
                        update: data => data.Update(),
                        assertEqual: (data, entity) => data.AssertEqual(entity))));
        }

        [Fact]
        public void Test_AccessGroups_Create() => test.Entity.Test_Create();

        [Fact]
        public void Test_AccessGroups_Create_WithUniqueAttributes() => test.Entity.Test_Create_WithUniqueAttributes();

        [Fact]
        public void Test_AccessGroups_Delete_ById() => test.Entity.Test_Delete_ById();

        [Fact]
        public void Test_AccessGroups_Delete_ByUniqueAttributes() => test.Entity.Test_Delete_ByUniqueAttributes();

        [Fact]
        public void Test_AccessGroups_Update() => test.Entity.Test_Update_ById();

        [Fact]
        public void Test_AccessGroups_Update_ByUniqueAttributes() => test.Entity.Test_Update_ByUniqueAttributes();

        [Fact]
        public void Test_AccessGroups_Upsert() => test.Entity.Test_Upsert();

        [Fact]
        public void Test_AccessGroups_Get_ById() => test.Entity.Test_Get_ById();

        [Fact]
        public void Test_AccessGroups_Get_ByUniqueAttributes() => test.Entity.Test_Get_ByUniqueAttributes();
    }
}
