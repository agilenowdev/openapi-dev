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
                    new("Username", data => data.Username, (data, value) => data.Username = value),
                },
                list: (filters, currentPage, pageSize) =>
                    api.ListAccounts(filters: filters, currentPage: currentPage, pageSize: pageSize).Data,
                get: (id, name) => api.GetAccount(id, name),
                create: data => api.CreateAccount(data),
                update: (id, data, name) => api.UpdateAccount(id, data, name),
                upsert: data => api.UpsertAccount(data),
                delete: (id, name) => api.DeleteAccount(id, name));
        }

        [Fact] public void Test_Accounts_List_ById() => account.Test_List_ById();
        [Fact] public void Test_Accounts_List_ByUniqueAttributes() => account.Test_List_ByUniqueAttributes();
        [Fact] public void Test_Accounts_List_Paging() => account.Test_List_Paging();
        [Fact] public void Test_Accounts_Get_ById() => account.Test_Get_ById();
        [Fact] public void Test_Accounts_Get_ByUniqueAttributes() => account.Test_Get_ByUniqueAttributes();
        [Fact] public void Test_Accounts_Create() => account.Test_Create();
        [Fact] public void Test_Accounts_Create_WithUniqueAttributes() => account.Test_Create_WithUniqueAttributes();
        [Fact] public void Test_Accounts_Update() => account.Test_Update_ById();
        [Fact] public void Test_Accounts_Update_WithUniqueAttributes() => account.Test_Update_WithUniqueAttributes();
        [Fact] public void Test_Accounts_Update_ByUniqueAttributes() => account.Test_Update_ByUniqueAttributes();
        [Fact] public void Test_Accounts_Upsert() => account.Test_Upsert();
        [Fact] public void Test_Accounts_Delete_ById() => account.Test_Delete_ById();
        [Fact] public void Test_Accounts_Delete_ByUniqueAttributes() => account.Test_Delete_ByUniqueAttributes();
    }
}
