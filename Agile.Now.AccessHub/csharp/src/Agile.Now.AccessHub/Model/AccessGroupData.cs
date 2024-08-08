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
    /// The record of AccessGroup information.
    /// </summary>
    [DataContract(Name = "AccessGroupData")]
    public partial class AccessGroupData : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets AccessGroupTypeId
        /// </summary>
        [DataMember(Name = "AccessGroupTypeId", EmitDefaultValue = false)]
        public EnumAccessGroupType? AccessGroupTypeId { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessGroupData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccessGroupData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessGroupData" /> class.
        /// </summary>
        /// <param name="id">The identifier of access group..</param>
        /// <param name="name">The name of access group. (required).</param>
        /// <param name="externalId">The external system code of the access group..</param>
        /// <param name="description">The description of access group..</param>
        /// <param name="isActive">Defines if record is active. (default to false).</param>
        /// <param name="isSystem">Defines if access group is system and end-user cannot change it general, permissions and applications. (default to false).</param>
        /// <param name="accessGroupTypeId">accessGroupTypeId.</param>
        public AccessGroupData(string id = default, string name = default, string externalId = default, string description = default, bool isActive = false, bool isSystem = false, EnumAccessGroupType? accessGroupTypeId = default)
        {
            // to ensure "name" is required (not null)
            name = name ?? throw new ArgumentNullException("name is a required property for AccessGroupData and cannot be null");
            Name = name;
            Id = id;
            ExternalId = externalId;
            Description = description;
            IsActive = isActive;
            IsSystem = isSystem;
            AccessGroupTypeId = accessGroupTypeId;
        }

        /// <summary>
        /// The identifier of access group.
        /// </summary>
        /// <value>The identifier of access group.</value>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The name of access group.
        /// </summary>
        /// <value>The name of access group.</value>
        [DataMember(Name = "Name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The external system code of the access group.
        /// </summary>
        /// <value>The external system code of the access group.</value>
        [DataMember(Name = "ExternalId", EmitDefaultValue = false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The description of access group.
        /// </summary>
        /// <value>The description of access group.</value>
        [DataMember(Name = "Description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Defines if record is active.
        /// </summary>
        /// <value>Defines if record is active.</value>
        /// <example>false</example>
        [DataMember(Name = "Is_Active", EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Defines if access group is system and end-user cannot change it general, permissions and applications.
        /// </summary>
        /// <value>Defines if access group is system and end-user cannot change it general, permissions and applications.</value>
        /// <example>false</example>
        [DataMember(Name = "Is_System", EmitDefaultValue = true)]
        public bool IsSystem { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccessGroupData {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsSystem: ").Append(IsSystem).Append("\n");
            sb.Append("  AccessGroupTypeId: ").Append(AccessGroupTypeId).Append("\n");
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
