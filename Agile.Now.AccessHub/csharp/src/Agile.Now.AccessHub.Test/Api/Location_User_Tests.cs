using System.Collections.Generic;
using System.Linq;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.AccessHub.Test.Data;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.AccessHub.Test.Api;

public class Location_User_Tests : SubEntityTests<Location, LocationInsertData, User, UserData> {
    readonly LocationsApi api;

    public Location_User_Tests()
        : base(new Location_Tests(),
            testData: new User_TestData(),
            id: new(nameof(User.Id), entity => entity.Id.ToString(), isString: false),
            uniqueAttributes: new Attribute<User, UserData>[] {
                new(nameof(User.ExternalId), data => data.ExternalId),
                new(nameof(User.Username), data => data.Name) }) {

        api = new LocationsApi(Settings.Connections[0]);
    }

    protected override List<User> List(Context<Location, LocationInsertData> context, 
        string filters, string orders, int currentPage, int pageSize) =>

        api.ListLocationUsers(id: context.ParentId, name: context.Parent.Id.Name,
            filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    protected override User Upsert(Context<Location, LocationInsertData> context, UserData data) =>
        api.UpsertLocationUser(context.ParentId, data);

    protected override User[] Patch(Context<Location, LocationInsertData> context, 
        UserData[] data, string deleteNotExists)  =>

        api.PatchLocationUsers(context.ParentId,
            usersData1: new UsersData1(users: data.Select(i => i.ToUserText1()).ToList()),
            deleteNotExists: deleteNotExists).Data.ToArray();

    protected override User Delete(Context<Location, LocationInsertData> context, string id, string name) =>
        api.DeleteLocationUser(context.ParentId, id, context.Parent.Id.Name, name);

    [Fact] public void Test_Location_User_List_ById() => Test_List_ById();
    //[Fact] public void Test_Location_User_List_ByUniqueAttributes() => Test_List_ByUniqueAttributes();
    [Fact] public void Test_Location_User_List_Paging() => Test_List_Paging();
    [Fact] public void Test_Location_User_List_OrderAscending() => Test_List_OrderAscending();
    [Fact] public void Test_Location_User_List_OrderDecending() => Test_List_OrderDecending();

    [Fact] public void Test_Location_User_Upsert() => Test_Upsert();

    [Fact] public void Test_Location_User_Patch() => Test_Patch();
    [Fact] public void Test_Location_User_Patch_DeleteNotExists() => Test_Patch_DeleteNotExists();

    [Fact] public void Test_Location_User_Delete_ById() => Test_Delete_ById();
    //[Fact] public void Test_Location_User_Delete_ByUniqueAttributes() => Test_Delete_ByUniqueAttributes();
}
