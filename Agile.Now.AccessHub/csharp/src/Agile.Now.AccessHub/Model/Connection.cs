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
    /// The record of Connection information.
    /// </summary>
    [DataContract(Name = "Connection")]
    public partial class Connection : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Connection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Connection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Connection" /> class.
        /// </summary>
        /// <param name="id">The identifier of the module that owns the entity that is being processed (required).</param>
        /// <param name="name">Name of connection (required).</param>
        /// <param name="description">Description of connection.</param>
        /// <param name="apiKey">An API key is a unique identifier used to authenticate a user, developer, or calling program to an API.</param>
        /// <param name="secretKey">A secret key for signing payloads, enhancing security..</param>
        /// <param name="uRL">Webhook external service URL-address (required).</param>
        /// <param name="isActive">If true, the configuration is active (default to false).</param>
        /// <param name="isSystem">If true, the configuration is internal to the system and not visible in the user interface (default to false).</param>
        /// <param name="modifiedBy">modifiedBy.</param>
        /// <param name="modifiedOn">The date the record was updated. (default to &quot;1900-01-01T00:00Z&quot;).</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="createdOn">The date the record was created. (default to &quot;1900-01-01T00:00Z&quot;).</param>
        public Connection(string id = default(string), string name = default(string), string description = default(string), string apiKey = default(string), string secretKey = default(string), string uRL = default(string), bool isActive = false, bool isSystem = false, AbstractLong modifiedBy = default(AbstractLong), DateTime modifiedOn = default(DateTime), AbstractLong createdBy = default(AbstractLong), DateTime createdOn = default(DateTime))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for Connection and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for Connection and cannot be null");
            }
            this.Name = name;
            // to ensure "uRL" is required (not null)
            if (uRL == null)
            {
                throw new ArgumentNullException("uRL is a required property for Connection and cannot be null");
            }
            this.URL = uRL;
            this.Description = description;
            this.ApiKey = apiKey;
            this.SecretKey = secretKey;
            this.IsActive = isActive;
            this.IsSystem = isSystem;
            this.ModifiedBy = modifiedBy;
            this.ModifiedOn = modifiedOn;
            this.CreatedBy = createdBy;
            this.CreatedOn = createdOn;
        }

        /// <summary>
        /// The identifier of the module that owns the entity that is being processed
        /// </summary>
        /// <value>The identifier of the module that owns the entity that is being processed</value>
        [DataMember(Name = "Id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Name of connection
        /// </summary>
        /// <value>Name of connection</value>
        [DataMember(Name = "Name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Description of connection
        /// </summary>
        /// <value>Description of connection</value>
        [DataMember(Name = "Description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// An API key is a unique identifier used to authenticate a user, developer, or calling program to an API
        /// </summary>
        /// <value>An API key is a unique identifier used to authenticate a user, developer, or calling program to an API</value>
        [DataMember(Name = "ApiKey", EmitDefaultValue = false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// A secret key for signing payloads, enhancing security.
        /// </summary>
        /// <value>A secret key for signing payloads, enhancing security.</value>
        [DataMember(Name = "SecretKey", EmitDefaultValue = false)]
        public string SecretKey { get; set; }

        /// <summary>
        /// Webhook external service URL-address
        /// </summary>
        /// <value>Webhook external service URL-address</value>
        [DataMember(Name = "URL", IsRequired = true, EmitDefaultValue = true)]
        public string URL { get; set; }

        /// <summary>
        /// If true, the configuration is active
        /// </summary>
        /// <value>If true, the configuration is active</value>
        /// <example>false</example>
        [DataMember(Name = "Is_Active", EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// If true, the configuration is internal to the system and not visible in the user interface
        /// </summary>
        /// <value>If true, the configuration is internal to the system and not visible in the user interface</value>
        /// <example>false</example>
        [DataMember(Name = "Is_System", EmitDefaultValue = true)]
        public bool IsSystem { get; set; }

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
            sb.Append("class Connection {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
            sb.Append("  SecretKey: ").Append(SecretKey).Append("\n");
            sb.Append("  URL: ").Append(URL).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsSystem: ").Append(IsSystem).Append("\n");
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
