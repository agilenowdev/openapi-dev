using System.Linq;
using Agile.Now.Api.Test;
using Agile.Now.Runtime.Api;
using Agile.Now.Runtime.Model;
using Agile.Now.Runtime.Test.Data;
using Xunit;
using Xunit.Abstractions;

namespace Agile.Runtime.Runtime.ApiTestsWithHelper {
    public class UsersApiTests {
        readonly EntityTests<User, int, User> user;
        readonly SubEntityTests<int, AccessGroup, string, AccessGroupData> user_AccessGroup;
        readonly SubEntityTests<int, Group, int, GroupData> user_Group;
        readonly SubEntityTests<int, Department, string, DepartmentData> user_Department;
        readonly SubEntityTests<int, Location, string, LocationData> user_Location;
        readonly SubEntityTests<int, Application, string, Application> user_Application;
        readonly SubEntityTests<int, AccessRole, string, AccessRole> user_AccessRole;
        readonly SubEntityTests<int, EffectivePermission, string, EffectivePermission> user_EffectivePermission;

        public UsersApiTests(ITestOutputHelper testOutputHelper) {
            var api = new UsersApi(Agile.Now.Runtime.Test.Api.Settings.Connections[0]);
            user = new(
                id: new(nameof(User.Id), entity => entity.Id, (entity, id) => entity.Id = id),
                testData: new(
                    generateInsertData: () => TestUserData.CreateUserDatas(),
                    assertEqualRequestResponse: (expected, actual) => { },
                    assertEqualResponses: (expected, actual) => { }),
                uniqueAttributes: new Attribute<User, string, User>[] {
                    new("External_Id", data => data.ExternalId, (data, value) => data.ExternalId = value),
                    new(nameof(User.Username), data => data.Username, (data, value) => data.Username = value),
                },
                list: (filters, orders, currentPage, pageSize) =>
                    api.ListUsers(filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data,
                get: (id, name) => api.GetUser(id, name),
                create: data => data,
                delete: (id, name) => { });

            user_AccessGroup = new(user,
                id: new(nameof(AccessGroup.Id), entity => entity.Id, null),
                testData: new(
                    generateInsertData: () => TestUserData.CreateAccessGroupDatas(),
                    assertEqualRequestResponse: (expected, actual) => { },
                    assertEqualResponses: (expected, actual) => { }),
                list: (id) => api.ListUserAccessGroups(id.ToString()).Data,
                upsert: (id, data) => api.UpsertUserAccessGroup(id.ToString(), data),
                delete: (id, subId) => api.DeleteUserAccessGroup(id.ToString(), subId.ToString(), subName: "AccessGroupId"));

            user_Group = new(user,
                id: new(nameof(Group.Id), entity => entity.Id, null),
                testData: new(
                    generateInsertData: () => TestUserData.CreateGroupDatas(),
                    assertEqualRequestResponse: (expected, actual) => { },
                    assertEqualResponses: (expected, actual) => { }),
                list: (id) => api.ListUserGroups(id.ToString()).Data,
                upsert: (id, data) => api.UpsertUserGroup(id.ToString(), data),
                delete: (id, subId) => api.DeleteUserGroup(id.ToString(), subId.ToString(), subName: "Group_Id"));

            user_Department = new(user,
                id: new(nameof(Department.Id), entity => entity.Id, null),
                testData: new(
                    generateInsertData: () => TestUserData.CreateDepartmentDatas(),
                    assertEqualRequestResponse: (expected, actual) => { },
                    assertEqualResponses: (expected, actual) => { }),
                list: (id) => api.ListUserDepartments(id.ToString()).Data,
                upsert: (id, data) => api.UpsertUserDepartment(id.ToString(), data),
                patch: (id, data) => api.PatchUserDepartments(id.ToString(),
                    new(departments: data.Select(i => TestUserData.ToDepartmentPatchData(i)).ToList())).Data,
                delete: (id, subId) => api.DeleteUserDepartment(id.ToString(), subId.ToString(), subName: "DepartmentId"));

            user_Location = new(user,
                id: new(nameof(Location.Id), entity => entity.Id, null),
                testData: new(
                    generateInsertData: () => TestUserData.CreateLocationDatas(),
                    assertEqualRequestResponse: (expected, actual) => { },
                    assertEqualResponses: (expected, actual) => { }),
                list: (id) => api.ListUserLocations(id.ToString()).Data,
                upsert: (id, data) => api.UpsertUserLocation(id.ToString(), data),
                patch: (id, data) => api.PatchUserLocations(id.ToString(),
                    new(locations: data.Select(i => TestUserData.ToLocationPatchData(i)).ToList())).Data,
                delete: (id, subId) => api.DeleteUserLocation(id.ToString(), subId.ToString(), subName: "LocationId"));

            user_Application = new(user,
                id: new(nameof(Application.Id), entity => entity.Id, null),
                testData: new(
                    generateInsertData: null,
                    assertEqualRequestResponse: (expected, actual) => { },
                    assertEqualResponses: (expected, actual) => { }),
                list: (id) => api.ListUserApplications(id.ToString()).Data);

            user_AccessRole = new(user,
                id: new(nameof(AccessRole.Id), entity => entity.Id, null),
                testData: new(
                    generateInsertData: null,
                    assertEqualRequestResponse: (expected, actual) => { },
                    assertEqualResponses: (expected, actual) => { }),
                list: (id) => api.ListUserAccessRoles(id.ToString()).Data);

            user_EffectivePermission = new(user,
                id: new(nameof(EffectivePermission.Id), entity => entity.Id, null),
                testData: new(
                    generateInsertData: null,
                    assertEqualRequestResponse: (expected, actual) => { },
                    assertEqualResponses: (expected, actual) => { }),
                list: (id) => api.ListUserEffectivePermissions(id.ToString()).Data);
        }

        [Fact] public void Test_User_List_ById() => user.Test_List_ById();
        [Fact] public void Test_User_List_ByUniqueAttributes() => user.Test_List_ByUniqueAttributes();
        [Fact] public void Test_User_List_Paging() => user.Test_List_Paging();
        [Fact] public void Test_User_Get_ById() => user.Test_Get_ById();
        [Fact] public void Test_User_Get_ByUniqueAttributes() => user.Test_Get_ByUniqueAttributes();

        [Fact] public void Test_User_AccessGroup_Test_List_ById() => user_AccessGroup.Test_List_ById();
        [Fact] public void Test_User_AccessGroup_Test_Upsert() => user_AccessGroup.Test_Upsert();
        [Fact] public void Test_User_AccessGroup_Delete() => user_AccessGroup.Test_Delete_ById();

        [Fact] public void Test_User_Group_Test_List_ById() => user_Group.Test_List_ById();
        [Fact] public void Test_User_Group_Test_Upsert() => user_Group.Test_Upsert();
        [Fact] public void Test_User_Group_Delete() => user_Group.Test_Delete_ById();

        [Fact] public void Test_User_Department_Test_List_ById() => user_Department.Test_List_ById();
        [Fact] public void Test_User_Department_Test_Upsert() => user_Department.Test_Upsert();
        [Fact] public void Test_User_Department_Test_Patch() => user_Department.Test_Patch();
        [Fact] public void Test_User_Department_Delete() => user_Department.Test_Delete_ById();

        [Fact] public void Test_User_Location_Test_List_ById() => user_Location.Test_List_ById();
        [Fact] public void Test_User_Location_Test_Upsert() => user_Location.Test_Upsert();
        [Fact] public void Test_User_Location_Test_Patch() => user_Location.Test_Patch();
        [Fact] public void Test_User_Location_Delete() => user_Location.Test_Delete_ById();

        [Fact] public void Test_User_Application_Test_List_ById() => user_Application.Test_List_ById();

        [Fact] public void Test_User_AccessRole_Test_List_ById() => user_AccessRole.Test_List_ById();

        [Fact] public void Test_User_EffectivePermission_Test_List_ById() => user_EffectivePermission.Test_List_ById();
    }
}
