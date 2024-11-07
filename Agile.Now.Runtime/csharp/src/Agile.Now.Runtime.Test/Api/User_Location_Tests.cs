using System.Collections.Generic;
using System.Linq;
using Agile.Now.Api.Test;
using Agile.Now.Runtime.Api;
using Agile.Now.Runtime.Model;
using Agile.Now.Runtime.Test.Data;
using Xunit;

namespace Agile.Now.Runtime.Test.Api;

public class User_Location_Tests : SubEntityTests<User, User, Location, LocationData> {
    readonly UsersApi api;

    public User_Location_Tests()
        : base(new User_Tests(),
            testData: new Location_TestData(),
            id: new(nameof(Location.Id), entity => entity.Id),
            uniqueAttributes: new Attribute<Location, LocationData>[] {
                new(nameof(Location.ExternalId), data => data.ExternalId),
                new(nameof(Location.Name), data => data.Name) }) {

        api = new UsersApi(Settings.Connections[0]);
    }

    protected override List<Location> List(Context<User, User> context, 
        string filters, string orders, int currentPage, int pageSize) =>

        api.ListUserLocations(id: context.ParentId, name: context.Parent.Id.Name,
            filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    protected override Location Upsert(Context<User, User> context, LocationData data) =>
        api.UpsertUserLocation(context.ParentId, data);

    protected override Location[] Patch(string id, List<LocationData> data, string deleteNotExists) =>
        api.PatchUserLocations(id: id,
            locationsData: new LocationsData(locations: data.Select(i => i.ToLocationData()).ToList()),
            deleteNotExists: deleteNotExists).Data.ToArray();

    protected override Location Delete(Context<User, User> context, string id, string name) =>
        api.DeleteUserLocation(context.ParentId, id, context.Parent.Id.Name, name);

    [Fact] public void Test_User_Location_List_ById() => Test_List_ById();
    //[Fact] public void Test_User_Location_List_ByUniqueAttributes() => Test_List_ByUniqueAttributes();
    [Fact] public void Test_User_Location_List_Paging() => Test_List_Paging();
    [Fact] public void Test_User_Location_List_OrderAscending() => Test_List_OrderAscending();
    [Fact] public void Test_User_Location_List_OrderDecending() => Test_List_OrderDecending();

    [Fact] public void Test_User_Location_Upsert() => Test_Upsert();

    [Fact] public void Test_User_Location_Patch() => Test_Patch();
    [Fact] public void Test_User_Location_Patch_DeleteNotExists() => Test_Patch_DeleteNotExists();

    [Fact] public void Test_User_Location_Delete_ById() => Test_Delete_ById();
    //[Fact] public void Test_User_Location_Delete_ByUniqueAttributes() => Test_Delete_ByUniqueAttributes();
}
