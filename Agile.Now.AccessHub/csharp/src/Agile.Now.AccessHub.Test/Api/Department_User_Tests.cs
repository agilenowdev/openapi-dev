using System.Collections.Generic;
using System.Linq;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.AccessHub.Test.Data;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.AccessHub.Test.Api;

public class Department_User_Tests : SubEntityTests<Department, DepartmentInsertData, User, UserData> {
    readonly DepartmentsApi api;

    public Department_User_Tests()
        : base(new Department_Tests(),
            testData: new User_TestData(),
            id: new(nameof(User.Id), entity => entity.Id.ToString(), isString: false),
            uniqueAttributes: new Attribute<User, UserData>[] {
                new(nameof(User.ExternalId), data => data.ExternalId),
                new(nameof(User.Username), data => data.Name) }) {

        api = new DepartmentsApi(Settings.Connections[0]);
    }

    protected override List<User> List(Context<Department, DepartmentInsertData> context,
        string filters, string orders, int currentPage, int pageSize) =>

        api.ListDepartmentUsers(id: context.ParentId, name: context.Parent.Id.Name,
            filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    protected override User Upsert(Context<Department, DepartmentInsertData> context, UserData data) =>
        api.UpsertDepartmentUser(context.ParentId, data);

    protected override User[] Patch(string id, List<UserData> data, string deleteNotExists) =>
        api.PatchDepartmentUsers(id: id,
            usersData1: new UsersData1(users: data.Select(i => i.ToUserText1()).ToList()),
            deleteNotExists: deleteNotExists).Data.ToArray();

    protected override User Delete(Context<Department, DepartmentInsertData> context, string id, string name) =>
        api.DeleteDepartmentUser(context.ParentId, id, context.Parent.Id.Name, name);

    [Fact] public void Test_Department_User_List_ById() => Test_List_ById();
    //[Fact] public void Test_Department_User_List_ByUniqueAttributes() => Test_List_ByUniqueAttributes();
    [Fact] public void Test_Department_User_List_Paging() => Test_List_Paging();
    [Fact] public void Test_Department_User_List_OrderAscending() => Test_List_OrderAscending();
    [Fact] public void Test_Department_User_List_OrderDecending() => Test_List_OrderDecending();

    [Fact] public void Test_Department_User_Upsert() => Test_Upsert();

    [Fact] public void Test_Department_User_Patch() => Test_Patch();
    [Fact] public void Test_Department_User_Patch_DeleteNotExists() => Test_Patch_DeleteNotExists();

    [Fact] public void Test_Department_User_Delete_ById() => Test_Delete_ById();
    //[Fact] public void Test_Department_User_Delete_ByUniqueAttributes() => Test_Delete_ByUniqueAttributes();
}
