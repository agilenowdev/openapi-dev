/*
 * Organization API
 *
 * ## Introduction  The OpenAPI Specification (OAS) defines a standard, language-agnostic interface to RESTful APIs which allows both humans and computers to discover and understand the capabilities of the service without access to source code, documentation, or through network traffic inspection. When properly defined, a consumer can understand and interact with the remote service with a minimal amount of implementation logic.    An OpenAPI definition can then be used by documentation generation tools to display the API, code generation tools to generate servers and clients in various programming languages, testing tools, and many other use cases.    | Version | URL | Description |  | - -- | - -- | - -- |  | v3 | https://dev.esystems.fi/Endpoint/rest/Doc/v3/Json/Organizations | Serializes to the Open API document as a string in the JSON format and represents all patches of OpenAPI V3.0 spec (e.g. 3.0.0, 3.0.1). |  | v3 | https://dev.esystems.fi/Endpoint/rest/Doc/v3/Yaml/Organizations | Serializes to the Open API document as a string in the Yaml format and represents all patches of OpenAPI V3.0 spec (e.g. 3.0.0, 3.0.1). |  | v2 | https://dev.esystems.fi/Endpoint/rest/Doc/v2/Json/Organizations | Serializes to the Open API document as a string in the JSON format and represents OpenAPI V2.0 spec.|  | v2 | https://dev.esystems.fi/Endpoint/rest/Doc/v2/Yaml/Organizations | Serializes to the Open API document as a string in the Yaml format and represents OpenAPI V2.0 spec. |
 *
 * The version of the OpenAPI document: 2.0.90
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
using OpenAPIDateConverter = Agile.Now.ApiOrganizations.Client.OpenAPIDateConverter;

namespace Agile.Now.ApiOrganizations.Model
{
    /// <summary>
    /// The abstract object structure
    /// </summary>
    [DataContract(Name = "AbstractLong")]
    public partial class AbstractLong : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractLong" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AbstractLong() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractLong" /> class.
        /// </summary>
        /// <param name="id">The primary key of the record row. If the Id attribute is used, then it must be unique (required) (default to 0).</param>
        /// <param name="externalId">The external identier of the record row. If the External Id attribute is used, then it must be unique (required).</param>
        /// <param name="name">The name of the record row (required).</param>
        /// <param name="type">The type of the record object (required).</param>
        public AbstractLong(long id = 0, string externalId = default(string), string name = default(string), string type = default(string))
        {
            this.Id = id;
            this.ExternalId = externalId;
            this.Name = name;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for AbstractLong and cannot be null");
            }
            this.Type = type;
        }

        /// <summary>
        /// The primary key of the record row. If the Id attribute is used, then it must be unique
        /// </summary>
        /// <value>The primary key of the record row. If the Id attribute is used, then it must be unique</value>
        /// <example>1234567891234567</example>
        [DataMember(Name = "Id", EmitDefaultValue = true)]
        public long Id { get; set; }

        /// <summary>
        /// The external identier of the record row. If the External Id attribute is used, then it must be unique
        /// </summary>
        /// <value>The external identier of the record row. If the External Id attribute is used, then it must be unique</value>
        /// <example>3ad64ab3-bd04-46c5-b1d7-c0b34be9e5b5</example>
        [DataMember(Name = "ExternalId", EmitDefaultValue = true)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The name of the record row
        /// </summary>
        /// <value>The name of the record row</value>
        /// <example>Bob Normal</example>
        [DataMember(Name = "Name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The type of the record object
        /// </summary>
        /// <value>The type of the record object</value>
        /// <example>User</example>
        [DataMember(Name = "Type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AbstractLong {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
