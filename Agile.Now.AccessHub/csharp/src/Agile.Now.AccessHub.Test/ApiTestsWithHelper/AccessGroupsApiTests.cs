using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.AccessHub.Test.Data;
using Agile.Now.Api.Test;
using Agile.Now.ApiAccessGroups.Test.Api;
using Agile.Now.ApiOrganizations.Test.Api;
using Xunit;
using Xunit.Abstractions;

namespace Agile.Now.AccessHub.Test.ApiTestsWithHelper {
    public class AccessGroupsApiTests {
        readonly EntityTests<AccessGroup, string, AccessGroupData> accessGroup;
        readonly SubEntityTests<string, Application, string, ApplicationData> accessGroup_Application;
        readonly SubEntityTests<string, Permission, long, PermissionData> accessGroup_Permission;
        readonly SubEntityTests<string, Group, long, GroupData> accessGroup_Group;
        readonly SubEntityTests<string, User, long, UserData> accessGroup_User;

        public AccessGroupsApiTests(ITestOutputHelper testOutputHelper) {
            var api = new AccessGroupsApi(Settings.Connections[0]);
            accessGroup = new(
                id: new(nameof(AccessGroup.Id), entity => entity.Id, (entity, id) => entity.Id = id),
                testData: new(
                    generateInsertData: () => AccessGroupTestData.CreateAccessGroupDatas(),
                    assertEqual: (data, entity) => data.AssertEqual(entity),
                    update: data => data.Update()),
                uniqueAttributes: new Attribute<AccessGroup, string, AccessGroupData>[] {
                    //new(nameof(AccessGroup.ExternalId), data => data.ExternalId, (data, value) => data.ExternalId = value),
                    new(nameof(AccessGroup.Name), data => data.Name, (data, value) => data.Name = value),
                },
                list: (filters, currentPage, pageSize) =>
                    api.ListAccessGroups(filters: filters, currentPage: currentPage, pageSize: pageSize).Data,
                get: (id, name) => api.GetAccessGroup(id, name),
                create: data => api.CreateAccessGroup(data),
                update: (id, data, name) => api.UpdateAccessGroup(id, data, name),
                upsert: data => api.UpsertAccessGroup(data),
                delete: (id, name) => api.DeleteAccessGroup(id, name));

            accessGroup_Application = new(accessGroup,
                id: new(nameof(Application.Id), entity => entity.Id, (entity, id) => entity.Id = id),
                testData: new(
                    generateInsertData: () => AccessGroupTestData.CreateApplicationDatas(),
                    assertEqual: (expected, actual) => { }),
                list: (id) => api.ListAccessGroupApplications(id).Data,
                upsert: (id, data) => api.UpsertAccessGroupApplication(id, data),
                delete: (id, subId) => api.DeleteAccessGroupApplication(id, subId.ToString(), subName: "AccessApplicationId"));

            accessGroup_Permission = new(accessGroup,
                id: new(nameof(Permission.Id), entity => entity.Id, (entity, id) => entity.Id = id),
                testData: new(
                    generateInsertData: () => AccessGroupTestData.CreatePermissionDatas(),
                    assertEqual: (expected, actual) => { }),
                list: (id) => api.ListAccessGroupPermissions(id).Data,
                upsert: (id, data) => api.UpsertAccessGroupPermission(id, data),
                delete: (id, subId) => api.DeleteAccessGroupPermission(id, subId.ToString()));

            accessGroup_Group = new(accessGroup,
                id: new(nameof(Group.Id), entity => entity.Id, (entity, id) => entity.Id = id),
                testData: new(
                    generateInsertData: () => UserTestData.CreateGroupDatas(),
                    assertEqual: (expected, actual) => { }),
                list: (id) => api.ListAccessGroupGroups(id).Data,
                upsert: (id, data) => api.UpsertAccessGroupGroup(id, data),
                delete: (id, subId) => api.DeleteAccessGroupGroup(id, subId.ToString(), subName: "GroupId"));

            accessGroup_User = new(accessGroup,
                id: new(nameof(User.Id), entity => entity.Id, (entity, id) => entity.Id = id),
                testData: new(
                    generateInsertData: () => UserTestData.CreateUserDatas(),
                    assertEqual: (expected, actual) => { }),
                list: (id) => api.ListAccessGroupUsers(id).Data,
                upsert: (id, data) => api.UpsertAccessGroupUser(id, data),
                delete: (id, subId) => api.DeleteAccessGroupUser(id, subId.ToString(), subName: "UserId"));
        }

        [Fact] public void Test_AccessGroup_List_ById() => accessGroup.Test_List_ById();
        [Fact] public void Test_AccessGroup_List_ByUniqueAttributes() => accessGroup.Test_List_ByUniqueAttributes();
        [Fact] public void Test_AccessGroup_List_Paging() => accessGroup.Test_List_Paging();
        [Fact] public void Test_AccessGroup_Get_ById() => accessGroup.Test_Get_ById();
        [Fact] public void Test_AccessGroup_Get_ByUniqueAttributes() => accessGroup.Test_Get_ByUniqueAttributes();
        [Fact] public void Test_AccessGroup_Create() => accessGroup.Test_Create();
        [Fact] public void Test_AccessGroup_Create_WithUniqueAttributes() => accessGroup.Test_Create_WithUniqueAttributes();
        [Fact] public void Test_AccessGroup_Update() => accessGroup.Test_Update_ById();
        [Fact] public void Test_AccessGroup_Update_WithUniqueAttributes() => accessGroup.Test_Update_WithUniqueAttributes();
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
}
