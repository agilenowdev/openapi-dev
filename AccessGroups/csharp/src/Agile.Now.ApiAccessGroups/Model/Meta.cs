/*
 * AccessGroups API documentation
 *
 * ## Introduction  The OpenAPI Specification (OAS) defines a standard, language-agnostic interface to RESTful APIs which allows both humans and computers to discover and understand the capabilities of the service without access to source code, documentation, or through network traffic inspection. When properly defined, a consumer can understand and interact with the remote service with a minimal amount of implementation logic.    An OpenAPI definition can then be used by documentation generation tools to display the API, code generation tools to generate servers and clients in various programming languages, testing tools, and many other use cases.    | Version | URL | Description |  | - -- | - -- | - -- |  | v3 | https://dev.esystems.fi/Endpoint/rest/Doc/v3/Json/AccessGroups | Serializes to the Open API document as a string in the JSON format and represents all patches of OpenAPI V3.0 spec (e.g. 3.0.0, 3.0.1). |  | v3 | https://dev.esystems.fi/Endpoint/rest/Doc/v3/Yaml/AccessGroups | Serializes to the Open API document as a string in the Yaml format and represents all patches of OpenAPI V3.0 spec (e.g. 3.0.0, 3.0.1). |  | v2 | https://dev.esystems.fi/Endpoint/rest/Doc/v2/Json/AccessGroups | Serializes to the Open API document as a string in the JSON format and represents OpenAPI V2.0 spec.|  | v2 | https://dev.esystems.fi/Endpoint/rest/Doc/v2/Yaml/AccessGroups | Serializes to the Open API document as a string in the Yaml format and represents OpenAPI V2.0 spec. |
 *
 * The version of the OpenAPI document: 3.0.8
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
    /// The object provides metadata about the list of items returned in the API response. It typically includes information that helps clients understand and work with the data.
    /// </summary>
    [DataContract(Name = "Meta")]
    public partial class Meta : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Meta" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Meta() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Meta" /> class.
        /// </summary>
        /// <param name="totalItems">This field represents the total number of items available in the entire dataset, not just the items returned in the current response. It&#39;s useful for implementing pagination, as clients can use it to calculate the number of pages or total available items. (required) (default to 0).</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with &#x60;PageSize&#x60; to manage pagination by indicating which subset of the total data is currently being retrieved. (required) (default to 1).</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed. (required) (default to 50).</param>
        /// <param name="type">The type of the record (required).</param>
        public Meta(int totalItems = 0, int currentPage = 1, int pageSize = 50, string type = default(string))
        {
            this.TotalItems = totalItems;
            this.CurrentPage = currentPage;
            this.PageSize = pageSize;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for Meta and cannot be null");
            }
            this.Type = type;
        }

        /// <summary>
        /// This field represents the total number of items available in the entire dataset, not just the items returned in the current response. It&#39;s useful for implementing pagination, as clients can use it to calculate the number of pages or total available items.
        /// </summary>
        /// <value>This field represents the total number of items available in the entire dataset, not just the items returned in the current response. It&#39;s useful for implementing pagination, as clients can use it to calculate the number of pages or total available items.</value>
        /// <example>1000</example>
        [DataMember(Name = "TotalItems", IsRequired = true, EmitDefaultValue = true)]
        public int TotalItems { get; set; }

        /// <summary>
        /// This field specifies the current page of results being returned. It&#39;s often used in conjunction with &#x60;PageSize&#x60; to manage pagination by indicating which subset of the total data is currently being retrieved.
        /// </summary>
        /// <value>This field specifies the current page of results being returned. It&#39;s often used in conjunction with &#x60;PageSize&#x60; to manage pagination by indicating which subset of the total data is currently being retrieved.</value>
        /// <example>50</example>
        [DataMember(Name = "CurrentPage", IsRequired = true, EmitDefaultValue = true)]
        public int CurrentPage { get; set; }

        /// <summary>
        /// The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.
        /// </summary>
        /// <value>The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.</value>
        /// <example>50</example>
        [DataMember(Name = "PageSize", IsRequired = true, EmitDefaultValue = true)]
        public int PageSize { get; set; }

        /// <summary>
        /// The type of the record
        /// </summary>
        /// <value>The type of the record</value>
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
            sb.Append("class Meta {\n");
            sb.Append("  TotalItems: ").Append(TotalItems).Append("\n");
            sb.Append("  CurrentPage: ").Append(CurrentPage).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
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
