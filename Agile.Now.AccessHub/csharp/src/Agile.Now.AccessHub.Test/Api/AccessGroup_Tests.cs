using System;
using System.Collections.Generic;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.AccessHub.Test.Data;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.AccessHub.Test.Api;

public class AccessGroup_Tests : EntityTests<AccessGroup, AccessGroupInsertData> {
    readonly AccessGroupsApi api;

    public AccessGroup_Tests()
        : base(
            testData: new AccessGroup_TestData(),
            id: new(nameof(AccessGroup.Id), entity => entity.Id, (entity, id) => entity.Id = id),
            uniqueAttributes: new Attribute<AccessGroup, AccessGroupInsertData>[] {
                new(nameof(AccessGroup.ExternalId), data => data.ExternalId, (data, value) => data.ExternalId = value),
                new(nameof(AccessGroup.Name), data => data.Name, (data, value) => data.Name = value),
            }) {

        api = new AccessGroupsApi(Settings.Connections[0]);
    }

    protected override List<AccessGroup> List(Context<AccessGroup, AccessGroupInsertData> context,
        string filters, string orders, int currentPage, int pageSize) =>

        api.ListAccessGroups(filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    protected override AccessGroup Get(Context<AccessGroup, AccessGroupInsertData> context, string id, string name) =>
        api.GetAccessGroup(id, name);

    protected override AccessGroup Create(Context<AccessGroup, AccessGroupInsertData> context, AccessGroupInsertData data) =>
        api.CreateAccessGroup(data);

    protected override AccessGroup Update(Context<AccessGroup, AccessGroupInsertData> context, 
        string id, AccessGroupInsertData data, string name) =>

        api.UpdateAccessGroup(id, data.ToAccessGroupUpdateData(), name);

    protected override AccessGroup Upsert(Context<AccessGroup, AccessGroupInsertData> context, AccessGroupInsertData data) =>
        api.UpsertAccessGroup(data.ToAccessGroupData());

    protected override AccessGroup Delete(Context<AccessGroup, AccessGroupInsertData> context, string id, string name) =>
        api.DeleteAccessGroup(id, name);

    [Fact] public void Test_AccessGroup_List_ById() => Test_List_ById();
    [Fact] public void Test_AccessGroup_List_ByUniqueAttributes() => Test_List_ByUniqueAttributes();
    [Fact] public void Test_AccessGroup_List_Paging() => Test_List_Paging();
    [Fact] public void Test_AccessGroup_List_OrderAscending() => Test_List_OrderAscending();
    [Fact] public void Test_AccessGroup_List_OrderDecending() => Test_List_OrderDecending();

    [Fact] public void Test_AccessGroup_Get_ById() => Test_Get_ById();
    [Fact] public void Test_AccessGroup_Get_ByUniqueAttributes() => Test_Get_ByUniqueAttributes();

    [Fact] public void Test_AccessGroup_Create() => Test_Create();
    [Fact] public void Test_AccessGroup_Create_WithUniqueAttributes() => Test_Create_WithUniqueAttributes();

    [Fact] public void Test_AccessGroup_Update() => Test_Update_ById();
    [Fact] public void Test_AccessGroup_Update_ByUniqueAttributes() => Test_Update_ByUniqueAttributes();

    [Fact] public void Test_AccessGroup_Upsert() => Test_Upsert();

    [Fact] public void Test_AccessGroup_Delete_ById() => Test_Delete_ById();
    [Fact] public void Test_AccessGroup_Delete_ByUniqueAttributes() => Test_Delete_ByUniqueAttributes();

    [Fact]
    public void Test_AccessGroup_Delete_IsSystem() {
        using var context = CreateContext();
        Assert.ThrowsAny<Exception>(() => Delete(context, AccessGroup_TestData.SystemAccessGroup));
    }
}
