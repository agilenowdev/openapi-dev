using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.Api.Test;
using Agile.Now.ApiAccounts.Test.Api;
using Agile.Now.ApiOrganizations.Test.Api;
using Xunit;
using Xunit.Abstractions;

namespace Agile.Now.AccessHub.Test.ApiTestsWithHelper {
    public class AccountsApiTests {
        readonly EntityTests<Account, string, AccountData> account;
        readonly SubEntityTests<string, Tenant, int, TenantData> account_Tenant;
        readonly SubEntityTests<string, Picture, int, PictureData> account_Picture;

        public AccountsApiTests(ITestOutputHelper testOutputHelper) {
            var api = new AccountsApi(Settings.Connections[0]);
            account = new(
                id: new("Id", entity => entity.Id, (entity, id) => entity.Id = id),
                testData: new(
                    generateInsertData: () => AccountTestData.CreateAccountDatas(),
                    assertEqual: (data, entity) => data.AssertEqual(entity),
                    update: data => AccountTestData.UpdateAccountData(data)),
                uniqueAttributes: new Attribute<Account, string, AccountData>[] {
                    new("ExternalId", data => data.ExternalId, (data, value) => data.ExternalId = value),
                    //new("Username", data => data.Username, (data, value) => data.Username = value),
                },
                list: (filters, currentPage, pageSize) =>
                    api.ListAccounts(filters: filters, currentPage: currentPage, pageSize: pageSize).Data,
                get: (id, name) => api.GetAccount(id, name),
                create: data => api.CreateAccount(data),
                update: (id, data, name) => api.UpdateAccount(id, data, name),
                upsert: data => api.UpsertAccount(data),
                delete: (id, name) => api.DeleteAccount(id, name));

            account_Tenant = new(account,
                id: new(nameof(Tenant.Id), entity => entity.Id, (entity, id) => entity.TenantId = new ("Id", id.ToString())),
                testData: new(
                    generateInsertData: () => AccountTestData.CreateTenantDatas(),
                    assertEqual: (expected, actual) => { }),
                list: (id) => api.ListAccountTenants(id).Data,
                upsert: (id, data) => api.UpsertAccountTenant(id, data),
                delete: (id, subId) => api.DeleteAccountTenant(id, subId.ToString(), subName: "TenantId"));

            account_Picture = new(account,
                id: null,
                testData: new(
                    generateInsertData: () => AccountTestData.CreatePicturesDatas(),
                    assertEqual: (expected, actual) => { }),
                list: (id) => api.ListAccountPictures(id).Data,
                upsert: (id, data) => api.UpsertAccountPicture(id, data),
                delete: (id, subId) => api.DeleteAccountPicture(id, subId.ToString(), subName: "PictureId"));
        }

        [Fact] public void Test_Account_List_ById() => account.Test_List_ById();
        [Fact] public void Test_Account_List_ByUniqueAttributes() => account.Test_List_ByUniqueAttributes();
        [Fact] public void Test_Account_List_Paging() => account.Test_List_Paging();
        [Fact] public void Test_Account_Get_ById() => account.Test_Get_ById();
        [Fact] public void Test_Account_Get_ByUniqueAttributes() => account.Test_Get_ByUniqueAttributes();
        [Fact] public void Test_Account_Create() => account.Test_Create();
        [Fact] public void Test_Account_Create_WithUniqueAttributes() => account.Test_Create_WithUniqueAttributes();
        [Fact] public void Test_Account_Update() => account.Test_Update_ById();
        [Fact] public void Test_Account_Update_WithUniqueAttributes() => account.Test_Update_WithUniqueAttributes();
        [Fact] public void Test_Account_Update_ByUniqueAttributes() => account.Test_Update_ByUniqueAttributes();
        [Fact] public void Test_Account_Upsert() => account.Test_Upsert();
        [Fact] public void Test_Account_Delete_ById() => account.Test_Delete_ById();
        [Fact] public void Test_Account_Delete_ByUniqueAttributes() => account.Test_Delete_ByUniqueAttributes();

        [Fact] public void Test_Account_Tenant_List_ById() => account_Tenant.Test_List_ById();
        [Fact] public void Test_Account_Tenant_Upsert() => account_Tenant.Test_Upsert();
        [Fact] public void Test_Account_Tenant_Delete() => account_Tenant.Test_Delete_ById();

        [Fact] public void Test_Account_Picture_List_ById() => account_Picture.Test_List_ById();
        [Fact] public void Test_Account_Picture_Upsert() => account_Picture.Test_Upsert();
        [Fact] public void Test_Account_Picture_Delete() => account_Picture.Test_Delete_ById();
    }
}
