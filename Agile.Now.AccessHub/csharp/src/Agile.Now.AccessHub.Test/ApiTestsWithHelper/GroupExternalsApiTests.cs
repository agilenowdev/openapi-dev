using System.Collections.Generic;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.Api.Test;
using Agile.Now.ApiAccessGroups.Test.Api;
using Agile.Now.ApiOrganizations.Test.Api;
using Xunit;
using Xunit.Abstractions;

namespace Agile.Now.AccessHub.Test.ApiTestsWithHelper;

class GroupExternalTests : EntityTests<GroupExternal, int, GroupExternalData> {
    readonly GroupExternalsApi api;

    public GroupExternalTests(GroupExternalsApi api)
        : base(
            testData: new GroupExternalTestData2(),
            id: new(nameof(GroupExternal.Id), entity => entity.Id, (entity, id) => entity.Id = id),
            uniqueAttributes: new Attribute<GroupExternal, string, GroupExternalData>[] {
                //new(nameof(GroupExternal.ExternalId), data => data.ExternalId, (data, value) => data.ExternalId = value),
                new(nameof(GroupExternal.Name), data => data.Name, (data, value) => data.Name = value),
            }) {

        this.api = api;
    }

    protected override List<GroupExternal> List(string filters, string orders, int currentPage, int pageSize) =>
        api.ListGroupExternals(filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    protected override GroupExternal Get(string id, string name) => api.GetGroupExternal(id, name);
    protected override GroupExternal Create(GroupExternalData data) => api.CreateGroupExternal(data);

    protected override GroupExternal Update(string id, GroupExternalData data, string name) =>
        api.UpdateGroupExternal(id, data, name);

    protected override GroupExternal Upsert(GroupExternalData data) =>
        api.UpsertGroupExternal(data);

    protected override GroupExternal Delete(string id, string name) => api.DeleteGroupExternal(id, name);
}

class GroupExternalUserExternalTests : SubEntityTests<int, UserExternal, int, UserExternalData> {
    readonly GroupExternalsApi api;

    public GroupExternalUserExternalTests(GroupExternalsApi api, EntityTestsBase<int> parent)
        : base(parent,
            id: new(nameof(UserExternal.Id), entity => entity.Id, null),
            testData: new GroupExternalUserExternalTestData()) {

        this.api = api;
    }

    protected override List<UserExternal> List(int id) => api.ListGroupExternalUserExternals(id.ToString()).Data;
    protected override UserExternal Upsert(int id, UserExternalData data) => api.UpsertGroupExternalUserExternal(id.ToString(), data);
    protected override void Delete(int id, int subId) => api.DeleteGroupExternalUserExternal(id.ToString(), subId.ToString(), subName: "UserExternalId");
}

public class GroupExternalsApiTests {
    readonly GroupExternalTests groupExternal;
    readonly GroupExternalUserExternalTests groupExternal_UserExternal;

    public GroupExternalsApiTests(ITestOutputHelper testOutputHelper) {
        var api = new GroupExternalsApi(Settings.Connections[0]);
        groupExternal = new GroupExternalTests(api);
        groupExternal_UserExternal = new GroupExternalUserExternalTests(api, groupExternal);
    }

    [Fact] public void Test_GroupExternal_List_ById() => groupExternal.Test_List_ById();
    [Fact] public void Test_GroupExternal_List_ByUniqueAttributes() => groupExternal.Test_List_ByUniqueAttributes();
    [Fact] public void Test_GroupExternal_List_Paging() => groupExternal.Test_List_Paging();
    [Fact] public void Test_GroupExternal_List_OrderAscending() => groupExternal.Test_List_OrderAscending();
    [Fact] public void Test_GroupExternal_List_OrderDecending() => groupExternal.Test_List_OrderDecending();

    [Fact] public void Test_GroupExternal_Get_ById() => groupExternal.Test_Get_ById();
    [Fact] public void Test_GroupExternal_Get_ByUniqueAttributes() => groupExternal.Test_Get_ByUniqueAttributes();

    [Fact] public void Test_GroupExternal_Create() => groupExternal.Test_Create();
    [Fact] public void Test_GroupExternal_Create_WithUniqueAttributes() => groupExternal.Test_Create_WithUniqueAttributes();
    [Fact] public void Test_GroupExternal_Update() => groupExternal.Test_Update_ById();
    [Fact] public void Test_GroupExternal_Update_ByUniqueAttributes() => groupExternal.Test_Update_ByUniqueAttributes();
    [Fact] public void Test_GroupExternal_Upsert() => groupExternal.Test_Upsert();
    [Fact] public void Test_GroupExternal_Delete_ById() => groupExternal.Test_Delete_ById();
    [Fact] public void Test_GroupExternal_Delete_ByUniqueAttributes() => groupExternal.Test_Delete_ByUniqueAttributes();

    [Fact] public void Test_AccessGroup_User_List_ById() => groupExternal_UserExternal.Test_List_ById();
    [Fact] public void Test_AccessGroup_User_Upsert() => groupExternal_UserExternal.Test_Upsert();
    [Fact] public void Test_AccessGroup_User_Delete_ById() => groupExternal_UserExternal.Test_Delete_ById();
}
