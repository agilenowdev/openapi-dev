using System;
using System.Collections.Generic;
using System.Linq;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.Api.Test;
using Agile.Now.ApiAccounts.Test.Api;
using Polly;
using Xunit;

namespace Agile.Now.AccessHub.Test.Api;

public class Account_Tests : EntityTests<Account, AccountInsertData> {
    readonly AccountsApi api;
    readonly Tenant_TestData account_Tenant_TestData = new Tenant_TestData();

    public Account_Tests()
        : base(
            testData: new Account_TestData(),
            id: new(nameof(Account.Id), entity => entity.Id, (entity, id) => entity.Id = id),
            uniqueAttributes: new Attribute<Account, AccountInsertData>[] {
                new(nameof(Account.ExternalId), data => data.ExternalId, (data, value) => data.ExternalId = value),
                new(nameof(Account.Username), data => data.Username, (data, value) => data.Username = value)
            }) {
        api = new AccountsApi(Settings.Connections[0]);
    }

    protected override List<Account> List(Context<Account, AccountInsertData> context,
        string filters, string orders = default, int currentPage = default, int pageSize = DefaultPageSize) =>

        api.ListAccounts(filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    protected override Account Get(Context<Account, AccountInsertData> context, string id, string name) =>
        api.GetAccount(id, name);

    protected override Account Create(Context<Account, AccountInsertData> context, AccountInsertData data) => 
        api.CreateAccount(data);

    protected override Account Update(Context<Account, AccountInsertData> context, 
        string id, AccountInsertData data, string name = default) =>

        api.UpdateAccount(id, data.ToAccountUpdateData(), name);

    protected override Account Upsert(Context<Account, AccountInsertData> context, AccountInsertData data) =>
        api.UpsertAccount(data.ToAccountData());

    protected override Account Delete(Context<Account, AccountInsertData> context, string id, string name) =>
        api.DeleteAccount(id, name);

    [Fact] public void Test_Account_List_ById() => Test_List_ById();
    [Fact] public void Test_Account_List_ByUniqueAttributes() => Test_List_ByUniqueAttributes();
    [Fact] public void Test_Account_List_Paging() => Test_List_Paging();
    [Fact] public void Test_Account_List_OrderAscending() => Test_List_OrderAscending();
    [Fact] public void Test_Account_List_OrderDecending() => Test_List_OrderDecending();

    [Fact]
    public void Test_Account_List_ExternalUser() {
        using var context = CreateContext();
        var account = GenerateEntity(context);
        try {
            api.UpsertAccountTenant(account.Id, account_Tenant_TestData.GenerateRequestData().First());
            var filters = CreateFilters(context, Id, account);
            var existing = List(context, filters);
            Assert.NotEmpty(existing);
            api.DeleteAccountTenant(account.Id,
                Tenant_TestData.DefaultTenant.ToString(), subName: nameof(TenantData.TenantId));
            existing = List(context, filters);
            Assert.Empty(existing);
        }
        finally {
            Delete(context, account);
        }
    }

    [Fact] public void Test_Account_Get_ById() => Test_Get_ById();
    [Fact] public void Test_Account_Get_ByUniqueAttributes() => Test_Get_ByUniqueAttributes();

    [Fact]
    public void Test_Account_Get_ExternalUser() {
        using var context = CreateContext();
        var account = GenerateEntity(context);
        api.UpsertAccountTenant(account.Id, account_Tenant_TestData.GenerateRequestData().Skip(1).First());
        Assert.Null(Record.Exception(() => Get(context, account.Id, Id.Name)));
        api.DeleteAccountTenant(account.Id,
            Tenant_TestData.DefaultTenant.ToString(), subName: nameof(TenantData.TenantId));
        Assert.ThrowsAny<Exception>(() => Get(context, account.Id, Id.Name));
    }

    [Fact] public void Test_Account_Create() => Test_Create();
    [Fact] public void Test_Account_Create_WithUniqueAttributes() => Test_Create_WithUniqueAttributes();

    [Fact] public void Test_Account_Update() => Test_Update_ById();
    [Fact] public void Test_Account_Update_ByUniqueAttributes() => Test_Update_ByUniqueAttributes();

    [Fact] public void Test_Account_Upsert() => Test_Upsert();

    [Fact] public void Test_Account_Delete_ById() => Test_Delete_ById();
    [Fact] public void Test_Account_Delete_ByUniqueAttributes() => Test_Delete_ByUniqueAttributes();

    [Fact]
    public void Test_Account_Delete_ExternalUser() {
        using var context = CreateContext();
        var account = GenerateEntity(context);
        var externalTenant = api.UpsertAccountTenant(account.Id, account_Tenant_TestData.GenerateRequestData().Skip(1).First());
        Assert.ThrowsAny<Exception>(() => Delete(null, account));
        Assert.Null(Record.Exception(() => Get(context, account.Id, Id.Name)));
    }
}
