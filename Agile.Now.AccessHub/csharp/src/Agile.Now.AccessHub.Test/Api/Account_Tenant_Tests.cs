using System.Collections.Generic;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.Api.Test;
using Agile.Now.ApiAccounts.Test.Api;
using Xunit;

namespace Agile.Now.AccessHub.Test.Api;

public class Account_Tenant_Tests : SubEntityTests<Account, AccountInsertData, Tenant, TenantData> {
    readonly AccountsApi api;

    public Account_Tenant_Tests()
        : base(new Account_Tests(),
            testData: new Tenant_TestData(),
            id: new(nameof(Tenant.Id), entity => entity.Id.ToString(), isString: false)) {

        api = new AccountsApi(Settings.Connections[0]);
        NoCleanUp = true;
    }

    protected override List<Tenant> List(Context<Account, AccountInsertData> context, 
        string filters, string orders = default, int currentPage = default, int pageSize = DefaultPageSize) =>

        api.ListAccountTenants(id: context.ParentId, name: context.Parent.Id.Name,
            filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    protected override Tenant Upsert(Context<Account, AccountInsertData> context, TenantData data) =>
        api.UpsertAccountTenant(context.ParentId, data);

    protected override Tenant Delete(Context<Account, AccountInsertData> context, string id, string name) =>
        api.DeleteAccountTenant(context.ParentId, id, context.Parent.Id.Name, name);

    //[Fact] public void Test_Account_Tenant_List_ById() => Test_List_ById();
    //[Fact] public void Test_Account_Tenant_List_ByUniqueAttributes() => Test_List_ByUniqueAttributes();
    //[Fact] public void Test_Account_Tenant_List_Paging() => Test_List_Paging();
    //[Fact] public void Test_Account_Tenant_List_OrderAscending() => Test_List_OrderAscending();
    //[Fact] public void Test_Account_Tenant_List_OrderDecending() => Test_List_OrderDecending();

    [Fact] public void Test_Account_Tenant_Upsert() => Test_Upsert();

    [Fact] public void Test_Account_Tenant_Delete_ById() => Test_Delete_ById();
    //[Fact] public void Test_Account_Tenant_Delete_ByUniqueAttributes() => Test_Delete_ByUniqueAttributes();
}
