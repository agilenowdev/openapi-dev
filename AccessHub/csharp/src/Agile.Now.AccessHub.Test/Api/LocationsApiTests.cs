/*
 * Accounts API documentation
 *
 * Agile.Now.AccessHub is a secure REST API designed to manage accounts, access groups, user groups, organizations, locations, applications, roles, and webhooks. This API provides a robust and scalable solution for managing user access and organizational structures in a multi-tenant environment.    **Key Features:**    1. **Accounts Management:**     - Manage user accounts with secure authentication and authorization.    2. **Access Groups:**     - Define and manage access groups for access control.     - Assign users to access groups based on roles and permissions.    3. **User Groups:**     - Create and manage user groups for better organization and collaboration.    4. **Organizations & Locations:**     - Manage multiple organizations and locations within a single platform.     - Attribute-based access control (ABAC) for settings.    5. **Applications:**     - Centralized management of applications within the platform.     - Assign and monitor application usage and access.    6. **Roles:**     - Define and manage roles for different access levels.     - Role-based access control to ensure appropriate permissions.    7. **Webhooks:**     - Integration with external services and applications.     - Configure and manage webhooks for real-time notifications and data syncing.    **Benefits:**    - **Enhanced Security:** Attribute-based and role-based access controls ensure data protection and authorized access.  - **Scalability:** Designed for growing organizations.  - **Efficiency:** Streamlined management of accounts, groups, and roles reduces overhead.  - **Flexibility:** Multi-tenant architecture allows easy customization.  - **Integration:** Webhook support facilitates seamless integration with external systems.    **Conclusion:**    Agile.Now.AccessHub is a powerful platform for managing your business data. It offers a centralized, secure, and scalable solution, enhancing operational efficiency, security, and flexibility in managing multi-tenant environments.
 *
 * The version of the OpenAPI document: 3.0.22
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Agile.Now.AccessHub.Client;
using Agile.Now.AccessHub.Api;
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
        private LocationsApi instance;

        public LocationsApiTests()
        {
            instance = new LocationsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LocationsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' LocationsApi
            //Assert.IsType<LocationsApi>(instance);
        }

        /// <summary>
        /// Test CreateLocation
        /// </summary>
        [Fact]
        public void CreateLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //LocationData locationData = null;
            //var response = instance.CreateLocation(locationData);
            //Assert.IsType<Location>(response);
        }

        /// <summary>
        /// Test DeleteLocation
        /// </summary>
        [Fact]
        public void DeleteLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string? name = null;
            //var response = instance.DeleteLocation(id, name);
            //Assert.IsType<Location>(response);
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
        /// Test GetLocation
        /// </summary>
        [Fact]
        public void GetLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string? name = null;
            //var response = instance.GetLocation(id, name);
            //Assert.IsType<Location>(response);
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
        /// Test ListLocations
        /// </summary>
        [Fact]
        public void ListLocationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? fields = null;
            //string? filters = null;
            //string? orders = null;
            //int? currentPage = null;
            //int? pageSize = null;
            //var response = instance.ListLocations(fields, filters, orders, currentPage, pageSize);
            //Assert.IsType<Locations>(response);
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
        public void UpdateLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //LocationData locationData = null;
            //string? name = null;
            //var response = instance.UpdateLocation(id, locationData, name);
            //Assert.IsType<Location>(response);
        }

        /// <summary>
        /// Test UpsertLocation
        /// </summary>
        [Fact]
        public void UpsertLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //LocationData locationData = null;
            //var response = instance.UpsertLocation(locationData);
            //Assert.IsType<Location>(response);
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
