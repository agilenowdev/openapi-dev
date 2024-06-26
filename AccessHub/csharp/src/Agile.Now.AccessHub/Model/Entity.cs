/*
 * Accounts API documentation
 *
 * Agile.Now.AccessHub is a secure REST API designed to manage accounts, access groups, user groups, organizations, locations, applications, roles, and webhooks. This API provides a robust and scalable solution for managing user access and organizational structures in a multi-tenant environment.    **Key Features:**    1. **Accounts Management:**     - Manage user accounts with secure authentication and authorization.    2. **Access Groups:**     - Define and manage access groups for access control.     - Assign users to access groups based on roles and permissions.    3. **User Groups:**     - Create and manage user groups for better organization and collaboration.    4. **Organizations & Locations:**     - Manage multiple organizations and locations within a single platform.     - Attribute-based access control (ABAC) for settings.    5. **Applications:**     - Centralized management of applications within the platform.     - Assign and monitor application usage and access.    6. **Roles:**     - Define and manage roles for different access levels.     - Role-based access control to ensure appropriate permissions.    7. **Webhooks:**     - Integration with external services and applications.     - Configure and manage webhooks for real-time notifications and data syncing.    **Benefits:**    - **Enhanced Security:** Attribute-based and role-based access controls ensure data protection and authorized access.  - **Scalability:** Designed for growing organizations.  - **Efficiency:** Streamlined management of accounts, groups, and roles reduces overhead.  - **Flexibility:** Multi-tenant architecture allows easy customization.  - **Integration:** Webhook support facilitates seamless integration with external systems.    **Conclusion:**    Agile.Now.AccessHub is a powerful platform for managing your business data. It offers a centralized, secure, and scalable solution, enhancing operational efficiency, security, and flexibility in managing multi-tenant environments.
 *
 * The version of the OpenAPI document: 3.0.5
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
    /// The record of Entity information.
    /// </summary>
    [DataContract(Name = "Entity")]
    public partial class Entity : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Entity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Entity() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Entity" /> class.
        /// </summary>
        /// <param name="id">The Guid identifier of web hook entity (required).</param>
        /// <param name="name">Name of entity (required).</param>
        /// <param name="application">Name of application (required).</param>
        /// <param name="internalConfigId">internalConfigId (required).</param>
        /// <param name="isActive">If true, the entity is active (default to false).</param>
        /// <param name="createdOn">The date the record was created. (default to &quot;1900-01-01T00:00Z&quot;).</param>
        public Entity(string id = default(string), string name = default(string), string application = default(string), AbstractText internalConfigId = default(AbstractText), bool isActive = false, DateTime createdOn = default(DateTime))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for Entity and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for Entity and cannot be null");
            }
            this.Name = name;
            // to ensure "application" is required (not null)
            if (application == null)
            {
                throw new ArgumentNullException("application is a required property for Entity and cannot be null");
            }
            this.Application = application;
            // to ensure "internalConfigId" is required (not null)
            if (internalConfigId == null)
            {
                throw new ArgumentNullException("internalConfigId is a required property for Entity and cannot be null");
            }
            this.InternalConfigId = internalConfigId;
            this.IsActive = isActive;
            this.CreatedOn = createdOn;
        }

        /// <summary>
        /// The Guid identifier of web hook entity
        /// </summary>
        /// <value>The Guid identifier of web hook entity</value>
        [DataMember(Name = "Id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Name of entity
        /// </summary>
        /// <value>Name of entity</value>
        [DataMember(Name = "Name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Name of application
        /// </summary>
        /// <value>Name of application</value>
        [DataMember(Name = "Application", IsRequired = true, EmitDefaultValue = true)]
        public string Application { get; set; }

        /// <summary>
        /// Gets or Sets InternalConfigId
        /// </summary>
        [DataMember(Name = "InternalConfigId", IsRequired = true, EmitDefaultValue = true)]
        public AbstractText InternalConfigId { get; set; }

        /// <summary>
        /// If true, the entity is active
        /// </summary>
        /// <value>If true, the entity is active</value>
        /// <example>false</example>
        [DataMember(Name = "Is_Active", EmitDefaultValue = true)]
        public bool IsActive { get; set; }

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
            sb.Append("class Entity {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  InternalConfigId: ").Append(InternalConfigId).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
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
