/*
 * Accounts API documentation
 *
 * Agile.Now.AccessHub is a secure REST API designed to manage accounts, access groups, user groups, organizations, locations, applications, roles, and webhooks. This API provides a robust and scalable solution for managing user access and organizational structures in a multi-tenant environment.    **Key Features:**    1. **Accounts Management:**     - Manage user accounts with secure authentication and authorization.    2. **Access Groups:**     - Define and manage access groups for access control.     - Assign users to access groups based on roles and permissions.    3. **User Groups:**     - Create and manage user groups for better organization and collaboration.    4. **Organizations & Locations:**     - Manage multiple organizations and locations within a single platform.     - Attribute-based access control (ABAC) for settings.    5. **Applications:**     - Centralized management of applications within the platform.     - Assign and monitor application usage and access.    6. **Roles:**     - Define and manage roles for different access levels.     - Role-based access control to ensure appropriate permissions.    7. **Webhooks:**     - Integration with external services and applications.     - Configure and manage webhooks for real-time notifications and data syncing.    **Benefits:**    - **Enhanced Security:** Attribute-based and role-based access controls ensure data protection and authorized access.  - **Scalability:** Designed for growing organizations.  - **Efficiency:** Streamlined management of accounts, groups, and roles reduces overhead.  - **Flexibility:** Multi-tenant architecture allows easy customization.  - **Integration:** Webhook support facilitates seamless integration with external systems.    **Conclusion:**    Agile.Now.AccessHub is a powerful platform for managing your business data. It offers a centralized, secure, and scalable solution, enhancing operational efficiency, security, and flexibility in managing multi-tenant environments.
 *
 * The version of the OpenAPI document: 3.0.20
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
    /// The data loading record of Department importing
    /// </summary>
    [DataContract(Name = "DepartmentsData")]
    public partial class DepartmentsData : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DepartmentsData" /> class.
        /// </summary>
        /// <param name="extra">List validation for entity attribute.</param>
        /// <param name="isFullValidation">If the value is true, the data quality of all fields are checked. This has an effect on performance. (default to false).</param>
        /// <param name="departments">The list of &#x60;Department&#x60; data record for import.</param>
        public DepartmentsData(List<ListValidation> extra = default(List<ListValidation>), bool isFullValidation = false, List<DepartmentText> departments = default(List<DepartmentText>))
        {
            this.Extra = extra;
            this.IsFullValidation = isFullValidation;
            this.Departments = departments;
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
        /// The list of &#x60;Department&#x60; data record for import
        /// </summary>
        /// <value>The list of &#x60;Department&#x60; data record for import</value>
        [DataMember(Name = "Departments", EmitDefaultValue = false)]
        public List<DepartmentText> Departments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DepartmentsData {\n");
            sb.Append("  Extra: ").Append(Extra).Append("\n");
            sb.Append("  IsFullValidation: ").Append(IsFullValidation).Append("\n");
            sb.Append("  Departments: ").Append(Departments).Append("\n");
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
