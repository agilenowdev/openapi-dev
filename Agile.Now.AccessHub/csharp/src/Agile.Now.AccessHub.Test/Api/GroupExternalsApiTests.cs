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
using System.Collections.Generic;
using System.Linq;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Client;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.AccessHub.Test.Data;
using Agile.Now.ApiAccessGroups.Test.Api;
using Xunit;
using Xunit.Abstractions;
// uncomment below to import models
//using Agile.Now.AccessHub.Model;

namespace Agile.Now.AccessHub.Test.Api
{
    /// <summary>
    ///  Class for testing GroupExternalsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class GroupExternalsApiTests : IDisposable {
        private readonly GroupExternalsApi api;

        public GroupExternalsApiTests(ITestOutputHelper testOutputHelper) {
            api = new GroupExternalsApi(Settings.Connections[0]);
        }

        public void Dispose() { }

        /// <summary>
        /// Test CreateGroupExternal
        /// </summary>
        [Fact]
        public void Test_GroupExternal_Create() {
            var data = GroupExternalTestData.CreateGroupExternalData();
            var created = api.CreateGroupExternal(data);
            try {
                data.AssertEqual(created);
            }
            finally {
                api.DeleteGroupExternal(created.Id.ToString());
            }
        }

        /// <summary>
        /// Test DeleteGroupExternal by Id
        /// </summary>
        [Fact]
        public void Test_GroupExternal_Delete_ById() {
            var created = api.CreateGroupExternal(GroupExternalTestData.CreateGroupExternalData());
            api.DeleteGroupExternal(created.Id.ToString());
            Assert.Throws<ApiException>(() => api.GetGroupExternal(created.Id.ToString()));
        }

        /// <summary>
        /// Test DeleteGroupExternal by Name
        /// </summary>
        [Fact]
        public void Test_GroupExternal_Delete_ByName() {
            var created = api.CreateGroupExternal(GroupExternalTestData.CreateGroupExternalData());
            api.DeleteGroupExternal(created.Name, "Name");
            Assert.Throws<ApiException>(() => api.GetGroupExternal(created.Id.ToString()));
        }

        /// <summary>
        /// Test GetGroup by Id
        /// </summary>
        [Fact]
        public void Test_GroupExternal_Get_ById() {
            var created = api.CreateGroupExternal(GroupExternalTestData.CreateGroupExternalData());
            try {
                Assert.Null(Record.Exception(() => {
                    var existing = api.GetGroupExternal(created.Id.ToString());
                    Assert.Equal(created.Id, existing.Id);
                    return existing;
                }));
            }
            finally {
                api.DeleteGroupExternal(created.Id.ToString());
            }
        }

        /// <summary>
        /// Test GetGroup by Name
        /// </summary>
        [Fact]
        public void Test_GroupExternal_Get_ByName() {
            var created = api.CreateGroupExternal(GroupExternalTestData.CreateGroupExternalData());
            try {
                Assert.Null(Record.Exception(() => {
                    var existing = api.GetGroupExternal(created.Name, "Name");
                    Assert.Equal(created.Name, existing.Name);
                    return existing;
                }));
            }
            finally {
                api.DeleteGroupExternal(created.Id.ToString());
            }
        }

        /// <summary>
        /// Test ListGroups by Id
        /// </summary>
        [Fact]
        public void Test_GroupExternal_List_ById() {
            var created = CommonTestData.CreateTestDataList(2, GroupExternalTestData.CreateGroupExternalData).
                Select(i => api.CreateGroupExternal(i)).ToArray();
            try {
                var existing = api.ListGroupExternals(
                    filters: $"Id In {string.Join(", ", created.Select(i => i.Id))}").Data;
                Assert.Equal(existing.Count, created.Length);
            }
            finally {
                foreach(var i in created)
                    api.DeleteGroupExternal(i.Id.ToString());
            }
        }

        /// <summary>
        /// Test ListGroups by Name
        /// </summary>
        [Fact]
        public void Test_GroupExternal_List_ByName() {
            var created = CommonTestData.CreateTestDataList(2, GroupExternalTestData.CreateGroupExternalData).
                Select(i => api.CreateGroupExternal(i)).ToArray();
            try {
                var existing = api.ListGroupExternals(
                    filters: $"Name In {string.Join("; ", created.Select(i => i.Name))}");
                Assert.Equal(existing.Data.Count, created.Length);
            }
            finally {
                foreach(var i in created)
                    api.DeleteGroupExternal(i.Id.ToString());
            }
        }

        /// <summary>
        /// Test ListGroupExternals with paging
        /// </summary>
        [Fact]
        public void Test_GroupExternal_List_Paging() {
            var created = CommonTestData.CreateTestDataList(4, GroupExternalTestData.CreateGroupExternalData)
                .Select(i => api.CreateGroupExternal(i)).ToArray();
            try {
                var filters = $"Name In {string.Join("; ", created.Select(i => i.Name))}";
                var pageSize = 2;
                var pages = new[] {
                    api.ListGroupExternals(filters: filters, currentPage: 0, pageSize: pageSize).Data,
                    api.ListGroupExternals(filters: filters, currentPage: 1, pageSize: pageSize).Data,
                };
                Assert.Equal(pageSize, pages[0].Count);
                Assert.Equal(pageSize, pages[1].Count);
                Assert.Equal(created.Length, pages[0].Concat(pages[1]).GroupBy(i => i.Id).Count());
            }
            finally {
                foreach(var i in created)
                    api.DeleteGroupExternal(i.Id.ToString());
            }
        }

        /// <summary>
        /// Test UpdateGroup
        /// </summary>
        [Fact]
        public void Test_GroupExternal_Update() {
            var data = GroupExternalTestData.CreateGroupExternalData();
            var created = api.CreateGroupExternal(data);
            try {
                data.Update();
                var updated = api.UpdateGroupExternal(created.Id.ToString(), data);
                Assert.Equal(created.Id, updated.Id);
                data.AssertEqual(updated);
            }
            finally {
                api.DeleteGroupExternal(created.Id.ToString());
            }
        }

        /// <summary>
        /// Test UpsertGroup
        /// </summary>
        [Fact]
        public void Test_GroupExternal_Upsert() {
            var data = GroupExternalTestData.CreateGroupExternalData();
            var created = api.UpsertGroupExternal(data);
            try {
                data.AssertEqual(created);
                data.Update();
                data.Id = created.Id;
                var updated = api.UpsertGroupExternal(data);
                Assert.Equal(created.Id, updated.Id);
                data.AssertEqual(updated);
            }
            finally {
                api.DeleteGroupExternal(created.Id.ToString());
            }
        }

        /// <summary>
        /// Test PatchGroup
        /// </summary>
        [Fact]
        public void Test_GroupExternal_Patch() {
            var dataForUpdate = GroupExternalTestData.CreateGroupExternalData();
            var dataForCreate = GroupExternalTestData.CreateGroupExternalData();
            var updated = api.CreateGroupExternal(dataForUpdate);
            dataForUpdate.Id = updated.Id;
            dataForUpdate.Update();
            try {
                var patched = api.PatchGroupExternals(new(groupExternals: new List<GroupExternalText> {
                    dataForUpdate.ToGroupExternalText(),
                    dataForCreate.ToGroupExternalText()
                })).Data;
                var created = patched.First(i => i.Id != updated.Id);
                try {
                    var existing = api.ListGroupExternals(
                        filters: $"Id In {string.Join(", ", patched.Select(i => i.Id))}").Data;
                    Assert.Contains(existing, i => dataForUpdate.DataEqual(i) && dataForUpdate.Id == updated.Id);
                    Assert.Contains(existing, i => dataForCreate.DataEqual(i));
                }
                finally {
                    api.DeleteGroupExternal(created.Id.ToString());
                }
            }
            finally {
                api.DeleteGroupExternal(updated.Id.ToString());
            }
        }

        /// <summary>
        /// Test DeleteGroupExternalUserExternal
        /// </summary>
        [Fact]
        public void Test_GroupExternal_UserExternal_Delete() {
            var entity = api.CreateGroupExternal(GroupExternalTestData.CreateGroupExternalData());
            try {
                var created = api.UpsertGroupExternalUserExternal(entity.Id.ToString(),
                    GroupExternalTestData.CreateUserExternalData(UserTestData.Users[0]));
                api.DeleteGroupExternalUserExternal(entity.Id.ToString(), created.Id.ToString());
                var existing = api.ListGroupExternalUserExternals(entity.Id.ToString()).Data;
                Assert.Empty(existing);
            }
            finally {
                api.DeleteGroupExternal(entity.Id.ToString());
            }
        }

        /// <summary>
        /// Test ListGroupExternalUserExternals
        /// </summary>
        [Fact]
        public void Test_GroupExternal_UserExternal_List() {
            var entity = api.CreateGroupExternal(GroupExternalTestData.CreateGroupExternalData());
            try {
                var created = UserTestData.Users.Select(i =>
                    api.UpsertGroupExternalUserExternal(entity.Id.ToString(),
                        GroupExternalTestData.CreateUserExternalData(i))).ToArray();
                var existing = api.ListGroupExternalUserExternals(entity.Id.ToString()).Data;
                Assert.Equal(created.Length, existing.Count);
            }
            finally {
                api.DeleteGroupExternal(entity.Id.ToString());
            }
        }

        /// <summary>
        /// Test UpsertGroupExternalUser
        /// </summary>
        [Fact]
        public void Test_GroupExternal_UserExternal_Upsert() {
            var entity = api.CreateGroupExternal(GroupExternalTestData.CreateGroupExternalData());
            try {
                var data = GroupExternalTestData.CreateUserExternalData(UserTestData.Users[0]);
                var created = api.UpsertGroupExternalUserExternal(entity.Id.ToString(), data);
                try {
                    var existing = api.ListGroupExternalUserExternals(entity.Id.ToString()).Data;
                    Assert.Contains(existing, i => i.Id == created.Id);
                    data = GroupExternalTestData.CreateUserExternalData(UserTestData.Users[1]);
                    data.Id = created.Id;
                    var updated = api.UpsertGroupExternalUserExternal(entity.Id.ToString(), data);
                    Assert.Equal(created.Id, updated.Id);
                    Assert.Equal(data.UserId.Value, updated.UserId.Id.ToString());
                }
                finally {
                    api.DeleteGroupExternalUserExternal(entity.Id.ToString(), created.Id.ToString());
                }
            }
            finally {
                api.DeleteGroupExternal(entity.Id.ToString());
            }
        }

        /// <summary>
        /// Test PatchGroupExternalUser
        /// </summary>
        [Fact]
        public void Test_GroupExternal_UserExternal_Patch() {
            var entity = api.CreateGroupExternal(GroupExternalTestData.CreateGroupExternalData());
            try {
                var created = api.UpsertGroupExternalUserExternal(entity.Id.ToString(),
                    GroupExternalTestData.CreateUserExternalData(UserTestData.Users[0]));
                try {
                    var patched = api.PatchGroupExternalUserExternals(entity.Id.ToString(),
                        new(userExternals: new List<UserExternalText> {
                            new(userId: UserTestData.Users[1].ToString()),
                            new(userId: UserTestData.Users[2].ToString(), id: created.Id)
                        })).Data;
                    try {
                        var existing = api.ListGroupExternalUserExternals(entity.Id.ToString()).Data;
                        Assert.Contains(existing, i => i.UserId.Id == UserTestData.Users[1]);
                        Assert.Contains(existing, i => i.UserId.Id == UserTestData.Users[2] && i.Id == created.Id);
                    }
                    finally {
                        api.DeleteGroupExternalUserExternal(entity.Id.ToString(),
                            patched.First(i => i.Id != created.Id).Id.ToString());
                    }
                }
                finally {
                    api.DeleteGroupExternalUserExternal(entity.Id.ToString(), created.Id.ToString());
                }
            }
            finally {
                api.DeleteGroupExternal(entity.Id.ToString());
            }
        }

        /// <summary>
        /// Test PatchGroupExternalUsers with deleteNotExists
        /// </summary>
        [Fact]
        public void Test_GroupExternal_User_PatchExternal_DeleteNotExists() {
            var entity = api.CreateGroupExternal(GroupExternalTestData.CreateGroupExternalData());
            try {
                var toDelete = api.UpsertGroupExternalUserExternal(entity.Id.ToString(),
                    GroupExternalTestData.CreateUserExternalData(UserTestData.Users[0]));
                var toPatch = api.UpsertGroupExternalUserExternal(entity.Id.ToString(),
                    GroupExternalTestData.CreateUserExternalData(UserTestData.Users[1]));
                try {
                    api.PatchGroupExternalUserExternals(entity.Id.ToString(),
                        new(userExternals: new List<UserExternalText> {
                            new(userId: UserTestData.Users[2].ToString(), id: toPatch.Id)
                        }),
                        deleteNotExists: true.ToString());
                    toDelete = null;
                    var existing = api.ListGroupExternalUserExternals(entity.Id.ToString()).Data;
                    Assert.Single(existing);
                    Assert.Contains(existing,
                        i => i.UserId.Id == UserTestData.Users[2] && i.Id == toPatch.Id);
                }
                finally {
                    if(toDelete != null)
                        api.DeleteGroupExternalUserExternal(entity.Id.ToString(), toDelete.Id.ToString());
                    api.DeleteGroupExternalUserExternal(entity.Id.ToString(), toPatch.Id.ToString());
                }
            }
            finally {
                api.DeleteGroupExternal(entity.Id.ToString());
            }
        }
    }
}
