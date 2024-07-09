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
using System.Security.Principal;
using Agile.Now.ApiOrganizations.Api;
using Agile.Now.ApiOrganizations.Client;
using Agile.Now.ApiOrganizations.Model;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using Xunit;
// uncomment below to import models
//using Agile.Now.ApiOrganizations.Model;

namespace Agile.Now.ApiOrganizations.Test.Api
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
        private DepartmentsApi api;

        public DepartmentsApiTests()
        {
            Configuration configuration = new Configuration
            {
                BasePath = "https://dev.esystems.fi",
                OAuthTokenUrl = "https://dev.esystems.fi/oAuth/rest/v2/Token",
                OAuthFlow = Client.Auth.OAuthFlow.APPLICATION,
                OAuthClientId = "c8907421-0886-4fb0-b859-d29966762e16",
                OAuthClientSecret = "1da54fa9-ae11-4db3-9740-1bb47b85cd8e"
            };
            api = new DepartmentsApi(configuration);
        }

        public void Dispose()
        {
        }

        /// <summary>
        /// Test an instance of DepartmentsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
        }

        void AssertDepartmentDataEqual(DepartmentInsertData departmentInsertData, Department department)
        {
            Assert.Equal(departmentInsertData.Name, department.Name);
            Assert.Equal(departmentInsertData.ContactName, department.ContactName);
            Assert.Equal(departmentInsertData.ContactEmail, department.ContactEmail);
            Assert.Equal(departmentInsertData.DepartmentTypeId.Value, department.DepartmentTypeId.Id);
            Assert.Equal(departmentInsertData.CountryId.Value, department.CountryId.Name);
        }

        /// <summary>
        /// Test CreateDepartment
        /// </summary>
        [Fact]
        public void Test_CreateDepartment()
        {
            var departmentData = TestDepartmentData.CreateDepartmentData();
            var createdDepartment = api.CreateDepartment(departmentData);
            try
            {
                AssertDepartmentDataEqual(departmentData, createdDepartment);
            }
            finally
            {
                api.DeleteDepartment(createdDepartment.Id);
            }
        }

        /// <summary>
        /// Test DeleteDepartment by Id
        /// </summary>
        [Fact]
        public void Test_DeleteDepartment_ById()
        {
            var createdDepartment = api.CreateDepartment(TestDepartmentData.CreateDepartmentData());
            api.DeleteDepartment(createdDepartment.Id);
            Assert.Throws<ApiException>(() => api.GetDepartment(createdDepartment.Id));
        }

        /// <summary>
        /// Test DeleteDepartment by Name
        /// </summary>
        [Fact]
        public void Test_DeleteDepartment_ByName()
        {
            var createdDepartment = api.CreateDepartment(TestDepartmentData.CreateDepartmentData());
            api.DeleteDepartment(createdDepartment.Id);
            Assert.Throws<ApiException>(() => api.GetDepartment(createdDepartment.Name, "Name"));
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
        /// Test GetDepartment by Id
        /// </summary>
        [Fact]
        public void Test_GetDepartment_ById()
        {
            var createdDepartment = api.CreateDepartment(TestDepartmentData.CreateDepartmentData());
            try
            {
                Assert.Null(Record.Exception(() =>
                {
                    var existingDepartment = api.GetDepartment(createdDepartment.Id);
                    Assert.Equal(createdDepartment.Id, existingDepartment.Id);
                    return existingDepartment;
                }));
            }
            finally
            {
                api.DeleteDepartment(createdDepartment.Id);
            }
        }

        /// <summary>
        /// Test GetDepartment by Name
        /// </summary>
        [Fact]
        public void Test_GetDepartment_ByName()
        {
            var createdDepartment = api.CreateDepartment(TestDepartmentData.CreateDepartmentData());
            try
            {
                Assert.Null(Record.Exception(() =>
                {
                    var existingDepartment = api.GetDepartment(createdDepartment.Name, "Name");
                    Assert.Equal(createdDepartment.Id, existingDepartment.Id);
                    return existingDepartment;
                }));
            }
            finally
            {
                api.DeleteDepartment(createdDepartment.Id);
            }
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
        /// Test ListDepartments by Id
        /// </summary>
        [Fact]
        public void Test_ListDepartments_ById()
        {
            var DepartmentData = TestDepartmentData.CreateDepartmentDataList(2);
            var createdDepartments = DepartmentData.Select(i => api.CreateDepartment(i)).ToArray();
            try
            {
                var foundDepartments = api.ListDepartments(
                    filters: $"Id In {string.Join("; ", createdDepartments.Select(i => i.Id))}").Data;
                Assert.Equal(foundDepartments.Count, createdDepartments.Length);
            }
            finally
            {
                foreach (var i in createdDepartments)
                    api.DeleteDepartment(i.Id);
            }
        }

        /// <summary>
        /// Test ListDepartments by UserName
        /// </summary>
        [Fact]
        public void Test_ListDepartments_ByUserName()
        {
            var DepartmentData = TestDepartmentData.CreateDepartmentDataList(2);
            var createdDepartments = DepartmentData.Select(i => api.CreateDepartment(i)).ToArray();
            try
            {
                var foundDepartments = api.ListDepartments(
                    filters: $"Name In {string.Join("; ", createdDepartments.Select(i => i.Name))}");
                Assert.Equal(foundDepartments.Data.Count, createdDepartments.Length);
            }
            finally
            {
                foreach (var i in createdDepartments)
                    api.DeleteDepartment(i.Id);
            }
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
        public void Test_UpdateDepartment()
        {
            var departmentData = TestDepartmentData.CreateDepartmentData();
            var createdDepartment = api.CreateDepartment(departmentData);
            try
            {
                var updatedDepertmentData =  TestDepartmentData.UpdateDepartmentData(departmentData);
                var updatedDepartment = api.UpdateDepartment(createdDepartment.Id, updatedDepertmentData);
                AssertDepartmentDataEqual(departmentData, updatedDepartment);
            }
            finally
            {
                api.DeleteDepartment(createdDepartment.Id);
            }
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
