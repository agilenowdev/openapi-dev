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
    ///  Class for testing DepartmentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DepartmentsApiTests : IDisposable
    {
        private DepartmentsApi instance;

        public DepartmentsApiTests()
        {
            instance = new DepartmentsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DepartmentsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DepartmentsApi
            //Assert.IsType<DepartmentsApi>(instance);
        }

        /// <summary>
        /// Test CreateDepartment
        /// </summary>
        [Fact]
        public void CreateDepartmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DepartmentInsertData departmentInsertData = null;
            //var response = instance.CreateDepartment(departmentInsertData);
            //Assert.IsType<Department>(response);
        }

        /// <summary>
        /// Test DeleteDepartment
        /// </summary>
        [Fact]
        public void DeleteDepartmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string? name = null;
            //var response = instance.DeleteDepartment(id, name);
            //Assert.IsType<Department>(response);
        }

        /// <summary>
        /// Test DeleteDepartmentUser
        /// </summary>
        [Fact]
        public void DeleteDepartmentUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string subId = null;
            //string? name = null;
            //string? subName = null;
            //var response = instance.DeleteDepartmentUser(id, subId, name, subName);
            //Assert.IsType<User>(response);
        }

        /// <summary>
        /// Test GetDepartment
        /// </summary>
        [Fact]
        public void GetDepartmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string? name = null;
            //var response = instance.GetDepartment(id, name);
            //Assert.IsType<Department>(response);
        }

        /// <summary>
        /// Test ListDepartmentUsers
        /// </summary>
        [Fact]
        public void ListDepartmentUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string? name = null;
            //string? fields = null;
            //string? filters = null;
            //string? orders = null;
            //int? currentPage = null;
            //int? pageSize = null;
            //var response = instance.ListDepartmentUsers(id, name, fields, filters, orders, currentPage, pageSize);
            //Assert.IsType<Users>(response);
        }

        /// <summary>
        /// Test ListDepartments
        /// </summary>
        [Fact]
        public void ListDepartmentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? fields = null;
            //string? filters = null;
            //string? orders = null;
            //int? currentPage = null;
            //int? pageSize = null;
            //var response = instance.ListDepartments(fields, filters, orders, currentPage, pageSize);
            //Assert.IsType<Departments>(response);
        }

        /// <summary>
        /// Test PatchDepartmentUsers
        /// </summary>
        [Fact]
        public void PatchDepartmentUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //UsersData usersData = null;
            //string? name = null;
            //string? deleteNotExists = null;
            //var response = instance.PatchDepartmentUsers(id, usersData, name, deleteNotExists);
            //Assert.IsType<User>(response);
        }

        /// <summary>
        /// Test PatchDepartments
        /// </summary>
        [Fact]
        public void PatchDepartmentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DepartmentsData departmentsData = null;
            //var response = instance.PatchDepartments(departmentsData);
            //Assert.IsType<Departments>(response);
        }

        /// <summary>
        /// Test UpdateDepartment
        /// </summary>
        [Fact]
        public void UpdateDepartmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DepartmentUpdateData departmentUpdateData = null;
            //string? name = null;
            //var response = instance.UpdateDepartment(id, departmentUpdateData, name);
            //Assert.IsType<Department>(response);
        }

        /// <summary>
        /// Test UpsertDepartment
        /// </summary>
        [Fact]
        public void UpsertDepartmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DepartmentUpsertData departmentUpsertData = null;
            //var response = instance.UpsertDepartment(departmentUpsertData);
            //Assert.IsType<Department>(response);
        }

        /// <summary>
        /// Test UpsertDepartmentUser
        /// </summary>
        [Fact]
        public void UpsertDepartmentUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //UserData userData = null;
            //string? name = null;
            //var response = instance.UpsertDepartmentUser(id, userData, name);
            //Assert.IsType<User>(response);
        }
    }
}
