/*
 * Accounts API documentation
 *
 * Agile.Now.AccessHub is a secure REST API designed to manage accounts, access groups, user groups, organizations, locations, applications, roles, and webhooks. This API provides a robust and scalable solution for managing user access and organizational structures in a multi-tenant environment.    **Key Features:**    1. **Accounts Management:**     - Manage user accounts with secure authentication and authorization.    2. **Access Groups:**     - Define and manage access groups for access control.     - Assign users to access groups based on roles and permissions.    3. **User Groups:**     - Create and manage user groups for better organization and collaboration.    4. **Organizations & Locations:**     - Manage multiple organizations and locations within a single platform.     - Attribute-based access control (ABAC) for settings.    5. **Applications:**     - Centralized management of applications within the platform.     - Assign and monitor application usage and access.    6. **Roles:**     - Define and manage roles for different access levels.     - Role-based access control to ensure appropriate permissions.    7. **Webhooks:**     - Integration with external services and applications.     - Configure and manage webhooks for real-time notifications and data syncing.    **Benefits:**    - **Enhanced Security:** Attribute-based and role-based access controls ensure data protection and authorized access.  - **Scalability:** Designed for growing organizations.  - **Efficiency:** Streamlined management of accounts, groups, and roles reduces overhead.  - **Flexibility:** Multi-tenant architecture allows easy customization.  - **Integration:** Webhook support facilitates seamless integration with external systems.    **Conclusion:**    Agile.Now.AccessHub is a powerful platform for managing your business data. It offers a centralized, secure, and scalable solution, enhancing operational efficiency, security, and flexibility in managing multi-tenant environments.
 *
 * The version of the OpenAPI document: 3.0.20
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Agile.Now.AccessHub.Test.Model
{
    /// <summary>
    ///  Class for testing Meta2
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class Meta2Tests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Meta2
        //private Meta2 instance;

        public Meta2Tests()
        {
            // TODO uncomment below to create an instance of Meta2
            //instance = new Meta2();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Meta2
        /// </summary>
        [Fact]
        public void Meta2InstanceTest()
        {
            // TODO uncomment below to test "IsType" Meta2
            //Assert.IsType<Meta2>(instance);
        }

        /// <summary>
        /// Test the property 'TotalItems'
        /// </summary>
        [Fact]
        public void TotalItemsTest()
        {
            // TODO unit test for the property 'TotalItems'
        }

        /// <summary>
        /// Test the property 'CurrentPage'
        /// </summary>
        [Fact]
        public void CurrentPageTest()
        {
            // TODO unit test for the property 'CurrentPage'
        }

        /// <summary>
        /// Test the property 'PageSize'
        /// </summary>
        [Fact]
        public void PageSizeTest()
        {
            // TODO unit test for the property 'PageSize'
        }

        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }
    }
}
