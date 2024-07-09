/*
 * Accounts API documentation
 *
 * ## Introduction  The OpenAPI Specification (OAS) defines a standard, language-agnostic interface to RESTful APIs which allows both humans and computers to discover and understand the capabilities of the service without access to source code, documentation, or through network traffic inspection. When properly defined, a consumer can understand and interact with the remote service with a minimal amount of implementation logic.    An OpenAPI definition can then be used by documentation generation tools to display the API, code generation tools to generate servers and clients in various programming languages, testing tools, and many other use cases.    | Version | URL | Description |  | - -- | - -- | - -- |  | v3 | https://dev.esystems.fi/Endpoint/rest/Doc/v3/Json/Accounts | Serializes to the Open API document as a string in the JSON format and represents all patches of OpenAPI V3.0 spec (e.g. 3.0.0, 3.0.1). |  | v3 | https://dev.esystems.fi/Endpoint/rest/Doc/v3/Yaml/Accounts | Serializes to the Open API document as a string in the Yaml format and represents all patches of OpenAPI V3.0 spec (e.g. 3.0.0, 3.0.1). |  | v2 | https://dev.esystems.fi/Endpoint/rest/Doc/v2/Json/Accounts | Serializes to the Open API document as a string in the JSON format and represents OpenAPI V2.0 spec.|  | v2 | https://dev.esystems.fi/Endpoint/rest/Doc/v2/Yaml/Accounts | Serializes to the Open API document as a string in the Yaml format and represents OpenAPI V2.0 spec. |
 *
 * The version of the OpenAPI document: 2.0.57
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Agile.Now.ApiAccounts.Model;
using Agile.Now.ApiAccounts.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Agile.Now.ApiAccounts.Test.Model
{
    /// <summary>
    ///  Class for testing TenantData
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TenantDataTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for TenantData
        //private TenantData instance;

        public TenantDataTests()
        {
            // TODO uncomment below to create an instance of TenantData
            //instance = new TenantData();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TenantData
        /// </summary>
        [Fact]
        public void TenantDataInstanceTest()
        {
            // TODO uncomment below to test "IsType" TenantData
            //Assert.IsType<TenantData>(instance);
        }

        /// <summary>
        /// Test the property 'UserId'
        /// </summary>
        [Fact]
        public void UserIdTest()
        {
            // TODO unit test for the property 'UserId'
        }

        /// <summary>
        /// Test the property 'TenantId'
        /// </summary>
        [Fact]
        public void TenantIdTest()
        {
            // TODO unit test for the property 'TenantId'
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
