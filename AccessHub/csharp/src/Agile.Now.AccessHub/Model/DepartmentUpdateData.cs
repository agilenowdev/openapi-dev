/*
 * Accounts API documentation
 *
 * Agile.Now.AccessHub is a secure REST API designed to manage accounts, access groups, user groups, organizations, locations, applications, roles, and webhooks. This API provides a robust and scalable solution for managing user access and organizational structures in a multi-tenant environment.    **Key Features:**    1. **Accounts Management:**     - Manage user accounts with secure authentication and authorization.    2. **Access Groups:**     - Define and manage access groups for access control.     - Assign users to access groups based on roles and permissions.    3. **User Groups:**     - Create and manage user groups for better organization and collaboration.    4. **Organizations & Locations:**     - Manage multiple organizations and locations within a single platform.     - Attribute-based access control (ABAC) for settings.    5. **Applications:**     - Centralized management of applications within the platform.     - Assign and monitor application usage and access.    6. **Roles:**     - Define and manage roles for different access levels.     - Role-based access control to ensure appropriate permissions.    7. **Webhooks:**     - Integration with external services and applications.     - Configure and manage webhooks for real-time notifications and data syncing.    **Benefits:**    - **Enhanced Security:** Attribute-based and role-based access controls ensure data protection and authorized access.  - **Scalability:** Designed for growing organizations.  - **Efficiency:** Streamlined management of accounts, groups, and roles reduces overhead.  - **Flexibility:** Multi-tenant architecture allows easy customization.  - **Integration:** Webhook support facilitates seamless integration with external systems.    **Conclusion:**    Agile.Now.AccessHub is a powerful platform for managing your business data. It offers a centralized, secure, and scalable solution, enhancing operational efficiency, security, and flexibility in managing multi-tenant environments.
 *
 * The version of the OpenAPI document: 3.0.22
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
    /// The record of Department information.
    /// </summary>
    [DataContract(Name = "DepartmentUpdateData")]
    public partial class DepartmentUpdateData : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DepartmentUpdateData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DepartmentUpdateData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DepartmentUpdateData" /> class.
        /// </summary>
        /// <param name="externalId">The external identifier of the department.</param>
        /// <param name="name">The name of the department (required).</param>
        /// <param name="contactName">The contact name of company or department.</param>
        /// <param name="contactEmail">The contact email of external company or department.</param>
        /// <param name="contactPhone">contactPhone.</param>
        /// <param name="ownerId">ownerId.</param>
        /// <param name="countryId">countryId.</param>
        /// <param name="isActive">Defines if the department is active and can be used (required) (default to false).</param>
        public DepartmentUpdateData(string externalId = default(string), string name = default(string), string contactName = default(string), string contactEmail = default(string), string contactPhone = default(string), FieldType ownerId = default(FieldType), FieldType countryId = default(FieldType), bool isActive = false)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for DepartmentUpdateData and cannot be null");
            }
            this.Name = name;
            this.IsActive = isActive;
            this.ExternalId = externalId;
            this.ContactName = contactName;
            this.ContactEmail = contactEmail;
            this.ContactPhone = contactPhone;
            this.OwnerId = ownerId;
            this.CountryId = countryId;
        }

        /// <summary>
        /// The external identifier of the department
        /// </summary>
        /// <value>The external identifier of the department</value>
        [DataMember(Name = "ExternalId", EmitDefaultValue = false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The name of the department
        /// </summary>
        /// <value>The name of the department</value>
        [DataMember(Name = "Name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The contact name of company or department
        /// </summary>
        /// <value>The contact name of company or department</value>
        [DataMember(Name = "ContactName", EmitDefaultValue = false)]
        public string ContactName { get; set; }

        /// <summary>
        /// The contact email of external company or department
        /// </summary>
        /// <value>The contact email of external company or department</value>
        [DataMember(Name = "ContactEmail", EmitDefaultValue = false)]
        public string ContactEmail { get; set; }

        /// <summary>
        /// Gets or Sets ContactPhone
        /// </summary>
        [DataMember(Name = "ContactPhone", EmitDefaultValue = false)]
        public string ContactPhone { get; set; }

        /// <summary>
        /// Gets or Sets OwnerId
        /// </summary>
        [DataMember(Name = "OwnerId", EmitDefaultValue = false)]
        public FieldType OwnerId { get; set; }

        /// <summary>
        /// Gets or Sets CountryId
        /// </summary>
        [DataMember(Name = "CountryId", EmitDefaultValue = false)]
        public FieldType CountryId { get; set; }

        /// <summary>
        /// Defines if the department is active and can be used
        /// </summary>
        /// <value>Defines if the department is active and can be used</value>
        /// <example>false</example>
        [DataMember(Name = "Is_Active", IsRequired = true, EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DepartmentUpdateData {\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ContactName: ").Append(ContactName).Append("\n");
            sb.Append("  ContactEmail: ").Append(ContactEmail).Append("\n");
            sb.Append("  ContactPhone: ").Append(ContactPhone).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  CountryId: ").Append(CountryId).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
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
