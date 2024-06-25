/*
 * Organization API
 *
 * ## Introduction  The OpenAPI Specification (OAS) defines a standard, language-agnostic interface to RESTful APIs which allows both humans and computers to discover and understand the capabilities of the service without access to source code, documentation, or through network traffic inspection. When properly defined, a consumer can understand and interact with the remote service with a minimal amount of implementation logic.    An OpenAPI definition can then be used by documentation generation tools to display the API, code generation tools to generate servers and clients in various programming languages, testing tools, and many other use cases.    | Version | URL | Description |  | - -- | - -- | - -- |  | v3 | https://dev.esystems.fi/Endpoint/rest/Doc/v3/Json/Organizations | Serializes to the Open API document as a string in the JSON format and represents all patches of OpenAPI V3.0 spec (e.g. 3.0.0, 3.0.1). |  | v3 | https://dev.esystems.fi/Endpoint/rest/Doc/v3/Yaml/Organizations | Serializes to the Open API document as a string in the Yaml format and represents all patches of OpenAPI V3.0 spec (e.g. 3.0.0, 3.0.1). |  | v2 | https://dev.esystems.fi/Endpoint/rest/Doc/v2/Json/Organizations | Serializes to the Open API document as a string in the JSON format and represents OpenAPI V2.0 spec.|  | v2 | https://dev.esystems.fi/Endpoint/rest/Doc/v2/Yaml/Organizations | Serializes to the Open API document as a string in the Yaml format and represents OpenAPI V2.0 spec. |
 *
 * The version of the OpenAPI document: 2.0.84
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Agile.Now.ApiOrganizations.Model;
using Agile.Now.ApiOrganizations.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Agile.Now.ApiOrganizations.Test.Model
{
    /// <summary>
    ///  Class for testing DepartmentUpdateData
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DepartmentUpdateDataTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DepartmentUpdateData
        //private DepartmentUpdateData instance;

        public DepartmentUpdateDataTests()
        {
            // TODO uncomment below to create an instance of DepartmentUpdateData
            //instance = new DepartmentUpdateData();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DepartmentUpdateData
        /// </summary>
        [Fact]
        public void DepartmentUpdateDataInstanceTest()
        {
            // TODO uncomment below to test "IsType" DepartmentUpdateData
            //Assert.IsType<DepartmentUpdateData>(instance);
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
        /// Test the property 'ContactName'
        /// </summary>
        [Fact]
        public void ContactNameTest()
        {
            // TODO unit test for the property 'ContactName'
        }

        /// <summary>
        /// Test the property 'ContactEmail'
        /// </summary>
        [Fact]
        public void ContactEmailTest()
        {
            // TODO unit test for the property 'ContactEmail'
        }

        /// <summary>
        /// Test the property 'ContactPhone'
        /// </summary>
        [Fact]
        public void ContactPhoneTest()
        {
            // TODO unit test for the property 'ContactPhone'
        }

        /// <summary>
        /// Test the property 'OwnerId'
        /// </summary>
        [Fact]
        public void OwnerIdTest()
        {
            // TODO unit test for the property 'OwnerId'
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
        /// Test the property 'IsActive'
        /// </summary>
        [Fact]
        public void IsActiveTest()
        {
            // TODO unit test for the property 'IsActive'
        }
    }
}
