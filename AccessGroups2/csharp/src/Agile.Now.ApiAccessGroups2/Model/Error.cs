/*
 * AccessGroups2 API documentation
 *
 * ## Introduction  The OpenAPI Specification (OAS) defines a standard, language-agnostic interface to RESTful APIs which allows both humans and computers to discover and understand the capabilities of the service without access to source code, documentation, or through network traffic inspection. When properly defined, a consumer can understand and interact with the remote service with a minimal amount of implementation logic.    An OpenAPI definition can then be used by documentation generation tools to display the API, code generation tools to generate servers and clients in various programming languages, testing tools, and many other use cases.    | Version | URL | Description |  | - -- | - -- | - -- |  | v3 | https://dev.esystems.fi/Endpoint/rest/Doc/v3/Json/AccessGroups2 | Serializes to the Open API document as a string in the JSON format and represents all patches of OpenAPI V3.0 spec (e.g. 3.0.0, 3.0.1). |  | v3 | https://dev.esystems.fi/Endpoint/rest/Doc/v3/Yaml/AccessGroups2 | Serializes to the Open API document as a string in the Yaml format and represents all patches of OpenAPI V3.0 spec (e.g. 3.0.0, 3.0.1). |  | v2 | https://dev.esystems.fi/Endpoint/rest/Doc/v2/Json/AccessGroups2 | Serializes to the Open API document as a string in the JSON format and represents OpenAPI V2.0 spec.|  | v2 | https://dev.esystems.fi/Endpoint/rest/Doc/v2/Yaml/AccessGroups2 | Serializes to the Open API document as a string in the Yaml format and represents OpenAPI V2.0 spec. |
 *
 * The version of the OpenAPI document: 3.0.6
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
using OpenAPIDateConverter = Agile.Now.ApiAccessGroups2.Client.OpenAPIDateConverter;

namespace Agile.Now.ApiAccessGroups2.Model
{
    /// <summary>
    /// The list of errors. Throw specific exceptions based on the received error.
    /// </summary>
    [DataContract(Name = "Error")]
    public partial class Error : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Error() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        /// <param name="errors">Human-readable explanation of the errors (required).</param>
        /// <param name="type">URI identifier that categorizes the error (default to &quot;&quot;).</param>
        /// <param name="title">Brief, human-readable message about the error (default to &quot;&quot;).</param>
        /// <param name="statusCode">The HTTP response code (required).</param>
        /// <param name="instance">URI that identifies the specific occurrence of the error (default to &quot;&quot;).</param>
        /// <param name="requestKey">Provides a request key that identifies the current request. (default to &quot;&quot;).</param>
        public Error(List<string> errors = default(List<string>), string type = @"", string title = @"", int statusCode = default(int), string instance = @"", string requestKey = @"")
        {
            // to ensure "errors" is required (not null)
            if (errors == null)
            {
                throw new ArgumentNullException("errors is a required property for Error and cannot be null");
            }
            this.Errors = errors;
            this.StatusCode = statusCode;
            // use default value if no "type" provided
            this.Type = type ?? @"";
            // use default value if no "title" provided
            this.Title = title ?? @"";
            // use default value if no "instance" provided
            this.Instance = instance ?? @"";
            // use default value if no "requestKey" provided
            this.RequestKey = requestKey ?? @"";
        }

        /// <summary>
        /// Human-readable explanation of the errors
        /// </summary>
        /// <value>Human-readable explanation of the errors</value>
        [DataMember(Name = "Errors", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Errors { get; set; }

        /// <summary>
        /// URI identifier that categorizes the error
        /// </summary>
        /// <value>URI identifier that categorizes the error</value>
        [DataMember(Name = "Type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Brief, human-readable message about the error
        /// </summary>
        /// <value>Brief, human-readable message about the error</value>
        [DataMember(Name = "Title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// The HTTP response code
        /// </summary>
        /// <value>The HTTP response code</value>
        /// <example>400</example>
        [DataMember(Name = "StatusCode", IsRequired = true, EmitDefaultValue = true)]
        public int StatusCode { get; set; }

        /// <summary>
        /// URI that identifies the specific occurrence of the error
        /// </summary>
        /// <value>URI that identifies the specific occurrence of the error</value>
        [DataMember(Name = "Instance", EmitDefaultValue = false)]
        public string Instance { get; set; }

        /// <summary>
        /// Provides a request key that identifies the current request.
        /// </summary>
        /// <value>Provides a request key that identifies the current request.</value>
        [DataMember(Name = "RequestKey", EmitDefaultValue = false)]
        public string RequestKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Error {\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  Instance: ").Append(Instance).Append("\n");
            sb.Append("  RequestKey: ").Append(RequestKey).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
