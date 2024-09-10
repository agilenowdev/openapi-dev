/*
 * Agile.Now.AccessHub API
 *
 * Agile.Now.AccessHub is a secure REST API designed to manage accounts, access groups, user groups, organizations, locations, applications, roles, and webhooks. This API provides a robust and scalable solution for managing user access and organizational structures in a multi-tenant environment.
 *
 * The version of the OpenAPI document: 2.0.1
 * Contact: dev@agilenow.io
 *
 * BSD 3-Clause License
 * 
 * Copyright (c) 2024, eSystems Nordic Ltd.
 * All rights reserved.
 * 
 * Redistribution and use in source and binary forms, with or without modification,
 * are permitted provided that the following conditions are met:
 * 
 * 1. Redistributions of source code must retain the above copyright notice, this list
 *    of conditions and the following disclaimer.
 * 2. Redistributions in binary form must reproduce the above copyright notice, this
 *    list of conditions and the following disclaimer in the documentation and/or other
 *    materials provided with the distribution.
 * 3. Neither the name of the copyright holder nor the names of its contributors may be
 *    used to endorse or promote products derived from this software without specific
 *    prior written permission.
 * 
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY
 * EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES
 * OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT
 * SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT,
 * INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED
 * TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR
 * BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
 * CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN
 * ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH
 * DAMAGE.
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
        public Connection(string id = default, string name = default, string description = default, string apiKey = default, string secretKey = default, string uRL = default, bool isActive = false, bool isSystem = false, AbstractLong1 modifiedBy = default, DateTime modifiedOn = default, AbstractLong1 createdBy = default, DateTime createdOn = default)
        {
            // to ensure "id" is required (not null)
            id = id ?? throw new ArgumentNullException("id is a required property for Connection and cannot be null");
            Id = id;
            // to ensure "name" is required (not null)
            name = name ?? throw new ArgumentNullException("name is a required property for Connection and cannot be null");
            Name = name;
            // to ensure "uRL" is required (not null)
            uRL = uRL ?? throw new ArgumentNullException("uRL is a required property for Connection and cannot be null");
            URL = uRL;
            Description = description;
            ApiKey = apiKey;
            SecretKey = secretKey;
            IsActive = isActive;
            IsSystem = isSystem;
            ModifiedBy = modifiedBy;
            ModifiedOn = modifiedOn;
            CreatedBy = createdBy;
            CreatedOn = createdOn;
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
        public AbstractLong1 ModifiedBy { get; set; }

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
        public AbstractLong1 CreatedBy { get; set; }

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
