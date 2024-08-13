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
using Agile.Now.AccessHub.Test.Data;
using Agile.Now.ApiAccessGroups.Test.Api;
using Agile.Now.ApiOrganizations.Test.Api;
using Agile.Now.Runtime.Api;
using Agile.Now.Runtime.Client;
using Agile.Now.Runtime.Client.Auth;
using Agile.Now.Runtime.Model;
using Xunit;
using Xunit.Abstractions;
// uncomment below to import models
//using Agile.Now.AccessHub.Model;

namespace Agile.Now.AccessHub.Test.Api
{
    /// <summary>
    ///  Class for testing UsersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UsersApiTests : IDisposable
    {
        private readonly UsersApi api;

        public UsersApiTests(ITestOutputHelper testOutputHelper)
        {
            Configuration configuration = new Configuration
            {
                BasePath = "https://dev.esystems.fi",
                OAuthTokenUrl = "https://dev.esystems.fi/oAuth/rest/v2/Token",
                OAuthFlow = OAuthFlow.APPLICATION,
                OAuthClientId = "c8907421-0886-4fb0-b859-d29966762e16",
                OAuthClientSecret = "1da54fa9-ae11-4db3-9740-1bb47b85cd8e"
            };
            api = new UsersApi(configuration);
        }

        public void Dispose()
        {
        }

        /// <summary>
        /// Test GetUser by Id
        /// </summary>
        [Fact]
        public void Test_User_Get_ById()
        {
            Assert.Null(Record.Exception(() =>
            {
                var existingEntity = api.GetUser(TestUserData.Users[2].ToString());
                Assert.Equal(TestUserData.Users[2], existingEntity.Id);
                return existingEntity;
            }));
        }

        /// <summary>
        /// Test GetUser by Name
        /// </summary>
        [Fact]
        public void Test_User_Get_ByName()
        {
            Assert.Null(Record.Exception(() =>
            {
                var existingEntity = api.GetUser(TestUserData.Users[2].ToString(), "Name");
                Assert.Equal("test test", existingEntity.Id.ToString());
                return existingEntity;
            }));
        }

        /// <summary>
        /// Test ListUsers by Id
        /// </summary>
        [Fact]
        public void Test_User_List_ById()
        {
            var existingEntities = api.ListUsers(
                filters: $"Id In {string.Join("; ", TestUserData.Users[1], TestUserData.Users[2])}").Data;
            Assert.Equal(2, existingEntities.Count);
        }

        /// <summary>
        /// Test ListUsers by Name
        /// </summary>
        [Fact]
        public void Test_User_List_ByName()
        {
            var existingEntities = api.ListUsers(
                filters: $"Name In {string.Join("; ", TestUserData.Users[2])}").Data;
            Assert.Single(existingEntities);
        }

        /// <summary>
        /// Test DeleteUserAccessGroup
        /// </summary>
        [Fact]
        public void Test_User_AccessGroup_Delete()
        {
            var existedEntity = TestUserData.Users[0];
            var createdSubEntity = api.UpsertUserAccessGroup(existedEntity.ToString(), new(
                accessGroupId: new("Id", TestUserData.AccessGroups[0].ToString()), createdOn: DateTime.Now));
            api.DeleteUserAccessGroup(existedEntity.ToString(), createdSubEntity.Id.ToString());
            var existingdSubEntities = api.ListUserAccessGroups(existedEntity.ToString()).Data;
            Assert.Empty(existingdSubEntities);
        }

        /// <summary>
        /// Test ListUserAccessGroups
        /// </summary>
        [Fact]
        public void Test_User_AccessGroup_List()
        {
            var existedEntity = TestUserData.Users[0];
            var createdSubEntities = TestUserData.AccessGroups.Select(i =>
                api.UpsertUserAccessGroup(existedEntity.ToString(),
                    new(accessGroupId: new("Id", i.ToString()), createdOn: DateTime.Now))).ToArray();
            var existingSubEntities = api.ListUserAccessGroups(existedEntity.ToString()).Data;
            Assert.Equal(createdSubEntities.Length, existingSubEntities.Count);
        }

        /// <summary>
        /// Test UpsertUserAccessGroup
        /// </summary>
        [Fact]
        public void Test_User_AccessGroup_Upsert()
        {
            var existedEntity = TestUserData.Users[0];
            var createdSubEntity = api.UpsertUserAccessGroup(existedEntity.ToString(), new(
                accessGroupId: new("Id", TestUserData.AccessGroups[0].ToString()), createdOn: DateTime.Now));
            var existingSubEntities = api.ListUserAccessGroups(existedEntity.ToString()).Data;
            Assert.Contains(existingSubEntities, i => i.Id == createdSubEntity.Id);
        }

        /// <summary>
        /// Test DeleteUserGroup
        /// </summary>
        [Fact]
        public void Test_User_Group_Delete()
        {
            var existedEntity = TestUserData.Users[0];
            var createdSubEntity = api.UpsertUserGroup(existedEntity.ToString(), new(
                groupId: new("Id", TestAccessGroupData.Groups[0].ToString())));
            api.DeleteUserGroup(existedEntity.ToString(), createdSubEntity.Id.ToString());
            var existingdSubEntities = api.ListUserGroups(existedEntity.ToString()).Data;
            Assert.Empty(existingdSubEntities);
        }

        /// <summary>
        /// Test ListUserGroups
        /// </summary>
        [Fact]
        public void Test_User_Group_List()
        {
            var existedEntity = TestUserData.Users[0];
            var createdSubEntities = TestAccessGroupData.Groups.Select(i =>
                api.UpsertUserGroup(existedEntity.ToString(),
                    new(groupId: new("Id", i.ToString())))).ToArray();
            var existingSubEntities = api.ListUserGroups(existedEntity.ToString()).Data;
            Assert.Equal(createdSubEntities.Length, existingSubEntities.Count);
        }

        /// <summary>
        /// Test UpsertUserGroup
        /// </summary>
        [Fact]
        public void Test_User_Group_Upsert()
        {
            var existedEntity = TestUserData.Users[0];
            var createdSubEntity = api.UpsertUserGroup(existedEntity.ToString(), new(
                groupId: new("Id", TestAccessGroupData.Groups[0].ToString())));
            var existingSubEntities = api.ListUserGroups(existedEntity.ToString()).Data;
            Assert.Contains(existingSubEntities, i => i.Id == createdSubEntity.Id);
        }

        /// <summary>
        /// Test DeleteUserDepartment
        /// </summary>
        [Fact]
        public void Test_User_Department_Delete()
        {
            var existedEntity = TestUserData.Users[0];
            var createdSubEntity = api.UpsertUserDepartment(existedEntity.ToString(), new(
                departmentId: new("Id", TestDepartmentData.Departments[0].ToString())));
            api.DeleteUserDepartment(existedEntity.ToString(), createdSubEntity.Id.ToString());
            var existingdSubEntities = api.ListUserDepartments(existedEntity.ToString()).Data;
            Assert.Empty(existingdSubEntities);
        }

        /// <summary>
        /// Test ListUserDepartments
        /// </summary>
        [Fact]
        public void Test_User_Department_List()
        {
            var existedEntity = TestUserData.Users[0];
            var createdSubEntities = TestDepartmentData.Departments.Select(i =>
                api.UpsertUserDepartment(existedEntity.ToString(),
                    new(departmentId: new("Id", i.ToString())))).ToArray();
            var existingSubEntities = api.ListUserDepartments(existedEntity.ToString()).Data;
            Assert.Equal(createdSubEntities.Length, existingSubEntities.Count);
        }

        /// <summary>
        /// Test UpsertUserDepartment
        /// </summary>
        [Fact]
        public void Test_User_Department_Upsert()
        {
            var existedEntity = TestUserData.Users[0];
            var createdSubEntity = api.UpsertUserDepartment(existedEntity.ToString(), new(
                departmentId: new("Id", TestDepartmentData.Departments[0].ToString())));
            var existingSubEntities = api.ListUserDepartments(existedEntity.ToString()).Data;
            Assert.Contains(existingSubEntities, i => i.Id == createdSubEntity.Id);
        }

        /// <summary>
        /// Test PatchUserDepartment
        /// </summary>
        [Fact]
        public void Test_User_Department_Patch()
        {
            var existedEntity = TestUserData.Users[0];
            var createdSubEntity = api.UpsertUserDepartment(existedEntity.ToString(), new(
                departmentId: new("Id", TestDepartmentData.Departments[0].ToString())));
            api.PatchUserDepartments(existedEntity.ToString(), new(departments: new List<DepartmentText> {
                    new(departmentId: TestDepartmentData.Departments[1].ToString()),
                    new(departmentId: TestDepartmentData.Departments[2].ToString(), id: createdSubEntity.Id)
                }));
            var existingEntities = api.ListUserDepartments(existedEntity.ToString()).Data;
            Assert.Contains(existingEntities, i =>
                i.DepartmentId.Id == TestDepartmentData.Departments[1]);
            Assert.Contains(existingEntities, i =>
                i.Id == createdSubEntity.Id &&
                i.DepartmentId.Id == TestDepartmentData.Departments[2]);
        }

        /// <summary>
        /// Test DeleteUserLocation
        /// </summary>
        [Fact]
        public void Test_User_Location_Delete()
        {
            var existedEntity = TestUserData.Users[0];
            var createdSubEntity = api.UpsertUserLocation(existedEntity.ToString(), new(
                locationId: new("Id", TestLocationData.Locations[0].ToString())));
            api.DeleteUserLocation(existedEntity.ToString(), createdSubEntity.Id.ToString());
            var existingdSubEntities = api.ListUserLocations(existedEntity.ToString()).Data;
            Assert.Empty(existingdSubEntities);
        }

        /// <summary>
        /// Test ListUserLocations
        /// </summary>
        [Fact]
        public void Test_User_Location_List()
        {
            var existedEntity = TestUserData.Users[0];
            var createdSubEntities = TestLocationData.Locations.Select(i =>
                api.UpsertUserLocation(existedEntity.ToString(),
                    new(locationId: new("Id", i.ToString())))).ToArray();
            var existingSubEntities = api.ListUserLocations(existedEntity.ToString()).Data;
            Assert.Equal(createdSubEntities.Length, existingSubEntities.Count);
        }

        /// <summary>
        /// Test UpsertUserLocation
        /// </summary>
        [Fact]
        public void Test_User_Location_Upsert()
        {
            var existedEntity = TestUserData.Users[0];
            var createdSubEntity = api.UpsertUserLocation(existedEntity.ToString(), new(
                locationId: new("Id", TestLocationData.Locations[0].ToString())));
            var existingSubEntities = api.ListUserLocations(existedEntity.ToString()).Data;
            Assert.Contains(existingSubEntities, i => i.Id == createdSubEntity.Id);
        }

        /// <summary>
        /// Test PatchUserLocation
        /// </summary>
        [Fact]
        public void Test_User_Location_Patch()
        {
            var existedEntity = TestUserData.Users[0];
            var createdSubEntity = api.UpsertUserLocation(existedEntity.ToString(), new(
                locationId: new("Id", TestLocationData.Locations[0].ToString())));
            api.PatchUserLocations(existedEntity.ToString(), new(locations: new List<LocationText> {
                    new(locationId: TestLocationData.Locations[1].ToString()),
                    new(locationId: TestLocationData.Locations[2].ToString(), id: createdSubEntity.Id)
                }));
            var existingEntities = api.ListUserLocations(existedEntity.ToString()).Data;
            Assert.Contains(existingEntities, i =>
                i.LocationId.Id == TestLocationData.Locations[1]);
            Assert.Contains(existingEntities, i =>
                i.Id == createdSubEntity.Id &&
                i.LocationId.Id == TestLocationData.Locations[2]);
        }

        /// <summary>
        /// Test ListUserApplications
        /// </summary>
        [Fact]
        public void Test_User_Application_List()
        {
            var existedEntity = TestUserData.Users[0];
            var existingSubEntities = api.ListUserApplications(existedEntity.ToString()).Data;
            Assert.NotEmpty(existingSubEntities);
        }

        /// <summary>
        /// Test ListUserEffectivePermissions
        /// </summary>
        [Fact]
        public void Test_User_EffectivePermissions_List()
        {
            var existedEntity = TestUserData.Users[0];
            var existingSubEntities = api.ListUserEffectivePermissions(existedEntity.ToString()).Data;
            Assert.NotEmpty(existingSubEntities);
        }
    }
}