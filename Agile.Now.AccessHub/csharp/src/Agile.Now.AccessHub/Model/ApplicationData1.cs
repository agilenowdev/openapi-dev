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
    /// The record of Application information.
    /// </summary>
    [DataContract(Name = "ApplicationData1")]
    public partial class ApplicationData1 : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets AuthenticationId
        /// </summary>
        [DataMember(Name = "AuthenticationId", EmitDefaultValue = false)]
        public EnumAuthentication? AuthenticationId { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationData1" /> class.
        /// </summary>
        /// <param name="id">The identifier of the access application..</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="name">Name of application. The value must be unique in the system and you cannot add multiple values..</param>
        /// <param name="applicationKey">The key used to identify the application must be unique within each workspace. The value must be unique in the system and you cannot add multiple values..</param>
        /// <param name="externalId">The external system code of the application. The value must be unique in the system and you cannot add multiple values..</param>
        /// <param name="description">The description of access group..</param>
        /// <param name="webSiteURL">Web Site URL of application..</param>
        /// <param name="isSystem">Defines if application is system (setting menu). (default to false).</param>
        /// <param name="isEndUser">Specifies whether the application is an end-user application. (default to false).</param>
        /// <param name="isTestApp">Specifies whether the application is a test application. (default to false).</param>
        /// <param name="isActive">Defines if the application is active and can be used. (default to false).</param>
        /// <param name="isReadOnly">Determines whether the application is readonly and can be modified. (default to false).</param>
        /// <param name="authenticationId">authenticationId.</param>
        public ApplicationData1(string id = default, FieldType applicationId = default, string name = default, string applicationKey = default, string externalId = default, string description = default, string webSiteURL = default, bool isSystem = false, bool isEndUser = false, bool isTestApp = false, bool isActive = false, bool isReadOnly = false, EnumAuthentication? authenticationId = default)
        {
            Id = id;
            ApplicationId = applicationId;
            Name = name;
            ApplicationKey = applicationKey;
            ExternalId = externalId;
            Description = description;
            WebSiteURL = webSiteURL;
            IsSystem = isSystem;
            IsEndUser = isEndUser;
            IsTestApp = isTestApp;
            IsActive = isActive;
            IsReadOnly = isReadOnly;
            AuthenticationId = authenticationId;
        }

        /// <summary>
        /// The identifier of the access application.
        /// </summary>
        /// <value>The identifier of the access application.</value>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationId
        /// </summary>
        [DataMember(Name = "ApplicationId", EmitDefaultValue = false)]
        public FieldType ApplicationId { get; set; }

        /// <summary>
        /// Name of application. The value must be unique in the system and you cannot add multiple values.
        /// </summary>
        /// <value>Name of application. The value must be unique in the system and you cannot add multiple values.</value>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The key used to identify the application must be unique within each workspace. The value must be unique in the system and you cannot add multiple values.
        /// </summary>
        /// <value>The key used to identify the application must be unique within each workspace. The value must be unique in the system and you cannot add multiple values.</value>
        [DataMember(Name = "ApplicationKey", EmitDefaultValue = false)]
        public string ApplicationKey { get; set; }

        /// <summary>
        /// The external system code of the application. The value must be unique in the system and you cannot add multiple values.
        /// </summary>
        /// <value>The external system code of the application. The value must be unique in the system and you cannot add multiple values.</value>
        [DataMember(Name = "ExternalId", EmitDefaultValue = false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The description of access group.
        /// </summary>
        /// <value>The description of access group.</value>
        [DataMember(Name = "Description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Web Site URL of application.
        /// </summary>
        /// <value>Web Site URL of application.</value>
        [DataMember(Name = "WebSiteURL", EmitDefaultValue = false)]
        public string WebSiteURL { get; set; }

        /// <summary>
        /// Defines if application is system (setting menu).
        /// </summary>
        /// <value>Defines if application is system (setting menu).</value>
        /// <example>false</example>
        [DataMember(Name = "Is_System", EmitDefaultValue = true)]
        public bool IsSystem { get; set; }

        /// <summary>
        /// Specifies whether the application is an end-user application.
        /// </summary>
        /// <value>Specifies whether the application is an end-user application.</value>
        /// <example>false</example>
        [DataMember(Name = "Is_EndUser", EmitDefaultValue = true)]
        public bool IsEndUser { get; set; }

        /// <summary>
        /// Specifies whether the application is a test application.
        /// </summary>
        /// <value>Specifies whether the application is a test application.</value>
        /// <example>false</example>
        [DataMember(Name = "Is_TestApp", EmitDefaultValue = true)]
        public bool IsTestApp { get; set; }

        /// <summary>
        /// Defines if the application is active and can be used.
        /// </summary>
        /// <value>Defines if the application is active and can be used.</value>
        /// <example>false</example>
        [DataMember(Name = "Is_Active", EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Determines whether the application is readonly and can be modified.
        /// </summary>
        /// <value>Determines whether the application is readonly and can be modified.</value>
        /// <example>false</example>
        [DataMember(Name = "Is_ReadOnly", EmitDefaultValue = true)]
        public bool IsReadOnly { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApplicationData1 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ApplicationKey: ").Append(ApplicationKey).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  WebSiteURL: ").Append(WebSiteURL).Append("\n");
            sb.Append("  IsSystem: ").Append(IsSystem).Append("\n");
            sb.Append("  IsEndUser: ").Append(IsEndUser).Append("\n");
            sb.Append("  IsTestApp: ").Append(IsTestApp).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsReadOnly: ").Append(IsReadOnly).Append("\n");
            sb.Append("  AuthenticationId: ").Append(AuthenticationId).Append("\n");
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
