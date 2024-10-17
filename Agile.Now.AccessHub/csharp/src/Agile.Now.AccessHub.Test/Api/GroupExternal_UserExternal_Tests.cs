using System.Collections.Generic;
using System.Linq;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.AccessHub.Test.Data;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.AccessHub.Test.Api;

public class GroupExternal_User_Tests
    : SubEntityTests<GroupExternal, int, GroupExternalData, UserExternal, int, UserExternalData> {

    readonly GroupExternalsApi api;

    public GroupExternal_User_Tests()
        : base(
            parent: new GroupExternal_Tests(),
            testData: new UserExternal_TestData(),
            id: new(nameof(User.Id), entity => entity.Id)) {

        api = new GroupExternalsApi(Settings.Connections[0]);
    }

    protected override string EntityName => "User_";

    protected override List<UserExternal> List(
        string id, string name, string filters, string orders, int currentPage, int pageSize) =>

        api.ListGroupExternalUserExternals(
            id: id, name: name, filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    protected override UserExternal Upsert(int id, UserExternalData data) =>
        api.UpsertGroupExternalUserExternal(id.ToString(), data);

    protected override UserExternal[] Patch(int id, List<UserExternalData> data, string deleteNotExists) =>
        api.PatchGroupExternalUserExternals(id: id.ToString(),
            userExternalsData: new(userExternals: data.Select(i => i.ToUserExternalText()).ToList()),
            deleteNotExists: deleteNotExists).Data.ToArray();

    protected override UserExternal Delete(string id, string subId, string name, string subName) =>
        api.DeleteGroupExternalUserExternal(id, subId, subName: subName);

    [Fact] public void Test_GroupExternal_User_List_ById() => Test_List_ById();
    //[Fact] public void Test_GroupExternal_User_List_ByUniqueAttributes() => Test_List_ByUniqueAttributes();
    [Fact] public void Test_GroupExternal_User_List_Paging() => Test_List_Paging();
    [Fact] public void Test_GroupExternal_User_List_OrderAscending() => Test_List_OrderAscending();
    [Fact] public void Test_GroupExternal_User_List_OrderDecending() => Test_List_OrderDecending();

    [Fact] public void Test_GroupExternal_User_Upsert() => Test_Upsert();

    [Fact] public void Test_GroupExternal_User_Patch() => Test_Patch();
    //[Fact] public void Test_GroupExternal_User_Patch_DeleteNotExists() => Test_Patch_DeleteNotExists();

    [Fact] public void Test_GroupExternal_User_Delete_ById() => Test_Delete_ById();
    //[Fact] public void Test_GroupExternal_User_Delete_ByUniqueAttributes() => Test_Delete_ByUniqueAttributes();
}
