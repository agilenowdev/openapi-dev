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
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Agile.Now.AccessHub.Client.OpenAPIDateConverter;

namespace Agile.Now.AccessHub.Model
{
    /// <summary>
    /// The record of Config information.
    /// </summary>
    [DataContract(Name = "Config")]
    public partial class Config : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Config" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Config() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Config" /> class.
        /// </summary>
        /// <param name="id">The identifier of the config (required).</param>
        /// <param name="webhookEntityId">webhookEntityId (required).</param>
        /// <param name="hasCreateAccess">Service has create access to data (default to false).</param>
        /// <param name="hasUpdateAccess">Service has update access to data (default to false).</param>
        /// <param name="hasDeleteAccess">Service has delete access to data (default to false).</param>
        /// <param name="isActive">If true, the configuration is active (default to false).</param>
        /// <param name="modifiedBy">modifiedBy.</param>
        /// <param name="modifiedOn">The date the record was updated. (default to &quot;1900-01-01T00:00Z&quot;).</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="createdOn">The date the record was created. (default to &quot;1900-01-01T00:00Z&quot;).</param>
        public Config(string id = default, AbstractText webhookEntityId = default, bool hasCreateAccess = false, bool hasUpdateAccess = false, bool hasDeleteAccess = false, bool isActive = false, AbstractLong modifiedBy = default, DateTime modifiedOn = default, AbstractLong createdBy = default, DateTime createdOn = default)
        {
            // to ensure "id" is required (not null)
            id = id ?? throw new ArgumentNullException("id is a required property for Config and cannot be null");
            Id = id;
            // to ensure "webhookEntityId" is required (not null)
            webhookEntityId = webhookEntityId ?? throw new ArgumentNullException("webhookEntityId is a required property for Config and cannot be null");
            WebhookEntityId = webhookEntityId;
            HasCreateAccess = hasCreateAccess;
            HasUpdateAccess = hasUpdateAccess;
            HasDeleteAccess = hasDeleteAccess;
            IsActive = isActive;
            ModifiedBy = modifiedBy;
            ModifiedOn = modifiedOn;
            CreatedBy = createdBy;
            CreatedOn = createdOn;
        }

        /// <summary>
        /// The identifier of the config
        /// </summary>
        /// <value>The identifier of the config</value>
        [DataMember(Name = "Id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets WebhookEntityId
        /// </summary>
        [DataMember(Name = "WebhookEntityId", IsRequired = true, EmitDefaultValue = true)]
        public AbstractText WebhookEntityId { get; set; }

        /// <summary>
        /// Service has create access to data
        /// </summary>
        /// <value>Service has create access to data</value>
        /// <example>false</example>
        [DataMember(Name = "HasCreateAccess", EmitDefaultValue = true)]
        public bool HasCreateAccess { get; set; }

        /// <summary>
        /// Service has update access to data
        /// </summary>
        /// <value>Service has update access to data</value>
        /// <example>false</example>
        [DataMember(Name = "HasUpdateAccess", EmitDefaultValue = true)]
        public bool HasUpdateAccess { get; set; }

        /// <summary>
        /// Service has delete access to data
        /// </summary>
        /// <value>Service has delete access to data</value>
        /// <example>false</example>
        [DataMember(Name = "HasDeleteAccess", EmitDefaultValue = true)]
        public bool HasDeleteAccess { get; set; }

        /// <summary>
        /// If true, the configuration is active
        /// </summary>
        /// <value>If true, the configuration is active</value>
        /// <example>false</example>
        [DataMember(Name = "Is_Active", EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedBy
        /// </summary>
        [DataMember(Name = "ModifiedBy", EmitDefaultValue = false)]
        public AbstractLong ModifiedBy { get; set; }

        /// <summary>
        /// The date the record was updated.
        /// </summary>
        /// <value>The date the record was updated.</value>
        /// <example>1900-01-01T00:00Z</example>
        [DataMember(Name = "ModifiedOn", EmitDefaultValue = false)]
        public DateTime ModifiedOn { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "CreatedBy", EmitDefaultValue = false)]
        public AbstractLong CreatedBy { get; set; }

        /// <summary>
        /// The date the record was created.
        /// </summary>
        /// <value>The date the record was created.</value>
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
            sb.Append("class Config {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  WebhookEntityId: ").Append(WebhookEntityId).Append("\n");
            sb.Append("  HasCreateAccess: ").Append(HasCreateAccess).Append("\n");
            sb.Append("  HasUpdateAccess: ").Append(HasUpdateAccess).Append("\n");
            sb.Append("  HasDeleteAccess: ").Append(HasDeleteAccess).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  ModifiedOn: ").Append(ModifiedOn).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
