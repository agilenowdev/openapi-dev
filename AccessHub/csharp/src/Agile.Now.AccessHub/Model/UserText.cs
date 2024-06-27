/*
 * Accounts API documentation
 *
 * Agile.Now.AccessHub is a secure REST API designed to manage accounts, access groups, user groups, organizations, locations, applications, roles, and webhooks. This API provides a robust and scalable solution for managing user access and organizational structures in a multi-tenant environment.    **Key Features:**    1. **Accounts Management:**     - Manage user accounts with secure authentication and authorization.    2. **Access Groups:**     - Define and manage access groups for access control.     - Assign users to access groups based on roles and permissions.    3. **User Groups:**     - Create and manage user groups for better organization and collaboration.    4. **Organizations & Locations:**     - Manage multiple organizations and locations within a single platform.     - Attribute-based access control (ABAC) for settings.    5. **Applications:**     - Centralized management of applications within the platform.     - Assign and monitor application usage and access.    6. **Roles:**     - Define and manage roles for different access levels.     - Role-based access control to ensure appropriate permissions.    7. **Webhooks:**     - Integration with external services and applications.     - Configure and manage webhooks for real-time notifications and data syncing.    **Benefits:**    - **Enhanced Security:** Attribute-based and role-based access controls ensure data protection and authorized access.  - **Scalability:** Designed for growing organizations.  - **Efficiency:** Streamlined management of accounts, groups, and roles reduces overhead.  - **Flexibility:** Multi-tenant architecture allows easy customization.  - **Integration:** Webhook support facilitates seamless integration with external systems.    **Conclusion:**    Agile.Now.AccessHub is a powerful platform for managing your business data. It offers a centralized, secure, and scalable solution, enhancing operational efficiency, security, and flexibility in managing multi-tenant environments.
 *
 * The version of the OpenAPI document: 3.0.12
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
    /// The record of User information.
    /// </summary>
    [DataContract(Name = "UserText")]
    public partial class UserText : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserText" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserText() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserText" /> class.
        /// </summary>
        /// <param name="id">The identifier of user department (required).</param>
        /// <param name="userId">The identifier of the user who has link the department.</param>
        /// <param name="modifiedOn">The date the record was updated (default to &quot;1900-01-01T00:00Z&quot;).</param>
        /// <param name="modifiedBy">The Identifier of the user who updated the record.</param>
        /// <param name="createdBy">The Identifier of the user who created the record.</param>
        /// <param name="createdOn">The date the record was created (default to &quot;1900-01-01T00:00Z&quot;).</param>
        public UserText(string id = default(string), string userId = default(string), DateTime modifiedOn = default(DateTime), string modifiedBy = default(string), string createdBy = default(string), DateTime createdOn = default(DateTime))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for UserText and cannot be null");
            }
            this.Id = id;
            this.UserId = userId;
            this.ModifiedOn = modifiedOn;
            this.ModifiedBy = modifiedBy;
            this.CreatedBy = createdBy;
            this.CreatedOn = createdOn;
        }

        /// <summary>
        /// The identifier of user department
        /// </summary>
        /// <value>The identifier of user department</value>
        [DataMember(Name = "Id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The identifier of the user who has link the department
        /// </summary>
        /// <value>The identifier of the user who has link the department</value>
        [DataMember(Name = "UserId", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// The date the record was updated
        /// </summary>
        /// <value>The date the record was updated</value>
        /// <example>1900-01-01T00:00Z</example>
        [DataMember(Name = "ModifiedOn", EmitDefaultValue = false)]
        public DateTime ModifiedOn { get; set; }

        /// <summary>
        /// The Identifier of the user who updated the record
        /// </summary>
        /// <value>The Identifier of the user who updated the record</value>
        [DataMember(Name = "ModifiedBy", EmitDefaultValue = false)]
        public string ModifiedBy { get; set; }

        /// <summary>
        /// The Identifier of the user who created the record
        /// </summary>
        /// <value>The Identifier of the user who created the record</value>
        [DataMember(Name = "CreatedBy", EmitDefaultValue = false)]
        public string CreatedBy { get; set; }

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
            sb.Append("class UserText {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
