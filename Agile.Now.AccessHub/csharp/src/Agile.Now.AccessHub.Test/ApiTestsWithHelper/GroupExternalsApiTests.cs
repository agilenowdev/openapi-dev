using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.ApiAccessGroups.Test.Api;
using Agile.Now.ApiOrganizations.Test.Api;
using Xunit;
using Xunit.Abstractions;

namespace Agile.Now.AccessHub.Test.ApiTestsWithHelper {
    public class GroupExternalsApiTests {
        readonly EntityTestsBase<int> groupExternalsTests;

        public GroupExternalsApiTests(ITestOutputHelper testOutputHelper) {
            var api = new GroupExternalsApi(Settings.Connections[0]);
            groupExternalsTests = new EntityTests<
                GroupExternal, int,
                GroupExternalData, GroupExternalData, GroupExternalData>(

                id: new("Id", entity => entity.Id, (entity, id) => entity.Id = id),
                testData: new(
                    getInsertData: () => GroupExternalTestData.CreateGroupExternalData(),
                    toUpdateData: data => data,
                    toUpsertData: data => data,
                    assertEqual: (data, entity) => data.AssertEqual(entity),
                    update: data => data.Update()),
                uniqueAttributes: new Attribute<GroupExternal, string, GroupExternalData>[] {
                    //new("ExternalId", data => data.ExternalId, (data, value) => data.ExternalId = value),
                    new("Name", data => data.Name, (data, value) => data.Name = value),
                },
                create: data => api.CreateGroupExternal(data),
                delete: (id, name) => api.DeleteGroupExternal(id.ToString(), name),
                get: (id, name) => api.GetGroupExternal(id.ToString(), name),
                update: (id, data, name) => api.UpdateGroupExternal(id.ToString(), data, name),
                upsert: data => api.UpsertGroupExternal(data));
        }

        [Fact]
        public void Test_GroupExternals_Create() => groupExternalsTests.Test_Create();

        [Fact]
        public void Test_GroupExternals_Create_WithUniqueAttributes() => groupExternalsTests.Test_Create_WithUniqueAttributes();

        [Fact]
        public void Test_GroupExternals_Delete_ById() => groupExternalsTests.Test_Delete_ById();

        [Fact]
        public void Test_GroupExternals_Delete_ByUniqueAttributes() => groupExternalsTests.Test_Delete_ByUniqueAttributes();

        [Fact]
        public void Test_GroupExternals_Update() => groupExternalsTests.Test_Update_ById();

        [Fact]
        public void Test_GroupExternals_Update_ByUniqueAttributes() => groupExternalsTests.Test_Update_ByUniqueAttributes();

        [Fact]
        public void Test_GroupExternals_Upsert() => groupExternalsTests.Test_Upsert();

        [Fact]
        public void Test_GroupExternals_Get_ById() => groupExternalsTests.Test_Get_ById();

        [Fact]
        public void Test_GroupExternals_Get_ByUniqueAttributes() => groupExternalsTests.Test_Get_ByUniqueAttributes();
    }
}
