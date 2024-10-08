using System.Collections.Generic;
using System.Linq;
using Agile.Now.Api.Test;
using Agile.Now.Runtime.Api;
using Agile.Now.Runtime.Model;
using Agile.Now.Runtime.Test.Api;
using Agile.Now.Runtime.Test.Data;
using Xunit;
using Xunit.Abstractions;

namespace Agile.Runtime.Runtime.ApiTestsWithHelper;

class UserTests : EntityTests<User, int, object> {
    readonly UsersApi api;

    public UserTests(UsersApi api)
        : base(
            testData: new UserTestData2(),
            id: new(nameof(User.Id), entity => entity.Id, null),
            uniqueAttributes: new Attribute<User, string, object>[] {
                new(nameof(User.ExternalId), data => data.ExternalId, null),
                new(nameof(User.Name), data => data.Name, null),
            }) {

        this.api = api;
    }

    protected override List<User> List(string filters, string orders, int currentPage, int pageSize) =>
        api.ListUsers(filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    protected override User Get(string id, string name) => api.GetUser(id, name);
}

class UserAccessGroupTests : SubEntityTests<int, AccessGroup, string, AccessGroupData> {
    readonly UsersApi api;

    public UserAccessGroupTests(UsersApi api, EntityTestsBase<int> parent)
        : base(parent,
            id: new(nameof(AccessGroup.Id), entity => entity.Id, null),
            testData: new UserAccessGroupTestData()) {

        this.api = api;
    }

    protected override List<AccessGroup> List(int id) => api.ListUserAccessGroups(id.ToString()).Data;
    protected override AccessGroup Upsert(int id, AccessGroupData data) => api.UpsertUserAccessGroup(id.ToString(), data);
    protected override void Delete(int id, string subId) => api.DeleteUserAccessGroup(id.ToString(), subId.ToString(), subName: "AccessGroupId");
}

class UserGroupTests : SubEntityTests<int, Group, int, GroupData> {
    readonly UsersApi api;

    public UserGroupTests(UsersApi api, EntityTestsBase<int> parent)
        : base(parent,
            id: new(nameof(Group.Id), entity => entity.Id, null),
            testData: new UserGroupTestData()) {

        this.api = api;
    }

    protected override List<Group> List(int id) => api.ListUserGroups(id.ToString()).Data;
    protected override Group Upsert(int id, GroupData data) => api.UpsertUserGroup(id.ToString(), data);
    protected override void Delete(int id, int subId) => api.DeleteUserGroup(id.ToString(), subId.ToString(), subName: "Group_Id");
}

class UserDepartmentTests : SubEntityTests<int, Department, string, DepartmentData> {
    readonly UsersApi api;

    public UserDepartmentTests(UsersApi api, EntityTestsBase<int> parent)
        : base(parent,
            id: new(nameof(Department.Id), entity => entity.Id, null),
            testData: new UserDepartmentTestData()) {

        this.api = api;
    }

    protected override List<Department> List(int id) => api.ListUserDepartments(id.ToString()).Data;
    protected override Department Upsert(int id, DepartmentData data) => api.UpsertUserDepartment(id.ToString(), data);
    protected override void Delete(int id, string subId) => api.DeleteUserDepartment(id.ToString(), subId.ToString(), subName: "DepartmentId");
}

class UserLocationTests : SubEntityTests<int, Location, string, LocationData> {
    readonly UsersApi api;

    public UserLocationTests(UsersApi api, EntityTestsBase<int> parent)
        : base(parent,
            id: new(nameof(Location.Id), entity => entity.Id, null),
            testData: new UserLocationTestData()) {

        this.api = api;
    }

    protected override List<Location> List(int id) => api.ListUserLocations(id.ToString()).Data;
    protected override Location Upsert(int id, LocationData data) => api.UpsertUserLocation(id.ToString(), data);
    protected override void Delete(int id, string subId) => api.DeleteUserLocation(id.ToString(), subId.ToString(), subName: "LocationId");
}

class UserApplicationTests : SubEntityTests<int, Application, string, object> {
    readonly UsersApi api;

    public UserApplicationTests(UsersApi api, EntityTestsBase<int> parent)
        : base(parent,
            id: new(nameof(Application.Id), entity => entity.Id, null),
            testData: null) {

        this.api = api;
    }

    protected override List<Application> List(int id) => api.ListUserApplications(id.ToString()).Data;
}

class UserAccessRoleTests : SubEntityTests<int, AccessRole, string, object> {
    readonly UsersApi api;

    public UserAccessRoleTests(UsersApi api, EntityTestsBase<int> parent)
        : base(parent,
            id: new(nameof(AccessRole.Id), entity => entity.Id, null),
            testData: null) {

        this.api = api;
    }

    protected override List<AccessRole> List(int id) => api.ListUserAccessRoles(id.ToString()).Data;
}

class UserEffectivePermissionTests : SubEntityTests<int, EffectivePermission, string, object> {
    readonly UsersApi api;

    public UserEffectivePermissionTests(UsersApi api, EntityTestsBase<int> parent)
        : base(parent,
            id: new(nameof(EffectivePermission.Id), entity => entity.Id, null),
            testData: null) {

        this.api = api;
    }

    protected override List<EffectivePermission> List(int id) => api.ListUserEffectivePermissions(id.ToString()).Data;
}

public class UsersApiTests {
    readonly UserTests user;
    readonly UserAccessGroupTests user_AccessGroup;
    readonly UserGroupTests user_Group;
    readonly UserDepartmentTests user_Department;
    readonly UserLocationTests user_Location;
    readonly UserApplicationTests user_Application;
    readonly UserAccessRoleTests user_AccessRole;
    readonly UserEffectivePermissionTests user_EffectivePermission;

    public UsersApiTests(ITestOutputHelper testOutputHelper) {
        var api = new UsersApi(Settings.Connections[0]);
        user = new UserTests(api);
        user_AccessGroup = new UserAccessGroupTests(api, user);
        user_AccessGroup = new UserAccessGroupTests(api, user);
        user_Group = new UserGroupTests(api, user);
        user_Department = new UserDepartmentTests(api, user);
        user_Location = new UserLocationTests(api, user);
        user_Application = new UserApplicationTests(api, user);
        user_AccessRole = new UserAccessRoleTests(api, user);
        user_EffectivePermission = new UserEffectivePermissionTests(api, user);
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
