/*
 * Organization API
 *
 * ## Introduction  The OpenAPI Specification (OAS) defines a standard, language-agnostic interface to RESTful APIs which allows both humans and computers to discover and understand the capabilities of the service without access to source code, documentation, or through network traffic inspection. When properly defined, a consumer can understand and interact with the remote service with a minimal amount of implementation logic.    An OpenAPI definition can then be used by documentation generation tools to display the API, code generation tools to generate servers and clients in various programming languages, testing tools, and many other use cases.    | Version | URL | Description |  | - -- | - -- | - -- |  | v3 | https://dev.esystems.fi/Endpoint/rest/Doc/v3/Json/Organizations | Serializes to the Open API document as a string in the JSON format and represents all patches of OpenAPI V3.0 spec (e.g. 3.0.0, 3.0.1). |  | v3 | https://dev.esystems.fi/Endpoint/rest/Doc/v3/Yaml/Organizations | Serializes to the Open API document as a string in the Yaml format and represents all patches of OpenAPI V3.0 spec (e.g. 3.0.0, 3.0.1). |  | v2 | https://dev.esystems.fi/Endpoint/rest/Doc/v2/Json/Organizations | Serializes to the Open API document as a string in the JSON format and represents OpenAPI V2.0 spec.|  | v2 | https://dev.esystems.fi/Endpoint/rest/Doc/v2/Yaml/Organizations | Serializes to the Open API document as a string in the Yaml format and represents OpenAPI V2.0 spec. |
 *
 * The version of the OpenAPI document: 2.0.90
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using Agile.Now.ApiOrganizations.Api;
using Agile.Now.ApiOrganizations.Client;
using Agile.Now.ApiOrganizations.Model;
using Xunit;
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
        private LocationsApi api;

        public LocationsApiTests()
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

        void AssertLocationDataEqual(LocationData locationData, Location location)
        {
            Assert.Equal(locationData.Name, location.Name);
            Assert.Equal(locationData.CountryId.Value, location.CountryId.Name);
            Assert.Equal(locationData.CurrencyId.Value, location.CurrencyId.Name);
        }

        /// <summary>
        /// Test CreateLocation
        /// </summary>
        [Fact]
        public void Test_CreateLocation()
        {
            var LocationData = TestLocationsData.CreateLocationData();
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
        public void Test_DeleteLocation_ById()
        {
            var createdLocation = api.CreateLocation(TestLocationsData.CreateLocationData());
            api.DeleteLocation(createdLocation.Id);
            Assert.Throws<ApiException>(() => api.GetLocation(createdLocation.Id));
        }

        /// <summary>
        /// Test DeleteLocation by Name
        /// </summary>
        [Fact]
        public void Test_DeleteLocation_ByName()
        {
            var createdLocation = api.CreateLocation(TestLocationsData.CreateLocationData());
            api.DeleteLocation(createdLocation.Id);
            Assert.Throws<ApiException>(() => api.GetLocation(createdLocation.Name, "Name"));
        }

        /// <summary>
        /// Test DeleteLocationUser
        /// </summary>
        [Fact]
        public void DeleteLocationUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string subId = null;
            //string? name = null;
            //string? subName = null;
            //var response = instance.DeleteLocationUser(id, subId, name, subName);
            //Assert.IsType<User>(response);
        }

        /// <summary>
        /// Test GetLocation by Id
        /// </summary>
        [Fact]
        public void Test_GetLocation_ById()
        {
            var createdLocation = api.CreateLocation(TestLocationsData.CreateLocationData());
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
        public void Test_GetLocation_ByName()
        {
            var createdLocation = api.CreateLocation(TestLocationsData.CreateLocationData());
            try
            {
                Assert.Null(Record.Exception(() =>
                {
                    var existingLocation = api.GetLocation(createdLocation.Name, "Name");
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
        /// Test ListLocationUsers
        /// </summary>
        [Fact]
        public void ListLocationUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string? name = null;
            //string? fields = null;
            //string? filters = null;
            //string? orders = null;
            //int? currentPage = null;
            //int? pageSize = null;
            //var response = instance.ListLocationUsers(id, name, fields, filters, orders, currentPage, pageSize);
            //Assert.IsType<Users>(response);
        }

        /// <summary>
        /// Test ListLocations by Id
        /// </summary>
        [Fact]
        public void Test_ListLocations_ById()
        {
            var LocationData = TestLocationsData.CreateLocationDataList(2);
            var createdLocations = LocationData.Select(i => api.CreateLocation(i)).ToArray();
            try
            {
                var foundLocations = api.ListLocations(
                    filters: $"Id In {string.Join("; ", createdLocations.Select(i => i.Id))}").Data;
                Assert.Equal(foundLocations.Count, createdLocations.Length);
            }
            finally
            {
                foreach (var i in createdLocations)
                    api.DeleteLocation(i.Id);
            }
        }

        /// <summary>
        /// Test ListLocations by UserName
        /// </summary>
        [Fact]
        public void Test_ListLocations_ByUserName()
        {
            var LocationData = TestLocationsData.CreateLocationDataList(2);
            var createdLocations = LocationData.Select(i => api.CreateLocation(i)).ToArray();
            try
            {
                var foundLocations = api.ListLocations(
                    filters: $"Name In {string.Join("; ", createdLocations.Select(i => i.Name))}");
                Assert.Equal(foundLocations.Data.Count, createdLocations.Length);
            }
            finally
            {
                foreach (var i in createdLocations)
                    api.DeleteLocation(i.Id);
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
            //string? name = null;
            //string? deleteNotExists = null;
            //var response = instance.PatchLocationUsers(id, usersData, name, deleteNotExists);
            //Assert.IsType<User>(response);
        }

        /// <summary>
        /// Test PatchLocations
        /// </summary>
        [Fact]
        public void PatchLocationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //LocationsData locationsData = null;
            //var response = instance.PatchLocations(locationsData);
            //Assert.IsType<Locations>(response);
        }

        /// <summary>
        /// Test UpdateLocation
        /// </summary>
        [Fact]
        public void Test_UpdateLocation()
        {
            var locationData = TestLocationsData.CreateLocationData();
            var createdLocation = api.CreateLocation(locationData);
            try
            {
                TestLocationsData.UpdateLocationData(locationData);
                var updatedLocation = api.UpdateLocation(createdLocation.Id, locationData);
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
        public void Test_UpsertLocation()
        {
            var locationData = TestLocationsData.CreateLocationData();
            var createdLocation = api.UpsertLocation(locationData);
            try
            {
                Assert.Null(Record.Exception(() => api.GetLocation(createdLocation.Id)));
                TestLocationsData.UpdateLocationData(locationData, createdLocation.Id);
                var updatedLocation = api.UpsertLocation(locationData);
                AssertLocationDataEqual(locationData, updatedLocation);
            }
            finally
            {
                api.DeleteLocation(createdLocation.Id);
            }
        }

        /// <summary>
        /// Test UpsertLocationUser
        /// </summary>
        [Fact]
        public void UpsertLocationUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //UserData userData = null;
            //string? name = null;
            //var response = instance.UpsertLocationUser(id, userData, name);
            //Assert.IsType<User>(response);
        }
    }
}
