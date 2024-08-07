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
            Configuration configuration = new Configuration
            {
                BasePath = "https://dev.esystems.fi",
                OAuthTokenUrl = "https://dev.esystems.fi/oAuth/rest/v2/Token",
                OAuthFlow = Client.Auth.OAuthFlow.APPLICATION,
                OAuthClientId = "c8907421-0886-4fb0-b859-d29966762e16",
                OAuthClientSecret = "1da54fa9-ae11-4db3-9740-1bb47b85cd8e"
            };
            api = new LocationsApi(configuration);
        }

        public void Dispose()
        {
        }

        /// <summary>
        /// Test an instance of LocationsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
        }

        void AssertLocationDataEqual(LocationInsertData locationInsertData, Location location)
        {
            Assert.Equal(locationInsertData.Name, location.Name);
            //Assert.Equal(locationInsertData.CountryId.ToString(), location.CountryId.Name);
            //Assert.Equal(locationInsertData.CurrencyId.ToString(), location.CurrencyId.Id);
        }

        /// <summary>
        /// Test CreateLocation
        /// </summary>
        [Fact]
        public void Test_Location_Create()
        {
            var entityData = TestLocationData.CreateLocationData();
            var createdEntity = api.CreateLocation(entityData);
            try
            {
                AssertLocationDataEqual(entityData, createdEntity);
            }
            finally
            {
                api.DeleteLocation(createdEntity.Id);
            }
        }

        /// <summary>
        /// Test DeleteLocation by Id
        /// </summary>
        [Fact]
        public void Test_Location_Delete_ById()
        {
            var createdEntity = api.CreateLocation(TestLocationData.CreateLocationData());
            api.DeleteLocation(createdEntity.Id);
            Assert.Throws<ApiException>(() => api.GetLocation(createdEntity.Id));
        }

        /// <summary>
        /// Test DeleteLocation by Name
        /// </summary>
        [Fact]
        public void Test_Location_Delete_ByName()
        {
            var createdEntity = api.CreateLocation(TestLocationData.CreateLocationData());
            api.DeleteLocation(createdEntity.Name, "Name");
            Assert.Throws<ApiException>(() => api.GetLocation(createdEntity.Id));
        }

        /// <summary>
        /// Test GetLocation by Id
        /// </summary>
        [Fact]
        public void Test_Location_Get_ById()
        {
            var createdEntity = api.CreateLocation(TestLocationData.CreateLocationData());
            try
            {
                Assert.Null(Record.Exception(() =>
                {
                    var existingEntity = api.GetLocation(createdEntity.Id);
                    Assert.Equal(createdEntity.Id, existingEntity.Id);
                    return existingEntity;
                }));
            }
            finally
            {
                api.DeleteLocation(createdEntity.Id);
            }
        }

        /// <summary>
        /// Test GetLocation by Name
        /// </summary>
        [Fact]
        public void Test_Location_Get_ByName()
        {
            var createdEntity = api.CreateLocation(TestLocationData.CreateLocationData());
            try
            {
                Assert.Null(Record.Exception(() =>
                {
                    var existingEntity = api.GetLocation(createdEntity.Name, "Name");
                    Assert.Equal(createdEntity.Name, existingEntity.Name);
                    return existingEntity;
                }));
            }
            finally
            {
                api.DeleteLocation(createdEntity.Id);
            }
        }

        /// <summary>
        /// Test ListLocations by Id
        /// </summary>
        [Fact]
        public void Test_Location_List_ById()
        {
            var createdEntities = TestLocationData.CreateLocationDataList(2).Select(i => api.CreateLocation(i)).ToArray();
            try
            {
                var existingEntities = api.ListLocations(
                    filters: $"Id In {string.Join("; ", createdEntities.Select(i => i.Id))}").Data;
                Assert.Equal(createdEntities.Length, existingEntities.Count);
            }
            finally
            {
                foreach (var i in createdEntities)
                    api.DeleteLocation(i.Id);
            }
        }

        /// <summary>
        /// Test ListLocations by Name
        /// </summary>
        [Fact]
        public void Test_Location_List_ByName()
        {
            var entityData = TestLocationData.CreateLocationDataList(2);
            var createdEntities = entityData.Select(i => api.CreateLocation(i)).ToArray();
            try
            {
                var existingEntities = api.ListLocations(
                    filters: $"Name In {string.Join("; ", createdEntities.Select(i => i.Name))}").Data;
                Assert.Equal(createdEntities.Length, existingEntities.Count);
            }
            finally
            {
                foreach (var i in createdEntities)
                    api.DeleteLocation(i.Id);
            }
        }

        /// <summary>
        /// Test UpdateLocation
        /// </summary>
        [Fact]
        public void Test_Location_Update()
        {
            var entityData = TestLocationData.CreateLocationData();
            var createdEntity = api.CreateLocation(entityData);
            try
            {
                TestLocationData.UpdateLocationData(entityData);
                var updatedEntity = api.UpdateLocation(createdEntity.Id, entityData.ToLocationUpdateData());
                AssertLocationDataEqual(entityData, updatedEntity);
            }
            finally
            {
                api.DeleteLocation(createdEntity.Id);
            }
        }

        /// <summary>
        /// Test UpsertLocation
        /// </summary>
        [Fact]
        public void Test_Location_Upsert()
        {
            var entityData = TestLocationData.CreateLocationData();
            var createdEntity = api.UpsertLocation(entityData.ToLocationData());
            try
            {
                AssertLocationDataEqual(entityData, createdEntity);
                TestLocationData.UpdateLocationData(entityData);
                entityData.Id = createdEntity.Id;
                var updatedEntity = api.UpsertLocation(entityData.ToLocationData());
                Assert.Equal(createdEntity.Id, updatedEntity.Id);
                AssertLocationDataEqual(entityData, updatedEntity);
            }
            finally
            {
                api.DeleteLocation(createdEntity.Id);
            }
        }

        /// <summary>
        /// Test DeleteLocationUser
        /// </summary>
        [Fact]
        public void Test_Location_User_Delete()
        {
            var entityData = TestLocationData.CreateLocationData();
            var createdEntity = api.CreateLocation(entityData);
            try
            {
                var createdSubEntity = api.UpsertLocationUser(createdEntity.Id,
                    new(userId: new("Id", TestLocationData.TestUsers[0].ToString())));
                api.DeleteLocationUser(createdEntity.Id, createdSubEntity.Id);
                var existingSubEntities = api.ListLocationUsers(createdEntity.Id).Data;
                Assert.DoesNotContain(existingSubEntities, i => i.Id == createdSubEntity.Id);
            }
            finally
            {
                api.DeleteLocation(createdEntity.Id);
            }
        }

        /// <summary>
        /// Test ListLocationUsers
        /// </summary>
        [Fact]
        public void Test_Location_User_List()
        {
            var entityData = TestLocationData.CreateLocationData();
            var createdEntity = api.CreateLocation(entityData);
            try
            {
                var createdSubEntities = TestLocationData.TestUsers.Select(i =>
                    api.UpsertLocationUser(createdEntity.Id, new(userId: new("Id", i.ToString())))).ToArray();
                try
                {
                    var existingSubEntities = api.ListLocationUsers(createdEntity.Id).Data;
                    Assert.Equal(createdSubEntities.Length, existingSubEntities.Count);
                }
                finally
                {
                    foreach (var i in createdSubEntities)
                        api.DeleteLocationUser(createdEntity.Id, i.Id);

                }
            }
            finally
            {
                api.DeleteLocation(createdEntity.Id);
            }
        }

        /// <summary>
        /// Test UpsertLocationUser
        /// </summary>
        [Fact]
        public void Test_LocationUser_Upsert()
        {
            var entityData = TestLocationData.CreateLocationData();
            var createdEntity = api.CreateLocation(entityData);
            try
            {
                var createdSubEntity = api.UpsertLocationUser(createdEntity.Id,
                    new(userId: new("Id", TestLocationData.TestUsers[0].ToString())));
                try
                {
                    var existingSubEntities = api.ListLocationUsers(createdEntity.Id).Data;
                    Assert.Contains(existingSubEntities, i => i.Id == createdSubEntity.Id);
                }
                finally
                {
                    api.DeleteLocationUser(createdEntity.Id, createdSubEntity.Id);
                }
            }
            finally
            {
                api.DeleteLocation(createdEntity.Id);
            }
        }

        /// <summary>
        /// Test PatchLocationUsers
        /// </summary>
        [Fact]
        public void PatchLocationUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //UsersData usersData = null;
            //string name = null;
            //string deleteNotExists = null;
            //var response = instance.PatchLocationUsers(id, usersData, name, deleteNotExists);
            //Assert.IsType<User>(response);
        }
    }
}
