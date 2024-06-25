/*
 * Webhook API
 *
 * ## Introduction  The OpenAPI Specification (OAS) defines a standard, language-agnostic interface to RESTful APIs which allows both humans and computers to discover and understand the capabilities of the service without access to source code, documentation, or through network traffic inspection. When properly defined, a consumer can understand and interact with the remote service with a minimal amount of implementation logic.    An OpenAPI definition can then be used by documentation generation tools to display the API, code generation tools to generate servers and clients in various programming languages, testing tools, and many other use cases.    | Version | URL | Description |  | - -- | - -- | - -- |  | v3 | https://dev.esystems.fi/Endpoint/rest/Doc/v3/Json/Webhooks | Serializes to the Open API document as a string in the JSON format and represents all patches of OpenAPI V3.0 spec (e.g. 3.0.0, 3.0.1). |  | v3 | https://dev.esystems.fi/Endpoint/rest/Doc/v3/Yaml/Webhooks | Serializes to the Open API document as a string in the Yaml format and represents all patches of OpenAPI V3.0 spec (e.g. 3.0.0, 3.0.1). |  | v2 | https://dev.esystems.fi/Endpoint/rest/Doc/v2/Json/Webhooks | Serializes to the Open API document as a string in the JSON format and represents OpenAPI V2.0 spec.|  | v2 | https://dev.esystems.fi/Endpoint/rest/Doc/v2/Yaml/Webhooks | Serializes to the Open API document as a string in the Yaml format and represents OpenAPI V2.0 spec. |
 *
 * The version of the OpenAPI document: 3.0.18
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
using OpenAPIDateConverter = Agile.Now.ApiWebhooks.Client.OpenAPIDateConverter;

namespace Agile.Now.ApiWebhooks.Model
{
    /// <summary>
    /// List validation for entity attribute
    /// </summary>
    [DataContract(Name = "ListValidation")]
    public partial class ListValidation : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListValidation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListValidation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListValidation" /> class.
        /// </summary>
        /// <param name="name">The name of the entity field. (required).</param>
        /// <param name="fieldName">The field name of relation database table.  Example;  The field name is &amp;quot;TenantId&amp;quot; and is associated with the &amp;quot;Tenant&amp;quot; table. You want to use in the &amp;quot;Tenant&amp;quot; table &amp;quot;Name&amp;quot; field fetching data. Once &amp;quot;Name&amp;quot; is specified, the validation service retrieves the tenant identifier from the &amp;quot;Tenant&amp;quot; table based on the &amp;quot;Name&amp;quot; field..</param>
        /// <param name="required">If True, the value is required. (default to false).</param>
        /// <param name="unique">If True, the value must be unique in the database and you cannot add multiple values. (default to false).</param>
        /// <param name="max">The max value of input value..</param>
        /// <param name="min">The min value of input value..</param>
        /// <param name="pattern">The pattern of the validation. Searches the input string for an occurrence of a regular expression..</param>
        /// <param name="defaultValue">The default value of row. If the value of the field is empty, the service automatically sets the value in the field. If the value does not match the data type, the value is cleaned. Remember data types..</param>
        public ListValidation(string name = default(string), string fieldName = default(string), bool required = false, bool unique = false, string max = default(string), string min = default(string), string pattern = default(string), string defaultValue = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ListValidation and cannot be null");
            }
            this.Name = name;
            this.FieldName = fieldName;
            this.Required = required;
            this.Unique = unique;
            this.Max = max;
            this.Min = min;
            this.Pattern = pattern;
            this.DefaultValue = defaultValue;
        }

        /// <summary>
        /// The name of the entity field.
        /// </summary>
        /// <value>The name of the entity field.</value>
        [DataMember(Name = "Name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The field name of relation database table.  Example;  The field name is &amp;quot;TenantId&amp;quot; and is associated with the &amp;quot;Tenant&amp;quot; table. You want to use in the &amp;quot;Tenant&amp;quot; table &amp;quot;Name&amp;quot; field fetching data. Once &amp;quot;Name&amp;quot; is specified, the validation service retrieves the tenant identifier from the &amp;quot;Tenant&amp;quot; table based on the &amp;quot;Name&amp;quot; field.
        /// </summary>
        /// <value>The field name of relation database table.  Example;  The field name is &amp;quot;TenantId&amp;quot; and is associated with the &amp;quot;Tenant&amp;quot; table. You want to use in the &amp;quot;Tenant&amp;quot; table &amp;quot;Name&amp;quot; field fetching data. Once &amp;quot;Name&amp;quot; is specified, the validation service retrieves the tenant identifier from the &amp;quot;Tenant&amp;quot; table based on the &amp;quot;Name&amp;quot; field.</value>
        [DataMember(Name = "FieldName", EmitDefaultValue = false)]
        public string FieldName { get; set; }

        /// <summary>
        /// If True, the value is required.
        /// </summary>
        /// <value>If True, the value is required.</value>
        /// <example>false</example>
        [DataMember(Name = "Required", EmitDefaultValue = true)]
        public bool Required { get; set; }

        /// <summary>
        /// If True, the value must be unique in the database and you cannot add multiple values.
        /// </summary>
        /// <value>If True, the value must be unique in the database and you cannot add multiple values.</value>
        /// <example>false</example>
        [DataMember(Name = "Unique", EmitDefaultValue = true)]
        public bool Unique { get; set; }

        /// <summary>
        /// The max value of input value.
        /// </summary>
        /// <value>The max value of input value.</value>
        [DataMember(Name = "Max", EmitDefaultValue = false)]
        public string Max { get; set; }

        /// <summary>
        /// The min value of input value.
        /// </summary>
        /// <value>The min value of input value.</value>
        [DataMember(Name = "Min", EmitDefaultValue = false)]
        public string Min { get; set; }

        /// <summary>
        /// The pattern of the validation. Searches the input string for an occurrence of a regular expression.
        /// </summary>
        /// <value>The pattern of the validation. Searches the input string for an occurrence of a regular expression.</value>
        [DataMember(Name = "Pattern", EmitDefaultValue = false)]
        public string Pattern { get; set; }

        /// <summary>
        /// The default value of row. If the value of the field is empty, the service automatically sets the value in the field. If the value does not match the data type, the value is cleaned. Remember data types.
        /// </summary>
        /// <value>The default value of row. If the value of the field is empty, the service automatically sets the value in the field. If the value does not match the data type, the value is cleaned. Remember data types.</value>
        [DataMember(Name = "DefaultValue", EmitDefaultValue = false)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListValidation {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Unique: ").Append(Unique).Append("\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
            sb.Append("  Min: ").Append(Min).Append("\n");
            sb.Append("  Pattern: ").Append(Pattern).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
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
