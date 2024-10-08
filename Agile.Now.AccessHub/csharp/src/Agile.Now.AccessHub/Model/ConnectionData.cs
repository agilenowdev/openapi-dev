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
    [DataContract(Name = "ConnectionData")]
    public partial class ConnectionData : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConnectionData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionData" /> class.
        /// </summary>
        /// <param name="id">The identifier of the module that owns the entity that is being processed..</param>
        /// <param name="name">Name of connection. The value must be unique in the system and you cannot add multiple values. (required).</param>
        /// <param name="description">Description of connection..</param>
        /// <param name="apiKey">An API key is a unique identifier used to authenticate a user, developer, or calling program to an API. The pattern of the value (Secure). The default of the value (Generate password)..</param>
        /// <param name="secretKey">A secret key for signing payloads, enhancing security. The pattern of the value (Secure). The default of the value (Generate password)..</param>
        /// <param name="uRL">Webhook external service URL-address. The value must be unique in the system and you cannot add multiple values. The pattern of the value (^(http(s)://.)[-a-zA-Z0-9@:%._\\+~#=]{2,256}\\.[a-z]{2,6}\\b([-a-zA-Z0-9@:%_\\+.~#?&//=]*)$). (required).</param>
        /// <param name="isActive">If true, the configuration is active. (default to false).</param>
        public ConnectionData(string id = default, string name = default, string description = default, string apiKey = default, string secretKey = default, string uRL = default, bool isActive = false)
        {
            // to ensure "name" is required (not null)
            name = name ?? throw new ArgumentNullException("name is a required property for ConnectionData and cannot be null");
            Name = name;
            // to ensure "uRL" is required (not null)
            uRL = uRL ?? throw new ArgumentNullException("uRL is a required property for ConnectionData and cannot be null");
            URL = uRL;
            Id = id;
            Description = description;
            ApiKey = apiKey;
            SecretKey = secretKey;
            IsActive = isActive;
        }

        /// <summary>
        /// The identifier of the module that owns the entity that is being processed.
        /// </summary>
        /// <value>The identifier of the module that owns the entity that is being processed.</value>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Name of connection. The value must be unique in the system and you cannot add multiple values.
        /// </summary>
        /// <value>Name of connection. The value must be unique in the system and you cannot add multiple values.</value>
        [DataMember(Name = "Name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Description of connection.
        /// </summary>
        /// <value>Description of connection.</value>
        [DataMember(Name = "Description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// An API key is a unique identifier used to authenticate a user, developer, or calling program to an API. The pattern of the value (Secure). The default of the value (Generate password).
        /// </summary>
        /// <value>An API key is a unique identifier used to authenticate a user, developer, or calling program to an API. The pattern of the value (Secure). The default of the value (Generate password).</value>
        [DataMember(Name = "ApiKey", EmitDefaultValue = false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// A secret key for signing payloads, enhancing security. The pattern of the value (Secure). The default of the value (Generate password).
        /// </summary>
        /// <value>A secret key for signing payloads, enhancing security. The pattern of the value (Secure). The default of the value (Generate password).</value>
        [DataMember(Name = "SecretKey", EmitDefaultValue = false)]
        public string SecretKey { get; set; }

        /// <summary>
        /// Webhook external service URL-address. The value must be unique in the system and you cannot add multiple values. The pattern of the value (^(http(s)://.)[-a-zA-Z0-9@:%._\\+~#=]{2,256}\\.[a-z]{2,6}\\b([-a-zA-Z0-9@:%_\\+.~#?&//=]*)$).
        /// </summary>
        /// <value>Webhook external service URL-address. The value must be unique in the system and you cannot add multiple values. The pattern of the value (^(http(s)://.)[-a-zA-Z0-9@:%._\\+~#&#x3D;]{2,256}\\.[a-z]{2,6}\\b([-a-zA-Z0-9@:%_\\+.~#?&amp;//&#x3D;]*)$).</value>
        [DataMember(Name = "URL", IsRequired = true, EmitDefaultValue = true)]
        public string URL { get; set; }

        /// <summary>
        /// If true, the configuration is active.
        /// </summary>
        /// <value>If true, the configuration is active.</value>
        /// <example>false</example>
        [DataMember(Name = "Is_Active", EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConnectionData {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
            sb.Append("  SecretKey: ").Append(SecretKey).Append("\n");
            sb.Append("  URL: ").Append(URL).Append("\n");
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
