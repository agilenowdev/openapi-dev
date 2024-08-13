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
using Xunit;

using Agile.Now.AccessHub.Client;
using Agile.Now.AccessHub.Api;
using Xunit.Abstractions;
using Agile.Now.AccessHub.Model;
using Agile.Now.ApiOrganizations.Test.Api;
using System.Linq;
// uncomment below to import models
//using Agile.Now.AccessHub.Model;

namespace Agile.Now.AccessHub.Test.Api
{
    /// <summary>
    ///  Class for testing DepartmentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DepartmentsApiTests : IDisposable
    {
        private readonly DepartmentsApi api;

        public DepartmentsApiTests(ITestOutputHelper testOutputHelper)
        {
            Configuration configuration = new Configuration
            {
                BasePath = "https://dev.esystems.fi",
                OAuthTokenUrl = "https://dev.esystems.fi/oAuth/rest/v2/Token",
                OAuthFlow = Client.Auth.OAuthFlow.APPLICATION,
                OAuthClientId = "c8907421-0886-4fb0-b859-d29966762e16",
                OAuthClientSecret = "1da54fa9-ae11-4db3-9740-1bb47b85cd8e"
            };
            api = new DepartmentsApi(configuration);
        }

        public void Dispose()
        {
        }

        /// <summary>
        /// Test an instance of DepartmentsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
        }

        void AssertDepartmentDataEqual(DepartmentInsertData departmentInsertData, Department department)
        {
            Assert.Equal(departmentInsertData.Name, department.Name);
            Assert.Equal(departmentInsertData.ContactName, department.ContactName);
            Assert.Equal(departmentInsertData.ContactEmail, department.ContactEmail);
            //Assert.Equal(departmentInsertData.CountryId.ToString(), department.CountryId.Name);
        }

        /// <summary>
        /// Test CreateDepartment
        /// </summary>
        [Fact]
        public void Test_Department_Create()
        {
            var entityData = DepartmentTestData.CreateDepartmentData();
            var createdEntity = api.CreateDepartment(entityData);
            try
            {
                AssertDepartmentDataEqual(entityData, createdEntity);
            }
            finally
            {
                api.DeleteDepartment(createdEntity.Id);
            }
        }

        /// <summary>
        /// Test DeleteDepartment by Id
        /// </summary>
        [Fact]
        public void Test_Department_Delete_ById()
        {
            var createdEntity = api.CreateDepartment(DepartmentTestData.CreateDepartmentData());
            api.DeleteDepartment(createdEntity.Id);
            Assert.Throws<ApiException>(() => api.GetDepartment(createdEntity.Id));
        }

        /// <summary>
        /// Test DeleteDepartment by Name
        /// </summary>
        [Fact]
        public void Test_Department_Delete_ByName()
        {
            var createdEntity = api.CreateDepartment(DepartmentTestData.CreateDepartmentData());
            api.DeleteDepartment(createdEntity.Name, "Name");
            Assert.Throws<ApiException>(() => api.GetDepartment(createdEntity.Id));
        }

        /// <summary>
        /// Test GetDepartment by Id
        /// </summary>
        [Fact]
        public void Test_Department_Get_ById()
        {
            var createdEntity = api.CreateDepartment(DepartmentTestData.CreateDepartmentData());
            try
            {
                Assert.Null(Record.Exception(() =>
                {
                    var existingEntity = api.GetDepartment(createdEntity.Id);
                    Assert.Equal(createdEntity.Id, existingEntity.Id);
                    return existingEntity;
                }));
            }
            finally
            {
                api.DeleteDepartment(createdEntity.Id);
            }
        }

        /// <summary>
        /// Test GetDepartment by Name
        /// </summary>
        [Fact]
        public void Test_Department_Get_ByName()
        {
            var createdEntity = api.CreateDepartment(DepartmentTestData.CreateDepartmentData());
            try
            {
                Assert.Null(Record.Exception(() =>
                {
                    var existingEntity = api.GetDepartment(createdEntity.Name, "Name");
                    Assert.Equal(createdEntity.Name, existingEntity.Name);
                    return existingEntity;
                }));
            }
            finally
            {
                api.DeleteDepartment(createdEntity.Id);
            }
        }

        /// <summary>
        /// Test ListDepartments by Id
        /// </summary>
        [Fact]
        public void Test_Department_List_ById()
        {
            var createdEntities = DepartmentTestData.CreateDepartmentDataList(2).Select(
                i => api.CreateDepartment(i)).ToArray();
            try
            {
                var existingEntities = api.ListDepartments(
                    filters: $"Id In {string.Join("; ", createdEntities.Select(i => i.Id))}").Data;
                Assert.Equal(createdEntities.Length, existingEntities.Count);
            }
            finally
            {
                foreach (var i in createdEntities)
                    api.DeleteDepartment(i.Id);
            }
        }

        /// <summary>
        /// Test ListDepartments by Name
        /// </summary>
        [Fact]
        public void Test_Department_List_ByName()
        {
            var createdEntities = DepartmentTestData.CreateDepartmentDataList(2).Select(
                i => api.CreateDepartment(i)).ToArray();
            try
            {
                var existingEntities = api.ListDepartments(
                    filters: $"Name In {string.Join("; ", createdEntities.Select(i => i.Name))}").Data;
                Assert.Equal(createdEntities.Length, existingEntities.Count);
            }
            finally
            {
                foreach (var i in createdEntities)
                    api.DeleteDepartment(i.Id);
            }
        }

        /// <summary>
        /// Test UpdateDepartment
        /// </summary>
        [Fact]
        public void Test_Department_Update()
        {
            var entityData = DepartmentTestData.CreateDepartmentData();
            var createdEntity = api.CreateDepartment(entityData);
            try
            {
                DepartmentTestData.UpdateDepartmentData(entityData);
                var updatedEntity = api.UpdateDepartment(createdEntity.Id, entityData.ToDepartmentUpdateData());
                AssertDepartmentDataEqual(entityData, updatedEntity);
            }
            finally
            {
                api.DeleteDepartment(createdEntity.Id);
            }
        }

        /// <summary>
        /// Test UpsertDepartment
        /// </summary>
        [Fact]
        public void Test_Department_Upsert()
        {
            var entityData = DepartmentTestData.CreateDepartmentData();
            var createdEntity = api.UpsertDepartment(entityData.ToDepartmentData());
            try
            {
                AssertDepartmentDataEqual(entityData, createdEntity);
                DepartmentTestData.UpdateDepartmentData(entityData);
                entityData.Id = createdEntity.Id;
                var updatedEntity = api.UpsertDepartment(entityData.ToDepartmentData());
                Assert.Equal(createdEntity.Id, updatedEntity.Id);
                AssertDepartmentDataEqual(entityData, updatedEntity);
            }
            finally
            {
                api.DeleteDepartment(createdEntity.Id);
            }
        }

        /// <summary>
        /// Test DeleteDepartmentUser
        /// </summary>
        [Fact]
        public void Test_Department_User_Delete()
        {
            var entityData = DepartmentTestData.CreateDepartmentData();
            var createdEntity = api.CreateDepartment(entityData);
            try
            {
                var createdSubEntity = api.UpsertDepartmentUser(createdEntity.Id,
                    new(userId: new("Id", DepartmentTestData.TestUsers[0].ToString())));
                api.DeleteDepartmentUser(createdEntity.Id, createdSubEntity.Id);
                var existingEntityUsers = api.ListDepartmentUsers(createdEntity.Id).Data;
                Assert.Empty(existingEntityUsers);
            }
            finally
            {
                api.DeleteDepartment(createdEntity.Id);
            }
        }

        /// <summary>
        /// Test ListDepartmentUsers
        /// </summary>
        [Fact]
        public void Test_Department_User_List()
        {
            var entityData = DepartmentTestData.CreateDepartmentData();
            var createdEntity = api.CreateDepartment(entityData);
            try
            {
                var createdSubEntities = LocationTestData.TestUsers.Select(i =>
                    api.UpsertDepartmentUser(createdEntity.Id, new(userId: new("Id", i.ToString())))).ToArray();
                try
                {
                    var existingSubEntities = api.ListDepartmentUsers(createdEntity.Id).Data;
                    Assert.Equal(existingSubEntities.Count, createdSubEntities.Length);
                }
                finally
                {
                    foreach (var i in createdSubEntities)
                        api.DeleteDepartmentUser(createdEntity.Id, i.Id);
                }
            }
            finally
            {
                api.DeleteDepartment(createdEntity.Id);
            }
        }

        /// <summary>
        /// Test UpsertDepartmentUser
        /// </summary>
        [Fact]
        public void Test_DepartmentUser_Upsert()
        {
            var entityData = DepartmentTestData.CreateDepartmentData();
            var createdEntity = api.CreateDepartment(entityData);
            try
            {
                var createdSubEntity = api.UpsertDepartmentUser(createdEntity.Id,
                    new(userId: new("Id", DepartmentTestData.TestUsers[0].ToString())));
                try
                {
                    var existingSubEntities = api.ListDepartmentUsers(createdEntity.Id).Data;
                    Assert.Contains(existingSubEntities, i => i.Id == createdSubEntity.Id);
                }
                finally
                {
                    api.DeleteDepartmentUser(createdEntity.Id, createdSubEntity.Id);
                }
            }
            finally
            {
                api.DeleteDepartment(createdEntity.Id);
            }
        }

        /// <summary>
        /// Test PatchDepartmentUsers
        /// </summary>
        [Fact]
        public void PatchDepartmentUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //UsersData usersData = null;
            //string name = null;
            //string deleteNotExists = null;
            //var response = instance.PatchDepartmentUsers(id, usersData, name, deleteNotExists);
            //Assert.IsType<User>(response);
        }
    }
}
