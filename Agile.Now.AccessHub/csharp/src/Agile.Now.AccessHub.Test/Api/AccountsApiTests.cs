/*
 * Agile.Now.AccessHub API
 *
 * Agile.Now.AccessHub is a secure REST API designed to manage accounts, access groups, user groups, organizations, locations, applications, roles, and webhooks. This API provides a robust and scalable solution for managing user access and organizational structures in a multi-tenant environment.
 *
 * The version of the OpenAPI document: 2.0.1
 * Contact: dev@agilenow.io
 *
 * BSD 3-Clause License
 * 
 * Copyright (c) 2024, eSystems Nordic Ltd.
 * All rights reserved.
 * 
 * Redistribution and use in source and binary forms, with or without modification,
 * are permitted provided that the following conditions are met:
 * 
 * 1. Redistributions of source code must retain the above copyright notice, this list
 *    of conditions and the following disclaimer.
 * 2. Redistributions in binary form must reproduce the above copyright notice, this
 *    list of conditions and the following disclaimer in the documentation and/or other
 *    materials provided with the distribution.
 * 3. Neither the name of the copyright holder nor the names of its contributors may be
 *    used to endorse or promote products derived from this software without specific
 *    prior written permission.
 * 
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY
 * EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES
 * OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT
 * SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT,
 * INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED
 * TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR
 * BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
 * CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN
 * ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH
 * DAMAGE.
 */

using System;
using System.Data;
using System.Linq;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Client;
// uncomment below to import models
using Agile.Now.AccessHub.Test.Data;
using Agile.Now.ApiAccessGroups.Test.Api;
using Agile.Now.ApiAccounts.Test.Api;
using Xunit;
using Xunit.Abstractions;

namespace Agile.Now.AccessHub.Test.Api {
    /// <summary>
    ///  Class for testing AccountsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AccountsApiTests : IDisposable {
        private readonly AccountsApi api;
        private readonly ITestOutputHelper output;

        public AccountsApiTests(ITestOutputHelper testOutputHelper) {
            output = testOutputHelper;
            api = new AccountsApi(Settings.Connections[0]);
        }

        public void Dispose() { }

        /// <summary>
        /// Test CreateAccount
        /// </summary>
        [Fact]
        public void Test_Account_Create() {
            var data = AccountTestData.CreateAccountData();
            var created = api.CreateAccount(data);
            try {
                data.AssertEqual(created);
                output.WriteLine($"TenantId= {created.TenantId.Id}");
            }
            finally {
                api.DeleteAccount(created.Id);
            }
        }

        [Fact]
        public void Test_Account_Create_WithExternalId() {
            var externalId = Guid.NewGuid().ToString();
            var data = AccountTestData.CreateAccountData();
            data.ExternalId = externalId;
            var created = api.CreateAccount(data);
            try {
                data = AccountTestData.CreateAccountData();
                data.ExternalId = externalId;
                Assert.Throws<ApiException>(() => api.CreateAccount(data));
            }
            finally {
                api.DeleteAccount(created.Id);
            }
        }

        /// <summary>
        /// Test DeleteAccount by Id
        /// </summary>
        [Fact]
        public void Test_Account_Delete_ById() {
            var created = api.CreateAccount(AccountTestData.CreateAccountData());
            api.DeleteAccount(created.Id);
            Assert.Throws<ApiException>(() => api.GetAccount(created.Id));
        }

        /// <summary>
        /// Test DeleteAccount by UserName
        /// </summary>
        [Fact]
        public void Test_Account_Delete_ByUserName() {
            var created = api.CreateAccount(AccountTestData.CreateAccountData());
            api.DeleteAccount(created.Username, "Username");
            Assert.Throws<ApiException>(() => api.GetAccount(created.Id));
        }

        /// <summary>
        /// Test DeleteAccount with several tenants
        /// </summary>
        [Fact]
        public void Test_Account_Delete_WithSeveralTenants() {
            var created = api.CreateAccount(AccountTestData.CreateAccountData());
            try {
                var anotherTenant = api.UpsertAccountTenant(created.Id, new(
                    new("Id", ""),
                    new("Id", AccountTestData.AnotherTenant.ToString())));
                api.DeleteAccount(created.Id);
                Assert.Null(Record.Exception(() => api.GetAccount(created.Id)));
                api.DeleteAccountTenant(created.Id, anotherTenant.Id.ToString(), subName: "UserId");
                api.DeleteAccount(created.Id);
                Assert.Throws<ApiException>(() => api.GetAccount(created.Id));
            }
            finally {
                api.DeleteAccount(created.Id);
            }
        }

        /// <summary>
        /// Test GetAccount by Id
        /// </summary>
        [Fact]
        public void Test_Account_Get_ById() {
            var created = api.CreateAccount(AccountTestData.CreateAccountData());
            try {
                Assert.Null(Record.Exception(() => {
                    var existing = api.GetAccount(created.Id);
                    Assert.Equal(created.Id, existing.Id);
                    return existing;
                }));
            }
            finally {
                api.DeleteAccount(created.Id);
            }
        }

        /// <summary>
        /// Test GetAccount by UserName
        /// </summary>
        [Fact]
        public void Test_Account_Get_ByUserName() {
            var created = api.CreateAccount(AccountTestData.CreateAccountData());
            try {
                Assert.Null(Record.Exception(() => {
                    var existing = api.GetAccount(created.Username, "Username");
                    Assert.Equal(created.Username, existing.Username);
                    return existing;
                }));
            }
            finally {
                api.DeleteAccount(created.Id);
            }
        }

        /// <summary>
        /// Test ListAccounts by Id
        /// </summary>
        [Fact]
        public void Test_Account_List_ById() {
            var created = CommonTestData.CreateTestDataList(2, AccountTestData.CreateAccountData).
                Select(i => api.CreateAccount(i)).ToArray();
            try {
                var existing = api.ListAccounts(
                    filters: $"Id In {string.Join("; ", created.Select(i => i.Id))}").Data;
                Assert.Equal(created.Length, existing.Count);
            }
            finally {
                foreach(var i in created)
                    api.DeleteAccount(i.Id);
            }
        }

        /// <summary>
        /// Test ListAccounts by UserName
        /// </summary>
        [Fact]
        public void Test_Account_List_ByUserName() {
            var created = CommonTestData.CreateTestDataList(2, AccountTestData.CreateAccountData).
                Select(i => api.CreateAccount(i)).ToArray();
            try {
                var existing = api.ListAccounts(
                    filters: $"Username In {string.Join("; ", created.Select(i => i.Username))}").Data;
                Assert.Equal(created.Length, existing.Count);
            }
            finally {
                foreach(var i in created)
                    api.DeleteAccount(i.Id);
            }
        }

        /// <summary>
        /// Test ListAccounts with paging
        /// </summary>
        [Fact]
        public void Test_Account_List_Paging() {
            var created = CommonTestData.CreateTestDataList(4, AccountTestData.CreateAccountData)
                .Select(i => api.CreateAccount(i)).ToArray();
            try {
                var filters = $"Name In {string.Join("; ", created.Select(i => i.Name))}";
                var pageSize = 2;
                var pages = new[] {
                    api.ListAccounts(filters: filters, currentPage: 0, pageSize: pageSize).Data,
                    api.ListAccounts(filters: filters, currentPage: 1, pageSize: pageSize).Data,
                };
                Assert.Equal(pageSize, pages[0].Count);
                Assert.Equal(pageSize, pages[1].Count);
                Assert.Equal(created.Length, pages[0].Concat(pages[1]).GroupBy(i => i.Id).Count());
            }
            finally {
                foreach(var i in created)
                    api.DeleteAccount(i.Id.ToString());
            }
        }

        /// <summary>
        /// Test UpdateAccount
        /// </summary>
        [Fact]
        public void Test_Account_Update() {
            var data = AccountTestData.CreateAccountData();
            var created = api.CreateAccount(data);
            try {
                AccountTestData.UpdateAccountData(data);
                var updated = api.UpdateAccount(created.Id, data);
                data.AssertEqual(updated);
            }
            finally {
                api.DeleteAccount(created.Id);
            }
        }

        /// <summary>
        /// Test UpsertAccount
        /// </summary>
        [Fact]
        public void Test_Account_Upsert() {
            var data = AccountTestData.CreateAccountData();
            var created = api.UpsertAccount(data);
            try {
                data.AssertEqual(created);
                AccountTestData.UpdateAccountData(data);
                data.Id = created.Id;
                var updated = api.UpsertAccount(data);
                Assert.Equal(created.Id, updated.Id);
                data.AssertEqual(updated);
            }
            finally {
                api.DeleteAccount(created.Id);
            }
        }

        /// <summary>
        /// Test DeleteAccountTenant
        /// </summary>
        [Fact]
        public void Test_AccountTenant_Delete() {
            var entity = api.CreateAccount(AccountTestData.CreateAccountData());
            try {
                var existing = api.ListAccountTenants(entity.Id).Data;
                var deleted = api.DeleteAccountTenant(entity.Id, existing[0].Id.ToString());
                existing = api.ListAccountTenants(entity.Id).Data;
                Assert.DoesNotContain(existing, i => i.Id == deleted.Id);
            }
            finally {
                api.DeleteAccount(entity.Id);
            }
        }

        /// <summary>
        /// Test ListAccountTenants
        /// </summary>
        [Fact]
        public void Test_AccountTenant_List() {
            var created = api.CreateAccount(AccountTestData.CreateAccountData());
            try {

                var existingSubEntities = api.ListAccountTenants(created.Id).Data;
                Assert.Contains(existingSubEntities, i => i.Id == created.TenantId.Id);
            }
            finally {
                api.DeleteAccount(created.Id);
            }
        }

        /// <summary>
        /// Test UpsertAccountTenant
        /// </summary>
        [Fact]
        public void Test_AccountTenant_Upsert() {
            // WIP
            var entity = api.CreateAccount(AccountTestData.CreateAccountData());
            try {
                var created = api.UpsertAccountTenant(entity.Id, new(
                    userId: new("Id", UserTestData.Users[0].ToString()),
                    tenantId: new("Id", AccountTestData.AnotherTenant.ToString())));
                try {
                    var existingSubEntities = api.ListAccountTenants(entity.Id).Data;
                    //Assert.Contains(existingEntityTenants, i => created.Id == i.AccountId.Id);
                }
                finally {
                    //api.DeleteAccountTenant(created.Id, createdSubEntity.TenantId.Id.ToString(), subName: "UserId");
                    //api.DeleteAccountTenant("78b8f190-834a-4501-a2c7-ea173b327936",
                    //    "34560", subName: "UserId");
                }
            }
            finally {
                api.DeleteAccount(entity.Id);
            }
        }

        /// <summary>
        /// Test DeleteAccountPicture
        /// </summary>
        [Fact]
        public void Test_AccountPicture_Delete() {
            var created = api.CreateAccount(AccountTestData.CreateAccountData());
            try {
                var createdSubEntity = api.UpsertAccountPicture(
                    created.Id,
                    new(created.Username + "_picture", AccountTestData.PictureData.ToStream()));
                api.DeleteAccountPicture(created.Id, null);
            }
            finally {
                api.DeleteAccount(created.Id);
            }
        }

        /// <summary>
        /// Test UpsertAccountPicture
        /// </summary>
        [Fact]
        public void Test_AccountPicture_Upsert() {
            var created = api.CreateAccount(AccountTestData.CreateAccountData());
            try {
                var createdSubEntity = api.UpsertAccountPicture(created.Id,
                    new(created.Username + "_picture", AccountTestData.PictureData.ToStream()), name: "AccountId");
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

        /// <summary>
        /// Test ListAccountPicture
        /// </summary>
        [Fact]
        public void Test_AccountPicture_List() {
            var created = api.CreateAccount(AccountTestData.CreateAccountData());
            try {
                var createdSubEntity = api.UpsertAccountPicture(created.Id,
                    new(created.Username + "_picture", AccountTestData.PictureData.ToStream()));
                try {
                    var existingSubEntities = api.ListAccountPictures(created.Id).Data;
                    Assert.Single(existingSubEntities);
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
}
