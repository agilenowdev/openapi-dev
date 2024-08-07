/*
 * Organization API
 *
 * ## Introduction  The OpenAPI Specification (OAS) defines a standard, language-agnostic interface to RESTful APIs which allows both humans and computers to discover and understand the capabilities of the service without access to source code, documentation, or through network traffic inspection. When properly defined, a consumer can understand and interact with the remote service with a minimal amount of implementation logic.    An OpenAPI definition can then be used by documentation generation tools to display the API, code generation tools to generate servers and clients in various programming languages, testing tools, and many other use cases.    | Version | URL | Description |  | - -- | - -- | - -- |  | v3 | https://dev.esystems.fi/Endpoint/rest/Doc/v3/Json/Organizations | Serializes to the Open API document as a string in the JSON format and represents all patches of OpenAPI V3.0 spec (e.g. 3.0.0, 3.0.1). |  | v3 | https://dev.esystems.fi/Endpoint/rest/Doc/v3/Yaml/Organizations | Serializes to the Open API document as a string in the Yaml format and represents all patches of OpenAPI V3.0 spec (e.g. 3.0.0, 3.0.1). |  | v2 | https://dev.esystems.fi/Endpoint/rest/Doc/v2/Json/Organizations | Serializes to the Open API document as a string in the JSON format and represents OpenAPI V2.0 spec.|  | v2 | https://dev.esystems.fi/Endpoint/rest/Doc/v2/Yaml/Organizations | Serializes to the Open API document as a string in the Yaml format and represents OpenAPI V2.0 spec. |
 *
 * The version of the OpenAPI document: 2.0.104
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
    /// The record of Location information.
    /// </summary>
    [DataContract(Name = "LocationInsertData")]
    public partial class LocationInsertData : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets CountryId
        /// </summary>
        [DataMember(Name = "CountryId", EmitDefaultValue = false)]
        public EnumCountry? CountryId { get; set; }

        /// <summary>
        /// Gets or Sets TimezoneId
        /// </summary>
        [DataMember(Name = "TimezoneId", EmitDefaultValue = false)]
        public EnumTimezone? TimezoneId { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyId
        /// </summary>
        [DataMember(Name = "CurrencyId", EmitDefaultValue = false)]
        public EnumCurrency? CurrencyId { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationInsertData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LocationInsertData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationInsertData" /> class.
        /// </summary>
        /// <param name="id">The guid to identify the location. (required).</param>
        /// <param name="externalId">The external identifier of the location..</param>
        /// <param name="name">The name of the location. The value must be unique in the system and you cannot add multiple values. (required).</param>
        /// <param name="countryId">countryId.</param>
        /// <param name="timezoneId">timezoneId.</param>
        /// <param name="currencyId">currencyId.</param>
        public LocationInsertData(string id = default(string), string externalId = default(string), string name = default(string), EnumCountry? countryId = default(EnumCountry?), EnumTimezone? timezoneId = default(EnumTimezone?), EnumCurrency? currencyId = default(EnumCurrency?))
        {
            this.Id = id;
            this.Name = name;
            this.ExternalId = externalId;
            this.CountryId = countryId;
            this.TimezoneId = timezoneId;
            this.CurrencyId = currencyId;
        }

        /// <summary>
        /// The guid to identify the location.
        /// </summary>
        /// <value>The guid to identify the location.</value>
        [DataMember(Name = "Id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The external identifier of the location.
        /// </summary>
        /// <value>The external identifier of the location.</value>
        [DataMember(Name = "ExternalId", EmitDefaultValue = false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The name of the location. The value must be unique in the system and you cannot add multiple values.
        /// </summary>
        /// <value>The name of the location. The value must be unique in the system and you cannot add multiple values.</value>
        [DataMember(Name = "Name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LocationInsertData {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CountryId: ").Append(CountryId).Append("\n");
            sb.Append("  TimezoneId: ").Append(TimezoneId).Append("\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
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
