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
    /// The record of AccessGroup information.
    /// </summary>
    [DataContract(Name = "AccessGroupData")]
    public partial class AccessGroupData : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets AccessGroupTypeId
        /// </summary>
        [DataMember(Name = "AccessGroupTypeId", EmitDefaultValue = false)]
        public EnumAccessGroupType? AccessGroupTypeId { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessGroupData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccessGroupData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessGroupData" /> class.
        /// </summary>
        /// <param name="id">The identifier of access group..</param>
        /// <param name="name">The name of access group. (required).</param>
        /// <param name="externalId">The external system code of the access group..</param>
        /// <param name="description">The description of access group..</param>
        /// <param name="isActive">Defines if record is active. (default to false).</param>
        /// <param name="isSystem">Defines if access group is system and end-user cannot change it general, permissions and applications. (default to false).</param>
        /// <param name="accessGroupTypeId">accessGroupTypeId.</param>
        public AccessGroupData(string id = default(string), string name = default(string), string externalId = default(string), string description = default(string), bool isActive = false, bool isSystem = false, EnumAccessGroupType? accessGroupTypeId = default(EnumAccessGroupType?))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AccessGroupData and cannot be null");
            }
            this.Name = name;
            this.Id = id;
            this.ExternalId = externalId;
            this.Description = description;
            this.IsActive = isActive;
            this.IsSystem = isSystem;
            this.AccessGroupTypeId = accessGroupTypeId;
        }

        /// <summary>
        /// The identifier of access group.
        /// </summary>
        /// <value>The identifier of access group.</value>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The name of access group.
        /// </summary>
        /// <value>The name of access group.</value>
        [DataMember(Name = "Name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The external system code of the access group.
        /// </summary>
        /// <value>The external system code of the access group.</value>
        [DataMember(Name = "ExternalId", EmitDefaultValue = false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The description of access group.
        /// </summary>
        /// <value>The description of access group.</value>
        [DataMember(Name = "Description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Defines if record is active.
        /// </summary>
        /// <value>Defines if record is active.</value>
        /// <example>false</example>
        [DataMember(Name = "Is_Active", EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Defines if access group is system and end-user cannot change it general, permissions and applications.
        /// </summary>
        /// <value>Defines if access group is system and end-user cannot change it general, permissions and applications.</value>
        /// <example>false</example>
        [DataMember(Name = "Is_System", EmitDefaultValue = true)]
        public bool IsSystem { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccessGroupData {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsSystem: ").Append(IsSystem).Append("\n");
            sb.Append("  AccessGroupTypeId: ").Append(AccessGroupTypeId).Append("\n");
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
