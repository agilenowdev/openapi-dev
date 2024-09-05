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
using Agile.Now.ApiOrganizations.Test.Api;
using Xunit;
using Xunit.Abstractions;
using static System.Runtime.InteropServices.JavaScript.JSType;
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
            api = new DepartmentsApi(Settings.Connections[0]);
        }

        public void Dispose() { }

        void AssertDepartmentDataEqual(DepartmentInsertData departmentInsertData, Department department)
        {
            Assert.Equal(departmentInsertData.Name, department.Name);
            Assert.Equal(departmentInsertData.DepartmentTypeId.ToString(), department.DepartmentTypeId.Id);
            Assert.Equal(departmentInsertData.ParentDepartmentId.Value ?? "", department.ParentDepartmentId.Id ?? "");
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
            var data = DepartmentTestData.CreateDepartmentData();
            var created = api.CreateDepartment(data);
            try
            {
                AssertDepartmentDataEqual(data, created);
            }
            finally
            {
                api.DeleteDepartment(created.Id);
            }
        }

        /// <summary>
        /// Test CreateDepartment - unique ExternalId
        /// </summary>
        [Fact]
        public void Test_Department_Create_UniqueExternalId()
        {
            var externalId = Guid.NewGuid().ToString();
            var data = DepartmentTestData.CreateDepartmentData();
            data.ExternalId = externalId;
            var created = api.CreateDepartment(data);
            try
            {
                data = DepartmentTestData.CreateDepartmentData();
                data.ExternalId = externalId;
                Assert.Throws<ApiException>(() => api.CreateDepartment(data));
            }
            finally
            {
                api.DeleteDepartment(created.Id);
            }
        }

        /// <summary>
        /// Test DeleteDepartment by Id
        /// </summary>
        [Fact]
        public void Test_Department_Delete_ById()
        {
            var created = api.CreateDepartment(DepartmentTestData.CreateDepartmentData());
            api.DeleteDepartment(created.Id);
            Assert.Throws<ApiException>(() => api.GetDepartment(created.Id));
        }

        /// <summary>
        /// Test DeleteDepartment by Name
        /// </summary>
        [Fact]
        public void Test_Department_Delete_ByName()
        {
            var created = api.CreateDepartment(DepartmentTestData.CreateDepartmentData());
            api.DeleteDepartment(created.Name, "Name");
            Assert.Throws<ApiException>(() => api.GetDepartment(created.Id));
        }

        /// <summary>
        /// Test GetDepartment by Id
        /// </summary>
        [Fact]
        public void Test_Department_Get_ById()
        {
            var created = api.CreateDepartment(DepartmentTestData.CreateDepartmentData());
            try
            {
                Assert.Null(Record.Exception(() =>
                {
                    var existing = api.GetDepartment(created.Id);
                    Assert.Equal(created.Id, existing.Id);
                    return existing;
                }));
            }
            finally
            {
                api.DeleteDepartment(created.Id);
            }
        }

        /// <summary>
        /// Test GetDepartment by Name
        /// </summary>
        [Fact]
        public void Test_Department_Get_ByName()
        {
            var created = api.CreateDepartment(DepartmentTestData.CreateDepartmentData());
            try
            {
                Assert.Null(Record.Exception(() =>
                {
                    var existing = api.GetDepartment(created.Name, "Name");
                    Assert.Equal(created.Name, existing.Name);
                    return existing;
                }));
            }
            finally
            {
                api.DeleteDepartment(created.Id);
            }
        }

        /// <summary>
        /// Test ListDepartments by Id
        /// </summary>
        [Fact]
        public void Test_Department_List_ById()
        {
            var created = CommonTestData.CreateTestDataList(2, DepartmentTestData.CreateDepartmentData).
                Select(i => api.CreateDepartment(i)).ToArray();
            try
            {
                var existing = api.ListDepartments(
                    filters: $"Id In {string.Join("; ", created.Select(i => i.Id))}").Data;
                Assert.Equal(created.Length, existing.Count);
            }
            finally
            {
                foreach (var i in created)
                    api.DeleteDepartment(i.Id);
            }
        }

        /// <summary>
        /// Test ListDepartments by Name
        /// </summary>
        [Fact]
        public void Test_Department_List_ByName()
        {
            var created = CommonTestData.CreateTestDataList(2, DepartmentTestData.CreateDepartmentData).
                Select(i => api.CreateDepartment(i)).ToArray();
            try
            {
                var existing = api.ListDepartments(
                    filters: $"Name In {string.Join("; ", created.Select(i => i.Name))}").Data;
                Assert.Equal(created.Length, existing.Count);
            }
            finally
            {
                foreach (var i in created)
                    api.DeleteDepartment(i.Id);
            }
        }

        /// <summary>
        /// Test UpdateDepartment
        /// </summary>
        [Fact]
        public void Test_Department_Update()
        {
            var data = DepartmentTestData.CreateDepartmentData();
            var created = api.CreateDepartment(data);
            try
            {
                DepartmentTestData.UpdateDepartmentData(data);
                var updated = api.UpdateDepartment(created.Id, data.ToDepartmentUpdateData());
                AssertDepartmentDataEqual(data, updated);
            }
            finally
            {
                api.DeleteDepartment(created.Id);
            }
        }

        /// <summary>
        /// Test UpsertDepartment
        /// </summary>
        [Fact]
        public void Test_Department_Upsert()
        {
            var data = DepartmentTestData.CreateDepartmentData();
            var created = api.UpsertDepartment(data.ToDepartmentData());
            try
            {
                AssertDepartmentDataEqual(data, created);
                DepartmentTestData.UpdateDepartmentData(data);
                data.Id = created.Id;
                var updated = api.UpsertDepartment(data.ToDepartmentData());
                Assert.Equal(created.Id, updated.Id);
                AssertDepartmentDataEqual(data, updated);
            }
            finally
            {
                api.DeleteDepartment(created.Id);
            }
        }

        /// <summary>
        /// Test DeleteDepartmentUser
        /// </summary>
        [Fact]
        public void Test_Department_User_Delete()
        {
            var created = api.CreateDepartment(DepartmentTestData.CreateDepartmentData());
            try
            {
                var createdSubEntity = api.UpsertDepartmentUser(created.Id,
                    UserTestData.CreateUserData1(UserTestData.Users[0]));
                api.DeleteDepartmentUser(created.Id, createdSubEntity.Id);
                var existing = api.ListDepartmentUsers(created.Id).Data;
                Assert.Empty(existing);
            }
            finally
            {
                api.DeleteDepartment(created.Id);
            }
        }

        /// <summary>
        /// Test ListDepartmentUsers
        /// </summary>
        [Fact]
        public void Test_Department_User_List()
        {
            var created = api.CreateDepartment(DepartmentTestData.CreateDepartmentData());
            try
            {
                var createdSubEntities = UserTestData.Users.Select(i =>
                    api.UpsertDepartmentUser(created.Id, UserTestData.CreateUserData1(i))).ToArray();
                try
                {
                    var existing = api.ListDepartmentUsers(created.Id).Data;
                    Assert.Equal(existing.Count, createdSubEntities.Length);
                }
                finally
                {
                    foreach (var i in createdSubEntities)
                        api.DeleteDepartmentUser(created.Id, i.Id);
                }
            }
            finally
            {
                api.DeleteDepartment(created.Id);
            }
        }

        /// <summary>
        /// Test UpsertDepartmentUser
        /// </summary>
        [Fact]
        public void Test_Department_User_Upsert()
        {
            var created = api.CreateDepartment(DepartmentTestData.CreateDepartmentData());
            try
            {
                var data = UserTestData.CreateUserData1(UserTestData.Users[0]);
                var createdSubEntity = api.UpsertDepartmentUser(created.Id, data);
                try
                {
                    var existing = api.ListDepartmentUsers(created.Id).Data;
                    Assert.Contains(existing, i => i.Id == createdSubEntity.Id);
                    data = UserTestData.CreateUserData1(UserTestData.Users[1]);
                    data.Id = createdSubEntity.Id;
                    var updated = api.UpsertDepartmentUser(created.Id, data);
                    Assert.Equal(createdSubEntity.Id, updated.Id);
                    Assert.Equal(data.UserId.Value, updated.UserId.Id.ToString());
                }
                finally
                {
                    api.DeleteDepartmentUser(created.Id, createdSubEntity.Id);
                }
            }
            finally
            {
                api.DeleteDepartment(created.Id);
            }
        }

        /// <summary>
        /// Test PatchDepartmentUsers
        /// </summary>
        [Fact]
        public void Test_Department_User_Patch()
        {
            var created = api.CreateDepartment(DepartmentTestData.CreateDepartmentData());
            try
            {
                var createdSubEntity = api.UpsertDepartmentUser(created.Id.ToString(),
                    UserTestData.CreateUserData1(UserTestData.Users[0]));
                api.PatchDepartmentUsers(created.Id.ToString(),
                    new(users: new List<UserText1> {
                        new(userId: UserTestData.Users[1].ToString()),
                        new(userId: UserTestData.Users[2].ToString(), id: createdSubEntity.Id)
                    }));
                var existing = api.ListDepartmentUsers(created.Id.ToString()).Data;
                Assert.Contains(existing, i => i.UserId.Id == UserTestData.Users[1]);
                Assert.Contains(existing, i => i.UserId.Id == UserTestData.Users[2] && i.Id == createdSubEntity.Id);
            }
            finally
            {
                api.DeleteDepartment(created.Id.ToString());
            }
        }
    }
}
