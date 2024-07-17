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
    /// The data loading record of User importing
    /// </summary>
    [DataContract(Name = "UsersData")]
    public partial class UsersData : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersData" /> class.
        /// </summary>
        /// <param name="extra">List validation for entity attribute.</param>
        /// <param name="isFullValidation">If the value is true, the data quality of all fields are checked. This has an effect on performance. (default to false).</param>
        /// <param name="users">The list of &#x60;User&#x60; data record for import.</param>
        public UsersData(List<ListValidation> extra = default, bool isFullValidation = false, List<UserText> users = default)
        {
            Extra = extra;
            IsFullValidation = isFullValidation;
            Users = users;
        }

        /// <summary>
        /// List validation for entity attribute
        /// </summary>
        /// <value>List validation for entity attribute</value>
        [DataMember(Name = "Extra", EmitDefaultValue = false)]
        public List<ListValidation> Extra { get; set; }

        /// <summary>
        /// If the value is true, the data quality of all fields are checked. This has an effect on performance.
        /// </summary>
        /// <value>If the value is true, the data quality of all fields are checked. This has an effect on performance.</value>
        /// <example>false</example>
        [DataMember(Name = "IsFullValidation", EmitDefaultValue = true)]
        public bool IsFullValidation { get; set; }

        /// <summary>
        /// The list of &#x60;User&#x60; data record for import
        /// </summary>
        /// <value>The list of &#x60;User&#x60; data record for import</value>
        [DataMember(Name = "Users", EmitDefaultValue = false)]
        public List<UserText> Users { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UsersData {\n");
            sb.Append("  Extra: ").Append(Extra).Append("\n");
            sb.Append("  IsFullValidation: ").Append(IsFullValidation).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
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
