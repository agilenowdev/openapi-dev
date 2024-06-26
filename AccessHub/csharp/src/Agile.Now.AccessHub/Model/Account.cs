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
    /// The record of Account information.
    /// </summary>
    [DataContract(Name = "Account")]
    public partial class Account : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Account() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        /// <param name="id">The identifier of account (required).</param>
        /// <param name="tenantId">tenantId (required).</param>
        /// <param name="name">The name of the account (required).</param>
        /// <param name="firstName">Person&#39;s first name (required).</param>
        /// <param name="lastName">Person&#39;s last name (required).</param>
        /// <param name="phone">The phone number of account. The phone number is unique in the system.</param>
        /// <param name="email">The e-mail of account. The email is unique in the system (required).</param>
        /// <param name="languageId">languageId.</param>
        /// <param name="timezoneId">timezoneId.</param>
        /// <param name="dateFormatId">dateFormatId.</param>
        /// <param name="username">Username used to log in into the system. The username is unique in the system (required).</param>
        /// <param name="externalId">External Authentication identifier. Example Azure AD guid.</param>
        /// <param name="notifyByEmail">Defines if a person should get notifications via e-mail (default to false).</param>
        /// <param name="notifyBySMS">Defines if a contact should get notifications via SMS (default to false).</param>
        /// <param name="isActive">Defines if the account is active and can be used (default to false).</param>
        /// <param name="modifiedOn">The date the record was updated (default to &quot;1900-01-01T00:00Z&quot;).</param>
        /// <param name="createdOn">The date the record was created (default to &quot;1900-01-01T00:00Z&quot;).</param>
        public Account(string id = default(string), AbstractLong tenantId = default(AbstractLong), string name = default(string), string firstName = default(string), string lastName = default(string), string phone = default(string), string email = default(string), AbstractText languageId = default(AbstractText), AbstractText timezoneId = default(AbstractText), AbstractText dateFormatId = default(AbstractText), string username = default(string), string externalId = default(string), bool notifyByEmail = false, bool notifyBySMS = false, bool isActive = false, DateTime modifiedOn = default(DateTime), DateTime createdOn = default(DateTime))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for Account and cannot be null");
            }
            this.Id = id;
            // to ensure "tenantId" is required (not null)
            if (tenantId == null)
            {
                throw new ArgumentNullException("tenantId is a required property for Account and cannot be null");
            }
            this.TenantId = tenantId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for Account and cannot be null");
            }
            this.Name = name;
            // to ensure "firstName" is required (not null)
            if (firstName == null)
            {
                throw new ArgumentNullException("firstName is a required property for Account and cannot be null");
            }
            this.FirstName = firstName;
            // to ensure "lastName" is required (not null)
            if (lastName == null)
            {
                throw new ArgumentNullException("lastName is a required property for Account and cannot be null");
            }
            this.LastName = lastName;
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new ArgumentNullException("email is a required property for Account and cannot be null");
            }
            this.Email = email;
            // to ensure "username" is required (not null)
            if (username == null)
            {
                throw new ArgumentNullException("username is a required property for Account and cannot be null");
            }
            this.Username = username;
            this.Phone = phone;
            this.LanguageId = languageId;
            this.TimezoneId = timezoneId;
            this.DateFormatId = dateFormatId;
            this.ExternalId = externalId;
            this.NotifyByEmail = notifyByEmail;
            this.NotifyBySMS = notifyBySMS;
            this.IsActive = isActive;
            this.ModifiedOn = modifiedOn;
            this.CreatedOn = createdOn;
        }

        /// <summary>
        /// The identifier of account
        /// </summary>
        /// <value>The identifier of account</value>
        [DataMember(Name = "Id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "TenantId", IsRequired = true, EmitDefaultValue = true)]
        public AbstractLong TenantId { get; set; }

        /// <summary>
        /// The name of the account
        /// </summary>
        /// <value>The name of the account</value>
        [DataMember(Name = "Name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Person&#39;s first name
        /// </summary>
        /// <value>Person&#39;s first name</value>
        [DataMember(Name = "FirstName", IsRequired = true, EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// Person&#39;s last name
        /// </summary>
        /// <value>Person&#39;s last name</value>
        [DataMember(Name = "LastName", IsRequired = true, EmitDefaultValue = true)]
        public string LastName { get; set; }

        /// <summary>
        /// The phone number of account. The phone number is unique in the system
        /// </summary>
        /// <value>The phone number of account. The phone number is unique in the system</value>
        [DataMember(Name = "Phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// The e-mail of account. The email is unique in the system
        /// </summary>
        /// <value>The e-mail of account. The email is unique in the system</value>
        [DataMember(Name = "Email", IsRequired = true, EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets LanguageId
        /// </summary>
        [DataMember(Name = "LanguageId", EmitDefaultValue = false)]
        public AbstractText LanguageId { get; set; }

        /// <summary>
        /// Gets or Sets TimezoneId
        /// </summary>
        [DataMember(Name = "TimezoneId", EmitDefaultValue = false)]
        public AbstractText TimezoneId { get; set; }

        /// <summary>
        /// Gets or Sets DateFormatId
        /// </summary>
        [DataMember(Name = "DateFormatId", EmitDefaultValue = false)]
        public AbstractText DateFormatId { get; set; }

        /// <summary>
        /// Username used to log in into the system. The username is unique in the system
        /// </summary>
        /// <value>Username used to log in into the system. The username is unique in the system</value>
        [DataMember(Name = "Username", IsRequired = true, EmitDefaultValue = true)]
        public string Username { get; set; }

        /// <summary>
        /// External Authentication identifier. Example Azure AD guid
        /// </summary>
        /// <value>External Authentication identifier. Example Azure AD guid</value>
        [DataMember(Name = "ExternalId", EmitDefaultValue = false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Defines if a person should get notifications via e-mail
        /// </summary>
        /// <value>Defines if a person should get notifications via e-mail</value>
        /// <example>false</example>
        [DataMember(Name = "NotifyByEmail", EmitDefaultValue = true)]
        public bool NotifyByEmail { get; set; }

        /// <summary>
        /// Defines if a contact should get notifications via SMS
        /// </summary>
        /// <value>Defines if a contact should get notifications via SMS</value>
        /// <example>false</example>
        [DataMember(Name = "NotifyBySMS", EmitDefaultValue = true)]
        public bool NotifyBySMS { get; set; }

        /// <summary>
        /// Defines if the account is active and can be used
        /// </summary>
        /// <value>Defines if the account is active and can be used</value>
        /// <example>false</example>
        [DataMember(Name = "Is_Active", EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// The date the record was updated
        /// </summary>
        /// <value>The date the record was updated</value>
        /// <example>1900-01-01T00:00Z</example>
        [DataMember(Name = "ModifiedOn", EmitDefaultValue = false)]
        public DateTime ModifiedOn { get; set; }

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
            sb.Append("class Account {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  LanguageId: ").Append(LanguageId).Append("\n");
            sb.Append("  TimezoneId: ").Append(TimezoneId).Append("\n");
            sb.Append("  DateFormatId: ").Append(DateFormatId).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  NotifyByEmail: ").Append(NotifyByEmail).Append("\n");
            sb.Append("  NotifyBySMS: ").Append(NotifyBySMS).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  ModifiedOn: ").Append(ModifiedOn).Append("\n");
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
