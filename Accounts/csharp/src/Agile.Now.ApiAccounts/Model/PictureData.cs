/*
 * Accounts API documentation
 *
 * ## Introduction  The OpenAPI Specification (OAS) defines a standard, language-agnostic interface to RESTful APIs which allows both humans and computers to discover and understand the capabilities of the service without access to source code, documentation, or through network traffic inspection. When properly defined, a consumer can understand and interact with the remote service with a minimal amount of implementation logic.    An OpenAPI definition can then be used by documentation generation tools to display the API, code generation tools to generate servers and clients in various programming languages, testing tools, and many other use cases.    | Version | URL | Description |  | - -- | - -- | - -- |  | v3 | https://dev.esystems.fi/Endpoint/rest/Doc/v3/Json/Accounts | Serializes to the Open API document as a string in the JSON format and represents all patches of OpenAPI V3.0 spec (e.g. 3.0.0, 3.0.1). |  | v3 | https://dev.esystems.fi/Endpoint/rest/Doc/v3/Yaml/Accounts | Serializes to the Open API document as a string in the Yaml format and represents all patches of OpenAPI V3.0 spec (e.g. 3.0.0, 3.0.1). |  | v2 | https://dev.esystems.fi/Endpoint/rest/Doc/v2/Json/Accounts | Serializes to the Open API document as a string in the JSON format and represents OpenAPI V2.0 spec.|  | v2 | https://dev.esystems.fi/Endpoint/rest/Doc/v2/Yaml/Accounts | Serializes to the Open API document as a string in the Yaml format and represents OpenAPI V2.0 spec. |
 *
 * The version of the OpenAPI document: 2.0.47
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
using OpenAPIDateConverter = Agile.Now.ApiAccounts.Client.OpenAPIDateConverter;

namespace Agile.Now.ApiAccounts.Model
{
    /// <summary>
    /// The record of Picture information.
    /// </summary>
    [DataContract(Name = "PictureData")]
    public partial class PictureData : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PictureData" /> class.
        /// </summary>
        /// <param name="filename">Filename of account picture.</param>
        /// <param name="picture">Picture of account.</param>
        /// <param name="createdOn">Date the record was created (default to &quot;1900-01-01T00:00Z&quot;).</param>
        public PictureData(string filename = default(string), System.IO.Stream picture = default(System.IO.Stream), DateTime createdOn = default(DateTime))
        {
            this.Filename = filename;
            this.Picture = picture;
            this.CreatedOn = createdOn;
        }

        /// <summary>
        /// Filename of account picture
        /// </summary>
        /// <value>Filename of account picture</value>
        [DataMember(Name = "Filename", EmitDefaultValue = false)]
        public string Filename { get; set; }

        /// <summary>
        /// Picture of account
        /// </summary>
        /// <value>Picture of account</value>
        [DataMember(Name = "Picture", EmitDefaultValue = false)]
        public System.IO.Stream Picture { get; set; }

        /// <summary>
        /// Date the record was created
        /// </summary>
        /// <value>Date the record was created</value>
        /// <example>1900-01-01T00:00Z</example>
        [DataMember(Name = "CreatedOn", EmitDefaultValue = false)]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PictureData {\n");
            sb.Append("  Filename: ").Append(Filename).Append("\n");
            sb.Append("  Picture: ").Append(Picture).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
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
