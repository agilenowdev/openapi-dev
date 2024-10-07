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

namespace Agile.Now.AccessHub.Test.Api {
    /// <summary>
    ///  Class for testing LocationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class LocationsApiTests : IDisposable {
        private readonly LocationsApi api;

        public LocationsApiTests(ITestOutputHelper testOutputHelper) {
            api = new LocationsApi(Settings.Connections[0]);
        }

        public void Dispose() { }

        /// <summary>
        /// Test CreateLocation
        /// </summary>
        [Fact]
        public void Test_Location_Create() {
            var data = LocationTestData.CreateLocationData();
            var created = api.CreateLocation(data);
            try {
                data.AssertEqual(created);
            }
            finally {
                api.DeleteLocation(created.Id);
            }
        }

        /// <summary>
        /// Test CreateLocation - unique Name
        /// </summary>
        [Fact]
        public void Test_Location_Create_UniqueName() {
            var uniqueValue = Guid.NewGuid().ToString();
            var data = LocationTestData.CreateLocationData();
            data.Name = uniqueValue;
            var created = api.CreateLocation(data);
            try {
                data = LocationTestData.CreateLocationData();
                data.Name = uniqueValue;
                Assert.Throws<ApiException>(() => api.CreateLocation(data));
            }
            finally {
                api.DeleteLocation(created.Id);
            }
        }

        /// <summary>
        /// Test CreateLocation - unique ExternalId
        /// </summary>
        [Fact]
        public void Test_Location_Create_UniqueExternalId() {
            var externalId = Guid.NewGuid().ToString();
            var data = LocationTestData.CreateLocationData();
            data.ExternalId = externalId;
            var created = api.CreateLocation(data);
            try {
                data = LocationTestData.CreateLocationData();
                data.ExternalId = externalId;
                Assert.Throws<ApiException>(() => api.CreateLocation(data));
            }
            finally {
                api.DeleteLocation(created.Id);
            }
        }

        /// <summary>
        /// </summary>
        [Fact]
        public void Test_Location_Delete_ById() {
            var created = api.CreateLocation(LocationTestData.CreateLocationData());
            api.DeleteLocation(created.Id);
            Assert.Throws<ApiException>(() => api.GetLocation(created.Id));
        }

        /// <summary>
        /// Test DeleteLocation by Name
        /// </summary>
        [Fact]
        public void Test_Location_Delete_ByName() {
            var created = api.CreateLocation(LocationTestData.CreateLocationData());
            api.DeleteLocation(created.Name, "Name");
            Assert.Throws<ApiException>(() => api.GetLocation(created.Id));
        }

        /// <summary>
        /// Test UpdateLocation
        /// </summary>
        [Fact]
        public void Test_Location_Update() {
            var data = LocationTestData.CreateLocationData();
            var created = api.CreateLocation(data);
            try {
                data.Update();
                var updated = api.UpdateLocation(created.Id, data.ToLocationUpdateData());
                Assert.Equal(created.Id, updated.Id);
                data.AssertEqual(updated);
            }
            finally {
                api.DeleteLocation(created.Id);
            }
        }

        /// <summary>
        /// Test UpsertLocation
        /// </summary>
        [Fact]
        public void Test_Location_Upsert() {
            var data = LocationTestData.CreateLocationData();
            var created = api.UpsertLocation(data.ToLocationData());
            try {
                data.AssertEqual(created);
                data.Update();
                data.Id = created.Id;
                var updated = api.UpsertLocation(data.ToLocationData());
                Assert.Equal(created.Id, updated.Id);
                data.AssertEqual(updated);
            }
            finally {
                api.DeleteLocation(created.Id);
            }
        }

        /// <summary>
        /// Test DeleteLocationUser
        /// </summary>
        [Fact]
        public void Test_Location_User_Delete() {
            var entity = api.CreateLocation(LocationTestData.CreateLocationData());
            try {
                var created = api.UpsertLocationUser(entity.Id, UserTestData.CreateUserData1(UserTestData.Users[0]));
                api.DeleteLocationUser(entity.Id, created.Id.ToString(), subName: "UserId");
                var existing = api.ListLocationUsers(entity.Id).Data;
                Assert.Empty(existing);
            }
            finally {
                api.DeleteLocation(entity.Id);
            }
        }

        /// <summary>
        /// Test ListLocationUsers
        /// </summary>
        [Fact]
        public void Test_Location_User_List() {
            var entity = api.CreateLocation(LocationTestData.CreateLocationData());
            try {
                var created = UserTestData.Users.Select(i =>
                    api.UpsertLocationUser(entity.Id, UserTestData.CreateUserData1(i))).ToArray();
                try {
                    var existing = api.ListLocationUsers(entity.Id).Data;
                    Assert.Equal(created.Length, existing.Count);
                }
                finally {
                    foreach(var i in created)
                        api.DeleteLocationUser(entity.Id, i.Id.ToString(), subName: "UserId");

                }
            }
            finally {
                api.DeleteLocation(entity.Id);
            }
        }

        /// <summary>
        /// Test UpsertLocationUser
        /// </summary>
        [Fact]
        public void Test_Location_User_Upsert() {
            var entity = api.CreateLocation(LocationTestData.CreateLocationData());
            try {
                var data = UserTestData.CreateUserData1(UserTestData.Users[0]);
                var created = api.UpsertLocationUser(entity.Id, data);
                try {
                    var existing = api.ListLocationUsers(entity.Id).Data;
                    Assert.Contains(existing, i => i.Id == created.Id);
                    data = UserTestData.CreateUserData1(UserTestData.Users[1]);
                    data.Id = created.Id.ToString();
                    var updated = api.UpsertLocationUser(entity.Id, data);
                    Assert.Equal(created.Id, updated.Id);
                    Assert.Equal(data.UserId.Value, updated.Id.ToString());
                }
                finally {
                    api.DeleteLocationUser(entity.Id, created.Id.ToString(), subName: "UserId");
                }
            }
            finally {
                api.DeleteLocation(entity.Id);
            }
        }

        /// <summary>
        /// Test PatchLocationUsers
        /// </summary>
        [Fact]
        public void Test_Location_User_Patch() {
            var entity = api.CreateLocation(LocationTestData.CreateLocationData());
            try {
                var created = api.UpsertLocationUser(entity.Id.ToString(),
                    UserTestData.CreateUserData1(UserTestData.Users[0]));
                try {
                    var patched = api.PatchLocationUsers(entity.Id.ToString(),
                        new(users: new List<UserText1> {
                            new(userId: UserTestData.Users[1].ToString())
                            //,
                            //new(userId: UserTestData.Users[2].ToString(), id: created.Id.ToString())
                        })).Data;
                    try {
                        var existing = api.ListLocationUsers(entity.Id.ToString()).Data;
                        Assert.Contains(existing, i => i.Id == UserTestData.Users[1]);
                        //Assert.Contains(existing, i => i.Id == UserTestData.Users[2] && i.Id == created.Id);
                    }
                    finally {
                        api.DeleteLocationUser(entity.Id, patched.First(i => i.Id != created.Id).Id.ToString(), subName: "UserId");
                    }
                }
                finally {
                    api.DeleteLocationUser(entity.Id, created.Id.ToString(), subName: "UserId");
                }
            }
            finally {
                api.DeleteLocation(entity.Id.ToString());
            }
        }

        /// <summary>
        /// Test PatchLocationUsers with deleteNotExists
        /// </summary>
        [Fact]
        public void Test_Location_User_Patch_DeleteNotExists() {
            var entity = api.CreateLocation(LocationTestData.CreateLocationData());
            try {
                var toDelete = api.UpsertLocationUser(entity.Id, UserTestData.CreateUserData1(UserTestData.Users[0]));
                var toPatch = api.UpsertLocationUser(entity.Id, UserTestData.CreateUserData1(UserTestData.Users[1]));
                try {
                    api.PatchLocationUsers(entity.Id.ToString(),
                        new(users: new List<UserText1> {
                            new(userId: UserTestData.Users[2].ToString())
                        }),
                        deleteNotExists: true.ToString());
                    toDelete = null;
                    var existing = api.ListLocationUsers(entity.Id.ToString()).Data;
                    Assert.Single(existing);
                    Assert.Contains(existing, i => i.Id == UserTestData.Users[2] && i.Id == toPatch.Id);
                }
                finally {
                    if(toDelete != null)
                        api.DeleteLocationUser(entity.Id, toDelete.Id.ToString(), subName: "UserId");
                    api.DeleteLocationUser(entity.Id, toPatch.Id.ToString(), subName: "UserId");
                }
            }
            finally {
                api.DeleteLocation(entity.Id.ToString());
            }
        }
    }
}
