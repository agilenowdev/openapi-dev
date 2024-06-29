/*
 * AccessHub API documentation
 *
 * Agile.Now.AccessHub is a secure REST API designed to manage accounts, access groups, user groups, organizations, locations, applications, roles, and webhooks. This API provides a robust and scalable solution for managing user access and organizational structures in a multi-tenant environment.    **Key Features:**    1. **Accounts Management:**     - Manage user accounts with secure authentication and authorization.    2. **Access Groups:**     - Define and manage access groups for access control.     - Assign users to access groups based on roles and permissions.    3. **User Groups:**     - Create and manage user groups for better organization and collaboration.    4. **Organizations & Locations:**     - Manage multiple organizations and locations within a single platform.     - Attribute-based access control (ABAC) for settings.    5. **Applications:**     - Centralized management of applications within the platform.     - Assign and monitor application usage and access.    6. **Roles:**     - Define and manage roles for different access levels.     - Role-based access control to ensure appropriate permissions.    7. **Webhooks:**     - Integration with external services and applications.     - Configure and manage webhooks for real-time notifications and data syncing.    **Benefits:**    - **Enhanced Security:** Attribute-based and role-based access controls ensure data protection and authorized access.  - **Scalability:** Designed for growing organizations.  - **Efficiency:** Streamlined management of accounts, groups, and roles reduces overhead.  - **Flexibility:** Multi-tenant architecture allows easy customization.  - **Integration:** Webhook support facilitates seamless integration with external systems.    **Conclusion:**    Agile.Now.AccessHub is a powerful platform for managing your business data. It offers a centralized, secure, and scalable solution, enhancing operational efficiency, security, and flexibility in managing multi-tenant environments.
 *
 * The version of the OpenAPI document: 2.0.1
 * Contact: dev@agilenow.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using AccessHub.Model;
using AccessHub.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace AccessHub.Test.Model
{
    /// <summary>
    ///  Class for testing LocationText
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class LocationTextTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for LocationText
        //private LocationText instance;

        public LocationTextTests()
        {
            // TODO uncomment below to create an instance of LocationText
            //instance = new LocationText();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LocationText
        /// </summary>
        [Fact]
        public void LocationTextInstanceTest()
        {
            // TODO uncomment below to test "IsType" LocationText
            //Assert.IsType<LocationText>(instance);
        }

        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }

        /// <summary>
        /// Test the property 'ExternalId'
        /// </summary>
        [Fact]
        public void ExternalIdTest()
        {
            // TODO unit test for the property 'ExternalId'
        }

        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }

        /// <summary>
        /// Test the property 'CountryId'
        /// </summary>
        [Fact]
        public void CountryIdTest()
        {
            // TODO unit test for the property 'CountryId'
        }

        /// <summary>
        /// Test the property 'TimezoneId'
        /// </summary>
        [Fact]
        public void TimezoneIdTest()
        {
            // TODO unit test for the property 'TimezoneId'
        }

        /// <summary>
        /// Test the property 'CurrencyId'
        /// </summary>
        [Fact]
        public void CurrencyIdTest()
        {
            // TODO unit test for the property 'CurrencyId'
        }

        /// <summary>
        /// Test the property 'IsActive'
        /// </summary>
        [Fact]
        public void IsActiveTest()
        {
            // TODO unit test for the property 'IsActive'
        }

        /// <summary>
        /// Test the property 'ModifiedOn'
        /// </summary>
        [Fact]
        public void ModifiedOnTest()
        {
            // TODO unit test for the property 'ModifiedOn'
        }

        /// <summary>
        /// Test the property 'ModifiedBy'
        /// </summary>
        [Fact]
        public void ModifiedByTest()
        {
            // TODO unit test for the property 'ModifiedBy'
        }

        /// <summary>
        /// Test the property 'CreatedBy'
        /// </summary>
        [Fact]
        public void CreatedByTest()
        {
            // TODO unit test for the property 'CreatedBy'
        }

        /// <summary>
        /// Test the property 'CreatedOn'
        /// </summary>
        [Fact]
        public void CreatedOnTest()
        {
            // TODO unit test for the property 'CreatedOn'
        }
    }
}
