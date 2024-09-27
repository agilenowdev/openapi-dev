using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.AccessHub.Test.Data;
using Agile.Now.Api.Test;
using Agile.Now.ApiOrganizations.Test.Api;
using Xunit;
using Xunit.Abstractions;

namespace Agile.Now.AccessHub.Test.ApiTestsWithHelper {
    public class LocationsApiTests {
        readonly EntityTests<Location, string, LocationInsertData> location;
        readonly SubEntityTests<string, User, int, UserData1> location_User;

        public LocationsApiTests(ITestOutputHelper testOutputHelper) {
            var api = new LocationsApi(Settings.Connections[0]);
            location = new(
                id: new(nameof(Location.Id), entity => entity.Id, (entity, id) => entity.Id = id),
                testData: new(
                    generateInsertData: () => LocationTestData.CreateLocationDatas(),
                    assertEqual: (data, entity) => data.AssertEqual(entity),
                    update: data => data.Update()),
                uniqueAttributes: new Attribute<Location, string, LocationInsertData>[] {
                    new(nameof(Location.ExternalId), data => data.ExternalId, (data, value) => data.ExternalId = value),
                    new(nameof(Location.Name), data => data.Name, (data, value) => data.Name = value),
                },
                list: (filters, currentPage, pageSize) =>
                    api.ListLocations(filters: filters, currentPage: currentPage, pageSize: pageSize).Data,
                get: (id, name) => api.GetLocation(id, name),
                create: data => api.CreateLocation(data),
                update: (id, data, name) => api.UpdateLocation(id, LocationTestData.ToLocationUpdateData(data), name),
                upsert: data => api.UpsertLocation(LocationTestData.ToLocationData(data)),
                delete: (id, name) => api.DeleteLocation(id, name));

            location_User = new(location,
                id: new(nameof(User1.Id), entity => entity.Id, (entity, id) => entity.Id = id.ToString()),
                testData: new(
                    generateInsertData: () => UserTestData.CreateUserData1s(),
                    assertEqual: (expected, actual) => { }),
                list: (id) => api.ListLocationUsers(id).Data,
                upsert: (id, data) => api.UpsertLocationUser(id, data),
                delete: (id, subId) => api.DeleteLocationUser(id, subId.ToString(), subName: "UserId"));
        }

        [Fact] public void Test_Location_List_ById() => location.Test_List_ById();
        [Fact] public void Test_Location_List_ByUniqueAttributes() => location.Test_List_ByUniqueAttributes();
        [Fact] public void Test_Location_List_Paging() => location.Test_List_Paging();
        [Fact] public void Test_Location_Get_ById() => location.Test_Get_ById();
        [Fact] public void Test_Location_Get_ByUniqueAttributes() => location.Test_Get_ByUniqueAttributes();
        [Fact] public void Test_Location_Create() => location.Test_Create();
        [Fact] public void Test_Location_Create_WithUniqueAttributes() => location.Test_Create_WithUniqueAttributes();
        [Fact] public void Test_Location_Update() => location.Test_Update_ById();
        [Fact] public void Test_Location_Update_WithUniqueAttributes() => location.Test_Update_WithUniqueAttributes();
        [Fact] public void Test_Location_Update_ByUniqueAttributes() => location.Test_Update_ByUniqueAttributes();
        [Fact] public void Test_Location_Upsert() => location.Test_Upsert();
        [Fact] public void Test_Location_Delete_ById() => location.Test_Delete_ById();
        [Fact] public void Test_Location_Delete_ByUniqueAttributes() => location.Test_Delete_ByUniqueAttributes();

        [Fact] public void Test_Location_User_List_ById() => location_User.Test_List_ById();
        [Fact] public void Test_Location_User_Upsert() => location_User.Test_Upsert();
        [Fact] public void Test_Location_User_Delete() => location_User.Test_Delete_ById();
    }
}
