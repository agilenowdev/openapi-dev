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
    ///  Class for testing ListValidation
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ListValidationTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ListValidation
        //private ListValidation instance;

        public ListValidationTests()
        {
            // TODO uncomment below to create an instance of ListValidation
            //instance = new ListValidation();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ListValidation
        /// </summary>
        [Fact]
        public void ListValidationInstanceTest()
        {
            // TODO uncomment below to test "IsType" ListValidation
            //Assert.IsType<ListValidation>(instance);
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
        /// Test the property 'FieldName'
        /// </summary>
        [Fact]
        public void FieldNameTest()
        {
            // TODO unit test for the property 'FieldName'
        }

        /// <summary>
        /// Test the property 'Required'
        /// </summary>
        [Fact]
        public void RequiredTest()
        {
            // TODO unit test for the property 'Required'
        }

        /// <summary>
        /// Test the property 'Unique'
        /// </summary>
        [Fact]
        public void UniqueTest()
        {
            // TODO unit test for the property 'Unique'
        }

        /// <summary>
        /// Test the property 'Max'
        /// </summary>
        [Fact]
        public void MaxTest()
        {
            // TODO unit test for the property 'Max'
        }

        /// <summary>
        /// Test the property 'Min'
        /// </summary>
        [Fact]
        public void MinTest()
        {
            // TODO unit test for the property 'Min'
        }

        /// <summary>
        /// Test the property 'Pattern'
        /// </summary>
        [Fact]
        public void PatternTest()
        {
            // TODO unit test for the property 'Pattern'
        }

        /// <summary>
        /// Test the property 'DefaultValue'
        /// </summary>
        [Fact]
        public void DefaultValueTest()
        {
            // TODO unit test for the property 'DefaultValue'
        }
    }
}
