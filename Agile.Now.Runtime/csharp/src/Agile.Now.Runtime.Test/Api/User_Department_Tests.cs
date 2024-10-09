using System.Collections.Generic;
using System.Linq;
using Agile.Now.Api.Test;
using Agile.Now.Runtime.Api;
using Agile.Now.Runtime.Model;
using Agile.Now.Runtime.Test.Data;
using Xunit;

namespace Agile.Now.Runtime.Test.Api;

public class User_Department_Tests : SubEntityTests<User, int, object, Department, string, DepartmentData>
{
    readonly UsersApi api;

    public User_Department_Tests()
        : base(new User_Tests(),
            testData: new User_Department_TestData(),
            id: new(nameof(Department.Id), entity => entity.Id, null),
            uniqueAttributes: new Attribute<Department, string, DepartmentData>[] {
                new(nameof(Department.ExternalId), data => data.ExternalId, null),
                new(nameof(Department.Name), data => data.Name, null) })
    {

        api = new UsersApi(Settings.Connections[0]);
    }

    protected override List<Department> List(
        string id, string name, string filters, string orders, int currentPage, int pageSize) =>

        api.ListUserDepartments(
            id: id, name: name, filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    protected override Department Upsert(int id, DepartmentData data) => api.UpsertUserDepartment(id.ToString(), data);

    protected override Department[] Patch(int id, List<DepartmentData> data, string deleteNotExists) =>
        api.PatchUserDepartments(id: id.ToString(),
            departmentsData: new DepartmentsData(departments: data.Select(i => i.ToDepartmentPatchData()).ToList()),
            deleteNotExists: deleteNotExists).Data.ToArray();

    protected override Department Delete(string id, string subId, string name, string subName) =>
        api.DeleteUserDepartment(id, subId, name: name, subName: subName);

    [Fact] public void Test_User_Department_List_ById() => Test_List_ById();
    [Fact] public void Test_User_Department_List_ByUniqueAttributes() => Test_List_ByUniqueAttributes();
    [Fact] public void Test_User_Department_List_Paging() => Test_List_Paging();
    [Fact] public void Test_User_Department_List_OrderAscending() => Test_List_OrderAscending();
    [Fact] public void Test_User_Department_List_OrderDecending() => Test_List_OrderDecending();

    [Fact] public void Test_User_Department_Upsert() => Test_Upsert();

    [Fact] public void Test_User_Department_Patch() => Test_Patch();
    [Fact] public void Test_User_Department_Patch_DeleteNotExists() => Test_Patch_DeleteNotExists();

    [Fact] public void Test_User_Department_Delete_ById() => Test_Delete_ById();
    [Fact] public void Test_User_Department_Delete_ByUniqueAttributes() => Test_Delete_ByUniqueAttributes();
}
