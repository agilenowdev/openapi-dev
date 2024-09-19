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
using Agile.Now.ApiOrganizations.Test.Api;
using Xunit;
using Xunit.Abstractions;
// uncomment below to import models
//using Agile.Now.AccessHub.Model;

namespace Agile.Now.AccessHub.Test.Api
{
    /// <summary>
    ///  Class for testing AccessGroupsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AccessGroupsApiTests : IDisposable {
        private readonly AccessGroupsApi api;

        public AccessGroupsApiTests(ITestOutputHelper testOutputHelper) {
            api = new AccessGroupsApi(Settings.Connections[0]);
        }

        public void Dispose() { }

        /// <summary>
        /// Test CreateAccessGroup
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Create() {
            var data = AccessGroupTestData.CreateAccessGroupData();
            var created = api.CreateAccessGroup(data);
            try {
                data.AssertEqual(created);
            }
            finally {
                api.DeleteAccessGroup(created.Id);
            }
        }

        /// <summary>
        /// Test CreateAccessGroup - unique ExternalId
        /// </summary>

        [Fact]
        public void Test_AccessGroup_Create_UniqueExternalId() {
            var externalId = Guid.NewGuid().ToString();
            var data = AccessGroupTestData.CreateAccessGroupData();
            data.ExternalId = externalId;
            var created = api.CreateAccessGroup(data);
            try {
                data = AccessGroupTestData.CreateAccessGroupData();
                data.ExternalId = externalId;
                Assert.Throws<ApiException>(() => api.CreateAccessGroup(data));
            }
            finally {
                api.DeleteAccessGroup(created.Id);
            }
        }

        /// <summary>
        /// Test DeleteAccessGroup by Id
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Delete_ById() {
            var created = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData());
            api.DeleteAccessGroup(created.Id);
            Assert.Throws<ApiException>(() => api.GetAccessGroup(created.Id));
        }

        /// <summary>
        /// Test DeleteAccessGroup by Name
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Delete_ByName() {
            var created = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData());
            api.DeleteAccessGroup(created.Name, "Name");
            Assert.Throws<ApiException>(() => api.GetAccessGroup(created.Id));
        }

        /// <summary>
        /// Test GetAccessGroup by Id
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Get_ById() {
            var created = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData());
            try {
                Assert.Null(Record.Exception(() => {
                    var existing = api.GetAccessGroup(created.Id);
                    Assert.Equal(created.Id, existing.Id);
                    return existing;
                }));
            }
            finally {
                api.DeleteAccessGroup(created.Id);
            }
        }

        /// <summary>
        /// Test GetAccessGroup by Name
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Get_ByName() {
            var created = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData());
            try {
                Assert.Null(Record.Exception(() => {
                    var existing = api.GetAccessGroup(created.Name, "Name");
                    Assert.Equal(created.Name, existing.Name);
                    return existing;
                }));
            }
            finally {
                api.DeleteAccessGroup(created.Id);
            }
        }

        /// <summary>
        /// Test ListAccessGroups by Id
        /// </summary>
        [Fact]
        public void Test_AccessGroup_List_ById() {
            var created = CommonTestData.CreateTestDataList(2, AccessGroupTestData.CreateAccessGroupData).
                Select(i => api.CreateAccessGroup(i)).ToArray();
            try {
                var existingEntities = api.ListAccessGroups(
                    filters: $"Id In {string.Join("; ", created.Select(i => i.Id))}").Data;
                Assert.Equal(existingEntities.Count, created.Length);
            }
            finally {
                foreach(var i in created)
                    api.DeleteAccessGroup(i.Id);
            }
        }

        /// <summary>
        /// Test ListAccessGroups by Name
        /// </summary>
        [Fact]
        public void Test_AccessGroup_List_ByName() {
            var created = CommonTestData.CreateTestDataList(2, AccessGroupTestData.CreateAccessGroupData).
                Select(i => api.CreateAccessGroup(i)).ToArray();
            try {
                var existingEntities = api.ListAccessGroups(
                    filters: $"Name In {string.Join("; ", created.Select(i => i.Name))}").Data;
                Assert.Equal(existingEntities.Count, created.Length);
            }
            finally {
                foreach(var i in created)
                    api.DeleteAccessGroup(i.Id);
            }
        }

        /// <summary>
        /// Test ListAccessGroups with paging
        /// </summary>
        [Fact]
        public void Test_AccessGroup_List_Paging() {
            var created = CommonTestData.CreateTestDataList(4, AccessGroupTestData.CreateAccessGroupData)
                .Select(i => api.CreateAccessGroup(i)).ToArray();
            try {
                var filters = $"Name In {string.Join("; ", created.Select(i => i.Name))}";
                var pageSize = 2;
                var pages = new[] {
                    api.ListAccessGroups(filters: filters, currentPage: 0, pageSize: pageSize).Data,
                    api.ListAccessGroups(filters: filters, currentPage: 1, pageSize: pageSize).Data,
                };
                Assert.Equal(pageSize, pages[0].Count);
                Assert.Equal(pageSize, pages[1].Count);
                Assert.Equal(created.Length, pages[0].Concat(pages[1]).GroupBy(i => i.Id).Count());
            }
            finally {
                foreach(var i in created)
                    api.DeleteAccessGroup(i.Id);
            }
        }

        /// <summary>
        /// Test UpdateAccessGroup
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Update() {
            var data = AccessGroupTestData.CreateAccessGroupData();
            var created = api.CreateAccessGroup(data);
            try {
                data.Update();
                var updated = api.UpdateAccessGroup(created.Id, data);
                Assert.Equal(created.Id, updated.Id);
                data.AssertEqual(updated);
            }
            finally {
                api.DeleteAccessGroup(created.Id);
            }
        }

        /// <summary>
        /// Test UpsertAccessGroup
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Upsert() {
            var data = AccessGroupTestData.CreateAccessGroupData();
            var created = api.UpsertAccessGroup(data);
            try {
                data.AssertEqual(created);
                data.Update();
                data.Id = created.Id;
                var updated = api.UpsertAccessGroup(data);
                Assert.Equal(created.Id, updated.Id);
                data.AssertEqual(updated);
            }
            finally {
                api.DeleteAccessGroup(created.Id);
            }
        }

        /// <summary>
        /// Test DeleteAccessGroupApplication
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Application_Delete() {
            var entity = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData());
            try {
                var created = api.UpsertAccessGroupApplication(entity.Id,
                    AccessGroupTestData.CreateApplicationData(AccessGroupTestData.Applications[0]));
                api.DeleteAccessGroupApplication(entity.Id, created.Id);
                var existing = api.ListAccessGroupApplications(entity.Id).Data;
                Assert.Empty(existing);
            }
            finally {
                api.DeleteAccessGroup(entity.Id);
            }
        }

        /// <summary>
        /// Test ListAccessGroupAccessApplications
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Application_List() {
            var entity = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData());
            try {
                var created = AccessGroupTestData.Applications.Select(i =>
                    api.UpsertAccessGroupApplication(entity.Id,
                        AccessGroupTestData.CreateApplicationData(i))).ToArray();
                var existing = api.ListAccessGroupApplications(entity.Id).Data;
                Assert.Equal(created.Length, existing.Count);
            }
            finally {
                api.DeleteAccessGroup(entity.Id);
            }
        }

        /// <summary>
        /// Test UpsertAccessGroupApplication
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Application_Upsert() {
            var entity = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData());
            try {
                var data = AccessGroupTestData.CreateApplicationData(AccessGroupTestData.Applications[0]);
                var created = api.UpsertAccessGroupApplication(entity.Id, data);
                try {
                    var existing = api.ListAccessGroupApplications(entity.Id).Data;
                    Assert.Contains(existing, i => i.Id == created.Id);
                    data = AccessGroupTestData.CreateApplicationData(AccessGroupTestData.Applications[1]);
                    data.Id = created.Id;
                    var updated = api.UpsertAccessGroupApplication(entity.Id, data);
                    Assert.Equal(created.Id, updated.Id);
                    Assert.Equal(data.AccessApplicationId.Value, updated.AccessApplicationId.Id.ToString());
                }
                finally {
                    api.DeleteAccessGroupApplication(entity.Id, created.Id);
                }
            }
            finally {
                api.DeleteAccessGroup(entity.Id);
            }
        }

        /// <summary>
        /// Test PatchAccessGroupApplication
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Application_Patch() {
            var entity = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData());
            try {
                var created = api.UpsertAccessGroupApplication(entity.Id.ToString(),
                    AccessGroupTestData.CreateApplicationData(AccessGroupTestData.Applications[0]));
                try {
                    var patched = api.PatchAccessGroupApplications(entity.Id.ToString(),
                        new(applications: new List<ApplicationText> {
                            AccessGroupTestData.CreateApplicationText(
                                AccessGroupTestData.Applications[1].ToString()),
                            AccessGroupTestData.CreateApplicationText(
                                AccessGroupTestData.Applications[2].ToString(), id: created.Id)
                        })).Data;
                    try {
                        var existing = api.ListAccessGroupApplications(entity.Id.ToString()).Data;
                        Assert.Contains(existing,
                            i => i.AccessApplicationId.Id == AccessGroupTestData.Applications[1]);
                        Assert.Contains(existing,
                            i => i.AccessApplicationId.Id == AccessGroupTestData.Applications[2] && i.Id == created.Id);
                    }
                    finally {
                        api.DeleteAccessGroupApplication(entity.Id, patched.First(i => i.Id != created.Id).Id);
                    }
                }
                finally {
                    api.DeleteAccessGroupApplication(entity.Id, created.Id);
                }
            }
            finally {
                api.DeleteAccessGroup(entity.Id.ToString());
            }
        }

        /// <summary>
        /// Test PatchAccessGroupApplications with deleteNotExists
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Application_Patch_DeleteNotExists() {
            var entity = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData());
            try {
                var toDelete = api.UpsertAccessGroupApplication(entity.Id,
                    AccessGroupTestData.CreateApplicationData(AccessGroupTestData.Applications[0]));
                var toPatch = api.UpsertAccessGroupApplication(entity.Id,
                    AccessGroupTestData.CreateApplicationData(AccessGroupTestData.Applications[1]));
                try {
                    api.PatchAccessGroupApplications(entity.Id.ToString(),
                        new(applications: new List<ApplicationText> {
                            AccessGroupTestData.CreateApplicationText(
                                AccessGroupTestData.Applications[2].ToString(), id: toPatch.Id)
                        }),
                        deleteNotExists: true.ToString());
                    toDelete = null;
                    var existing = api.ListAccessGroupApplications(entity.Id.ToString()).Data;
                    Assert.Single(existing);
                    Assert.Contains(existing,
                        i => i.AccessApplicationId.Id == AccessGroupTestData.Applications[2] && i.Id == toPatch.Id);
                }
                finally {
                    if(toDelete != null)
                        api.DeleteAccessGroupApplication(entity.Id, toDelete.Id);
                    api.DeleteAccessGroupApplication(entity.Id, toPatch.Id);
                }
            }
            finally {
                api.DeleteAccessGroup(entity.Id.ToString());
            }
        }

        /// <summary>
        /// Test DeleteAccessGroupPermission
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Permission_Delete() {
            var entity = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData());
            try {
                var created = api.UpsertAccessGroupPermission(entity.Id,
                    AccessGroupTestData.CreatePermissionData(AccessGroupTestData.Permissions[0]));
                api.DeleteAccessGroupPermission(entity.Id.ToString(), created.Id.ToString());
                var existing = api.ListAccessGroupPermissions(entity.Id).Data;
                Assert.Empty(existing);
            }
            finally {
                api.DeleteAccessGroup(entity.Id);
            }
        }

        /// <summary>
        /// Test ListAccessGroupAccessPermissions
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Permission_List() {
            var entity = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData());
            try {
                var created = AccessGroupTestData.Permissions.Select(i =>
                    api.UpsertAccessGroupPermission(entity.Id,
                        AccessGroupTestData.CreatePermissionData(i))).ToArray();
                var existing = api.ListAccessGroupPermissions(entity.Id).Data;
                Assert.Equal(created.Length, existing.Count);
            }
            finally {
                api.DeleteAccessGroup(entity.Id);
            }
        }

        /// <summary>
        /// Test UpsertAccessGroupPermission
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Permission_Upsert() {
            var entity = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData());
            try {
                var data = AccessGroupTestData.CreatePermissionData(AccessGroupTestData.Permissions[0]);
                var created = api.UpsertAccessGroupPermission(entity.Id, data);
                try {
                    var existing = api.ListAccessGroupPermissions(entity.Id).Data;
                    Assert.Contains(existing, i => i.Id == created.Id);
                    data = AccessGroupTestData.CreatePermissionData(AccessGroupTestData.Permissions[1]);
                    data.Id = created.Id;
                    var updated = api.UpsertAccessGroupPermission(entity.Id, data);
                    Assert.Equal(created.Id, updated.Id);
                    Assert.Equal(data.PermissionId.ToString(), updated.PermissionId.Id.ToString());
                }
                finally {
                    api.DeleteAccessGroupPermission(entity.Id.ToString(), created.Id.ToString());
                }
            }
            finally {
                api.DeleteAccessGroup(entity.Id);
            }
        }

        /// <summary>
        /// Test PatchAccessGroupPermissions
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Permission_Patch() {
            var entity = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData());
            try {
                var created = api.UpsertAccessGroupPermission(entity.Id.ToString(),
                    AccessGroupTestData.CreatePermissionData(AccessGroupTestData.Permissions[0]));
                try {
                    var patched = api.PatchAccessGroupPermissions(entity.Id.ToString(),
                        new(permissions: new List<PermissionText> {
                            new(permissionId: AccessGroupTestData.Permissions[1].ToString()),
                            new(permissionId: AccessGroupTestData.Permissions[2].ToString(), id: created.Id)
                        })).Data;
                    try {
                        var existing = api.ListAccessGroupPermissions(entity.Id.ToString()).Data;
                        Assert.Contains(existing,
                            i => i.PermissionId.Id == AccessGroupTestData.Permissions[1].ToString());
                        Assert.Contains(existing,
                            i => i.PermissionId.Id == AccessGroupTestData.Permissions[2].ToString() && i.Id == created.Id);
                    }
                    finally {
                        api.DeleteAccessGroupPermission(entity.Id.ToString(), patched.First(i => i.Id != created.Id).Id.ToString());
                    }
                }
                finally {
                    api.DeleteAccessGroupPermission(entity.Id.ToString(), created.Id.ToString());
                }
            }
            finally {
                api.DeleteAccessGroup(entity.Id.ToString());
            }
        }

        /// <summary>
        /// Test PatchAccessGroupPermissions with deleteNotExists
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Permission_Patch_DeleteNotExists() {
            var entity = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData());
            try {
                var toDelete = api.UpsertAccessGroupPermission(entity.Id,
                    AccessGroupTestData.CreatePermissionData(AccessGroupTestData.Permissions[0]));
                var toPatch = api.UpsertAccessGroupPermission(entity.Id,
                    AccessGroupTestData.CreatePermissionData(AccessGroupTestData.Permissions[1]));
                try {
                    api.PatchAccessGroupPermissions(entity.Id.ToString(),
                        new(permissions: new List<PermissionText> {
                            new(permissionId: AccessGroupTestData.Permissions[2].ToString(), id: toPatch.Id)
                        }),
                        deleteNotExists: true.ToString());
                    toDelete = null;
                    var existing = api.ListAccessGroupPermissions(entity.Id.ToString()).Data;
                    Assert.Single(existing);
                    Assert.Contains(existing,
                        i => i.PermissionId.Id == AccessGroupTestData.Permissions[2].ToString() && i.Id == toPatch.Id);
                }
                finally {
                    if(toDelete != null)
                        api.DeleteAccessGroupPermission(entity.Id.ToString(), toDelete.Id.ToString());
                    api.DeleteAccessGroupPermission(entity.Id.ToString(), toPatch.Id.ToString());
                }
            }
            finally {
                api.DeleteAccessGroup(entity.Id.ToString());
            }
        }

        /// <summary>
        /// Test DeleteAccessGroupUser
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Group_Delete() {
            var entity = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData());
            try {
                var created = api.UpsertAccessGroupGroup(entity.Id,
                    UserTestData.CreateGroupData(UserTestData.Groups[0]));
                api.DeleteAccessGroupGroup(entity.Id, created.Id.ToString());
                var existing = api.ListAccessGroupGroups(entity.Id).Data;
                Assert.Empty(existing);
            }
            finally {
                api.DeleteAccessGroup(entity.Id);
            }
        }

        /// <summary>
        /// Test ListAccessGroupGroups
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Group_List() {
            var entity = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData());
            try {
                var created = UserTestData.Groups.Select(i =>
                    api.UpsertAccessGroupGroup(entity.Id, UserTestData.CreateGroupData(i))).ToArray();
                var existing = api.ListAccessGroupGroups(entity.Id).Data;
                Assert.Equal(created.Length, existing.Count);
            }
            finally {
                api.DeleteAccessGroup(entity.Id);
            }
        }

        /// <summary>
        /// Test UpsertAccessGroupGroup
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Group_Upsert() {
            var entity = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData());
            try {
                var data = UserTestData.CreateGroupData(UserTestData.Groups[0]);
                var created = api.UpsertAccessGroupGroup(entity.Id, data);
                try {
                    var existing = api.ListAccessGroupGroups(entity.Id).Data;
                    Assert.Contains(existing, i => i.Id == created.Id);
                    data = UserTestData.CreateGroupData(UserTestData.Groups[1]);
                    data.Id = created.Id;
                    var updated = api.UpsertAccessGroupGroup(entity.Id, data);
                    Assert.Equal(created.Id, updated.Id);
                    Assert.Equal(data.GroupId.Value, updated.GroupId.Id.ToString());
                }
                finally {
                    api.DeleteAccessGroupGroup(entity.Id, created.Id.ToString());
                }
            }
            finally {
                api.DeleteAccessGroup(entity.Id);
            }
        }

        /// <summary>
        /// Test PatchAccessGroupGroup
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Group_Patch() {
            var entity = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData());
            try {
                var created = api.UpsertAccessGroupGroup(entity.Id.ToString(),
                    UserTestData.CreateGroupData(UserTestData.Groups[0]));
                try {
                    var patched = api.PatchAccessGroupGroups(entity.Id.ToString(),
                        new(groups: new List<GroupText> {
                            new(groupId: UserTestData.Groups[1].ToString()),
                            new(groupId: UserTestData.Groups[2].ToString(), id: created.Id)
                        })).Data;
                    try {
                        var existing = api.ListAccessGroupGroups(entity.Id.ToString()).Data;
                        Assert.Contains(existing, i => i.GroupId.Id == UserTestData.Groups[1]);
                        Assert.Contains(existing, i => i.GroupId.Id == UserTestData.Groups[2] && i.Id == created.Id);
                    }
                    finally {
                        api.DeleteAccessGroupGroup(entity.Id, patched.First(i => i.Id != created.Id).Id.ToString());
                    }
                }
                finally {
                    api.DeleteAccessGroupGroup(entity.Id, created.Id.ToString());
                }
            }
            finally {
                api.DeleteAccessGroup(entity.Id.ToString());
            }
        }

        /// <summary>
        /// Test PatchAccessGroupGroups with deleteNotExists
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Group_Patch_DeleteNotExists() {
            var entity = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData());
            try {
                var toDelete = api.UpsertAccessGroupGroup(entity.Id, UserTestData.CreateGroupData(UserTestData.Groups[0]));
                var toPatch = api.UpsertAccessGroupGroup(entity.Id, UserTestData.CreateGroupData(UserTestData.Groups[1]));
                try {
                    api.PatchAccessGroupGroups(entity.Id.ToString(),
                        new(groups: new List<GroupText> {
                            new(groupId: UserTestData.Groups[2].ToString(), id: toPatch.Id)
                        }),
                        deleteNotExists: true.ToString());
                    toDelete = null;
                    var existing = api.ListAccessGroupGroups(entity.Id.ToString()).Data;
                    Assert.Single(existing);
                    Assert.Contains(existing, i => i.GroupId.Id == UserTestData.Groups[2] && i.Id == toPatch.Id);
                }
                finally {
                    if(toDelete != null)
                        api.DeleteAccessGroupGroup(entity.Id, toDelete.Id.ToString());
                    api.DeleteAccessGroupGroup(entity.Id, toPatch.Id.ToString());
                }
            }
            finally {
                api.DeleteAccessGroup(entity.Id.ToString());
            }
        }

        /// <summary>
        /// Test DeleteAccessGroupUser
        /// </summary>
        [Fact]
        public void Test_AccessGroup_User_Delete() {
            var entity = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData());
            try {
                var created = api.UpsertAccessGroupUser(entity.Id, UserTestData.CreateUserData(UserTestData.Users[0]));
                api.DeleteAccessGroupUser(entity.Id, created.Id.ToString());
                var existingd = api.ListAccessGroupUsers(entity.Id).Data;
                Assert.Empty(existingd);
            }
            finally {
                api.DeleteAccessGroup(entity.Id);
            }
        }

        /// <summary>
        /// Test ListAccessGroupUsers
        /// </summary>
        [Fact]
        public void Test_AccessGroup_User_List() {
            var entity = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData());
            try {
                var created = UserTestData.Users.Select(i =>
                    api.UpsertAccessGroupUser(entity.Id, UserTestData.CreateUserData(i))).ToArray();
                var existing = api.ListAccessGroupUsers(entity.Id).Data;
                Assert.Equal(created.Length, existing.Count);
            }
            finally {
                api.DeleteAccessGroup(entity.Id);
            }
        }

        /// <summary>
        /// Test UpsertAccessGroupUser
        /// </summary>
        [Fact]
        public void Test_AccessGroup_User_Upsert() {
            var entity = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData());
            try {
                var data = UserTestData.CreateUserData(UserTestData.Users[0]);
                var created = api.UpsertAccessGroupUser(entity.Id, data);
                try {
                    var existing = api.ListAccessGroupUsers(entity.Id).Data;
                    Assert.Contains(existing, i => i.Id == created.Id);
                    data = UserTestData.CreateUserData(UserTestData.Users[1]);
                    data.Id = created.Id;
                    var updated = api.UpsertAccessGroupUser(entity.Id, data);
                    Assert.Equal(created.Id, updated.Id);
                    Assert.Equal(data.UserId.Value, updated.UserId.Id.ToString());
                }
                finally {
                    api.DeleteAccessGroupUser(entity.Id, created.Id.ToString());
                }
            }
            finally {
                api.DeleteAccessGroup(entity.Id);
            }
        }

        /// <summary>
        /// Test PatchAccessGroupUser
        /// </summary>
        [Fact]
        public void Test_AccessGroup_User_Patch() {
            var entity = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData());
            try {
                var created = api.UpsertAccessGroupUser(entity.Id.ToString(),
                    UserTestData.CreateUserData(UserTestData.Users[0]));
                try {
                    var patched = api.PatchAccessGroupUsers(entity.Id.ToString(),
                        new(users: new List<UserText> {
                            new(userId: UserTestData.Users[1].ToString()),
                            new(userId: UserTestData.Users[2].ToString(), id: created.Id)
                        })).Data;
                    try {
                        var existing = api.ListAccessGroupUsers(entity.Id.ToString()).Data;
                        Assert.Contains(existing, i => i.UserId.Id == UserTestData.Users[1]);
                        Assert.Contains(existing, i => i.UserId.Id == UserTestData.Users[2] && i.Id == created.Id);
                    }
                    finally {
                        api.DeleteAccessGroupUser(entity.Id, patched.First(i => i.Id != created.Id).Id.ToString());
                    }
                }
                finally {
                    api.DeleteAccessGroupUser(entity.Id, created.Id.ToString());
                }
            }
            finally {
                api.DeleteAccessGroup(entity.Id.ToString());
            }
        }

        /// <summary>
        /// Test PatchAccessGroupUsers with deleteNotExists
        /// </summary>
        [Fact]
        public void Test_AccessGroup_User_Patch_DeleteNotExists() {
            var entity = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData());
            try {
                var toDelete = api.UpsertAccessGroupUser(entity.Id,
                    UserTestData.CreateUserData(UserTestData.Users[0]));
                var toPatch = api.UpsertAccessGroupUser(entity.Id,
                    UserTestData.CreateUserData(UserTestData.Users[1]));
                try {
                    api.PatchAccessGroupUsers(entity.Id.ToString(),
                        new(users: new List<UserText> {
                            new(userId: UserTestData.Users[2].ToString(), id: toPatch.Id)
                        }),
                        deleteNotExists: true.ToString());
                    toDelete = null;
                    var existing = api.ListAccessGroupUsers(entity.Id.ToString()).Data;
                    Assert.Single(existing);
                    Assert.Contains(existing,
                        i => i.UserId.Id == UserTestData.Users[2] && i.Id == toPatch.Id);
                }
                finally {
                    if(toDelete != null)
                        api.DeleteAccessGroupUser(entity.Id, toDelete.Id.ToString());
                    api.DeleteAccessGroupUser(entity.Id, toPatch.Id.ToString());
                }
            }
            finally {
                api.DeleteAccessGroup(entity.Id.ToString());
            }
        }
    }
}
