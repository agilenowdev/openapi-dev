using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.ApiOrganizations.Test.Api;
using Xunit;
using Xunit.Abstractions;

namespace Agile.Now.AccessHub.Test.Api {
    public class LocationsApiTests_WithHelper {
        readonly ApiTest test;

        public LocationsApiTests_WithHelper(ITestOutputHelper testOutputHelper) {
            var api = new LocationsApi(Settings.Connections[0]);
            test = new(
                entity: new EntityTest<
                    Location, string,
                    LocationInsertData, LocationUpdateData, LocationData>(

                    id: new("Id", entity => entity.Id, (entity, id) => entity.Id = id),
                    updatedId: entity => entity.Id,
                    uniqueAttributes: new Attribute<Location, string, LocationInsertData>[] {
                        new(
                            "ExternalId",
                            data => data.ExternalId, (data, value) => data.ExternalId = value),
                        new(
                            "Name",
                            data => data.Name, (data, value) => data.Name = value),
                    },
                    methods: new(
                        create: data => api.CreateLocation(data),
                        delete: (id, name) => api.DeleteLocation(id, name),
                        get: (id, name) => api.GetLocation(id, name),
                        update: (id, data, name) => api.UpdateLocation(id, data, name),
                        upsert: data => api.UpsertLocation(data)),
                    testData: new(
                        getCreateData: () => LocationTestData.CreateLocationData(),
                        getUpdateData: data => LocationTestData.ToLocationUpdateData(data),
                        getUpsertData: data => LocationTestData.ToLocationData(data),
                        update: data => LocationTestData.Update(data),
                        assertEqual: (data, entity) => LocationTestData.AssertEqual(data, entity))));
        }

        [Fact]
        public void Test_Location_Create() => test.Entity.Test_Create();

        [Fact]
        public void Test_Location_Create_WithUniqueAttributes() => test.Entity.Test_Create_WithUniqueAttributes();

        [Fact]
        public void Test_Location_Delete_ById() => test.Entity.Test_Delete_ById();

        [Fact]
        public void Test_Location_Delete_ByUniqueAttributes() => test.Entity.Test_Delete_ByUniqueAttributes();

        [Fact]
        public void Test_Location_Update() => test.Entity.Test_Update_ById();

        [Fact]
        public void Test_Location_Update_ByUniqueAttributes() => test.Entity.Test_Update_ByUniqueAttributes();

        [Fact]
        public void Test_Location_Upsert() => test.Entity.Test_Upsert();

        [Fact]
        public void Test_Location_Get_ById() => test.Entity.Test_Get_ById();

        [Fact]
        public void Test_Location_Get_ByUniqueAttributes() => test.Entity.Test_Get_ByUniqueAttributes();
    }
}
