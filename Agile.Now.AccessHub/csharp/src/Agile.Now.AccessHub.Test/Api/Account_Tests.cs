using System;
using System.Collections.Generic;
using System.Linq;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.Api.Test;
using Agile.Now.ApiAccounts.Test.Api;
using Xunit;

namespace Agile.Now.AccessHub.Test.Api;

public class Account_Tests : EntityTests<Account, string, AccountInsertData> {
    readonly AccountsApi api;
    readonly Tenant_TestData account_Tenant_TestData = new Tenant_TestData();

    public Account_Tests()
        : base(
            testData: new Account_TestData(),
            id: new(nameof(Account.Id), entity => entity.Id, (entity, id) => entity.Id = id),
            uniqueAttributes: new Attribute<Account, string, AccountInsertData>[] {
                new(nameof(Account.ExternalId), data => data.ExternalId, (data, value) => data.ExternalId = value),
                new(nameof(Account.Username), data => data.Username, (data, value) => data.Username = value)
            }) {
        api = new AccountsApi(Settings.Connections[0]);
    }

    protected override List<Account> List(
        string filters, string orders = default, int currentPage = default, int pageSize = DefaultPageSize) =>

        api.ListAccounts(filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    protected override Account Get(string id, string name = default) => api.GetAccount(id, name);
    protected override Account Create(AccountInsertData data) => api.CreateAccount(data);

    protected override Account Update(string id, AccountInsertData data, string name = default) =>
        api.UpdateAccount(id, data.ToAccountUpdateData(), name);

    protected override Account Upsert(AccountInsertData data) =>
        api.UpsertAccount(data.ToAccountData());

    protected override Account Delete(string id, string name) => api.DeleteAccount(id, name);

    [Fact] public void Test_Account_List_ById() => Test_List_ById();
    [Fact] public void Test_Account_List_ByUniqueAttributes() => Test_List_ByUniqueAttributes();
    [Fact] public void Test_Account_List_Paging() => Test_List_Paging();
    [Fact] public void Test_Account_List_OrderAscending() => Test_List_OrderAscending();
    [Fact] public void Test_Account_List_OrderDecending() => Test_List_OrderDecending();

    [Fact] public void Test_Account_Get_ById() => Test_Get_ById();
    [Fact] public void Test_Account_Get_ByUniqueAttributes() => Test_Get_ByUniqueAttributes();

    [Fact] public void Test_Account_Create() => Test_Create();
    [Fact] public void Test_Account_Create_WithUniqueAttributes() => Test_Create_WithUniqueAttributes();

    [Fact] public void Test_Account_Update() => Test_Update_ById();
    [Fact] public void Test_Account_Update_ByUniqueAttributes() => Test_Update_ByUniqueAttributes();

    [Fact] public void Test_Account_Upsert() => Test_Upsert();

    [Fact] public void Test_Account_Delete_ById() => Test_Delete_ById();
    [Fact] public void Test_Account_Delete_ByUniqueAttributes() => Test_Delete_ByUniqueAttributes();

    [Fact]
    public void Test_Account_List_ExternalUser() {
        var account = GenerateEntity();
        try {
            api.UpsertAccountTenant(account.Id, account_Tenant_TestData.GenerateRequestData().First());
            var existing = List(Id.CreateFilters(account));
            Assert.NotEmpty(existing);
            api.DeleteAccountTenant(account.Id,
                Tenant_TestData.DefaultTenant.ToString(), subName: nameof(TenantData.TenantId));
            existing = List(Id.CreateFilters(account));
            Assert.Empty(existing);
        }
        finally {
            Delete(account);
        }
    }

    [Fact]
    public void Test_Account_Get_ExternalUser() {
        var account = GenerateEntity();
        api.UpsertAccountTenant(account.Id, account_Tenant_TestData.GenerateRequestData().Skip(1).First());
        Assert.Null(Record.Exception(() => Get(account.Id)));
        api.DeleteAccountTenant(account.Id,
            Tenant_TestData.DefaultTenant.ToString(), subName: nameof(TenantData.TenantId));
        Assert.ThrowsAny<Exception>(() => Get(account.Id));
    }

    [Fact]
    public void Test_Account_Delete_ExternalUser() {
        var account = GenerateEntity();
        var externalTenant = api.UpsertAccountTenant(account.Id, account_Tenant_TestData.GenerateRequestData().Skip(1).First());
        Assert.ThrowsAny<Exception>(() => Delete(account));
        Assert.Null(Record.Exception(() => Get(account.Id)));
    }
}
