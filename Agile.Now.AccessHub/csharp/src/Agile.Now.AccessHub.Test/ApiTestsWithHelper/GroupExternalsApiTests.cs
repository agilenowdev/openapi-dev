using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.ApiAccessGroups.Test.Api;
using Agile.Now.ApiOrganizations.Test.Api;
using Xunit;
using Xunit.Abstractions;

namespace Agile.Now.AccessHub.Test.ApiTestsWithHelper {
    public class GroupExternalsApiTests {
        readonly EntityTests<GroupExternal, int, GroupExternalData, GroupExternalData, GroupExternalData, GroupExternalData> 
            groupExternal;
        readonly SubEntityTests<int, UserExternal, int, UserExternalData, UserExternalData, UserExternalData, UserExternalText> groupExternal_UsersExternals;

        public GroupExternalsApiTests(ITestOutputHelper testOutputHelper) {
            var api = new GroupExternalsApi(Settings.Connections[0]);
            groupExternal = new(
                id: new("Id", entity => entity.Id, (entity, id) => entity.Id = id),
                testData: new(
                    getInsertData: () => GroupExternalTestData.CreateGroupExternalDatas(),
                    assertEqual: (data, entity) => data.AssertEqual(entity),
                    update: data => data.Update()),
                uniqueAttributes: new Attribute<GroupExternal, string, GroupExternalData>[] {
                    //new("ExternalId", data => data.ExternalId, (data, value) => data.ExternalId = value),
                    new("Name", data => data.Name, (data, value) => data.Name = value)
                },
                list: (filters, currentPage, pageSize) =>
                    api.ListGroupExternals(filters: filters, currentPage: currentPage, pageSize: pageSize).Data,
                get: (id, name) => api.GetGroupExternal(id.ToString(), name),
                create: data => api.CreateGroupExternal(data),
                update: (id, data, name) => api.UpdateGroupExternal(id.ToString(), data, name),
                upsert: data => api.UpsertGroupExternal(data),
                delete: (id, name) => api.DeleteGroupExternal(id.ToString(), name));

            groupExternal_UsersExternals = new(groupExternal,
                id: new(nameof(UserExternal.Id), entity => entity.Id, (entity, id) => entity.Id = id),
                testData: new(
                    getInsertData: () => GroupExternalTestData.CreateUserExternalDatas(),
                    assertEqual: (expected, actual) => { }),
                list: (id) => api.ListGroupExternalUserExternals(id.ToString()).Data,
                upsert: (id, data) => api.UpsertGroupExternalUserExternal(id.ToString(), data),
                delete: (id, subId) => api.DeleteGroupExternalUserExternal(id.ToString(), subId.ToString(), subName: "User_Id"));
        }

        [Fact] public void Test_GroupExternal_List_ById() => groupExternal.Test_List_ById();
        [Fact] public void Test_GroupExternal_List_ByUniqueAttributes() => groupExternal.Test_List_ByUniqueAttributes();
        [Fact] public void Test_GroupExternal_List_Paging() => groupExternal.Test_List_Paging();
        [Fact] public void Test_GroupExternal_Get_ById() => groupExternal.Test_Get_ById();
        [Fact] public void Test_GroupExternal_Get_ByUniqueAttributes() => groupExternal.Test_Get_ByUniqueAttributes();
        [Fact] public void Test_GroupExternal_Create() => groupExternal.Test_Create();
        [Fact] public void Test_GroupExternal_Create_WithUniqueAttributes() => groupExternal.Test_Create_WithUniqueAttributes();
        [Fact] public void Test_GroupExternal_Update() => groupExternal.Test_Update_ById();
        [Fact] public void Test_GroupExternal_Update_WithUniqueAttributes() => groupExternal.Test_Update_WithUniqueAttributes();
        [Fact] public void Test_GroupExternal_Update_ByUniqueAttributes() => groupExternal.Test_Update_ByUniqueAttributes();
        [Fact] public void Test_GroupExternal_Upsert() => groupExternal.Test_Upsert();
        [Fact] public void Test_GroupExternal_Delete_ById() => groupExternal.Test_Delete_ById();
        [Fact] public void Test_GroupExternal_Delete_ByUniqueAttributes() => groupExternal.Test_Delete_ByUniqueAttributes();

        [Fact] public void Test_AccessGroup_User_Test_List_ById() => groupExternal_UsersExternals.Test_List_ById();
        [Fact] public void Test_AccessGroup_User_Test_Upsert() => groupExternal_UsersExternals.Test_Upsert();
        [Fact] public void Test_AccessGroup_User_Test_Delete_ById() => groupExternal_UsersExternals.Test_Delete_ById();
    }
}
