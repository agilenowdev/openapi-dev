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
    ///  Class for testing Meta
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class MetaTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Meta
        //private Meta instance;

        public MetaTests()
        {
            // TODO uncomment below to create an instance of Meta
            //instance = new Meta();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Meta
        /// </summary>
        [Fact]
        public void MetaInstanceTest()
        {
            // TODO uncomment below to test "IsType" Meta
            //Assert.IsType<Meta>(instance);
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
