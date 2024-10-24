﻿using System.Collections.Generic;
using System.Linq;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.AccessHub.Test.Data;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.AccessHub.Test.Api;

public class Location_User_Tests : SubEntityTests<Location, string, LocationInsertData, User, int, UserData> {
    readonly LocationsApi api;

    public Location_User_Tests()
        : base(new Location_Tests(),
            testData: new User_TestData(),
            id: new(nameof(User.Id), entity => entity.Id),
            uniqueAttributes: new Attribute<User, string, UserData>[] {
                new(nameof(User.ExternalId), data => data.ExternalId),
                new(nameof(User.Username), data => data.Name) }) {

        api = new LocationsApi(Settings.Connections[0]);
    }

    protected override List<User> List(
        string id, string name, string filters, string orders, int currentPage, int pageSize) =>

        api.ListLocationUsers(
            id: id, name: name, filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    protected override User Upsert(string id, UserData data) => api.UpsertLocationUser(id, data);

    protected override User[] Patch(string id, List<UserData> data, string deleteNotExists) =>
        api.PatchLocationUsers(id: id,
            usersData1: new UsersData1(users: data.Select(i => i.ToUserText1()).ToList()),
            deleteNotExists: deleteNotExists).Data.ToArray();

    protected override User Delete(string id, string subId, string name, string subName) =>
        api.DeleteLocationUser(id, subId, name: name, subName: subName);

    [Fact] public void Test_Location_User_List_ById() => Test_List_ById();
    //[Fact] public void Test_Location_User_List_ByUniqueAttributes() => Test_List_ByUniqueAttributes();
    [Fact] public void Test_Location_User_List_Paging() => Test_List_Paging();
    [Fact] public void Test_Location_User_List_OrderAscending() => Test_List_OrderAscending();
    [Fact] public void Test_Location_User_List_OrderDecending() => Test_List_OrderDecending();

    [Fact] public void Test_Location_User_Upsert() => Test_Upsert();

    [Fact] public void Test_Location_User_Patch() => Test_Patch();
    //[Fact] public void Test_Location_User_Patch_DeleteNotExists() => Test_Patch_DeleteNotExists();

    [Fact] public void Test_Location_User_Delete_ById() => Test_Delete_ById();
    //[Fact] public void Test_Location_User_Delete_ByUniqueAttributes() => Test_Delete_ByUniqueAttributes();
}
