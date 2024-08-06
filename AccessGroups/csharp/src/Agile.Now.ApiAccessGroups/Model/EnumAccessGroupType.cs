/*
 * AccessGroups API documentation
 *
 * ## Introduction  The OpenAPI Specification (OAS) defines a standard, language-agnostic interface to RESTful APIs which allows both humans and computers to discover and understand the capabilities of the service without access to source code, documentation, or through network traffic inspection. When properly defined, a consumer can understand and interact with the remote service with a minimal amount of implementation logic.    An OpenAPI definition can then be used by documentation generation tools to display the API, code generation tools to generate servers and clients in various programming languages, testing tools, and many other use cases.    | Version | URL | Description |  | - -- | - -- | - -- |  | v3 | https://dev.esystems.fi/Endpoint/rest/Doc/v3/Json/AccessGroups | Serializes to the Open API document as a string in the JSON format and represents all patches of OpenAPI V3.0 spec (e.g. 3.0.0, 3.0.1). |  | v3 | https://dev.esystems.fi/Endpoint/rest/Doc/v3/Yaml/AccessGroups | Serializes to the Open API document as a string in the Yaml format and represents all patches of OpenAPI V3.0 spec (e.g. 3.0.0, 3.0.1). |  | v2 | https://dev.esystems.fi/Endpoint/rest/Doc/v2/Json/AccessGroups | Serializes to the Open API document as a string in the JSON format and represents OpenAPI V2.0 spec.|  | v2 | https://dev.esystems.fi/Endpoint/rest/Doc/v2/Yaml/AccessGroups | Serializes to the Open API document as a string in the Yaml format and represents OpenAPI V2.0 spec. |
 *
 * The version of the OpenAPI document: 3.0.38
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Agile.Now.ApiAccessGroups.Client.OpenAPIDateConverter;

namespace Agile.Now.ApiAccessGroups.Model
{
    /// <summary>
    /// The enum of AccessGroupType.
    /// </summary>
    /// <value>The enum of AccessGroupType.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EnumAccessGroupType
    {
        /// <summary>
        /// Enum FullAccess for value: FullAccess
        /// </summary>
        [EnumMember(Value = "FullAccess")]
        FullAccess = 1,

        /// <summary>
        /// Enum Locations for value: Locations
        /// </summary>
        [EnumMember(Value = "Locations")]
        Locations = 2,

        /// <summary>
        /// Enum Departments for value: Departments
        /// </summary>
        [EnumMember(Value = "Departments")]
        Departments = 3
    }

}
