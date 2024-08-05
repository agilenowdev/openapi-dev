/*
 * Accounts API documentation
 *
 * ## Introduction  The OpenAPI Specification (OAS) defines a standard, language-agnostic interface to RESTful APIs which allows both humans and computers to discover and understand the capabilities of the service without access to source code, documentation, or through network traffic inspection. When properly defined, a consumer can understand and interact with the remote service with a minimal amount of implementation logic.    An OpenAPI definition can then be used by documentation generation tools to display the API, code generation tools to generate servers and clients in various programming languages, testing tools, and many other use cases.    | Version | URL | Description |  | - -- | - -- | - -- |  | v3 | https://dev.esystems.fi/Endpoint/rest/Doc/v3/Json/Accounts | Serializes to the Open API document as a string in the JSON format and represents all patches of OpenAPI V3.0 spec (e.g. 3.0.0, 3.0.1). |  | v3 | https://dev.esystems.fi/Endpoint/rest/Doc/v3/Yaml/Accounts | Serializes to the Open API document as a string in the Yaml format and represents all patches of OpenAPI V3.0 spec (e.g. 3.0.0, 3.0.1). |  | v2 | https://dev.esystems.fi/Endpoint/rest/Doc/v2/Json/Accounts | Serializes to the Open API document as a string in the JSON format and represents OpenAPI V2.0 spec.|  | v2 | https://dev.esystems.fi/Endpoint/rest/Doc/v2/Yaml/Accounts | Serializes to the Open API document as a string in the Yaml format and represents OpenAPI V2.0 spec. |
 *
 * The version of the OpenAPI document: 3.0.2
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.Text;
using Agile.Now.ApiAccounts.Api;
using Agile.Now.ApiAccounts.Client;
using Agile.Now.ApiAccounts.Model;
using Xunit;
using Xunit.Abstractions;
namespace Agile.Now.ApiAccounts.Test.Api
{
    /// <summary>
    ///  Class for testing AccountsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AccountsApiTests : IDisposable
    {
        private readonly AccountsApi api;
        private readonly ITestOutputHelper output;

        public AccountsApiTests(ITestOutputHelper testOutputHelper)
        {
            output = testOutputHelper;
            Configuration configuration = new Configuration
            {
                BasePath = "https://dev.esystems.fi",
                OAuthTokenUrl = "https://dev.esystems.fi/oAuth/rest/v2/Token",
                OAuthFlow = Client.Auth.OAuthFlow.APPLICATION,
                OAuthClientId = "c8907421-0886-4fb0-b859-d29966762e16",
                OAuthClientSecret = "1da54fa9-ae11-4db3-9740-1bb47b85cd8e"
            };
            api = new AccountsApi(configuration);
        }

        public void Dispose()
        {
        }

        void AssertAccountDataEqual(AccountData accountData, Account account)
        {
            Assert.Equal(accountData.LastName, account.LastName);
            Assert.Equal(accountData.FirstName, account.FirstName);
            Assert.Equal(accountData.Email, account.Email);
            Assert.Equal(accountData.IsActive, account.IsActive);

            Assert.Equal($"{accountData.LastName} {accountData.FirstName}", account.Name);

            Assert.Equal(accountData.DateFormatId.Value, account.DateFormatId.Id);
            Assert.Equal(accountData.LanguageId.Value, account.LanguageId.Name);
        }

        /// <summary>
        /// Test CreateAccount
        /// </summary>
        [Fact]
        public void Test_Account_Create()
        {
            var accountData = TestAccountData.CreateAccountData();
            var createdAccount = api.CreateAccount(accountData);
            try
            {
                AssertAccountDataEqual(accountData, createdAccount);
                output.WriteLine($"TenantId= {createdAccount.TenantId.Id}");
            }
            finally
            {
                api.DeleteAccount(createdAccount.Id);
            }
        }

        /// <summary>
        /// Test DeleteAccount by Id
        /// </summary>
        [Fact]
        public void Test_Account_Delete_ById()
        {
            var createdAccount = api.CreateAccount(TestAccountData.CreateAccountData());
            api.DeleteAccount(createdAccount.Id);
            Assert.Throws<ApiException>(() => api.GetAccount(createdAccount.Id));
        }

        /// <summary>
        /// Test DeleteAccount by UserName
        /// </summary>
        [Fact]
        public void Test_Account_Delete_ByUserName()
        {
            var createdAccount = api.CreateAccount(TestAccountData.CreateAccountData());
            api.DeleteAccount(createdAccount.Username, "Username");
            Assert.Throws<ApiException>(() => api.GetAccount(createdAccount.Id));
        }

        /// <summary>
        /// Test DeleteAccount with several tenants
        /// </summary>
        [Fact]
        public void Test_Account_Delete_WithSeveralTenants()
        {
            var accountData = TestAccountData.CreateAccountData();
            var createdAccount = api.CreateAccount(accountData);
            try
            {
                var anotherTenant = api.UpsertAccountTenant(createdAccount.Id, new(
                    new("Id", ""),
                    new("Id", TestAccountData.AnotherTenant.ToString())));
                api.DeleteAccount(createdAccount.Id);
                Assert.Null(Record.Exception(() => api.GetAccount(createdAccount.Id)));
                api.DeleteAccountTenant(createdAccount.Id, anotherTenant.UserId.ToString(), subName: "UserId");
                api.DeleteAccount(createdAccount.Id);
                Assert.Throws<ApiException>(() => api.GetAccount(createdAccount.Id));
            }
            finally
            {
                api.DeleteAccount(createdAccount.Id);
            }
        }

        /// <summary>
        /// Test GetAccount by Id
        /// </summary>
        [Fact]
        public void Test_Account_Get_ById()
        {
            var createdAccount = api.CreateAccount(TestAccountData.CreateAccountData());
            try
            {
                Assert.Null(Record.Exception(() =>
                {
                    var existingAccount = api.GetAccount(createdAccount.Id);
                    Assert.Equal(createdAccount.Id, existingAccount.Id);
                    return existingAccount;
                }));
            }
            finally
            {
                api.DeleteAccount(createdAccount.Id);
            }
        }

        /// <summary>
        /// Test GetAccount by UserName
        /// </summary>
        [Fact]
        public void Test_Account_Get_ByUserName()
        {
            var createdAccount = api.CreateAccount(TestAccountData.CreateAccountData());
            try
            {
                Assert.Null(Record.Exception(() =>
                {
                    var existingAccount = api.GetAccount(createdAccount.Username, "Username");
                    Assert.Equal(createdAccount.Username, existingAccount.Username);
                    return existingAccount;
                }));
            }
            finally
            {
                api.DeleteAccount(createdAccount.Id);
            }
        }

        /// <summary>
        /// Test ListAccounts by Id
        /// </summary>
        [Fact]
        public void Test_Account_List_ById()
        {
            var accountData = TestAccountData.CreateAccountDataList(2);
            var createdAccounts = accountData.Select(i => api.CreateAccount(i)).ToArray();
            try
            {
                var existingAccounts = api.ListAccounts(
                    filters: $"Id In {string.Join(", ", createdAccounts.Select(i => i.Id))}").Data;
                Assert.Equal(createdAccounts.Length, existingAccounts.Count);
                Assert.Contains(existingAccounts, i => i.Id == createdAccounts[0].Id);
                Assert.Contains(existingAccounts, i => i.Id == createdAccounts[1].Id);
            }
            finally
            {
                foreach (var i in createdAccounts)
                    api.DeleteAccount(i.Id);
            }
        }

        /// <summary>
        /// Test ListAccounts by UserName
        /// </summary>
        [Fact]
        public void Test_Account_List_ByUserName()
        {
            var accountData = TestAccountData.CreateAccountDataList(2);
            var createdAccounts = accountData.Select(i => api.CreateAccount(i)).ToArray();
            try
            {
                var existingAccounts = api.ListAccounts(
                    filters: $"Username In {string.Join("; ", createdAccounts.Select(i => i.Username))}").Data;
                Assert.Equal(createdAccounts.Length, existingAccounts.Count);
                Assert.Contains(existingAccounts, i => i.Id == createdAccounts[0].Id);
                Assert.Contains(existingAccounts, i => i.Id == createdAccounts[1].Id);
            }
            finally
            {
                foreach (var i in createdAccounts)
                    api.DeleteAccount(i.Id);
            }
        }

        /// <summary>
        /// Test UpdateAccount
        /// </summary>
        [Fact]
        public void Test_Account_Update()
        {
            var accountData = TestAccountData.CreateAccountData();
            var createdAccount = api.CreateAccount(accountData);
            try
            {
                TestAccountData.UpdateAccountData(accountData);
                var updatedAccount = api.UpdateAccount(createdAccount.Id, accountData);
                AssertAccountDataEqual(accountData, updatedAccount);
            }
            finally
            {
                api.DeleteAccount(createdAccount.Id);
            }
        }

        /// <summary>
        /// Test UpdateAccount - tenant does not change
        /// </summary>
        [Fact]
        public void Test_Account_Update_TenantDoesNotChange()
        {
            var accountData = TestAccountData.CreateAccountData();
            var createdAccount = api.CreateAccount(accountData);
            try
            {
                TestAccountData.UpdateAccountData(accountData);
                var oldTenant = createdAccount.TenantId.Id;
                accountData.TenantId = new("Id", (oldTenant + 1).ToString());
                var updatedAccount = api.UpdateAccount(createdAccount.Id, accountData);
                Assert.Equal(oldTenant, updatedAccount.TenantId.Id);
            }
            finally
            {
                api.DeleteAccount(createdAccount.Id);
            }
        }

        /// <summary>
        /// Test UpsertAccount
        /// </summary>
        [Fact]
        public void Test_Account_Upsert()
        {
            var accountData = TestAccountData.CreateAccountData();
            var createdAccount = api.UpsertAccount(accountData);
            try
            {
                AssertAccountDataEqual(accountData, createdAccount);
                TestAccountData.UpdateAccountData(accountData, createdAccount.Id);
                var updatedAccount = api.UpsertAccount(accountData);
                Assert.Equal(createdAccount.Id, updatedAccount.Id);
                AssertAccountDataEqual(accountData, updatedAccount);
            }
            finally
            {
                api.DeleteAccount(createdAccount.Id);
            }
        }

        /// <summary>
        /// Test DeleteAccountTenant
        /// </summary>
        [Fact]
        public void Test_AccountTenant_Delete()
        {
            var accountData = TestAccountData.CreateAccountData();
            var createdAccount = api.CreateAccount(accountData);
            try
            {
                var existingAccountTenants = api.ListAccountTenants(createdAccount.Id).Data;
                var deletedTenant = api.DeleteAccountTenant(
                    createdAccount.Id, existingAccountTenants[0].UserId.ToString(), subName: "UserId");
                existingAccountTenants = api.ListAccountTenants(createdAccount.Id).Data;
                Assert.DoesNotContain(existingAccountTenants, i => i.TenantId.Id == deletedTenant.TenantId.Id);
            }
            finally
            {
                api.DeleteAccount(createdAccount.Id);
            }
        }

        /// <summary>
        /// Test ListAccountTenants
        /// </summary>
        [Fact]
        public void Test_AccountTenant_List()
        {
            var accountData = TestAccountData.CreateAccountData();
            var createdAccount = api.CreateAccount(accountData);
            try
            {
                //var createdTenant = api.UpsertAccountTenant(createdAccount.Id, new(
                //    new("Id", ""),
                //    new("Id", TestAccountData.AnotherTenant.ToString())));
                try
                {
                    var existingAccountTenants = api.ListAccountTenants(createdAccount.Id).Data;
                    Assert.Collection(existingAccountTenants, i => Assert.Equal(createdAccount.Id, i.AccountId.Id));
                }
                finally
                {
                    //api.DeleteAccountTenant(createdAccount.Id, createdTenant.TenantId.Id.ToString(), subName: "UserId");
                }
            }
            finally
            {
                api.DeleteAccount(createdAccount.Id);
            }
        }

        /// <summary>
        /// Test UpsertAccountTenant
        /// </summary>
        [Fact]
        public void Test_AccountTenant_Upsert()
        {
            var accountData = TestAccountData.CreateAccountData();
            var createdAccount = api.CreateAccount(accountData);
            try
            {
                var createdTenant = api.UpsertAccountTenant(createdAccount.Id, new(
                    new("Id", ""),
                    new("Id", TestAccountData.AnotherTenant.ToString())));
                try
                {
                    var existingAccountTenants = api.ListAccountTenants(createdAccount.Id).Data;
                    Assert.Contains(existingAccountTenants, i => createdAccount.Id ==i.AccountId.Id);
                }
                finally
                {
                    api.DeleteAccountTenant(createdAccount.Id, createdTenant.TenantId.Id.ToString(), subName: "UserId");
                }
            }
            finally
            {
                api.DeleteAccount(createdAccount.Id);
            }
        }

        /// <summary>
        /// Test DeleteAccountPicture
        /// </summary>
        [Fact]
        public void Test_AccountPicture_Delete()
        {
            var accountData = TestAccountData.CreateAccountData();
            var createdAccount = api.CreateAccount(accountData);
            try
            {
                var picture = api.UpsertAccountPicture(
                    createdAccount.Id,
                    new(createdAccount.Username + "_picture", TestAccountData.PictureData.ToStream()));
                api.DeleteAccountPicture(createdAccount.Id, null);
            }
            finally
            {
                api.DeleteAccount(createdAccount.Id);
            }
        }

        /// <summary>
        /// Test UpsertAccountPicture
        /// </summary>
        [Fact]
        public void Test_AccountPicture_Upsert()
        {
            var accountData = TestAccountData.CreateAccountData();
            var createdAccount = api.CreateAccount(accountData);
            try
            {
                var picture = api.UpsertAccountPicture(createdAccount.Id,
                    new(createdAccount.Username + "_picture", TestAccountData.PictureData.ToStream()));
                try
                {
                    var existingAccountPictures = api.ListAccountPictures(createdAccount.Id).Data;
                    Assert.Contains(existingAccountPictures, i => i.Filename == picture.Filename);
                }
                finally
                {
                    api.DeleteAccountPicture(createdAccount.Id, null);
                }
            }
            finally
            {
                api.DeleteAccount(createdAccount.Id);
            }
        }

        /// <summary>
        /// Test ListAccountPicture
        /// </summary>
        [Fact]
        public void Test_AccountPicture_List()
        {
            var accountData = TestAccountData.CreateAccountData();
            var createdAccount = api.CreateAccount(accountData);
            try
            {
                var picture = api.UpsertAccountPicture(createdAccount.Id,
                    new(createdAccount.Username + "_picture", TestAccountData.PictureData.ToStream()));
                try
                {
                    var existingAccountPictures = api.ListAccountPictures(createdAccount.Id).Data;
                    Assert.Single(existingAccountPictures);
                    Assert.Contains(existingAccountPictures, i => i.Filename == picture.Filename);
                }
                finally
                {
                    api.DeleteAccountPicture(createdAccount.Id, null);
                }
            }
            finally
            {
                api.DeleteAccount(createdAccount.Id);
            }
        }
    }
}
