/*
 * Agile.Now.AccessHub API documentation
 *
 * Agile.Now.AccessHub is a secure REST API designed to manage accounts, access groups, user groups, organizations, locations, applications, roles, and webhooks. This API provides a robust and scalable solution for managing user access and organizational structures in a multi-tenant environment.    **Key Features:**    1. **Accounts Management:**     - Manage user accounts with secure authentication and authorization.    2. **Access Groups:**     - Define and manage access groups for access control.     - Assign users to access groups based on roles and permissions.    3. **User Groups:**     - Create and manage user groups for better organization and collaboration.    4. **Organizations & Locations:**     - Manage multiple organizations and locations within a single platform.     - Attribute-based access control (ABAC) for settings.    5. **Applications:**     - Centralized management of applications within the platform.     - Assign and monitor application usage and access.    6. **Roles:**     - Define and manage roles for different access levels.     - Role-based access control to ensure appropriate permissions.    7. **Webhooks:**     - Integration with external services and applications.     - Configure and manage webhooks for real-time notifications and data syncing.    **Benefits:**    - **Enhanced Security:** Attribute-based and role-based access controls ensure data protection and authorized access.  - **Scalability:** Designed for growing organizations.  - **Efficiency:** Streamlined management of accounts, groups, and roles reduces overhead.  - **Flexibility:** Multi-tenant architecture allows easy customization.  - **Integration:** Webhook support facilitates seamless integration with external systems.    **Conclusion:**    Agile.Now.AccessHub is a powerful platform for managing your business data. It offers a centralized, secure, and scalable solution, enhancing operational efficiency, security, and flexibility in managing multi-tenant environments.
 *
 * The version of the OpenAPI document: 2.0.1
 * Contact: dev@agilenow.io
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
using OpenAPIDateConverter = Agile.Now.AccessHub.Client.OpenAPIDateConverter;

namespace Agile.Now.AccessHub.Model
{
    /// <summary>
    /// The record of Location information.
    /// </summary>
    [DataContract(Name = "Location")]
    public partial class Location : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Location" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Location() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Location" /> class.
        /// </summary>
        /// <param name="id">The guid to identify the location (required).</param>
        /// <param name="externalId">The external identifier of the location.</param>
        /// <param name="name">The name of the location (required).</param>
        /// <param name="countryId">countryId.</param>
        /// <param name="timezoneId">timezoneId.</param>
        /// <param name="currencyId">currencyId.</param>
        /// <param name="isActive">Defines if the location is active and can be used (required) (default to false).</param>
        /// <param name="modifiedOn">The date the record was updated (default to &quot;1900-01-01T00:00Z&quot;).</param>
        /// <param name="modifiedBy">modifiedBy.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="createdOn">The date the record was created (default to &quot;1900-01-01T00:00Z&quot;).</param>
        public Location(string id = default(string), string externalId = default(string), string name = default(string), AbstractText countryId = default(AbstractText), AbstractText timezoneId = default(AbstractText), AbstractText currencyId = default(AbstractText), bool isActive = false, DateTime modifiedOn = default(DateTime), AbstractLong modifiedBy = default(AbstractLong), AbstractLong createdBy = default(AbstractLong), DateTime createdOn = default(DateTime))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for Location and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for Location and cannot be null");
            }
            this.Name = name;
            this.IsActive = isActive;
            this.ExternalId = externalId;
            this.CountryId = countryId;
            this.TimezoneId = timezoneId;
            this.CurrencyId = currencyId;
            this.ModifiedOn = modifiedOn;
            this.ModifiedBy = modifiedBy;
            this.CreatedBy = createdBy;
            this.CreatedOn = createdOn;
        }

        /// <summary>
        /// The guid to identify the location
        /// </summary>
        /// <value>The guid to identify the location</value>
        [DataMember(Name = "Id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The external identifier of the location
        /// </summary>
        /// <value>The external identifier of the location</value>
        [DataMember(Name = "ExternalId", EmitDefaultValue = false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The name of the location
        /// </summary>
        /// <value>The name of the location</value>
        [DataMember(Name = "Name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets CountryId
        /// </summary>
        [DataMember(Name = "CountryId", EmitDefaultValue = false)]
        public AbstractText CountryId { get; set; }

        /// <summary>
        /// Gets or Sets TimezoneId
        /// </summary>
        [DataMember(Name = "TimezoneId", EmitDefaultValue = false)]
        public AbstractText TimezoneId { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyId
        /// </summary>
        [DataMember(Name = "CurrencyId", EmitDefaultValue = false)]
        public AbstractText CurrencyId { get; set; }

        /// <summary>
        /// Defines if the location is active and can be used
        /// </summary>
        /// <value>Defines if the location is active and can be used</value>
        /// <example>false</example>
        [DataMember(Name = "Is_Active", IsRequired = true, EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// The date the record was updated
        /// </summary>
        /// <value>The date the record was updated</value>
        /// <example>1900-01-01T00:00Z</example>
        [DataMember(Name = "ModifiedOn", EmitDefaultValue = false)]
        public DateTime ModifiedOn { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedBy
        /// </summary>
        [DataMember(Name = "ModifiedBy", EmitDefaultValue = false)]
        public AbstractLong ModifiedBy { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "CreatedBy", EmitDefaultValue = false)]
        public AbstractLong CreatedBy { get; set; }

        /// <summary>
        /// The date the record was created
        /// </summary>
        /// <value>The date the record was created</value>
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
            sb.Append("class Location {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CountryId: ").Append(CountryId).Append("\n");
            sb.Append("  TimezoneId: ").Append(TimezoneId).Append("\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  ModifiedOn: ").Append(ModifiedOn).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
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
