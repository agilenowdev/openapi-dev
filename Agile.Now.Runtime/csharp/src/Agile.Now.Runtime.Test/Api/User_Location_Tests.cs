using System.Collections.Generic;
using System.Linq;
using Agile.Now.Api.Test;
using Agile.Now.Runtime.Api;
using Agile.Now.Runtime.Model;
using Agile.Now.Runtime.Test.Data;
using Xunit;

namespace Agile.Now.Runtime.Test.Api;

public class User_Location_Tests : SubEntityTests<User, int, object, Location, string, LocationData>
{
    readonly UsersApi api;

    public User_Location_Tests()
        : base(new User_Tests(),
            testData: new User_Location_TestData(),
            id: new(nameof(Location.Id), entity => entity.Id, null),
            uniqueAttributes: new Attribute<Location, string, LocationData>[] {
                new(nameof(Location.ExternalId), data => data.ExternalId, null),
                new(nameof(Location.Name), data => data.Name, null) })
    {

        api = new UsersApi(Settings.Connections[0]);
    }

    protected override List<Location> List(
        string id, string name, string filters, string orders, int currentPage, int pageSize) =>

        api.ListUserLocations(
            id: id, name: name, filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    protected override Location Upsert(int id, LocationData data) => api.UpsertUserLocation(id.ToString(), data);

    protected override Location[] Patch(int id, List<LocationData> data, string deleteNotExists) =>
        api.PatchUserLocations(id: id.ToString(),
            locationsData: new LocationsData(locations: data.Select(i => i.ToLocationPatchData()).ToList()),
            deleteNotExists: deleteNotExists).Data.ToArray();

    protected override Location Delete(string id, string subId, string name, string subName) =>
        api.DeleteUserLocation(id, subId, name: name, subName: subName);

    [Fact] public void Test_User_Location_List_ById() => Test_List_ById();
    [Fact] public void Test_User_Location_List_ByUniqueAttributes() => Test_List_ByUniqueAttributes();
    [Fact] public void Test_User_Location_List_Paging() => Test_List_Paging();
    [Fact] public void Test_User_Location_List_OrderAscending() => Test_List_OrderAscending();
    [Fact] public void Test_User_Location_List_OrderDecending() => Test_List_OrderDecending();

    [Fact] public void Test_User_Location_Upsert() => Test_Upsert();

    [Fact] public void Test_User_Location_Patch() => Test_Patch();
    [Fact] public void Test_User_Location_Patch_DeleteNotExists() => Test_Patch_DeleteNotExists();

    [Fact] public void Test_User_Location_Delete_ById() => Test_Delete_ById();
    [Fact] public void Test_User_Location_Delete_ByUniqueAttributes() => Test_Delete_ByUniqueAttributes();
}
