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
using Agile.Now.ApiOrganizations.Test.Api;
using Xunit;
using Xunit.Abstractions;
// uncomment below to import models
//using Agile.Now.AccessHub.Model;

namespace Agile.Now.AccessHub.Test.Api
{
    /// <summary>
    ///  Class for testing LocationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class LocationsApiTests : IDisposable
    {
        private readonly LocationsApi api;

        public LocationsApiTests(ITestOutputHelper testOutputHelper)
        {
            api = new LocationsApi(Settings.Connections[0]);
        }

        public void Dispose() { }

        void AssertLocationDataEqual(LocationInsertData locationInsertData, Location location)
        {
            Assert.Equal(locationInsertData.Name, location.Name);
            //Assert.Equal(locationInsertData.CountryId.ToString(), location.CountryId.Name);
            //Assert.Equal(locationInsertData.TimezoneId.ToString(), location.TimezoneId.Name);
            //Assert.Equal(locationInsertData.CurrencyId.ToString(), location.CurrencyId.Id);
        }

        /// <summary>
        /// Test CreateLocation
        /// </summary>
        [Fact]
        public void Test_Location_Create()
        {
            var entityData = LocationTestData.CreateLocationData();
            var created = api.CreateLocation(entityData);
            try
            {
                AssertLocationDataEqual(entityData, created);
            }
            finally
            {
                api.DeleteLocation(created.Id);
            }
        }

        [Fact]
        public void Test_Location_Create_WithExternalId()
        {
            var externalId = Guid.NewGuid().ToString();
            var data = LocationTestData.CreateLocationData();
            data.ExternalId = externalId;
            var created = api.CreateLocation(data);
            try
            {
                data = LocationTestData.CreateLocationData();
                data.ExternalId = externalId;
                Assert.Throws<ApiException>(() => api.CreateLocation(data));
            }
            finally
            {
                api.DeleteLocation(created.Id);
            }
        }

        /// <summary>
        /// Test DeleteLocation by Id
        /// </summary>
        [Fact]
        public void Test_Location_Delete_ById()
        {
            var created = api.CreateLocation(LocationTestData.CreateLocationData());
            api.DeleteLocation(created.Id);
            Assert.Throws<ApiException>(() => api.GetLocation(created.Id));
        }

        /// <summary>
        /// Test DeleteLocation by Name
        /// </summary>
        [Fact]
        public void Test_Location_Delete_ByName()
        {
            var created = api.CreateLocation(LocationTestData.CreateLocationData());
            api.DeleteLocation(created.Name, "Name");
            Assert.Throws<ApiException>(() => api.GetLocation(created.Id));
        }

        /// <summary>
        /// Test GetLocation by Id
        /// </summary>
        [Fact]
        public void Test_Location_Get_ById()
        {
            var created = api.CreateLocation(LocationTestData.CreateLocationData());
            try
            {
                Assert.Null(Record.Exception(() =>
                {
                    var existing = api.GetLocation(created.Id);
                    Assert.Equal(created.Id, existing.Id);
                    return existing;
                }));
            }
            finally
            {
                api.DeleteLocation(created.Id);
            }
        }

        /// <summary>
        /// Test GetLocation by Name
        /// </summary>
        [Fact]
        public void Test_Location_Get_ByName()
        {
            var created = api.CreateLocation(LocationTestData.CreateLocationData());
            try
            {
                Assert.Null(Record.Exception(() =>
                {
                    var existing = api.GetLocation(created.Name, "Name");
                    Assert.Equal(created.Name, existing.Name);
                    return existing;
                }));
            }
            finally
            {
                api.DeleteLocation(created.Id);
            }
        }

        /// <summary>
        /// Test ListLocations by Id
        /// </summary>
        [Fact]
        public void Test_Location_List_ById()
        {
            var created = CommonTestData.CreateTestDataList(2, LocationTestData.CreateLocationData).
                Select(i => api.CreateLocation(i)).ToArray();
            try
            {
                var existing = api.ListLocations(
                    filters: $"Id In {string.Join("; ", created.Select(i => i.Id))}").Data;
                Assert.Equal(created.Length, existing.Count);
            }
            finally
            {
                foreach (var i in created)
                    api.DeleteLocation(i.Id);
            }
        }

        /// <summary>
        /// Test ListLocations by Name
        /// </summary>
        [Fact]
        public void Test_Location_List_ByName()
        {
            var created = CommonTestData.CreateTestDataList(2, LocationTestData.CreateLocationData).
                Select(i => api.CreateLocation(i)).ToArray();
            try
            {
                var existing = api.ListLocations(
                    filters: $"Name In {string.Join("; ", created.Select(i => i.Name))}").Data;
                Assert.Equal(created.Length, existing.Count);
            }
            finally
            {
                foreach (var i in created)
                    api.DeleteLocation(i.Id);
            }
        }

        /// <summary>
        /// Test UpdateLocation
        /// </summary>
        [Fact]
        public void Test_Location_Update()
        {
            var entityData = LocationTestData.CreateLocationData();
            var created = api.CreateLocation(entityData);
            try
            {
                LocationTestData.UpdateLocationData(entityData);
                var updated = api.UpdateLocation(created.Id, entityData.ToLocationUpdateData());
                AssertLocationDataEqual(entityData, updated);
            }
            finally
            {
                api.DeleteLocation(created.Id);
            }
        }

        /// <summary>
        /// Test UpsertLocation
        /// </summary>
        [Fact]
        public void Test_Location_Upsert()
        {
            var entityData = LocationTestData.CreateLocationData();
            var created = api.UpsertLocation(entityData.ToLocationData());
            try
            {
                AssertLocationDataEqual(entityData, created);
                LocationTestData.UpdateLocationData(entityData);
                entityData.Id = created.Id;
                var updated = api.UpsertLocation(entityData.ToLocationData());
                Assert.Equal(created.Id, updated.Id);
                AssertLocationDataEqual(entityData, updated);
            }
            finally
            {
                api.DeleteLocation(created.Id);
            }
        }

        /// <summary>
        /// Test DeleteLocationUser
        /// </summary>
        [Fact]
        public void Test_Location_User_Delete()
        {
            var created = api.CreateLocation(LocationTestData.CreateLocationData());
            try
            {
                var createdSubEntity = api.UpsertLocationUser(created.Id,
                    UserTestData.CreateUserData1(UserTestData.Users[0]));
                api.DeleteLocationUser(created.Id, createdSubEntity.Id);
                var existing = api.ListLocationUsers(created.Id).Data;
                Assert.DoesNotContain(existing, i => i.Id == createdSubEntity.Id);
            }
            finally
            {
                api.DeleteLocation(created.Id);
            }
        }

        /// <summary>
        /// Test ListLocationUsers
        /// </summary>
        [Fact]
        public void Test_Location_User_List()
        {
            var created = api.CreateLocation(LocationTestData.CreateLocationData());
            try
            {
                var createdSubEntities = UserTestData.Users.Select(i =>
                    api.UpsertLocationUser(created.Id, UserTestData.CreateUserData1(i))).ToArray();
                try
                {
                    var existing = api.ListLocationUsers(created.Id).Data;
                    Assert.Equal(createdSubEntities.Length, existing.Count);
                }
                finally
                {
                    foreach (var i in createdSubEntities)
                        api.DeleteLocationUser(created.Id, i.Id);

                }
            }
            finally
            {
                api.DeleteLocation(created.Id);
            }
        }

        /// <summary>
        /// Test UpsertLocationUser
        /// </summary>
        [Fact]
        public void Test_Location_User_Upsert()
        {
            var created = api.CreateLocation(LocationTestData.CreateLocationData());
            try
            {
                var createdSubEntity = api.UpsertLocationUser(created.Id,
                    UserTestData.CreateUserData1(UserTestData.Users[0]));
                try
                {
                    var existing = api.ListLocationUsers(created.Id).Data;
                    Assert.Contains(existing, i => i.Id == createdSubEntity.Id);
                }
                finally
                {
                    api.DeleteLocationUser(created.Id, createdSubEntity.Id);
                }
            }
            finally
            {
                api.DeleteLocation(created.Id);
            }
        }

        /// <summary>
        /// Test PatchLocationUsers
        /// </summary>
        [Fact]
        public void Test_Location_User_Patch()
        {
            var created = api.CreateLocation(LocationTestData.CreateLocationData());
            try
            {
                var createdSubEntity = api.UpsertLocationUser(created.Id.ToString(),
                    UserTestData.CreateUserData1(UserTestData.Users[0]));
                api.PatchLocationUsers(created.Id.ToString(),
                    new(users: new List<UserText1> {
                        new(userId: UserTestData.Users[1].ToString()),
                        new(userId: UserTestData.Users[2].ToString(), id: createdSubEntity.Id)
                    }));
                var existing = api.ListLocationUsers(created.Id.ToString()).Data;
                Assert.Contains(existing, i => i.UserId.Id == UserTestData.Users[1]);
                Assert.Contains(existing, i => i.UserId.Id == UserTestData.Users[2] && i.Id == createdSubEntity.Id);
            }
            finally
            {
                api.DeleteLocation(created.Id.ToString());
            }
        }
    }
}
