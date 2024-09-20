using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Api;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.ApiAccessGroups.Test.Api;
using Agile.Now.ApiOrganizations.Test.Api;
using Xunit;
using Xunit.Abstractions;

namespace Agile.Now.AccessHub.Test.ApiTestsWithHelper {
    public class GroupExternalsApiTests {
        readonly ApiTest test;

        public GroupExternalsApiTests(ITestOutputHelper testOutputHelper) {
            var api = new GroupExternalsApi(Settings.Connections[0]);
            test = new(
                entity: new EntityTest<
                    GroupExternal, string,
                    GroupExternalData, GroupExternalData, GroupExternalData>(

                    id: new("Id", entity => entity.Id.ToString(), (entity, id) => entity.Id = int.Parse(id)),
                    updatedId: entity => entity.Id.ToString(),
                    uniqueAttributes: new Attribute<GroupExternal, string, GroupExternalData>[] {
                        //new("ExternalId", data => data.ExternalId, (data, value) => data.ExternalId = value),
                        new("Name", data => data.Name, (data, value) => data.Name = value),
                    },
                    methods: new(
                        create: data => api.CreateGroupExternal(data),
                        delete: (id, name) => api.DeleteGroupExternal(id, name),
                        get: (id, name) => api.GetGroupExternal(id, name),
                        update: (id, data, name) => api.UpdateGroupExternal(id, data, name),
                        upsert: data => api.UpsertGroupExternal(data)),
                    testData: new(
                        getCreateData: () => GroupExternalTestData.CreateGroupExternalData(),
                        getUpdateData: data => data,
                        getUpsertData: data => data,
                        update: data => data.Update(),
                        assertEqual: (data, entity) => data.AssertEqual(entity))));
        }

        [Fact]
        public void Test_GroupExternals_Create() => test.Entity.Test_Create();

        [Fact]
        public void Test_GroupExternals_Create_WithUniqueAttributes() => test.Entity.Test_Create_WithUniqueAttributes();

        [Fact]
        public void Test_GroupExternals_Delete_ById() => test.Entity.Test_Delete_ById();

        [Fact]
        public void Test_GroupExternals_Delete_ByUniqueAttributes() => test.Entity.Test_Delete_ByUniqueAttributes();

        [Fact]
        public void Test_GroupExternals_Update() => test.Entity.Test_Update_ById();

        [Fact]
        public void Test_GroupExternals_Update_ByUniqueAttributes() => test.Entity.Test_Update_ByUniqueAttributes();

        [Fact]
        public void Test_GroupExternals_Upsert() => test.Entity.Test_Upsert();

        [Fact]
        public void Test_GroupExternals_Get_ById() => test.Entity.Test_Get_ById();

        [Fact]
        public void Test_GroupExternals_Get_ByUniqueAttributes() => test.Entity.Test_Get_ByUniqueAttributes();
    }
}
