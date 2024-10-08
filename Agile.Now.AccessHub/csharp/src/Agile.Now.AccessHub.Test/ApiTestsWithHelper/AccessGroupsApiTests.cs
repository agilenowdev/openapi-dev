using System.Collections.Generic;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.Api.Test;
using Agile.Now.ApiAccessGroups.Test.Api;
using Xunit;
using Xunit.Abstractions;

namespace Agile.Now.AccessHub.Test.ApiTestsWithHelper;

class AccessGroupTests : EntityTests<AccessGroup, string, AccessGroupData> {
    readonly AccessGroupsApi api;

    public AccessGroupTests(AccessGroupsApi api)
        : base(
            testData: new AccessGroupTestData2(),
            id: new(nameof(AccessGroup.Id), entity => entity.Id, (entity, id) => entity.Id = id),
            uniqueAttributes: new Attribute<AccessGroup, string, AccessGroupData>[] {
                new(nameof(AccessGroup.ExternalId), data => data.ExternalId, (data, value) => data.ExternalId = value),
                new(nameof(AccessGroup.Name), data => data.Name, (data, value) => data.Name = value),
            }) {

        this.api = api;
    }

    protected override List<AccessGroup> List(string filters, string orders, int currentPage, int pageSize) =>
        api.ListAccessGroups(filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    protected override AccessGroup Get(string id, string name) => api.GetAccessGroup(id, name);
    protected override AccessGroup Create(AccessGroupData data) => api.CreateAccessGroup(data);
    protected override AccessGroup Update(string id, AccessGroupData data, string name) => api.UpdateAccessGroup(id, data, name);
    protected override AccessGroup Upsert(AccessGroupData data) => api.UpsertAccessGroup(data);
    protected override AccessGroup Delete(string id, string name) => api.DeleteAccessGroup(id, name);
}

class AccessGroupApplicationTests : SubEntityTests<string, Application, string, ApplicationData> {
    readonly AccessGroupsApi api;

    public AccessGroupApplicationTests(AccessGroupsApi api, EntityTestsBase<string> parent)
        : base(parent,
            id: new(nameof(Application.Id), entity => entity.Id, null),
            testData: new AccessGroupApplicationTestData()) {

        this.api = api;
    }

    protected override List<Application> List(string id) => api.ListAccessGroupApplications(id).Data;
    protected override Application Upsert(string id, ApplicationData data) => api.UpsertAccessGroupApplication(id, data);
    protected override void Delete(string id, string subId) =>
        api.DeleteAccessGroupApplication(id, subId.ToString(), subName: "ApplicationId");
}

class AccessGroupPermissionTests : SubEntityTests<string, Permission, long, PermissionData> {
    readonly AccessGroupsApi api;

    public AccessGroupPermissionTests(AccessGroupsApi api, EntityTestsBase<string> parent)
        : base(parent,
            id: new(nameof(Permission.Id), entity => entity.Id, null),
            testData: new AccessGroupPermissionTestData()) {

        this.api = api;
    }

    protected override List<Permission> List(string id) => api.ListAccessGroupPermissions(id).Data;
    protected override Permission Upsert(string id, PermissionData data) => api.UpsertAccessGroupPermission(id, data);
    protected override void Delete(string id, long subId) =>
        api.DeleteAccessGroupPermission(id, subId.ToString(), subName: "PermissionId");
}

class AccessGroupGroupTests : SubEntityTests<string, Group, long, GroupData> {
    readonly AccessGroupsApi api;

    public AccessGroupGroupTests(AccessGroupsApi api, EntityTestsBase<string> parent)
        : base(parent,
            id: new(nameof(Group.Id), entity => entity.Id, null),
            testData: new AccessGroupGroupTestData()) {

        this.api = api;
    }

    protected override List<Group> List(string id) => api.ListAccessGroupGroups(id).Data;
    protected override Group Upsert(string id, GroupData data) => api.UpsertAccessGroupGroup(id, data);
    protected override void Delete(string id, long subId) =>
        api.DeleteAccessGroupGroup(id, subId.ToString(), subName: "GroupId");
}

class AccessGroupUserTests : SubEntityTests<string, User, long, UserData> {
    readonly AccessGroupsApi api;

    public AccessGroupUserTests(AccessGroupsApi api, EntityTestsBase<string> parent)
        : base(parent,
            id: new(nameof(User.Id), entity => entity.Id, null),
            testData: new AccessGroupUserTestData()) {

        this.api = api;
    }

    protected override List<User> List(string id) => api.ListAccessGroupUsers(id).Data;
    protected override User Upsert(string id, UserData data) => api.UpsertAccessGroupUser(id, data);
    protected override void Delete(string id, long subId) =>
        api.DeleteAccessGroupUser(id, subId.ToString(), subName: "UserId");
}

public class AccessGroupsApiTests {
    readonly AccessGroupTests accessGroup;
    readonly AccessGroupApplicationTests accessGroup_Application;
    readonly AccessGroupPermissionTests accessGroup_Permission;
    readonly AccessGroupGroupTests accessGroup_Group;
    readonly AccessGroupUserTests accessGroup_User;

    public AccessGroupsApiTests(ITestOutputHelper testOutputHelper) {
        var api = new AccessGroupsApi(Settings.Connections[0]);
        accessGroup = new AccessGroupTests(api);
        accessGroup_Application = new AccessGroupApplicationTests(api, accessGroup);
        accessGroup_Permission = new AccessGroupPermissionTests(api, accessGroup);
        accessGroup_Group = new AccessGroupGroupTests(api, accessGroup);
        accessGroup_User = new AccessGroupUserTests(api, accessGroup);
    }

    [Fact] public void Test_AccessGroup_List_ById() => accessGroup.Test_List_ById();
    [Fact] public void Test_AccessGroup_List_ByUniqueAttributes() => accessGroup.Test_List_ByUniqueAttributes();
    [Fact] public void Test_AccessGroup_List_Paging() => accessGroup.Test_List_Paging();
    [Fact] public void Test_AccessGroup_List_OrderAscending() => accessGroup.Test_List_OrderAscending();
    [Fact] public void Test_AccessGroup_List_OrderDecending() => accessGroup.Test_List_OrderDecending();

    [Fact] public void Test_AccessGroup_Get_ById() => accessGroup.Test_Get_ById();
    [Fact] public void Test_AccessGroup_Get_ByUniqueAttributes() => accessGroup.Test_Get_ByUniqueAttributes();

    [Fact] public void Test_AccessGroup_Create() => accessGroup.Test_Create();
    [Fact] public void Test_AccessGroup_Create_WithUniqueAttributes() => accessGroup.Test_Create_WithUniqueAttributes();
    [Fact] public void Test_AccessGroup_Update() => accessGroup.Test_Update_ById();
    [Fact] public void Test_AccessGroup_Update_ByUniqueAttributes() => accessGroup.Test_Update_ByUniqueAttributes();
    [Fact] public void Test_AccessGroup_Upsert() => accessGroup.Test_Upsert();
    [Fact] public void Test_AccessGroup_Delete_ById() => accessGroup.Test_Delete_ById();
    [Fact] public void Test_AccessGroup_Delete_ByUniqueAttributes() => accessGroup.Test_Delete_ByUniqueAttributes();

    [Fact] public void Test_AccessGroup_Application_List_ById() => accessGroup_Application.Test_List_ById();
    [Fact] public void Test_AccessGroup_Application_Upsert() => accessGroup_Application.Test_Upsert();
    [Fact] public void Test_AccessGroup_Application_Delete_ById() => accessGroup_Application.Test_Delete_ById();

    [Fact] public void Test_AccessGroup_Permission_List_ById() => accessGroup_Permission.Test_List_ById();
    [Fact] public void Test_AccessGroup_Permission_Upsert() => accessGroup_Permission.Test_Upsert();
    [Fact] public void Test_AccessGroup_Permission_Delete_ById() => accessGroup_Permission.Test_Delete_ById();

    [Fact] public void Test_AccessGroup_Group_List_ById() => accessGroup_Group.Test_List_ById();
    [Fact] public void Test_AccessGroup_Group_Upsert() => accessGroup_Group.Test_Upsert();
    [Fact] public void Test_AccessGroup_Group_Delete_ById() => accessGroup_Group.Test_Delete_ById();

    [Fact] public void Test_AccessGroup_User_List_ById() => accessGroup_User.Test_List_ById();
    [Fact] public void Test_AccessGroup_User_Upsert() => accessGroup_User.Test_Upsert();
    [Fact] public void Test_AccessGroup_User_Delete_ById() => accessGroup_User.Test_Delete_ById();
}
