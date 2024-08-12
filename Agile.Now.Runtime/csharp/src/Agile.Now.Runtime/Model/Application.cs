/*
 * Agile.Now.Runtime API
 *
 * Agile.Now.Runtime
 *
 * The version of the OpenAPI document: 1.0
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
using OpenAPIDateConverter = Agile.Now.Runtime.Client.OpenAPIDateConverter;

namespace Agile.Now.Runtime.Model
{
    /// <summary>
    /// The record of Application information.
    /// </summary>
    [DataContract(Name = "Application")]
    public partial class Application : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Application" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Application() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Application" /> class.
        /// </summary>
        /// <param name="id">The identifier of the access application (required).</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="name">Name of application.</param>
        /// <param name="applicationKey">The key used to identify the application must be unique within each workspace..</param>
        /// <param name="externalId">The external system code of the application.</param>
        /// <param name="description">The description of access group.</param>
        /// <param name="webSiteURL">Web Site URL of application.</param>
        /// <param name="isSystem">Defines if application is system (setting menu) (default to false).</param>
        /// <param name="isEndUser">Specifies whether the application is an end-user application (default to false).</param>
        /// <param name="isTestApp">Specifies whether the application is a test application (default to false).</param>
        /// <param name="isActive">Defines if the application is active and can be used (required) (default to false).</param>
        /// <param name="isReadOnly">Determines whether the application is readonly and can be modified (required) (default to false).</param>
        /// <param name="authenticationId">authenticationId.</param>
        /// <param name="modifiedOn">The date the record was updated (default to &quot;1900-01-01T00:00Z&quot;).</param>
        /// <param name="createdOn">The date the record was created (default to &quot;1900-01-01T00:00Z&quot;).</param>
        public Application(string id = default, AbstractLong applicationId = default, string name = default, string applicationKey = default, string externalId = default, string description = default, string webSiteURL = default, bool isSystem = false, bool isEndUser = false, bool isTestApp = false, bool isActive = false, bool isReadOnly = false, AbstractText authenticationId = default, DateTime modifiedOn = default, DateTime createdOn = default)
        {
            // to ensure "id" is required (not null)
            id = id ?? throw new ArgumentNullException("id is a required property for Application and cannot be null");
            Id = id;
            IsActive = isActive;
            IsReadOnly = isReadOnly;
            ApplicationId = applicationId;
            Name = name;
            ApplicationKey = applicationKey;
            ExternalId = externalId;
            Description = description;
            WebSiteURL = webSiteURL;
            IsSystem = isSystem;
            IsEndUser = isEndUser;
            IsTestApp = isTestApp;
            AuthenticationId = authenticationId;
            ModifiedOn = modifiedOn;
            CreatedOn = createdOn;
        }

        /// <summary>
        /// The identifier of the access application
        /// </summary>
        /// <value>The identifier of the access application</value>
        [DataMember(Name = "Id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationId
        /// </summary>
        [DataMember(Name = "ApplicationId", EmitDefaultValue = false)]
        public AbstractLong ApplicationId { get; set; }

        /// <summary>
        /// Name of application
        /// </summary>
        /// <value>Name of application</value>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The key used to identify the application must be unique within each workspace.
        /// </summary>
        /// <value>The key used to identify the application must be unique within each workspace.</value>
        [DataMember(Name = "ApplicationKey", EmitDefaultValue = false)]
        public string ApplicationKey { get; set; }

        /// <summary>
        /// The external system code of the application
        /// </summary>
        /// <value>The external system code of the application</value>
        [DataMember(Name = "ExternalId", EmitDefaultValue = false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The description of access group
        /// </summary>
        /// <value>The description of access group</value>
        [DataMember(Name = "Description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Web Site URL of application
        /// </summary>
        /// <value>Web Site URL of application</value>
        [DataMember(Name = "WebSiteURL", EmitDefaultValue = false)]
        public string WebSiteURL { get; set; }

        /// <summary>
        /// Defines if application is system (setting menu)
        /// </summary>
        /// <value>Defines if application is system (setting menu)</value>
        /// <example>false</example>
        [DataMember(Name = "Is_System", EmitDefaultValue = true)]
        public bool IsSystem { get; set; }

        /// <summary>
        /// Specifies whether the application is an end-user application
        /// </summary>
        /// <value>Specifies whether the application is an end-user application</value>
        /// <example>false</example>
        [DataMember(Name = "Is_EndUser", EmitDefaultValue = true)]
        public bool IsEndUser { get; set; }

        /// <summary>
        /// Specifies whether the application is a test application
        /// </summary>
        /// <value>Specifies whether the application is a test application</value>
        /// <example>false</example>
        [DataMember(Name = "Is_TestApp", EmitDefaultValue = true)]
        public bool IsTestApp { get; set; }

        /// <summary>
        /// Defines if the application is active and can be used
        /// </summary>
        /// <value>Defines if the application is active and can be used</value>
        /// <example>false</example>
        [DataMember(Name = "Is_Active", IsRequired = true, EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Determines whether the application is readonly and can be modified
        /// </summary>
        /// <value>Determines whether the application is readonly and can be modified</value>
        /// <example>false</example>
        [DataMember(Name = "Is_ReadOnly", IsRequired = true, EmitDefaultValue = true)]
        public bool IsReadOnly { get; set; }

        /// <summary>
        /// Gets or Sets AuthenticationId
        /// </summary>
        [DataMember(Name = "AuthenticationId", EmitDefaultValue = false)]
        public AbstractText AuthenticationId { get; set; }

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
            sb.Append("class Application {\n");
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
