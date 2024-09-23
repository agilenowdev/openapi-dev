using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.ApiAccessGroups.Test.Api;
using Agile.Now.ApiOrganizations.Test.Api;
using Xunit;
using Xunit.Abstractions;

namespace Agile.Now.AccessHub.Test.ApiTestsWithHelper {
    public class AccessGroupsApiTests {
        readonly EntityTestsBase<string> accessGroupsTests;

        public AccessGroupsApiTests(ITestOutputHelper testOutputHelper) {
            var api = new AccessGroupsApi(Settings.Connections[0]);
            accessGroupsTests = new EntityTests<AccessGroup, string,
                AccessGroupData, AccessGroupData, AccessGroupData>(

                id: new("Id", entity => entity.Id, (entity, id) => entity.Id = id),
                testData: new(
                    getInsertData: () => AccessGroupTestData.CreateAccessGroupData(),
                    toUpdateData: data => data,
                    toUpsertData: data => data, 
                    assertEqual: (data, entity) => data.AssertEqual(entity),
                    update: data => data.Update()),
                uniqueAttributes: new Attribute<AccessGroup, string, AccessGroupData>[] {
                    new("ExternalId", data => data.ExternalId, (data, value) => data.ExternalId = value),
                    new("Name", data => data.Name, (data, value) => data.Name = value),
                },
                create: data => api.CreateAccessGroup(data),
                delete: (id, name) => api.DeleteAccessGroup(id, name),
                get: (id, name) => api.GetAccessGroup(id, name),
                update: (id, data, name) => api.UpdateAccessGroup(id, data, name),
                upsert: data => api.UpsertAccessGroup(data));
        }

        [Fact]
        public void Test_AccessGroups_Create() => accessGroupsTests.Test_Create();

        [Fact]
        public void Test_AccessGroups_Create_WithUniqueAttributes() => accessGroupsTests.Test_Create_WithUniqueAttributes();

        [Fact]
        public void Test_AccessGroups_Delete_ById() => accessGroupsTests.Test_Delete_ById();

        [Fact]
        public void Test_AccessGroups_Delete_ByUniqueAttributes() => accessGroupsTests.Test_Delete_ByUniqueAttributes();

        [Fact]
        public void Test_AccessGroups_Update() => accessGroupsTests.Test_Update_ById();

        [Fact]
        public void Test_AccessGroups_Update_ByUniqueAttributes() => accessGroupsTests.Test_Update_ByUniqueAttributes();

        [Fact]
        public void Test_AccessGroups_Upsert() => accessGroupsTests.Test_Upsert();

        [Fact]
        public void Test_AccessGroups_Get_ById() => accessGroupsTests.Test_Get_ById();

        [Fact]
        public void Test_AccessGroups_Get_ByUniqueAttributes() => accessGroupsTests.Test_Get_ByUniqueAttributes();
    }
}
