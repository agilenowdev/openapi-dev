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
using Agile.Now.ApiOrganizations.Test.Api;
using Xunit;
using Xunit.Abstractions;
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
    public class DepartmentsApiTests : IDisposable {
        private readonly DepartmentsApi api;

        public DepartmentsApiTests(ITestOutputHelper testOutputHelper) {
            api = new DepartmentsApi(Settings.Connections[0]);
        }

        public void Dispose() { }

        /// <summary>
        /// Test CreateDepartment
        /// </summary>
        [Fact]
        public void Test_Department_Create() {
            var data = DepartmentTestData.CreateDepartmentData();
            var created = api.CreateDepartment(data);
            try {
                data.AssertEqual(created);
            }
            finally {
                api.DeleteDepartment(created.Id);
            }
        }

        /// <summary>
        /// Test CreateDepartment - unique ExternalId
        /// </summary>
        [Fact]
        public void Test_Department_Create_UniqueExternalId() {
            var externalId = Guid.NewGuid().ToString();
            var data = DepartmentTestData.CreateDepartmentData();
            data.ExternalId = externalId;
            var created = api.CreateDepartment(data);
            try {
                data = DepartmentTestData.CreateDepartmentData();
                data.ExternalId = externalId;
                Assert.Throws<ApiException>(() => api.CreateDepartment(data));
            }
            finally {
                api.DeleteDepartment(created.Id);
            }
        }

        /// <summary>
        /// Test DeleteDepartment by Id
        /// </summary>
        [Fact]
        public void Test_Department_Delete_ById() {
            var created = api.CreateDepartment(DepartmentTestData.CreateDepartmentData());
            api.DeleteDepartment(created.Id);
            Assert.Throws<ApiException>(() => api.GetDepartment(created.Id));
        }

        /// <summary>
        /// Test DeleteDepartment by Name
        /// </summary>
        [Fact]
        public void Test_Department_Delete_ByName() {
            var created = api.CreateDepartment(DepartmentTestData.CreateDepartmentData());
            api.DeleteDepartment(created.Name, "Name");
            Assert.Throws<ApiException>(() => api.GetDepartment(created.Id));
        }

        /// <summary>
        /// Test GetDepartment by Id
        /// </summary>
        [Fact]
        public void Test_Department_Get_ById() {
            var created = api.CreateDepartment(DepartmentTestData.CreateDepartmentData());
            try {
                Assert.Null(Record.Exception(() => {
                    var existing = api.GetDepartment(created.Id);
                    Assert.Equal(created.Id, existing.Id);
                    return existing;
                }));
            }
            finally {
                api.DeleteDepartment(created.Id);
            }
        }

        /// <summary>
        /// Test GetDepartment by Name
        /// </summary>
        [Fact]
        public void Test_Department_Get_ByName() {
            var created = api.CreateDepartment(DepartmentTestData.CreateDepartmentData());
            try {
                Assert.Null(Record.Exception(() => {
                    var existing = api.GetDepartment(created.Name, "Name");
                    Assert.Equal(created.Name, existing.Name);
                    return existing;
                }));
            }
            finally {
                api.DeleteDepartment(created.Id);
            }
        }

        /// <summary>
        /// Test ListDepartments by Id
        /// </summary>
        [Fact]
        public void Test_Department_List_ById() {
            var created = CommonTestData.CreateTestDataList(2, DepartmentTestData.CreateDepartmentData).
                Select(i => api.CreateDepartment(i)).ToArray();
            try {
                var existing = api.ListDepartments(
                    filters: $"Id In {string.Join("; ", created.Select(i => i.Id))}").Data;
                Assert.Equal(created.Length, existing.Count);
            }
            finally {
                foreach(var i in created)
                    api.DeleteDepartment(i.Id);
            }
        }

        /// <summary>
        /// Test ListDepartments by Name
        /// </summary>
        [Fact]
        public void Test_Department_List_ByName() {
            var created = CommonTestData.CreateTestDataList(2, DepartmentTestData.CreateDepartmentData).
                Select(i => api.CreateDepartment(i)).ToArray();
            try {
                var existing = api.ListDepartments(
                    filters: $"Name In {string.Join("; ", created.Select(i => i.Name))}").Data;
                Assert.Equal(created.Length, existing.Count);
            }
            finally {
                foreach(var i in created)
                    api.DeleteDepartment(i.Id);
            }
        }

        /// <summary>
        /// Test ListDepartments with paging
        /// </summary>
        [Fact]
        public void Test_Department_List_Paging() {
            var created = CommonTestData.CreateTestDataList(4, DepartmentTestData.CreateDepartmentData)
                .Select(i => api.CreateDepartment(i)).ToArray();
            try {
                var filters = $"Name In {string.Join("; ", created.Select(i => i.Name))}";
                var pageSize = 2;
                var pages = new[] {
                    api.ListDepartments(filters: filters, currentPage: 0, pageSize: pageSize).Data,
                    api.ListDepartments(filters: filters, currentPage: 1, pageSize: pageSize).Data,
                };
                Assert.Equal(pageSize, pages[0].Count);
                Assert.Equal(pageSize, pages[1].Count);
                Assert.Equal(created.Length, pages[0].Concat(pages[1]).GroupBy(i => i.Id).Count());
            }
            finally {
                foreach(var i in created)
                    api.DeleteDepartment(i.Id);
            }
        }

        /// <summary>
        /// Test UpdateDepartment
        /// </summary>
        [Fact]
        public void Test_Department_Update() {
            var data = DepartmentTestData.CreateDepartmentData();
            var created = api.CreateDepartment(data);
            try {
                data.Update();
                var updated = api.UpdateDepartment(created.Id, data.ToDepartmentUpdateData());
                Assert.Equal(created.Id, updated.Id);
                data.AssertEqual(updated);
            }
            finally {
                api.DeleteDepartment(created.Id);
            }
        }

        /// <summary>
        /// Test UpsertDepartment
        /// </summary>
        [Fact]
        public void Test_Department_Upsert() {
            var data = DepartmentTestData.CreateDepartmentData();
            var created = api.UpsertDepartment(data.ToDepartmentData());
            try {
                data.AssertEqual(created);
                data.Update();
                data.Id = created.Id;
                var updated = api.UpsertDepartment(data.ToDepartmentData());
                Assert.Equal(created.Id, updated.Id);
                data.AssertEqual(updated);
            }
            finally {
                api.DeleteDepartment(created.Id);
            }
        }

        /// <summary>
        /// Test DeleteDepartmentUser
        /// </summary>
        [Fact]
        public void Test_Department_User_Delete() {
            var entity = api.CreateDepartment(DepartmentTestData.CreateDepartmentData());
            try {
                var created = api.UpsertDepartmentUser(entity.Id, UserTestData.CreateUserData1(UserTestData.Users[0]));
                api.DeleteDepartmentUser(entity.Id, created.Id.ToString());
                var existing = api.ListDepartmentUsers(entity.Id).Data;
                Assert.Empty(existing);
            }
            finally {
                api.DeleteDepartment(entity.Id);
            }
        }

        /// <summary>
        /// Test ListDepartmentUsers
        /// </summary>
        [Fact]
        public void Test_Department_User_List() {
            var entity = api.CreateDepartment(DepartmentTestData.CreateDepartmentData());
            try {
                var created = UserTestData.Users.Select(i =>
                    api.UpsertDepartmentUser(entity.Id, UserTestData.CreateUserData1(i))).ToArray();
                try {
                    var existing = api.ListDepartmentUsers(entity.Id).Data;
                    Assert.Equal(existing.Count, created.Length);
                }
                finally {
                    foreach(var i in created)
                        api.DeleteDepartmentUser(entity.Id, i.Id.ToString());
                }
            }
            finally {
                api.DeleteDepartment(entity.Id);
            }
        }

        /// <summary>
        /// Test UpsertDepartmentUser
        /// </summary>
        [Fact]
        public void Test_Department_User_Upsert() {
            var entity = api.CreateDepartment(DepartmentTestData.CreateDepartmentData());
            try {
                var data = UserTestData.CreateUserData1(UserTestData.Users[0]);
                var created = api.UpsertDepartmentUser(entity.Id, data);
                try {
                    var existing = api.ListDepartmentUsers(entity.Id).Data;
                    Assert.Contains(existing, i => i.Id == created.Id);
                    data = UserTestData.CreateUserData1(UserTestData.Users[1]);
                    data.Id = created.Id.ToString();
                    var updated = api.UpsertDepartmentUser(entity.Id, data);
                    Assert.Equal(created.Id, updated.Id);
                    Assert.Equal(data.UserId.Value, updated.Id.ToString());
                }
                finally {
                    api.DeleteDepartmentUser(entity.Id, created.Id.ToString(), subName: "UserId");
                }
            }
            finally {
                api.DeleteDepartment(entity.Id);
            }
        }

        /// <summary>
        /// Test PatchDepartmentUsers
        /// </summary>
        [Fact]
        public void Test_Department_User_Patch() {
            var entity = api.CreateDepartment(DepartmentTestData.CreateDepartmentData());
            try {
                var created = api.UpsertDepartmentUser(entity.Id.ToString(),
                    UserTestData.CreateUserData1(UserTestData.Users[0]));
                try {
                    var patched = api.PatchDepartmentUsers(entity.Id.ToString(),
                        new(users: new List<UserText1> {
                            new(userId: UserTestData.Users[1].ToString()),
                            new(userId: UserTestData.Users[2].ToString(), id: created.Id.ToString())
                        })).Data;
                    try {
                        var existing = api.ListDepartmentUsers(entity.Id.ToString()).Data;
                        Assert.Contains(existing, i => i.Id == UserTestData.Users[1]);
                        Assert.Contains(existing, i => i.Id == UserTestData.Users[2] && i.Id == created.Id);
                    }
                    finally {
                        api.DeleteDepartmentUser(entity.Id, patched.First(i => i.Id != created.Id).Id.ToString());
                    }
                }
                finally {
                    api.DeleteDepartmentUser(entity.Id, created.Id.ToString());
                }
            }
            finally {
                api.DeleteDepartment(entity.Id.ToString());
            }
        }

        /// <summary>
        /// Test PatchDepartmentUsers with deleteNotExists
        /// </summary>
        [Fact]
        public void Test_Department_User_Patch_DeleteNotExists() {
            var entity = api.CreateDepartment(DepartmentTestData.CreateDepartmentData());
            try {
                var toDelete = api.UpsertDepartmentUser(entity.Id, UserTestData.CreateUserData1(UserTestData.Users[0]));
                var toPatch = api.UpsertDepartmentUser(entity.Id, UserTestData.CreateUserData1(UserTestData.Users[1]));
                try {
                    api.PatchDepartmentUsers(entity.Id.ToString(),
                        new(users: new List<UserText1> {
                            new(userId: UserTestData.Users[2].ToString(), id: toPatch.Id.ToString())
                        }),
                        deleteNotExists: true.ToString());
                    toDelete = null;
                    var existing = api.ListDepartmentUsers(entity.Id.ToString()).Data;
                    Assert.Single(existing);
                    Assert.Contains(existing, i => i.Id == UserTestData.Users[2] && i.Id == toPatch.Id);
                }
                finally {
                    if(toDelete != null)
                        api.DeleteDepartmentUser(entity.Id, toDelete.Id.ToString());
                    api.DeleteDepartmentUser(entity.Id, toPatch.Id.ToString());
                }
            }
            finally {
                api.DeleteDepartment(entity.Id.ToString());
            }
        }
    }
}
