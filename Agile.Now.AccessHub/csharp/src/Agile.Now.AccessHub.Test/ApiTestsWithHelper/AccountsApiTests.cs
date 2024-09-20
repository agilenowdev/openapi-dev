using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Api;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.ApiAccounts.Test.Api;
using Agile.Now.ApiOrganizations.Test.Api;
using Xunit;
using Xunit.Abstractions;

namespace Agile.Now.AccessHub.Test.ApiTestsWithHelper {
    public class AccountsApiTests {
        readonly ApiTest test;

        public AccountsApiTests(ITestOutputHelper testOutputHelper) {
            var api = new AccountsApi(Settings.Connections[0]);
            test = new(
                entity: new EntityTest<
                    Account, string,
                    AccountData, AccountData, AccountData>(

                    id: new("Id", entity => entity.Id, (entity, id) => entity.Id = id),
                    updatedId: entity => entity.Id,
                    uniqueAttributes: new Attribute<Account, string, AccountData>[] {
                        new("ExternalId", data => data.ExternalId, (data, value) => data.ExternalId = value),
                        new("Username", data => data.Username, (data, value) => data.Username = value),
                    },
                    methods: new(
                        create: data => api.CreateAccount(data),
                        delete: (id, name) => api.DeleteAccount(id, name),
                        get: (id, name) => api.GetAccount(id, name),
                        update: (id, data, name) => api.UpdateAccount(id, data, name),
                        upsert: data => api.UpsertAccount(data)),
                    testData: new(
                        getCreateData: () => AccountTestData.CreateAccountData(),
                        getUpdateData: data => data,
                        getUpsertData: data => data,
                        update: data => AccountTestData.UpdateAccountData(data),
                        assertEqual: (data, entity) => data.AssertEqual(entity))));
        }

        [Fact]
        public void Test_Accounts_Create() => test.Entity.Test_Create();

        [Fact]
        public void Test_Accounts_Create_WithUniqueAttributes() => test.Entity.Test_Create_WithUniqueAttributes();

        [Fact]
        public void Test_Accounts_Delete_ById() => test.Entity.Test_Delete_ById();

        [Fact]
        public void Test_Accounts_Delete_ByUniqueAttributes() => test.Entity.Test_Delete_ByUniqueAttributes();

        [Fact]
        public void Test_Accounts_Update() => test.Entity.Test_Update_ById();

        [Fact]
        public void Test_Accounts_Update_ByUniqueAttributes() => test.Entity.Test_Update_ByUniqueAttributes();

        [Fact]
        public void Test_Accounts_Upsert() => test.Entity.Test_Upsert();

        [Fact]
        public void Test_Accounts_Get_ById() => test.Entity.Test_Get_ById();

        [Fact]
        public void Test_Accounts_Get_ByUniqueAttributes() => test.Entity.Test_Get_ByUniqueAttributes();
    }
}
