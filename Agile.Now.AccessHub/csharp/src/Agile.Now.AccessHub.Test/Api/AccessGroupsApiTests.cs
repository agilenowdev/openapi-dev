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
using Agile.Now.AccessHub.Test.Data;
using Agile.Now.ApiAccessGroups.Test.Api;
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
    public class AccessGroupsApiTests : IDisposable
    {
        private readonly AccessGroupsApi api;

        public AccessGroupsApiTests(ITestOutputHelper testOutputHelper)
        {
            Configuration configuration = new Configuration
            {
                BasePath = "https://dev.esystems.fi",
                OAuthTokenUrl = "https://dev.esystems.fi/oAuth/rest/v2/Token",
                OAuthFlow = Client.Auth.OAuthFlow.APPLICATION,
                OAuthClientId = "c8907421-0886-4fb0-b859-d29966762e16",
                OAuthClientSecret = "1da54fa9-ae11-4db3-9740-1bb47b85cd8e"
            };
            api = new AccessGroupsApi(configuration);
        }

        public void Dispose() { }

        /// <summary>
        /// Test an instance of AccessGroupsApi
        /// </summary>
        [Fact]
        public void InstanceTest() { }

        void AssertAccessGroupDataEqual(AccessGroupData AccessGroupData, AccessGroup AccessGroup)
        {
            Assert.Equal(AccessGroupData.Name, AccessGroup.Name);
            Assert.Equal(AccessGroupData.Description, AccessGroup.Description);
            Assert.Equal(AccessGroupData.AccessGroupTypeId.ToString(), AccessGroup.AccessGroupTypeId.Id);
        }

        /// <summary>
        /// Test CreateAccessGroup
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Create()
        {
            var entityData = AccessGroupTestData.CreateAccessGroupData();
            var createdEntity = api.CreateAccessGroup(entityData);
            try
            {
                AssertAccessGroupDataEqual(entityData, createdEntity);
            }
            finally
            {
                api.DeleteAccessGroup(createdEntity.Id);
            }
        }

        /// <summary>
        /// Test DeleteAccessGroup by Id
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Delete_ById()
        {
            var createdEntity = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData());
            api.DeleteAccessGroup(createdEntity.Id);
            Assert.Throws<ApiException>(() => api.GetAccessGroup(createdEntity.Id));
        }

        /// <summary>
        /// Test DeleteAccessGroup by Name
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Delete_ByName()
        {
            var createdEntity = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData());
            api.DeleteAccessGroup(createdEntity.Name, "Name");
            Assert.Throws<ApiException>(() => api.GetAccessGroup(createdEntity.Id));
        }

        /// <summary>
        /// Test DeleteAccessGroup IsSystem= true
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Delete_IsSystem()
        {
            var createdEntity = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData(isSystem: true));
            api.DeleteAccessGroup(createdEntity.Id);
            //Assert.Throws<ApiException>(() => api.DeleteAccessGroup(createdEntity.Id));
        }

        /// <summary>
        /// Test GetAccessGroup by Id
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Get_ById()
        {
            var createdEntity = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData());
            try
            {
                Assert.Null(Record.Exception(() =>
                {
                    var existingEntity = api.GetAccessGroup(createdEntity.Id);
                    Assert.Equal(createdEntity.Id, existingEntity.Id);
                    return existingEntity;
                }));
            }
            finally
            {
                api.DeleteAccessGroup(createdEntity.Id);
            }
        }

        /// <summary>
        /// Test GetAccessGroup by Name
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Get_ByName()
        {
            var createdEntity = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData());
            try
            {
                Assert.Null(Record.Exception(() =>
                {
                    var existingEntity = api.GetAccessGroup(createdEntity.Name, "Name");
                    Assert.Equal(createdEntity.Name, existingEntity.Name);
                    return existingEntity;
                }));
            }
            finally
            {
                api.DeleteAccessGroup(createdEntity.Id);
            }
        }

        /// <summary>
        /// Test ListAccessGroups by Id
        /// </summary>
        [Fact]
        public void Test_AccessGroup_List_ById()
        {
            var createdEntities = AccessGroupTestData.CreateAccessGroupDataList(2).Select(
                i => api.CreateAccessGroup(i)).ToArray();
            try
            {
                var existingEntities = api.ListAccessGroups(
                    filters: $"Id In {string.Join("; ", createdEntities.Select(i => i.Id))}").Data;
                Assert.Equal(existingEntities.Count, createdEntities.Length);
            }
            finally
            {
                foreach (var i in createdEntities)
                    api.DeleteAccessGroup(i.Id);
            }
        }

        /// <summary>
        /// Test ListAccessGroups by Name
        /// </summary>
        [Fact]
        public void Test_AccessGroup_List_ByName()
        {
            var createdEntities = AccessGroupTestData.CreateAccessGroupDataList(2).Select(
                i => api.CreateAccessGroup(i)).ToArray();
            try
            {
                var existingEntities = api.ListAccessGroups(
                    filters: $"Name In {string.Join("; ", createdEntities.Select(i => i.Name))}").Data;
                Assert.Equal(existingEntities.Count, createdEntities.Length);
            }
            finally
            {
                foreach (var i in createdEntities)
                    api.DeleteAccessGroup(i.Id);
            }
        }

        /// <summary>
        /// Test UpdateAccessGroup
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Update()
        {
            var entityData = AccessGroupTestData.CreateAccessGroupData();
            var createdEntity = api.CreateAccessGroup(entityData);
            try
            {
                AccessGroupTestData.UpdateAccessGroupData(entityData);
                var updatedEntity = api.UpdateAccessGroup(createdEntity.Id, entityData);
                AssertAccessGroupDataEqual(entityData, updatedEntity);
            }
            finally
            {
                api.DeleteAccessGroup(createdEntity.Id);
            }
        }

        /// <summary>
        /// Test UpdateAccessGroup IsSystem= true
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Update_IsSystem()
        {
            var entityData = AccessGroupTestData.CreateAccessGroupData(isSystem: true);
            var createdEntity = api.CreateAccessGroup(entityData);
            AccessGroupTestData.UpdateAccessGroupData(entityData);
            Assert.Throws<Exception>(() => api.UpdateAccessGroup(createdEntity.Id, entityData));
        }

        /// <summary>
        /// Test UpsertAccessGroup
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Upsert()
        {
            var entityData = AccessGroupTestData.CreateAccessGroupData();
            var createdEntity = api.UpsertAccessGroup(entityData);
            try
            {
                AssertAccessGroupDataEqual(entityData, createdEntity);
                AccessGroupTestData.UpdateAccessGroupData(entityData);
                entityData.Id = createdEntity.Id;
                var updatedEntity = api.UpsertAccessGroup(entityData);
                Assert.Equal(createdEntity.Id, updatedEntity.Id);
                AssertAccessGroupDataEqual(entityData, updatedEntity);
            }
            finally
            {
                api.DeleteAccessGroup(createdEntity.Id);
            }
        }

        /// <summary>
        /// Test DeleteAccessGroupApplication
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Application_Delete()
        {
            var entityData = AccessGroupTestData.CreateAccessGroupData();
            var createdEntity = api.CreateAccessGroup(entityData);
            try
            {
                var createdSubEntity = api.UpsertAccessGroupApplication(createdEntity.Id,
                    new(
                        parentApplicationId: new("Id", AccessGroupTestData.ParentApplication),
                        accessApplicationId: new("Id", AccessGroupTestData.Applications[0])));
                api.DeleteAccessGroupApplication(createdEntity.Id, createdSubEntity.Id);
                var existingSubEntities = api.ListAccessGroupApplications(createdEntity.Id).Data;
                Assert.Empty(existingSubEntities);
            }
            finally
            {
                api.DeleteAccessGroup(createdEntity.Id);
            }
        }

        /// <summary>
        /// Test ListAccessGroupAccessApplications
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Application_List()
        {
            var createdEntity = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData());
            try
            {
                var createdSubEntities = AccessGroupTestData.Applications.Select(i =>
                    api.UpsertAccessGroupApplication(createdEntity.Id, new(
                        parentApplicationId: new("Id", AccessGroupTestData.ParentApplication),
                        accessApplicationId: new("Id", i)))).ToArray();
                var existingSubEntities = api.ListAccessGroupApplications(createdEntity.Id).Data;
                Assert.Equal(createdSubEntities.Length, existingSubEntities.Count);
            }
            finally
            {
                api.DeleteAccessGroup(createdEntity.Id);
            }
        }

        /// <summary>
        /// Test UpsertAccessGroupApplication
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Application_Upsert()
        {
            var entityData = AccessGroupTestData.CreateAccessGroupData();
            var createdEntity = api.CreateAccessGroup(entityData);
            try
            {
                var createdSubEntity = api.UpsertAccessGroupApplication(createdEntity.Id,
                    new(
                        parentApplicationId: new("Id", AccessGroupTestData.ParentApplication),
                        accessApplicationId: new("Id", AccessGroupTestData.Applications[0])));
                var existingEntities = api.ListAccessGroupApplications(createdEntity.Id).Data;
                Assert.Contains(existingEntities, i => i.Id == createdSubEntity.Id);
            }
            finally
            {
                api.DeleteAccessGroup(createdEntity.Id);
            }
        }

        /// <summary>
        /// Test PatchAccessGroupApplication
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Application_Patch()
        {
            var createdEntity = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData());
            try
            {
                var createdSubEntity = api.UpsertAccessGroupApplication(createdEntity.Id, new(
                    parentApplicationId: new("Id", AccessGroupTestData.ParentApplication),
                    accessApplicationId: new("Id", AccessGroupTestData.Applications[0])));
                api.PatchAccessGroupApplications(createdEntity.Id, new(applications: new List<ApplicationText> {
                    new(
                        parentApplicationId: AccessGroupTestData.ParentApplication,
                        accessApplicationId: AccessGroupTestData.Applications[1]),
                    new(
                        id: createdSubEntity.Id,
                        parentApplicationId: AccessGroupTestData.ParentApplication,
                        accessApplicationId: AccessGroupTestData.Applications[2])
                }));
                var existingEntities = api.ListAccessGroupApplications(createdEntity.Id).Data;
                Assert.Contains(existingEntities, i =>
                    i.ParentApplicationId.Id == AccessGroupTestData.ParentApplication &&
                    i.AccessApplicationId.Id == AccessGroupTestData.Applications[1]);
                Assert.Contains(existingEntities, i =>
                    i.Id == createdSubEntity.Id &&
                    i.ParentApplicationId.Id == AccessGroupTestData.ParentApplication &&
                    i.AccessApplicationId.Id == AccessGroupTestData.Applications[2]);
            }
            finally
            {
                api.DeleteAccessGroup(createdEntity.Id);
            }
        }

        /// <summary>
        /// Test DeleteAccessGroupPermission
        /// </summary>
        //[Fact]
        //public void Test_AccessGroup_Permission_Delete()
        //{
        //    var accessGroupData = TestAccessGroupData.CreateAccessGroupData();
        //    var createdAccessGroup = api.CreateAccessGroup(accessGroupData);
        //    try
        //    {
        //        var permission = api.UpsertAccessGroupPermission(createdAccessGroup.Id,
        //            new PermissionData(permissionId: EnumPermissionType.Import, createdOn: DateTime.Now));
        //        var deletedPermission = api.DeleteAccessGroupPermission(createdAccessGroup.Id, permission.Id.ToString());
        //        var existingPermission = api.ListAccessGroupPermissions(createdAccessGroup.Id).Data;
        //        Assert.Empty(existingPermission);
        //    }
        //    finally
        //    {
        //        api.DeleteAccessGroup(createdAccessGroup.Id);
        //    }
        //}

        /// <summary>
        /// Test ListAccessGroupPermissions
        /// </summary>
        //[Fact]
        //public void Test_AccessGroup_Permission_List()
        //{
        //    var AccessGroupData = TestAccessGroupData.CreateAccessGroupData();
        //    var createdAccessGroup = api.CreateAccessGroup(AccessGroupData);
        //    try
        //    {
        //        var createdAccessGroupPermissions = new[] {
        //            api.UpsertAccessGroupPermission(createdAccessGroup.Id,
        //                new PermissionData ( permissionId: EnumPermissionType.Import, createdOn: DateTime.Now)),
        //            api.UpsertAccessGroupPermission(createdAccessGroup.Id,
        //                new PermissionData ( permissionId: EnumPermissionType.Export, createdOn: DateTime.Now))
        //        };
        //        try
        //        {
        //            var existingAccessGroupPermissions = api.ListAccessGroupPermissions(createdAccessGroup.Id).Data;
        //            Assert.Equal(createdAccessGroupPermissions.Length, existingAccessGroupPermissions.Count);
        //        }
        //        finally
        //        {
        //            foreach (var i in createdAccessGroupPermissions)
        //                api.DeleteAccessGroupPermission(createdAccessGroup.Id, i.Id.ToString());
        //        }
        //    }
        //    finally
        //    {
        //        api.DeleteAccessGroup(createdAccessGroup.Id);
        //    }
        //}

        /// <summary>
        /// Test UpsertAccessGroupPermission
        /// </summary>
        //[Fact]
        //public void Test_AccessGroup_Permission_Upsert()
        //{
        //    var accessGroupData = TestAccessGroupData.CreateAccessGroupData();
        //    var createdAccessGroup = api.CreateAccessGroup(accessGroupData);
        //    try
        //    {
        //        var createdAccessGroupPermission = api.UpsertAccessGroupPermission(createdAccessGroup.Id,
        //            new PermissionData
        //            (
        //                permissionId: EnumPermissionType.Import,
        //                createdOn: DateTime.Now
        //            ));
        //        try
        //        {
        //            var existingAccessGroupPermissions = api.ListAccessGroupPermissions(createdAccessGroup.Id).Data;
        //            Assert.Contains(existingAccessGroupPermissions, i => i.Id == createdAccessGroupPermission.Id);
        //        }
        //        finally
        //        {
        //            api.DeleteAccessGroupPermission(createdAccessGroup.Id, createdAccessGroupPermission.Id.ToString());
        //        }
        //    }
        //    finally
        //    {
        //        api.DeleteAccessGroup(createdAccessGroup.Id);
        //    }
        //}

        /// <summary>
        /// Test DeleteAccessGroupUser
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Group_Delete()
        {
            var createdEntity = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData());
            try
            {
                var createdSubEntity = api.UpsertAccessGroupGroup(createdEntity.Id, new(
                    groupId: new("Id", AccessGroupTestData.Groups[0].ToString()),
                    createdOn: DateTime.Now
                ));
                api.DeleteAccessGroupGroup(createdEntity.Id, createdSubEntity.Id.ToString());
                var existingSubEntities = api.ListAccessGroupGroups(createdEntity.Id).Data;
                Assert.Empty(existingSubEntities);
            }
            finally
            {
                api.DeleteAccessGroup(createdEntity.Id);
            }
        }

        /// <summary>
        /// Test ListAccessGroupGroups
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Group_List()
        {
            var createdEntity = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData());
            try
            {
                var createdSubEntities = AccessGroupTestData.Groups.Select(i =>
                    api.UpsertAccessGroupGroup(createdEntity.Id,
                        new(groupId: new("Id", i.ToString()), createdOn: DateTime.Now))).ToArray();
                var existingSubEntities = api.ListAccessGroupGroups(createdEntity.Id).Data;
                Assert.Equal(createdSubEntities.Length, existingSubEntities.Count);
            }
            finally
            {
                api.DeleteAccessGroup(createdEntity.Id);
            }
        }

        /// <summary>
        /// Test UpsertAccessGroupGroup
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Group_Upsert()
        {
            var createdEntity = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData());
            try
            {
                var createdSubEntity = api.UpsertAccessGroupGroup(createdEntity.Id, new(
                    groupId: new("Id", AccessGroupTestData.Groups[0].ToString()),
                    createdOn: DateTime.Now
                ));
                var existingSubEntities = api.ListAccessGroupGroups(createdEntity.Id).Data;
                Assert.Contains(existingSubEntities, i => i.Id == createdSubEntity.Id);
            }
            finally
            {
                api.DeleteAccessGroup(createdEntity.Id);
            }
        }

        /// <summary>
        /// Test PatchAccessGroupGroup
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Group_Patch()
        {
            var createdEntity = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData());
            try
            {
                var createdSubEntity = api.UpsertAccessGroupGroup(createdEntity.Id, new(
                    groupId: new("Id", AccessGroupTestData.Groups[0].ToString()),
                    createdOn: DateTime.Now
                ));
                api.PatchAccessGroupGroups(createdEntity.Id, new(groups: new List<GroupText> {
                    new(
                        groupId: AccessGroupTestData.Groups[1].ToString(),
                        createdOn: DateTime.Now),
                    new(
                        id: createdSubEntity.Id,
                        groupId: AccessGroupTestData.Groups[2].ToString(),
                        createdOn: DateTime.Now)
                }));
                var existingEntities = api.ListAccessGroupGroups(createdEntity.Id).Data;
                Assert.Contains(existingEntities, i =>
                    i.GroupId.Id == AccessGroupTestData.Groups[1]);
                Assert.Contains(existingEntities, i =>
                    i.Id == createdSubEntity.Id &&
                    i.GroupId.Id == AccessGroupTestData.Groups[2]);
            }
            finally
            {
                api.DeleteAccessGroup(createdEntity.Id);
            }
        }

        /// <summary>
        /// Test DeleteAccessGroupUser
        /// </summary>
        [Fact]
        public void Test_AccessGroup_User_Delete()
        {
            var createdEntity = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData());
            try
            {
                var createdSubEntity = api.UpsertAccessGroupUser(createdEntity.Id, new(
                    userId: new("Id", UserTestData.Users[0].ToString()),
                    createdOn: DateTime.Now));
                api.DeleteAccessGroupUser(createdEntity.Id, createdSubEntity.Id.ToString());
                var existingdSubEntities = api.ListAccessGroupUsers(createdEntity.Id).Data;
                Assert.Empty(existingdSubEntities);
            }
            finally
            {
                api.DeleteAccessGroup(createdEntity.Id);
            }
        }

        /// <summary>
        /// Test ListAccessGroupUsers
        /// </summary>
        [Fact]
        public void Test_AccessGroup_User_List()
        {
            var createdEntity = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData());
            try
            {
                var createdSubEntities = UserTestData.Users.Select(i =>
                    api.UpsertAccessGroupUser(createdEntity.Id,
                        new(userId: new("Id", i.ToString()), createdOn: DateTime.Now))).ToArray();
                var existingSubEntities = api.ListAccessGroupUsers(createdEntity.Id).Data;
                Assert.Equal(createdSubEntities.Length, existingSubEntities.Count);
            }
            finally
            {
                api.DeleteAccessGroup(createdEntity.Id);
            }
        }

        /// <summary>
        /// Test UpsertAccessGroupUser
        /// </summary>
        [Fact]
        public void Test_AccessGroup_User_Upsert()
        {
            var createdEntity = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData());
            try
            {
                var createdSubEntity = api.UpsertAccessGroupUser(createdEntity.Id, new(
                    userId: new("Id", UserTestData.Users[0].ToString()),
                    createdOn: DateTime.Now));
                var existingSubEntities = api.ListAccessGroupUsers(createdEntity.Id).Data;
                Assert.Contains(existingSubEntities, i => i.Id == createdSubEntity.Id);
            }
            finally
            {
                api.DeleteAccessGroup(createdEntity.Id);
            }
        }

        /// <summary>
        /// Test PatchAccessGroupUser
        /// </summary>
        [Fact]
        public void Test_AccessGroup_User_Patch()
        {
            var createdEntity = api.CreateAccessGroup(AccessGroupTestData.CreateAccessGroupData());
            try
            {
                var createdSubEntity = api.UpsertAccessGroupUser(createdEntity.Id, new(
                    userId: new("Id", UserTestData.Users[0].ToString()),
                    createdOn: DateTime.Now));
                api.PatchAccessGroupUsers(createdEntity.Id, new(users: new List<UserText> {
                    new(
                        userId: UserTestData.Users[1].ToString(),
                        createdOn: DateTime.Now),
                    new(
                        id: createdSubEntity.Id,
                        userId: UserTestData.Users[2].ToString(),
                        createdOn: DateTime.Now)
                }));
                var existingEntities = api.ListAccessGroupUsers(createdEntity.Id).Data;
                Assert.Contains(existingEntities, i =>
                    i.UserId.Id == UserTestData.Users[1]);
                Assert.Contains(existingEntities, i =>
                    i.Id == createdSubEntity.Id &&
                    i.UserId.Id == UserTestData.Users[2]);
            }
            finally
            {
                api.DeleteAccessGroup(createdEntity.Id);
            }
        }
    }
}
