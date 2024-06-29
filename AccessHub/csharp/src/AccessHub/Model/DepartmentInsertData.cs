/*
 * AccessHub API documentation
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
using OpenAPIDateConverter = AccessHub.Client.OpenAPIDateConverter;

namespace AccessHub.Model
{
    /// <summary>
    /// The record of Department information.
    /// </summary>
    [DataContract(Name = "DepartmentInsertData")]
    public partial class DepartmentInsertData : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DepartmentInsertData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DepartmentInsertData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DepartmentInsertData" /> class.
        /// </summary>
        /// <param name="id">The guid to identify the department (required).</param>
        /// <param name="externalId">The external identifier of the department.</param>
        /// <param name="name">The name of the department (required).</param>
        /// <param name="departmentTypeId">departmentTypeId (required).</param>
        /// <param name="parentDepartmentId">parentDepartmentId.</param>
        /// <param name="contactName">The contact name of company or department.</param>
        /// <param name="contactEmail">The contact email of external company or department.</param>
        /// <param name="contactPhone">contactPhone.</param>
        /// <param name="ownerId">ownerId.</param>
        /// <param name="countryId">countryId.</param>
        public DepartmentInsertData(string id = default(string), string externalId = default(string), string name = default(string), FieldType departmentTypeId = default(FieldType), FieldType parentDepartmentId = default(FieldType), string contactName = default(string), string contactEmail = default(string), string contactPhone = default(string), FieldType ownerId = default(FieldType), FieldType countryId = default(FieldType))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for DepartmentInsertData and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for DepartmentInsertData and cannot be null");
            }
            this.Name = name;
            // to ensure "departmentTypeId" is required (not null)
            if (departmentTypeId == null)
            {
                throw new ArgumentNullException("departmentTypeId is a required property for DepartmentInsertData and cannot be null");
            }
            this.DepartmentTypeId = departmentTypeId;
            this.ExternalId = externalId;
            this.ParentDepartmentId = parentDepartmentId;
            this.ContactName = contactName;
            this.ContactEmail = contactEmail;
            this.ContactPhone = contactPhone;
            this.OwnerId = ownerId;
            this.CountryId = countryId;
        }

        /// <summary>
        /// The guid to identify the department
        /// </summary>
        /// <value>The guid to identify the department</value>
        [DataMember(Name = "Id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

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
        /// Gets or Sets DepartmentTypeId
        /// </summary>
        [DataMember(Name = "DepartmentTypeId", IsRequired = true, EmitDefaultValue = true)]
        public FieldType DepartmentTypeId { get; set; }

        /// <summary>
        /// Gets or Sets ParentDepartmentId
        /// </summary>
        [DataMember(Name = "ParentDepartmentId", EmitDefaultValue = false)]
        public FieldType ParentDepartmentId { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DepartmentInsertData {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DepartmentTypeId: ").Append(DepartmentTypeId).Append("\n");
            sb.Append("  ParentDepartmentId: ").Append(ParentDepartmentId).Append("\n");
            sb.Append("  ContactName: ").Append(ContactName).Append("\n");
            sb.Append("  ContactEmail: ").Append(ContactEmail).Append("\n");
            sb.Append("  ContactPhone: ").Append(ContactPhone).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  CountryId: ").Append(CountryId).Append("\n");
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
