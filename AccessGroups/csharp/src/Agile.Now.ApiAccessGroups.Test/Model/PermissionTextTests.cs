/*
 * AccessGroups API documentation
 *
 * ## Introduction  The OpenAPI Specification (OAS) defines a standard, language-agnostic interface to RESTful APIs which allows both humans and computers to discover and understand the capabilities of the service without access to source code, documentation, or through network traffic inspection. When properly defined, a consumer can understand and interact with the remote service with a minimal amount of implementation logic.    An OpenAPI definition can then be used by documentation generation tools to display the API, code generation tools to generate servers and clients in various programming languages, testing tools, and many other use cases.    | Version | URL | Description |  | - -- | - -- | - -- |  | v3 | https://dev.esystems.fi/Endpoint/rest/Doc/v3/Json/AccessGroups | Serializes to the Open API document as a string in the JSON format and represents all patches of OpenAPI V3.0 spec (e.g. 3.0.0, 3.0.1). |  | v3 | https://dev.esystems.fi/Endpoint/rest/Doc/v3/Yaml/AccessGroups | Serializes to the Open API document as a string in the Yaml format and represents all patches of OpenAPI V3.0 spec (e.g. 3.0.0, 3.0.1). |  | v2 | https://dev.esystems.fi/Endpoint/rest/Doc/v2/Json/AccessGroups | Serializes to the Open API document as a string in the JSON format and represents OpenAPI V2.0 spec.|  | v2 | https://dev.esystems.fi/Endpoint/rest/Doc/v2/Yaml/AccessGroups | Serializes to the Open API document as a string in the Yaml format and represents OpenAPI V2.0 spec. |
 *
 * The version of the OpenAPI document: 3.0.3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Agile.Now.ApiAccessGroups.Model;
using Agile.Now.ApiAccessGroups.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Agile.Now.ApiAccessGroups.Test.Model
{
    /// <summary>
    ///  Class for testing PermissionText
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PermissionTextTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PermissionText
        //private PermissionText instance;

        public PermissionTextTests()
        {
            // TODO uncomment below to create an instance of PermissionText
            //instance = new PermissionText();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PermissionText
        /// </summary>
        [Fact]
        public void PermissionTextInstanceTest()
        {
            // TODO uncomment below to test "IsType" PermissionText
            //Assert.IsType<PermissionText>(instance);
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
        /// Test the property 'AccessRoleId'
        /// </summary>
        [Fact]
        public void AccessRoleIdTest()
        {
            // TODO unit test for the property 'AccessRoleId'
        }

        /// <summary>
        /// Test the property 'RoleId'
        /// </summary>
        [Fact]
        public void RoleIdTest()
        {
            // TODO unit test for the property 'RoleId'
        }

        /// <summary>
        /// Test the property 'PermissionId'
        /// </summary>
        [Fact]
        public void PermissionIdTest()
        {
            // TODO unit test for the property 'PermissionId'
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
        /// Test the property 'CreatedOn'
        /// </summary>
        [Fact]
        public void CreatedOnTest()
        {
            // TODO unit test for the property 'CreatedOn'
        }
    }
}
