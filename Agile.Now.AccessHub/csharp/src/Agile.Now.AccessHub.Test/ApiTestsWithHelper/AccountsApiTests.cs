using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.ApiAccounts.Test.Api;
using Agile.Now.ApiOrganizations.Test.Api;
using Xunit;
using Xunit.Abstractions;

namespace Agile.Now.AccessHub.Test.ApiTestsWithHelper {
    public class AccountsApiTests {
        readonly EntityTestsBase<string> accountsTests;

        public AccountsApiTests(ITestOutputHelper testOutputHelper) {
            var api = new AccountsApi(Settings.Connections[0]);
            accountsTests = new EntityTests<Account, string,
                AccountData, AccountData, AccountData>(

                id: new("Id", entity => entity.Id, (entity, id) => entity.Id = id),
                testData: new(
                    getInsertData: () => AccountTestData.CreateAccountData(),
                    toUpdateData: data => data,
                    toUpsertData: data => data,
                    assertEqual: (data, entity) => data.AssertEqual(entity),
                    update: data => AccountTestData.UpdateAccountData(data)),
                uniqueAttributes: new Attribute<Account, string, AccountData>[] {
                    new("ExternalId", data => data.ExternalId, (data, value) => data.ExternalId = value),
                    new("Username", data => data.Username, (data, value) => data.Username = value),
                },
                create: data => api.CreateAccount(data),
                delete: (id, name) => api.DeleteAccount(id, name),
                get: (id, name) => api.GetAccount(id, name),
                update: (id, data, name) => api.UpdateAccount(id, data, name),
                upsert: data => api.UpsertAccount(data));
        }

        [Fact]
        public void Test_Accounts_Create() => accountsTests.Test_Create();

        [Fact]
        public void Test_Accounts_Create_WithUniqueAttributes() => accountsTests.Test_Create_WithUniqueAttributes();

        [Fact]
        public void Test_Accounts_Delete_ById() => accountsTests.Test_Delete_ById();

        [Fact]
        public void Test_Accounts_Delete_ByUniqueAttributes() => accountsTests.Test_Delete_ByUniqueAttributes();

        [Fact]
        public void Test_Accounts_Update() => accountsTests.Test_Update_ById();

        [Fact]
        public void Test_Accounts_Update_ByUniqueAttributes() => accountsTests.Test_Update_ByUniqueAttributes();

        [Fact]
        public void Test_Accounts_Upsert() => accountsTests.Test_Upsert();

        [Fact]
        public void Test_Accounts_Get_ById() => accountsTests.Test_Get_ById();

        [Fact]
        public void Test_Accounts_Get_ByUniqueAttributes() => accountsTests.Test_Get_ByUniqueAttributes();
    }
}
