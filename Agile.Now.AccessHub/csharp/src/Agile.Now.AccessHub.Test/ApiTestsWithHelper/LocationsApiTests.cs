using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.AccessHub.Test.Data;
using Agile.Now.ApiOrganizations.Test.Api;
using Xunit;
using Xunit.Abstractions;

namespace Agile.Now.AccessHub.Test.ApiTestsWithHelper {
    public class LocationsApiTests {
        readonly EntityTestsBase<string> locationTests;
        readonly SubEntityTests<string, User1, int, UserData1, UserData1, UserData1> locationUsersTests;

        public LocationsApiTests(ITestOutputHelper testOutputHelper) {
            var api = new LocationsApi(Settings.Connections[0]);
            locationTests = new EntityTests<
                Location, string,
                LocationInsertData, LocationUpdateData, LocationData>(

                id: new("Id", entity => entity.Id, (entity, id) => entity.Id = id),
                testData: new(
                    getInsertData: () => LocationTestData.CreateLocationData(),
                    toUpdateData: data => data.ToLocationUpdateData(),
                    toUpsertData: data => data.ToLocationData(),
                    assertEqual: (data, entity) => data.AssertEqual(entity),
                    update: data => data.Update()),
                uniqueAttributes: new Attribute<Location, string, LocationInsertData>[] {
                    new("ExternalId", data => data.ExternalId, (data, value) => data.ExternalId = value),
                    new("Name", data => data.Name, (data, value) => data.Name = value),
                },
                create: data => api.CreateLocation(data),
                delete: (id, name) => api.DeleteLocation(id, name),
                get: (id, name) => api.GetLocation(id, name),
                update: (id, data, name) => api.UpdateLocation(id, data, name),
                upsert: data => api.UpsertLocation(data));

            locationUsersTests = new(locationTests,
                id: new("Id", entity => entity.Id, (entity, id) => entity.Id = id.ToString()),
                testData: new(
                    getInsertData: () => UserTestData.CreateUserData1(UserTestData.Users[0]),
                    toUpdateData: data => data,
                    toUpsertData: data => data),
                delete: (id, subId) => api.DeleteLocationUser(id, subId.ToString(), subName: "UserId"),
                list: (id) => api.ListLocationUsers(id).Data,
                upsert: (id, data) => api.UpsertLocationUser(id, data));
        }

        [Fact]
        public void Test_Location_Create() => locationTests.Test_Create();

        [Fact]
        public void Test_Location_Create_WithUniqueAttributes() => locationTests.Test_Create_WithUniqueAttributes();

        [Fact]
        public void Test_Location_Delete_ById() => locationTests.Test_Delete_ById();

        [Fact]
        public void Test_Location_Delete_ByUniqueAttributes() => locationTests.Test_Delete_ByUniqueAttributes();

        [Fact]
        public void Test_Location_Update() => locationTests.Test_Update_ById();

        [Fact]
        public void Test_Location_Update_ByUniqueAttributes() => locationTests.Test_Update_ByUniqueAttributes();

        [Fact]
        public void Test_Location_Upsert() => locationTests.Test_Upsert();

        [Fact]
        public void Test_Location_Get_ById() => locationTests.Test_Get_ById();

        [Fact]
        public void Test_Location_Get_ByUniqueAttributes() => locationTests.Test_Get_ByUniqueAttributes();

        [Fact]
        public void Test_Location_User_Delete() => locationUsersTests.Test_Delete();
    }
}
