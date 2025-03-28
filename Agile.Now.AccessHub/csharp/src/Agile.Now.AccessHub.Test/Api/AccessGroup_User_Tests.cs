﻿using System.Collections.Generic;
using System.Linq;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.AccessHub.Test.Data;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.AccessHub.Test.Api;

public class AccessGroup_User_Tests : SubEntityTests<AccessGroup, AccessGroupInsertData, User, UserData> {
    readonly AccessGroupsApi api;

    public AccessGroup_User_Tests()
        : base(
            parent: new AccessGroup_Tests(),
            testData: new User_TestData(),
            id: new(nameof(User.Id), entity => entity.Id.ToString(), isString: false),
            uniqueAttributes: new Attribute<User, UserData>[] {
                new(nameof(User.Username), data => data.Username)
            }) {

        api = new AccessGroupsApi(Settings.Connections[0]);
    }

    protected override List<User> List(Context<AccessGroup, AccessGroupInsertData> context, 
        string filters, string orders = default, int currentPage = default, int pageSize = DefaultPageSize) =>

        api.ListAccessGroupUsers(id: context.ParentId, name: context.Parent.Id.Name,
            filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    protected override User Upsert(Context<AccessGroup, AccessGroupInsertData> context, UserData data) =>
        api.UpsertAccessGroupUser(context.ParentId, data);

    protected override User[] Patch(Context<AccessGroup, AccessGroupInsertData> context, 
        UserData[] data, string deleteNotExists)  =>

        api.PatchAccessGroupUsers(context.ParentId,
            usersData: new UsersData(users: data.Select(i => i.ToUserText()).ToList()),
            deleteNotExists: deleteNotExists).Data.ToArray();

    protected override User Delete(Context<AccessGroup, AccessGroupInsertData> context, string id, string name) =>
        api.DeleteAccessGroupUser(context.ParentId, id, context.Parent.Id.Name, name);

    [Fact] public void Test_AccessGroup_User_List_ById() => Test_List_ById();
    //[Fact] public void Test_AccessGroup_User_List_ByUniqueAttributes() => Test_List_ByUniqueAttributes();
    [Fact] public void Test_AccessGroup_User_List_Paging() => Test_List_Paging();
    [Fact] public void Test_AccessGroup_User_List_OrderAscending() => Test_List_OrderAscending();
    [Fact] public void Test_AccessGroup_User_List_OrderDecending() => Test_List_OrderDecending();

    [Fact] public void Test_AccessGroup_User_Upsert() => Test_Upsert();

    [Fact] public void Test_AccessGroup_User_Patch() => Test_Patch();
    //[Fact] public void Test_AccessGroup_User_Patch_DeleteNotExists() => Test_Patch_DeleteNotExists();

    [Fact] public void Test_AccessGroup_User_Delete_ById() => Test_Delete_ById();
    //[Fact] public void Test_AccessGroup_User_Delete_ByUniqueAttributes() => Test_Delete_ByUniqueAttributes();
}
