/*
 * AccessGroups API documentation
 *
 * ## Introduction  The OpenAPI Specification (OAS) defines a standard, language-agnostic interface to RESTful APIs which allows both humans and computers to discover and understand the capabilities of the service without access to source code, documentation, or through network traffic inspection. When properly defined, a consumer can understand and interact with the remote service with a minimal amount of implementation logic.    An OpenAPI definition can then be used by documentation generation tools to display the API, code generation tools to generate servers and clients in various programming languages, testing tools, and many other use cases.    | Version | URL | Description |  | - -- | - -- | - -- |  | v3 | https://dev.esystems.fi/Endpoint/rest/Doc/v3/Json/AccessGroups | Serializes to the Open API document as a string in the JSON format and represents all patches of OpenAPI V3.0 spec (e.g. 3.0.0, 3.0.1). |  | v3 | https://dev.esystems.fi/Endpoint/rest/Doc/v3/Yaml/AccessGroups | Serializes to the Open API document as a string in the Yaml format and represents all patches of OpenAPI V3.0 spec (e.g. 3.0.0, 3.0.1). |  | v2 | https://dev.esystems.fi/Endpoint/rest/Doc/v2/Json/AccessGroups | Serializes to the Open API document as a string in the JSON format and represents OpenAPI V2.0 spec.|  | v2 | https://dev.esystems.fi/Endpoint/rest/Doc/v2/Yaml/AccessGroups | Serializes to the Open API document as a string in the Yaml format and represents OpenAPI V2.0 spec. |
 *
 * The version of the OpenAPI document: 3.0.33
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
    ///  Class for testing UsersData
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class UsersDataTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UsersData
        //private UsersData instance;

        public UsersDataTests()
        {
            // TODO uncomment below to create an instance of UsersData
            //instance = new UsersData();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UsersData
        /// </summary>
        [Fact]
        public void UsersDataInstanceTest()
        {
            // TODO uncomment below to test "IsType" UsersData
            //Assert.IsType<UsersData>(instance);
        }

        /// <summary>
        /// Test the property 'Extra'
        /// </summary>
        [Fact]
        public void ExtraTest()
        {
            // TODO unit test for the property 'Extra'
        }

        /// <summary>
        /// Test the property 'IsFullValidation'
        /// </summary>
        [Fact]
        public void IsFullValidationTest()
        {
            // TODO unit test for the property 'IsFullValidation'
        }

        /// <summary>
        /// Test the property 'Users'
        /// </summary>
        [Fact]
        public void UsersTest()
        {
            // TODO unit test for the property 'Users'
        }
    }
}
