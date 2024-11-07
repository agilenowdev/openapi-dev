using System.Collections.Generic;
using System.Linq;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.AccessHub.Test.Data;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.AccessHub.Test.Api;

public class GroupExternal_Tests : EntityTests<GroupExternal, GroupExternalData> {
    readonly GroupExternalsApi api;

    public GroupExternal_Tests()
        : base(
            testData: new GroupExternal_TestData(),
            id: new(nameof(GroupExternal.Id),
                entity => entity.Id.ToString(), (entity, id) => entity.Id = int.Parse(id), isString: false),
            uniqueAttributes: new Attribute<GroupExternal, GroupExternalData>[] {
                //new(nameof(GroupExternal.ExternalId), data => data.ExternalId, (data, value) => data.ExternalId = value),
                new(nameof(GroupExternal.Name), data => data.Name, (data, value) => data.Name = value),
            }) {

        api = new GroupExternalsApi(Settings.Connections[0]);
    }

    protected override List<GroupExternal> List(Context<GroupExternal, GroupExternalData> context,
        string filters, string orders, int currentPage, int pageSize) =>

        api.ListGroupExternals(filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    protected override GroupExternal Get(Context<GroupExternal, GroupExternalData> context, string id, string name) =>
        api.GetGroupExternal(id, name);

    protected override GroupExternal Create(Context<GroupExternal, GroupExternalData> context, GroupExternalData data) =>
        api.CreateGroupExternal(data);

    protected override GroupExternal Update(Context<GroupExternal, GroupExternalData> context, 
        string id, GroupExternalData data, string name)  =>

        api.UpdateGroupExternal(id, data, name);

    protected override GroupExternal Upsert(GroupExternalData data) =>
        api.UpsertGroupExternal(data);

    protected override IEnumerable<GroupExternal> Patch(List<GroupExternalData> data, string deleteNotExists) =>
        api.PatchGroupExternals(new GroupExternalsData(
            groupExternals: data.Select(i => i.ToGroupExternalText()).ToList())).Data;

    protected override GroupExternal Delete(Context<GroupExternal, GroupExternalData> context, string id, string name) =>
        api.DeleteGroupExternal(id, name);

    [Fact] public void Test_GroupExternal_List_ById() => Test_List_ById();
    [Fact] public void Test_GroupExternal_List_ByUniqueAttributes() => Test_List_ByUniqueAttributes();
    [Fact] public void Test_GroupExternal_List_Paging() => Test_List_Paging();
    [Fact] public void Test_GroupExternal_List_OrderAscending() => Test_List_OrderAscending();
    [Fact] public void Test_GroupExternal_List_OrderDecending() => Test_List_OrderDecending();

    [Fact] public void Test_GroupExternal_Get_ById() => Test_Get_ById();
    [Fact] public void Test_GroupExternal_Get_ByUniqueAttributes() => Test_Get_ByUniqueAttributes();

    [Fact] public void Test_GroupExternal_Create() => Test_Create();
    [Fact] public void Test_GroupExternal_Create_WithUniqueAttributes() => Test_Create_WithUniqueAttributes();
    [Fact] public void Test_GroupExternal_Update() => Test_Update_ById();
    [Fact] public void Test_GroupExternal_Update_ByUniqueAttributes() => Test_Update_ByUniqueAttributes();
    [Fact] public void Test_GroupExternal_Upsert() => Test_Upsert();

    [Fact] public void Test_GroupExternal_Patch() => Test_Patch();

    [Fact] public void Test_GroupExternal_Delete_ById() => Test_Delete_ById();
    [Fact] public void Test_GroupExternal_Delete_ByUniqueAttributes() => Test_Delete_ByUniqueAttributes();
}
