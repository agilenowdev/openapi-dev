using System.Collections.Generic;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.AccessHub.Test.Data;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.AccessHub.Test.Api;

public class Location_Tests : EntityTests<Location, LocationInsertData> {
    readonly LocationsApi api;

    public Location_Tests()
        : base(
            testData: new Location_TestData(),
            id: new(nameof(Location.Id), entity => entity.Id, (entity, id) => entity.Id = id),
            uniqueAttributes: new Attribute<Location, LocationInsertData>[] {
                new(nameof(Location.ExternalId), data => data.ExternalId, (data, value) => data.ExternalId = value),
                new(nameof(Location.Name), data => data.Name, (data, value) => data.Name = value)
            }) {

        api = new LocationsApi(Settings.Connections[0]);
    }

    protected override List<Location> List(Context<Location, LocationInsertData> context,
        string filters, string orders, int currentPage, int pageSize) =>

        api.ListLocations(filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    protected override Location Get(Context<Location, LocationInsertData> context, string id, string name) =>
        api.GetLocation(id, name);

    protected override Location Create(Context<Location, LocationInsertData> context, LocationInsertData data) =>
        api.CreateLocation(data);

    protected override Location Update(Context<Location, LocationInsertData> context,
        string id, LocationInsertData data, string name) =>

        api.UpdateLocation(id, data.ToLocationUpdateData(), name);

    protected override Location Upsert(Context<Location, LocationInsertData> context, LocationInsertData data) =>
        api.UpsertLocation(data.ToLocationData());

    protected override Location Delete(Context<Location, LocationInsertData> context, string id, string name) =>
        api.DeleteLocation(id, name);

    [Fact] public void Test_Location_List_ById() => Test_List_ById();
    [Fact] public void Test_Location_List_ByUniqueAttributes() => Test_List_ByUniqueAttributes();
    [Fact] public void Test_Location_List_Paging() => Test_List_Paging();
    [Fact] public void Test_Location_List_OrderAscending() => Test_List_OrderAscending();
    [Fact] public void Test_Location_List_OrderDecending() => Test_List_OrderDecending();

    [Fact] public void Test_Location_Get_ById() => Test_Get_ById();
    [Fact] public void Test_Location_Get_ByUniqueAttributes() => Test_Get_ByUniqueAttributes();

    [Fact] public void Test_Location_Create() => Test_Create();
    [Fact] public void Test_Location_Create_WithUniqueAttributes() => Test_Create_WithUniqueAttributes();

    [Fact] public void Test_Location_Update() => Test_Update_ById();
    [Fact] public void Test_Location_Update_ByUniqueAttributes() => Test_Update_ByUniqueAttributes();

    [Fact] public void Test_Location_Upsert() => Test_Upsert();

    [Fact] public void Test_Location_Delete_ById() => Test_Delete_ById();
    [Fact] public void Test_Location_Delete_ByUniqueAttributes() => Test_Delete_ByUniqueAttributes();
}
