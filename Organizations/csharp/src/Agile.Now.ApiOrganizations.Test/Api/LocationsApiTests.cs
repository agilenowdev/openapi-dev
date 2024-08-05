/*
 * Organization API
 *
 * ## Introduction  The OpenAPI Specification (OAS) defines a standard, language-agnostic interface to RESTful APIs which allows both humans and computers to discover and understand the capabilities of the service without access to source code, documentation, or through network traffic inspection. When properly defined, a consumer can understand and interact with the remote service with a minimal amount of implementation logic.    An OpenAPI definition can then be used by documentation generation tools to display the API, code generation tools to generate servers and clients in various programming languages, testing tools, and many other use cases.    | Version | URL | Description |  | - -- | - -- | - -- |  | v3 | https://dev.esystems.fi/Endpoint/rest/Doc/v3/Json/Organizations | Serializes to the Open API document as a string in the JSON format and represents all patches of OpenAPI V3.0 spec (e.g. 3.0.0, 3.0.1). |  | v3 | https://dev.esystems.fi/Endpoint/rest/Doc/v3/Yaml/Organizations | Serializes to the Open API document as a string in the Yaml format and represents all patches of OpenAPI V3.0 spec (e.g. 3.0.0, 3.0.1). |  | v2 | https://dev.esystems.fi/Endpoint/rest/Doc/v2/Json/Organizations | Serializes to the Open API document as a string in the JSON format and represents OpenAPI V2.0 spec.|  | v2 | https://dev.esystems.fi/Endpoint/rest/Doc/v2/Yaml/Organizations | Serializes to the Open API document as a string in the Yaml format and represents OpenAPI V2.0 spec. |
 *
 * The version of the OpenAPI document: 2.0.100
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Globalization;
using System.Linq;
using Agile.Now.ApiOrganizations.Api;
using Agile.Now.ApiOrganizations.Client;
using Agile.Now.ApiOrganizations.Model;
using Xunit;
using Xunit.Abstractions;
// uncomment below to import models
//using Agile.Now.ApiOrganizations.Model;

namespace Agile.Now.ApiOrganizations.Test.Api
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

        void AssertLocationDataEqual(LocationInsertData locationInsertData, Location location)
        {
            Assert.Equal(locationInsertData.Name, location.Name);
            Assert.Equal(locationInsertData.CountryId.ToString(), location.CountryId.Id);
            Assert.Equal(locationInsertData.CurrencyId.ToString(), location.CurrencyId.Id);
        }

        /// <summary>
        /// Test CreateLocation
        /// </summary>
        [Fact]
        public void Test_Location_Create()
        {
            var LocationData = TestLocationData.CreateLocationData();
            var createdLocation = api.CreateLocation(LocationData);
            try
            {
                AssertLocationDataEqual(LocationData, createdLocation);
            }
            finally
            {
                api.DeleteLocation(createdLocation.Id);
            }
        }

        /// <summary>
        /// Test DeleteLocation by Id
        /// </summary>
        [Fact]
        public void Test_Location_Delete_ById()
        {
            var createdLocation = api.CreateLocation(TestLocationData.CreateLocationData());
            api.DeleteLocation(createdLocation.Id);
            Assert.Throws<ApiException>(() => api.GetLocation(createdLocation.Id));
        }

        /// <summary>
        /// Test DeleteLocation by Name
        /// </summary>
        [Fact]
        public void Test_Location_Delete_ByName()
        {
            var createdLocation = api.CreateLocation(TestLocationData.CreateLocationData());
            api.DeleteLocation(createdLocation.Name, "Name");
            Assert.Throws<ApiException>(() => api.GetLocation(createdLocation.Id));
        }

        /// <summary>
        /// Test GetLocation by Id
        /// </summary>
        [Fact]
        public void Test_Location_Get_ById()
        {
            var createdLocation = api.CreateLocation(TestLocationData.CreateLocationData());
            try
            {
                Assert.Null(Record.Exception(() =>
                {
                    var existingLocation = api.GetLocation(createdLocation.Id);
                    Assert.Equal(createdLocation.Id, existingLocation.Id);
                    return existingLocation;
                }));
            }
            finally
            {
                api.DeleteLocation(createdLocation.Id);
            }
        }

        /// <summary>
        /// Test GetLocation by Name
        /// </summary>
        [Fact]
        public void Test_Location_Get_ByName()
        {
            var createdLocation = api.CreateLocation(TestLocationData.CreateLocationData());
            try
            {
                Assert.Null(Record.Exception(() =>
                {
                    var existingLocation = api.GetLocation(createdLocation.Name, "Name");
                    Assert.Equal(createdLocation.Name, existingLocation.Name);
                    return existingLocation;
                }));
            }
            finally
            {
                api.DeleteLocation(createdLocation.Id);
            }
        }

        /// <summary>
        /// Test ListLocations by Id
        /// </summary>
        [Fact]
        public void Test_Location_List_ById()
        {
            var locationData = TestLocationData.CreateLocationDataList(2);
            var createdLocations = locationData.Select(i => api.CreateLocation(i)).ToArray();
            try
            {
                var existingLocations = api.ListLocations(
                    filters: $"Id In {string.Join("; ", createdLocations.Select(i => i.Id))}").Data;
                Assert.Equal(createdLocations.Length, existingLocations.Count);
                Assert.Contains(existingLocations, i => i.Id == createdLocations[0].Id);
                Assert.Contains(existingLocations, i => i.Id == createdLocations[1].Id);
            }
            finally
            {
                foreach (var i in createdLocations)
                    api.DeleteLocation(i.Id);
            }
        }

        /// <summary>
        /// Test ListLocations by Name
        /// </summary>
        [Fact]
        public void Test_Location_List_ByName()
        {
            var locationData = TestLocationData.CreateLocationDataList(2);
            var createdLocations = locationData.Select(i => api.CreateLocation(i)).ToArray();
            try
            {
                var existingLocations = api.ListLocations(
                    filters: $"Name In {string.Join("; ", createdLocations.Select(i => i.Name))}").Data;
                Assert.Equal(createdLocations.Length, existingLocations.Count);
                Assert.Contains(existingLocations, i => i.Id == createdLocations[0].Id);
                Assert.Contains(existingLocations, i => i.Id == createdLocations[1].Id);
            }
            finally
            {
                foreach (var i in createdLocations)
                    api.DeleteLocation(i.Id);
            }
        }

        /// <summary>
        /// Test UpdateLocation
        /// </summary>
        [Fact]
        public void Test_Location_Update()
        {
            var locationData = TestLocationData.CreateLocationData();
            var createdLocation = api.CreateLocation(locationData);
            try
            {
                TestLocationData.UpdateLocationData(locationData);
                var updatedLocation = api.UpdateLocation(createdLocation.Id, locationData.ToLocationUpdateData());
                AssertLocationDataEqual(locationData, updatedLocation);
            }
            finally
            {
                api.DeleteLocation(createdLocation.Id);
            }
        }

        /// <summary>
        /// Test UpsertLocation
        /// </summary>
        [Fact]
        public void Test_Location_Upsert()
        {
            var locationData = TestLocationData.CreateLocationData();
            var createdLocation = api.UpsertLocation(locationData.ToLocationData());
            try
            {
                AssertLocationDataEqual(locationData, createdLocation);
                TestLocationData.UpdateLocationData(locationData, createdLocation.Id);
                var updatedLocation = api.UpsertLocation(locationData.ToLocationData());
                Assert.Equal(createdLocation.Id, updatedLocation.Id);
                AssertLocationDataEqual(locationData, updatedLocation);
            }
            finally
            {
                api.DeleteLocation(createdLocation.Id);
            }
        }

        /// <summary>
        /// Test DeleteLocationUser
        /// </summary>
        [Fact]
        public void Test_LocationUser_Delete()
        {
            var locationData = TestLocationData.CreateLocationData();
            var createdLocation = api.CreateLocation(locationData);
            try
            {
                var createdLocationUser = api.UpsertLocationUser(createdLocation.Id,
                    new(userId: new("Id", TestLocationData.TestUsers[0].ToString())));
                api.DeleteLocationUser(createdLocation.Id, createdLocationUser.Id);
                var existingLocationUsers = api.ListLocationUsers(createdLocation.Id).Data;
                Assert.DoesNotContain(existingLocationUsers, i => i.Id == createdLocationUser.Id);
            }
            finally
            {
                api.DeleteLocation(createdLocation.Id);
            }
        }

        /// <summary>
        /// Test ListLocationUsers
        /// </summary>
        [Fact]
        public void Test_LocationUser_List()
        {
            var locationData = TestLocationData.CreateLocationData();
            var createdLocation = api.CreateLocation(locationData);
            try
            {
                var createdLocationUsers = TestLocationData.TestUsers.Select(i =>
                    api.UpsertLocationUser(createdLocation.Id, new(userId: new("Id", i.ToString())))).ToArray();
                try
                {
                    var existingLocationUsers = api.ListLocationUsers(createdLocation.Id).Data;
                    Assert.Equal(createdLocationUsers.Length, existingLocationUsers.Count);
                    Assert.Contains(existingLocationUsers, i => i.Id == createdLocationUsers[0].Id);
                    Assert.Contains(existingLocationUsers, i => i.Id == createdLocationUsers[1].Id);
                }
                finally
                {
                    foreach (var i in createdLocationUsers)
                        api.DeleteLocationUser(createdLocation.Id, i.Id);

                }
            }
            finally
            {
                api.DeleteLocation(createdLocation.Id);
            }
        }

        /// <summary>
        /// Test PatchLocationUsers
        /// </summary>
        [Fact]
        public void PatchLocationUsersTest()
        {
        }

        /// <summary>
        /// Test UpsertLocationUser
        /// </summary>
        [Fact]
        public void Test_LocationUser_Upsert()
        {
            var locationData = TestLocationData.CreateLocationData();
            var createdLocation = api.CreateLocation(locationData);
            try
            {
                var createdLocationUser = api.UpsertLocationUser(createdLocation.Id,
                    new(userId: new ("Id", TestLocationData.TestUsers[0].ToString())));
                try
                {
                    var existingLocationUsers = api.ListLocationUsers(createdLocation.Id).Data;
                    Assert.Contains(existingLocationUsers, i => i.Id == createdLocationUser.Id);
                }
                finally
                {
                    api.DeleteLocationUser(createdLocation.Id, createdLocationUser.Id);
                }
            }
            finally
            {
                api.DeleteLocation(createdLocation.Id);
            }
        }
    }
}
