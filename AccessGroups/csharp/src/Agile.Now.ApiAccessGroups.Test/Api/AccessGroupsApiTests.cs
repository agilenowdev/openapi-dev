/*
 * AccessGroups API documentation
 *
 * ## Introduction  The OpenAPI Specification (OAS) defines a standard, language-agnostic interface to RESTful APIs which allows both humans and computers to discover and understand the capabilities of the service without access to source code, documentation, or through network traffic inspection. When properly defined, a consumer can understand and interact with the remote service with a minimal amount of implementation logic.    An OpenAPI definition can then be used by documentation generation tools to display the API, code generation tools to generate servers and clients in various programming languages, testing tools, and many other use cases.    | Version | URL | Description |  | - -- | - -- | - -- |  | v3 | https://dev.esystems.fi/Endpoint/rest/Doc/v3/Json/AccessGroups | Serializes to the Open API document as a string in the JSON format and represents all patches of OpenAPI V3.0 spec (e.g. 3.0.0, 3.0.1). |  | v3 | https://dev.esystems.fi/Endpoint/rest/Doc/v3/Yaml/AccessGroups | Serializes to the Open API document as a string in the Yaml format and represents all patches of OpenAPI V3.0 spec (e.g. 3.0.0, 3.0.1). |  | v2 | https://dev.esystems.fi/Endpoint/rest/Doc/v2/Json/AccessGroups | Serializes to the Open API document as a string in the JSON format and represents OpenAPI V2.0 spec.|  | v2 | https://dev.esystems.fi/Endpoint/rest/Doc/v2/Yaml/AccessGroups | Serializes to the Open API document as a string in the Yaml format and represents OpenAPI V2.0 spec. |
 *
 * The version of the OpenAPI document: 3.0.3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using Agile.Now.ApiAccessGroups.Api;
using Agile.Now.ApiAccessGroups.Client;
using Agile.Now.ApiAccessGroups.Model;
using Xunit;
using Xunit.Abstractions;
// uncomment below to import models
//using Agile.Now.ApiAccessGroups.Model;

namespace Agile.Now.ApiAccessGroups.Test.Api
{
    /// <summary>
    ///  Class for testing AccessGroupApi
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

        public void Dispose()
        {
        }

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
            var accessGroupData = TestAccessGroupData.CreateAccessGroupData();
            var createdAccessGroup = api.CreateAccessGroup(accessGroupData);
            try
            {
                AssertAccessGroupDataEqual(accessGroupData, createdAccessGroup);
            }
            finally
            {
                api.DeleteAccessGroup(createdAccessGroup.Id);
            }
        }

        /// <summary>
        /// Test DeleteAccessGroup by Id
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Delete_ById()
        {
            var createdAccessGroup = api.CreateAccessGroup(TestAccessGroupData.CreateAccessGroupData());
            api.DeleteAccessGroup(createdAccessGroup.Id);
            Assert.Throws<ApiException>(() => api.GetAccessGroup(createdAccessGroup.Id));
        }

        /// <summary>
        /// Test DeleteAccessGroup by Name
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Delete_ByName()
        {
            var createdAccessGroup = api.CreateAccessGroup(TestAccessGroupData.CreateAccessGroupData());
            api.DeleteAccessGroup(createdAccessGroup.Name, "Name");
            Assert.Throws<ApiException>(() => api.GetAccessGroup(createdAccessGroup.Id));
        }

        /// <summary>
        /// Test GetAccessGroup by Id
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Get_ById()
        {
            var createdAccessGroup = api.CreateAccessGroup(TestAccessGroupData.CreateAccessGroupData());
            try
            {
                Assert.Null(Record.Exception(() =>
                {
                    var existingAccessGroup = api.GetAccessGroup(createdAccessGroup.Id);
                    Assert.Equal(createdAccessGroup.Id, existingAccessGroup.Id);
                    return existingAccessGroup;
                }));
            }
            finally
            {
                api.DeleteAccessGroup(createdAccessGroup.Id);
            }
        }

        /// <summary>
        /// Test GetAccessGroup by Name
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Get_ByName()
        {
            var createdAccessGroup = api.CreateAccessGroup(TestAccessGroupData.CreateAccessGroupData());
            try
            {
                Assert.Null(Record.Exception(() =>
                {
                    var existingAccessGroup = api.GetAccessGroup(createdAccessGroup.Name, "Name");
                    Assert.Equal(createdAccessGroup.Name, existingAccessGroup.Name);
                    return existingAccessGroup;
                }));
            }
            finally
            {
                api.DeleteAccessGroup(createdAccessGroup.Id);
            }
        }

        /// <summary>
        /// Test ListAccessGroups by Id
        /// </summary>
        [Fact]
        public void Test_AccessGroup_List_ById()
        {
            var AccessGroupData = TestAccessGroupData.CreateAccessGroupDataList(2);
            var createdAccessGroups = AccessGroupData.Select(i => api.CreateAccessGroup(i)).ToArray();
            try
            {
                var foundAccessGroups = api.ListAccessGroups(
                    filters: $"Id In {string.Join("; ", createdAccessGroups.Select(i => i.Id))}").Data;
                Assert.Equal(foundAccessGroups.Count, createdAccessGroups.Length);
            }
            finally
            {
                foreach (var i in createdAccessGroups)
                    api.DeleteAccessGroup(i.Id);
            }
        }

        /// <summary>
        /// Test ListAccessGroups by Name
        /// </summary>
        [Fact]
        public void Test_AccessGroup_List_ByName()
        {
            var AccessGroupData = TestAccessGroupData.CreateAccessGroupDataList(2);
            var createdAccessGroups = AccessGroupData.Select(i => api.CreateAccessGroup(i)).ToArray();
            try
            {
                var foundAccessGroups = api.ListAccessGroups(
                    filters: $"Name In {string.Join("; ", createdAccessGroups.Select(i => i.Name))}").Data;
                Assert.Equal(foundAccessGroups.Count, createdAccessGroups.Length);
            }
            finally
            {
                foreach (var i in createdAccessGroups)
                    api.DeleteAccessGroup(i.Id);
            }
        }

        /// <summary>
        /// Test UpdateAccessGroup
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Update()
        {
            var AccessGroupData = TestAccessGroupData.CreateAccessGroupData();
            var createdAccessGroup = api.CreateAccessGroup(AccessGroupData);
            try
            {
                TestAccessGroupData.UpdateAccessGroupData(AccessGroupData);
                var updatedAccessGroup = api.UpdateAccessGroup(createdAccessGroup.Id, AccessGroupData);
                AssertAccessGroupDataEqual(AccessGroupData, updatedAccessGroup);
            }
            finally
            {
                api.DeleteAccessGroup(createdAccessGroup.Id);
            }
        }

        /// <summary>
        /// Test UpsertAccessGroup
        /// </summary>
        [Fact]
        public void Test_AccessGroup_Upsert()
        {
            var AccessGroupData = TestAccessGroupData.CreateAccessGroupData();
            var createdAccessGroup = api.UpsertAccessGroup(AccessGroupData);
            try
            {
                AssertAccessGroupDataEqual(AccessGroupData, createdAccessGroup);
                TestAccessGroupData.UpdateAccessGroupData(AccessGroupData, createdAccessGroup.Id);
                var updatedAccessGroup = api.UpsertAccessGroup(AccessGroupData);
                Assert.Equal(createdAccessGroup.Id, updatedAccessGroup.Id);
                AssertAccessGroupDataEqual(AccessGroupData, updatedAccessGroup);
            }
            finally
            {
                api.DeleteAccessGroup(createdAccessGroup.Id);
            }
        }

        /// <summary>
        /// Test DeleteAccessGroupApplication
        /// </summary>
        [Fact]
        public void Test_AccessGroupApplication_Delete()
        {
            var AccessGroupData = TestAccessGroupData.CreateAccessGroupData();
            var createdAccessGroup = api.CreateAccessGroup(AccessGroupData);
            try
            {
                var accessApplication = api.UpsertAccessGroupApplication(createdAccessGroup.Id,
                    new(
                        parentApplicationId: new("Id", TestAccessGroupData.ParentApplication),
                        accessApplicationId: new("Id", TestAccessGroupData.Applications[0])));
                api.DeleteAccessGroupApplication(createdAccessGroup.Id, accessApplication.Id);
            }
            finally
            {
                api.DeleteAccessGroup(createdAccessGroup.Id);
            }
        }

        /// <summary>
        /// Test DeleteAccessGroupPermission
        /// </summary>
        //[Fact]
        //public void Test_AccessGroupPermission_Delete()
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
        /// Test DeleteAccessGroupUser
        /// </summary>
        [Fact]
        public void Test_AccessGroupGroup_Delete()
        {
            var accessGroupData = TestAccessGroupData.CreateAccessGroupData();
            var createdAccessGroup = api.CreateAccessGroup(accessGroupData);
            try
            {
                var createdAccessGroupGroup = api.UpsertAccessGroupGroup(createdAccessGroup.Id, new(
                    groupId: new("Id", TestAccessGroupData.Groups[0].ToString()),
                    createdOn: DateTime.Now
                ));
                api.DeleteAccessGroupGroup(createdAccessGroup.Id, createdAccessGroupGroup.Id.ToString());
                var existingAccessGroupGroups = api.ListAccessGroupGroups(createdAccessGroup.Id).Data;
                Assert.Empty(existingAccessGroupGroups);
            }
            finally
            {
                api.DeleteAccessGroup(createdAccessGroup.Id);
            }
        }

        /// <summary>
        /// Test DeleteAccessGroupUser
        /// </summary>
        [Fact]
        public void Test_AccessGroupUser_Delete()
        {
            var AccessGroupData = TestAccessGroupData.CreateAccessGroupData();
            var createdAccessGroup = api.CreateAccessGroup(AccessGroupData);
            try
            {
                var createdAccessGroupUser = api.UpsertAccessGroupUser(createdAccessGroup.Id, new(
                    userId: new("Id", TestAccessGroupData.Users[0].ToString()),
                    createdOn: DateTime.Now));
                api.DeleteAccessGroupUser(createdAccessGroup.Id, createdAccessGroupUser.Id.ToString());
                var existingdAccessGroupUsers = api.ListAccessGroupUsers(createdAccessGroup.Id).Data;
                Assert.Empty(existingdAccessGroupUsers);
            }
            finally
            {
                api.DeleteAccessGroup(createdAccessGroup.Id);
            }
        }

        /// <summary>
        /// Test ListAccessGroupAccessApplications
        /// </summary>
        [Fact]
        public void Test_AccessGroupAccessApplication_List()
        {
            var AccessGroupData = TestAccessGroupData.CreateAccessGroupData();
            var createdAccessGroup = api.CreateAccessGroup(AccessGroupData);
            try
            {
                var createdAccessGroupAccessApplications = TestAccessGroupData.Applications.Select(i =>
                    api.UpsertAccessGroupApplication(createdAccessGroup.Id,
                        new(
                            parentApplicationId: new("Id", TestAccessGroupData.ParentApplication),
                            accessApplicationId: new("Id", i)))).ToArray();
                try
                {
                    var existingAccessGroupAccessApplications =
                        api.ListAccessGroupApplications(createdAccessGroup.Id).Data;
                    Assert.Equal(createdAccessGroupAccessApplications.Length, existingAccessGroupAccessApplications.Count);
                }
                finally
                {
                    foreach (var i in createdAccessGroupAccessApplications)
                        api.DeleteAccessGroupApplication(createdAccessGroup.Id, i.Id);
                }
            }
            finally
            {
                api.DeleteAccessGroup(createdAccessGroup.Id);
            }
        }

        /// <summary>
        /// Test ListAccessGroupPermissions
        /// </summary>
        //[Fact]
        //public void Test_AccessGroupPermission_List()
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
        /// Test ListAccessGroupGroups
        /// </summary>
        [Fact]
        public void Test_AccessGroupGroup_List()
        {
            var accessGroupData = TestAccessGroupData.CreateAccessGroupData();
            var createdAccessGroup = api.CreateAccessGroup(accessGroupData);
            try
            {
                var createdAccessGroupGroups = TestAccessGroupData.Groups.Select(i =>
                    api.UpsertAccessGroupGroup(createdAccessGroup.Id,
                        new(groupId: new("Id", i.ToString()), createdOn: DateTime.Now))).ToArray();
                try
                {
                    var existingAccessGroupGroups = api.ListAccessGroupGroups(createdAccessGroup.Id).Data;
                    Assert.Equal(createdAccessGroupGroups.Length, existingAccessGroupGroups.Count);
                    Assert.Contains(existingAccessGroupGroups, i => i.Id == createdAccessGroupGroups[0].Id);
                    Assert.Contains(existingAccessGroupGroups, i => i.Id == createdAccessGroupGroups[1].Id);
                }
                finally
                {
                    foreach (var i in createdAccessGroupGroups)
                        api.DeleteAccessGroupGroup(createdAccessGroup.Id, i.Id.ToString());
                }
            }
            finally
            {
                api.DeleteAccessGroup(createdAccessGroup.Id);
            }
        }

        /// <summary>
        /// Test ListAccessGroupUsers
        /// </summary>
        [Fact]
        public void Test_AccessGroupUser_List()
        {
            var accessGroupData = TestAccessGroupData.CreateAccessGroupData();
            var createdAccessGroup = api.CreateAccessGroup(accessGroupData);
            try
            {
                var createdAccessGroupUsers = TestAccessGroupData.Users.Select(i =>
                    api.UpsertAccessGroupUser(createdAccessGroup.Id,
                        new(userId: new("Id", i.ToString()), createdOn: DateTime.Now))).ToArray();
                try
                {
                    var existingAccessGroupUsers = api.ListAccessGroupUsers(createdAccessGroup.Id).Data;
                    Assert.Equal(createdAccessGroupUsers.Length, existingAccessGroupUsers.Count);
                }
                finally
                {
                    foreach (var i in createdAccessGroupUsers)
                        api.DeleteAccessGroupUser(createdAccessGroup.Id, i.Id.ToString());
                }
            }
            finally
            {
                api.DeleteAccessGroup(createdAccessGroup.Id);
            }
        }

        /// <summary>
        /// Test PatchAccessGroupApplications
        /// </summary>
        [Fact]
        public void PatchAccessGroupApplicationsTest()
        {
        }

        /// <summary>
        /// Test PatchAccessGroupPermissions
        /// </summary>
        [Fact]
        public void PatchAccessGroupPermissionsTest()
        {
        }

        /// <summary>
        /// Test UpsertAccessGroupApplication
        /// </summary>
        [Fact]
        public void Test_AccessGroupApplication_Upsert()
        {
            var AccessGroupData = TestAccessGroupData.CreateAccessGroupData();
            var createdAccessGroup = api.CreateAccessGroup(AccessGroupData);
            try
            {
                var createdAccessGroupApplication = api.UpsertAccessGroupApplication(createdAccessGroup.Id,
                    new(
                        parentApplicationId: new("Id", TestAccessGroupData.ParentApplication),
                        accessApplicationId: new("Id", TestAccessGroupData.Applications[0])));
                try
                {
                    var existingAccessGroupApplications =
                        api.ListAccessGroupApplications(createdAccessGroup.Id).Data;
                    Assert.Contains(existingAccessGroupApplications,
                        i => i.Id == createdAccessGroupApplication.Id);
                }
                finally
                {
                    api.DeleteAccessGroupApplication(createdAccessGroup.Id, createdAccessGroupApplication.Id);
                }
            }
            finally
            {
                api.DeleteAccessGroup(createdAccessGroup.Id);
            }
        }

        /// <summary>
        /// Test UpsertAccessGroupPermission
        /// </summary>
        //[Fact]
        //public void Test_AccessGroupPermission_Upsert()
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
        /// Test UpsertAccessGroupGroup
        /// </summary>
        [Fact]
        public void Test_AccessGroupGroup_Upsert()
        {
            var accessGroupData = TestAccessGroupData.CreateAccessGroupData();
            var createdAccessGroup = api.CreateAccessGroup(accessGroupData);
            try
            {
                var createdAccessGroupGroup = api.UpsertAccessGroupGroup(createdAccessGroup.Id, new(
                    groupId: new("Id", TestAccessGroupData.Groups[0].ToString()),
                    createdOn: DateTime.Now
                ));
                try
                {
                    var existingAccessGroupGroups = api.ListAccessGroupGroups(createdAccessGroup.Id).Data;
                    Assert.Contains(existingAccessGroupGroups, i => i.Id == createdAccessGroupGroup.Id);
                }
                finally
                {
                    api.DeleteAccessGroupGroup(createdAccessGroup.Id, createdAccessGroupGroup.Id.ToString());
                }
            }
            finally
            {
                api.DeleteAccessGroup(createdAccessGroup.Id);
            }
        }

        /// <summary>
        /// Test UpsertAccessGroupUser
        /// </summary>
        [Fact]
        public void Test_AccessGroupUser_Upsert()
        {
            var accessGroupData = TestAccessGroupData.CreateAccessGroupData();
            var createdAccessGroup = api.CreateAccessGroup(accessGroupData);
            try
            {
                var createdAccessGroupUser = api.UpsertAccessGroupUser(createdAccessGroup.Id, new(
                    userId: new("Id", TestAccessGroupData.Users[0].ToString()),
                    createdOn: DateTime.Now));
                try
                {
                    var existingAccessGroupUsers = api.ListAccessGroupUsers(createdAccessGroup.Id).Data;
                    Assert.Contains(existingAccessGroupUsers, i => i.Id == createdAccessGroupUser.Id);
                }
                finally
                {
                    api.DeleteAccessGroupUser(createdAccessGroup.Id, createdAccessGroupUser.Id.ToString());
                }
            }
            finally
            {
                api.DeleteAccessGroup(createdAccessGroup.Id);
            }
        }
    }
}
