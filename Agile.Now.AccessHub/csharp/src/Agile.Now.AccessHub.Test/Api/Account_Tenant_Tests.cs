using System.Collections.Generic;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.Api.Test;
using Agile.Now.ApiAccounts.Test.Api;
using Xunit;

namespace Agile.Now.AccessHub.Test.Api;

public class Account_Tenant_Tests : SubEntityTests<Account, string, AccountInsertData, Tenant, int, TenantData> {
    readonly AccountsApi api;

    public Account_Tenant_Tests()
        : base(new Account_Tests(),
            id: new(nameof(Tenant.Id), entity => entity.Id, (entity, id) => entity.UserId = new("Id", id.ToString())),
            testData: new Account_Tenant_TestData()) {

        api = new AccountsApi(Settings.Connections[0]);
    }

    protected override List<Tenant> List(
        string id, string name, string filters, string orders, int currentPage, int pageSize) =>

        api.ListAccountTenants(id).Data;

    protected override Tenant Upsert(string id, TenantData data) => api.UpsertAccountTenant(id, data);

    protected override Tenant Delete(string id, string subId, string name, string subName) =>
        api.DeleteAccountTenant(id, subId, subName: subName);

    [Fact] public void Test_Account_Tenant_List_ById() => Test_List_ById();
    [Fact] public void Test_Account_Tenant_List_ByUniqueAttributes() => Test_List_ByUniqueAttributes();
    [Fact] public void Test_Account_Tenant_List_Paging() => Test_List_Paging();
    [Fact] public void Test_Account_Tenant_List_OrderAscending() => Test_List_OrderAscending();
    [Fact] public void Test_Account_Tenant_List_OrderDecending() => Test_List_OrderDecending();

    [Fact] public void Test_Account_Tenant_Upsert() => Test_Upsert();

    [Fact] public void Test_Account_Tenant_Delete_ById() => Test_Delete_ById();
    [Fact] public void Test_Location_User_Delete_ByUniqueAttributes() => Test_Delete_ByUniqueAttributes();
}
