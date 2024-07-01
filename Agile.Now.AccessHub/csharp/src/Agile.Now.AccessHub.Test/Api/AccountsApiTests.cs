/*
 * Agile.Now.AccessHub API documentation
 *
 * Agile.Now.AccessHub is a secure REST API designed to manage accounts, access groups, user groups, organizations, locations, applications, roles, and webhooks. This API provides a robust and scalable solution for managing user access and organizational structures in a multi-tenant environment.    **Key Features:**    1. **Accounts Management:**     - Manage user accounts with secure authentication and authorization.    2. **Access Groups:**     - Define and manage access groups for access control.     - Assign users to access groups based on roles and permissions.    3. **User Groups:**     - Create and manage user groups for better organization and collaboration.    4. **Organizations & Locations:**     - Manage multiple organizations and locations within a single platform.     - Attribute-based access control (ABAC) for settings.    5. **Applications:**     - Centralized management of applications within the platform.     - Assign and monitor application usage and access.    6. **Roles:**     - Define and manage roles for different access levels.     - Role-based access control to ensure appropriate permissions.    7. **Webhooks:**     - Integration with external services and applications.     - Configure and manage webhooks for real-time notifications and data syncing.    **Benefits:**    - **Enhanced Security:** Attribute-based and role-based access controls ensure data protection and authorized access.  - **Scalability:** Designed for growing organizations.  - **Efficiency:** Streamlined management of accounts, groups, and roles reduces overhead.  - **Flexibility:** Multi-tenant architecture allows easy customization.  - **Integration:** Webhook support facilitates seamless integration with external systems.    **Conclusion:**    Agile.Now.AccessHub is a powerful platform for managing your business data. It offers a centralized, secure, and scalable solution, enhancing operational efficiency, security, and flexibility in managing multi-tenant environments.
 *
 * The version of the OpenAPI document: 2.0.1
 * Contact: dev@agilenow.io
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
    ///  Class for testing AccountsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AccountsApiTests : IDisposable
    {
        private AccountsApi instance;

        public AccountsApiTests()
        {
            instance = new AccountsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AccountsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AccountsApi
            //Assert.IsType<AccountsApi>(instance);
        }

        /// <summary>
        /// Test CreateAccount
        /// </summary>
        [Fact]
        public void CreateAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AccountData accountData = null;
            //var response = instance.CreateAccount(accountData);
            //Assert.IsType<Account>(response);
        }

        /// <summary>
        /// Test DeleteAccount
        /// </summary>
        [Fact]
        public void DeleteAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string? name = null;
            //var response = instance.DeleteAccount(id, name);
            //Assert.IsType<Account>(response);
        }

        /// <summary>
        /// Test DeleteAccountTenant
        /// </summary>
        [Fact]
        public void DeleteAccountTenantTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string subId = null;
            //string? name = null;
            //string? subName = null;
            //var response = instance.DeleteAccountTenant(id, subId, name, subName);
            //Assert.IsType<Tenant>(response);
        }

        /// <summary>
        /// Test GetAccount
        /// </summary>
        [Fact]
        public void GetAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string? name = null;
            //string? selectInclude = null;
            //string? selectExclude = null;
            //var response = instance.GetAccount(id, name, selectInclude, selectExclude);
            //Assert.IsType<Account>(response);
        }

        /// <summary>
        /// Test ListAccountTenants
        /// </summary>
        [Fact]
        public void ListAccountTenantsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string? name = null;
            //string? fields = null;
            //string? filters = null;
            //string? orders = null;
            //int? currentPage = null;
            //int? pageSize = null;
            //var response = instance.ListAccountTenants(id, name, fields, filters, orders, currentPage, pageSize);
            //Assert.IsType<Tenants>(response);
        }

        /// <summary>
        /// Test ListAccounts
        /// </summary>
        [Fact]
        public void ListAccountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? fields = null;
            //string? filters = null;
            //string? orders = null;
            //int? currentPage = null;
            //int? pageSize = null;
            //string? selectInclude = null;
            //string? selectExclude = null;
            //var response = instance.ListAccounts(fields, filters, orders, currentPage, pageSize, selectInclude, selectExclude);
            //Assert.IsType<Accounts>(response);
        }

        /// <summary>
        /// Test UpdateAccount
        /// </summary>
        [Fact]
        public void UpdateAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //AccountData accountData = null;
            //string? name = null;
            //var response = instance.UpdateAccount(id, accountData, name);
            //Assert.IsType<Account>(response);
        }

        /// <summary>
        /// Test UpsertAccount
        /// </summary>
        [Fact]
        public void UpsertAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AccountData accountData = null;
            //var response = instance.UpsertAccount(accountData);
            //Assert.IsType<Account>(response);
        }

        /// <summary>
        /// Test UpsertAccountTenant
        /// </summary>
        [Fact]
        public void UpsertAccountTenantTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TenantData tenantData = null;
            //string? name = null;
            //var response = instance.UpsertAccountTenant(id, tenantData, name);
            //Assert.IsType<Tenant>(response);
        }
    }
}
