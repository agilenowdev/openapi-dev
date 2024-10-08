using System.Collections.Generic;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.Api.Test;
using Agile.Now.ApiAccounts.Test.Api;
using Xunit;
using Xunit.Abstractions;

namespace Agile.Now.AccessHub.Test.ApiTestsWithHelper;

class AccountTests : EntityTests<Account, string, AccountData> {
    readonly AccountsApi api;

    public AccountTests(AccountsApi api)
        : base(
            testData: new AccountTestData2(),
            id: new(nameof(Account.Id), entity => entity.Id, (entity, id) => entity.Id = id),
            uniqueAttributes: new Attribute<Account, string, AccountData>[] {
                new(nameof(Account.ExternalId), data => data.ExternalId, (data, value) => data.ExternalId = value),
                new(nameof(Account.Name), data => data.Name, (data, value) => data.Name = value),
            }) {

        this.api = api;
    }

    protected override List<Account> List(string filters, string orders, int currentPage, int pageSize) =>
        api.ListAccounts(filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    protected override Account Get(string id, string name) => api.GetAccount(id, name);
    protected override Account Create(AccountData data) => api.CreateAccount(data);
    protected override Account Update(string id, AccountData data, string name) => api.UpdateAccount(id, data, name);
    protected override Account Upsert(AccountData data) => api.UpsertAccount(data);
    protected override Account Delete(string id, string name) => api.DeleteAccount(id, name);
}

class AccountTenantTests : SubEntityTests<string, Tenant, int, TenantData> {
    readonly AccountsApi api;

    public AccountTenantTests(AccountsApi api, EntityTestsBase<string> parent)
        : base(parent,
            id: new(nameof(Tenant.Id), entity => entity.Id, (entity, id) => entity.UserId = new("Id", id.ToString())),
            testData: new AccountTenantTestData()) {

        this.api = api;
    }

    protected override List<Tenant> List(string id) => api.ListAccountTenants(id).Data;
    protected override Tenant Upsert(string id, TenantData data) => api.UpsertAccountTenant(id, data);
    protected override void Delete(string id, int subId) => api.DeleteAccountTenant(id, subId.ToString(), subName: "TenantId");
}

class AccountPictureTests : SubEntityTests<string, Picture, int, PictureData> {
    readonly AccountsApi api;

    public AccountPictureTests(AccountsApi api, EntityTestsBase<string> parent)
        : base(parent,
            id: null,
            testData: new AccountPictureTestData()) {

        this.api = api;
    }

    protected override List<Picture> List(string id) => api.ListAccountPictures(id).Data;
    protected override Picture Upsert(string id, PictureData data) => api.UpsertAccountPicture(id, data);
    protected override void Delete(string id, int subId) => api.DeleteAccountPicture(id, subId.ToString(), subName: "PictureId");
}

public class AccountsApiTests {
    readonly AccountsApi api;
    readonly AccountTests account;
    readonly AccountTenantTests account_Tenant;
    readonly AccountPictureTests account_Picture;

    public AccountsApiTests(ITestOutputHelper testOutputHelper) {
        api = new AccountsApi(Settings.Connections[0]);
        account = new AccountTests(api);
        account_Tenant = new AccountTenantTests(api, account);
        account_Picture = new AccountPictureTests(api, account);
    }

    [Fact] public void Test_Account_List_ById() => account.Test_List_ById();
    [Fact] public void Test_Account_List_ByUniqueAttributes() => account.Test_List_ByUniqueAttributes();
    [Fact] public void Test_Account_List_Paging() => account.Test_List_Paging();
    [Fact] public void Test_Account_List_OrderAscending() => account.Test_List_OrderAscending();
    [Fact] public void Test_Account_List_OrderDecending() => account.Test_List_OrderDecending();

    [Fact] public void Test_Account_Get_ById() => account.Test_Get_ById();
    [Fact] public void Test_Account_Get_ByUniqueAttributes() => account.Test_Get_ByUniqueAttributes();

    [Fact] public void Test_Account_Create() => account.Test_Create();
    [Fact] public void Test_Account_Create_WithUniqueAttributes() => account.Test_Create_WithUniqueAttributes();
    [Fact] public void Test_Account_Update() => account.Test_Update_ById();
    [Fact] public void Test_Account_Update_ByUniqueAttributes() => account.Test_Update_ByUniqueAttributes();
    [Fact] public void Test_Account_Upsert() => account.Test_Upsert();
    [Fact] public void Test_Account_Delete_ById() => account.Test_Delete_ById();
    [Fact] public void Test_Account_Delete_ByUniqueAttributes() => account.Test_Delete_ByUniqueAttributes();

    [Fact] public void Test_Account_Tenant_List_ById() => account_Tenant.Test_List_ById();
    [Fact] public void Test_Account_Tenant_Upsert() => account_Tenant.Test_Upsert();
    [Fact] public void Test_Account_Tenant_Delete() => account_Tenant.Test_Delete_ById();

    [Fact] public void Test_Account_Picture_List_ById() => account_Picture.Test_List_ById();
    //[Fact] public void Test_Account_Picture_Upsert() => account_Picture.Test_Upsert();
    [Fact] public void Test_Account_Picture_Delete() => account_Picture.Test_Delete_ById();

    [Fact]
    public async void Test_AccountPicture_Upsert() {
        var created = api.CreateAccount(AccountTestData.CreateAccountData());
        try {
            var createdSubEntity = await api.UpsertAccountPictureAsync(created.Id,
                new(AccountTestData.PictureData.ToStream()), name: "AccountId");
            try {
                var existingSubEntities = api.ListAccountPictures(created.Id).Data;
                Assert.Contains(existingSubEntities, i => i.Filename == createdSubEntity.Filename);
            }
            finally {
                api.DeleteAccountPicture(created.Id, null);
            }
        }
        finally {
            api.DeleteAccount(created.Id);
        }
    }
}
