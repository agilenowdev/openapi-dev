/*
 * Organization API
 *
 * ## Introduction  The OpenAPI Specification (OAS) defines a standard, language-agnostic interface to RESTful APIs which allows both humans and computers to discover and understand the capabilities of the service without access to source code, documentation, or through network traffic inspection. When properly defined, a consumer can understand and interact with the remote service with a minimal amount of implementation logic.    An OpenAPI definition can then be used by documentation generation tools to display the API, code generation tools to generate servers and clients in various programming languages, testing tools, and many other use cases.    | Version | URL | Description |  | - -- | - -- | - -- |  | v3 | https://dev.esystems.fi/Endpoint/rest/Doc/v3/Json/Organizations | Serializes to the Open API document as a string in the JSON format and represents all patches of OpenAPI V3.0 spec (e.g. 3.0.0, 3.0.1). |  | v3 | https://dev.esystems.fi/Endpoint/rest/Doc/v3/Yaml/Organizations | Serializes to the Open API document as a string in the Yaml format and represents all patches of OpenAPI V3.0 spec (e.g. 3.0.0, 3.0.1). |  | v2 | https://dev.esystems.fi/Endpoint/rest/Doc/v2/Json/Organizations | Serializes to the Open API document as a string in the JSON format and represents OpenAPI V2.0 spec.|  | v2 | https://dev.esystems.fi/Endpoint/rest/Doc/v2/Yaml/Organizations | Serializes to the Open API document as a string in the Yaml format and represents OpenAPI V2.0 spec. |
 *
 * The version of the OpenAPI document: 2.0.84
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
using OpenAPIDateConverter = Agile.Now.OrganizationsApi.Client.OpenAPIDateConverter;

namespace Agile.Now.OrganizationsApi.Model
{
    /// <summary>
    /// The record of Department information.
    /// </summary>
    [DataContract(Name = "DepartmentUpdateData")]
    public partial class DepartmentUpdateData : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DepartmentUpdateData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DepartmentUpdateData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DepartmentUpdateData" /> class.
        /// </summary>
        /// <param name="externalId">The external identifier of the department.</param>
        /// <param name="name">The name of the department (required).</param>
        /// <param name="contactName">The contact name of company or department.</param>
        /// <param name="contactEmail">The contact email of external company or department.</param>
        /// <param name="contactPhone">contactPhone.</param>
        /// <param name="ownerId">ownerId.</param>
        /// <param name="countryId">countryId.</param>
        /// <param name="isActive">Defines if the department is active and can be used (required) (default to false).</param>
        public DepartmentUpdateData(string externalId = default(string), string name = default(string), string contactName = default(string), string contactEmail = default(string), string contactPhone = default(string), FieldType ownerId = default(FieldType), FieldType countryId = default(FieldType), bool isActive = false)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for DepartmentUpdateData and cannot be null");
            }
            this.Name = name;
            this.IsActive = isActive;
            this.ExternalId = externalId;
            this.ContactName = contactName;
            this.ContactEmail = contactEmail;
            this.ContactPhone = contactPhone;
            this.OwnerId = ownerId;
            this.CountryId = countryId;
        }

        /// <summary>
        /// The external identifier of the department
        /// </summary>
        /// <value>The external identifier of the department</value>
        [DataMember(Name = "ExternalId", EmitDefaultValue = false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The name of the department
        /// </summary>
        /// <value>The name of the department</value>
        [DataMember(Name = "Name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The contact name of company or department
        /// </summary>
        /// <value>The contact name of company or department</value>
        [DataMember(Name = "ContactName", EmitDefaultValue = false)]
        public string ContactName { get; set; }

        /// <summary>
        /// The contact email of external company or department
        /// </summary>
        /// <value>The contact email of external company or department</value>
        [DataMember(Name = "ContactEmail", EmitDefaultValue = false)]
        public string ContactEmail { get; set; }

        /// <summary>
        /// Gets or Sets ContactPhone
        /// </summary>
        [DataMember(Name = "ContactPhone", EmitDefaultValue = false)]
        public string ContactPhone { get; set; }

        /// <summary>
        /// Gets or Sets OwnerId
        /// </summary>
        [DataMember(Name = "OwnerId", EmitDefaultValue = false)]
        public FieldType OwnerId { get; set; }

        /// <summary>
        /// Gets or Sets CountryId
        /// </summary>
        [DataMember(Name = "CountryId", EmitDefaultValue = false)]
        public FieldType CountryId { get; set; }

        /// <summary>
        /// Defines if the department is active and can be used
        /// </summary>
        /// <value>Defines if the department is active and can be used</value>
        /// <example>false</example>
        [DataMember(Name = "Is_Active", IsRequired = true, EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DepartmentUpdateData {\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ContactName: ").Append(ContactName).Append("\n");
            sb.Append("  ContactEmail: ").Append(ContactEmail).Append("\n");
            sb.Append("  ContactPhone: ").Append(ContactPhone).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  CountryId: ").Append(CountryId).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
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
