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
    /// The list of errors. Throw specific exceptions based on the received error.
    /// </summary>
    [DataContract(Name = "Error")]
    public partial class Error : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Error() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        /// <param name="varError">Human-readable explanation of the errors.</param>
        /// <param name="type">URI identifier that categorizes the error (default to &quot;&quot;).</param>
        /// <param name="title">Brief, human-readable message about the error (default to &quot;&quot;).</param>
        /// <param name="statusCode">The HTTP response code (required).</param>
        /// <param name="instance">URI that identifies the specific occurrence of the error (default to &quot;&quot;).</param>
        /// <param name="requestKey">Provides a request key that identifies the current request. (default to &quot;&quot;).</param>
        public Error(List<string> varError = default, string type = @"", string title = @"", int statusCode = default, string instance = @"", string requestKey = @"")
        {
            StatusCode = statusCode;
            VarError = varError;
            // use default value if no "type" provided
            Type = type ?? @"";
            // use default value if no "title" provided
            Title = title ?? @"";
            // use default value if no "instance" provided
            Instance = instance ?? @"";
            // use default value if no "requestKey" provided
            RequestKey = requestKey ?? @"";
        }

        /// <summary>
        /// Human-readable explanation of the errors
        /// </summary>
        /// <value>Human-readable explanation of the errors</value>
        [DataMember(Name = "Error", EmitDefaultValue = false)]
        public List<string> VarError { get; set; }

        /// <summary>
        /// URI identifier that categorizes the error
        /// </summary>
        /// <value>URI identifier that categorizes the error</value>
        [DataMember(Name = "Type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Brief, human-readable message about the error
        /// </summary>
        /// <value>Brief, human-readable message about the error</value>
        [DataMember(Name = "Title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// The HTTP response code
        /// </summary>
        /// <value>The HTTP response code</value>
        /// <example>400</example>
        [DataMember(Name = "StatusCode", IsRequired = true, EmitDefaultValue = true)]
        public int StatusCode { get; set; }

        /// <summary>
        /// URI that identifies the specific occurrence of the error
        /// </summary>
        /// <value>URI that identifies the specific occurrence of the error</value>
        [DataMember(Name = "Instance", EmitDefaultValue = false)]
        public string Instance { get; set; }

        /// <summary>
        /// Provides a request key that identifies the current request.
        /// </summary>
        /// <value>Provides a request key that identifies the current request.</value>
        [DataMember(Name = "RequestKey", EmitDefaultValue = false)]
        public string RequestKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Error {\n");
            sb.Append("  VarError: ").Append(VarError).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  Instance: ").Append(Instance).Append("\n");
            sb.Append("  RequestKey: ").Append(RequestKey).Append("\n");
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
