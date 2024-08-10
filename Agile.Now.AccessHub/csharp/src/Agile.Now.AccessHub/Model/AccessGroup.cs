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
    [DataContract(Name = "AccessGroup")]
    public partial class AccessGroup : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccessGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessGroup" /> class.
        /// </summary>
        /// <param name="id">The identifier of access group (required).</param>
        /// <param name="name">The name of access group (required).</param>
        /// <param name="externalId">The external system code of the access group.</param>
        /// <param name="description">The description of access group.</param>
        /// <param name="isActive">Defines if record is active (default to false).</param>
        /// <param name="isSystem">Defines if access group is system and end-user cannot change it general, permissions and applications. (default to false).</param>
        /// <param name="accessGroupTypeId">accessGroupTypeId.</param>
        /// <param name="modifiedOn">The date the record was updated (default to &quot;1900-01-01T00:00Z&quot;).</param>
        /// <param name="modifiedBy">modifiedBy.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="createdOn">The date the record was created (default to &quot;1900-01-01T00:00Z&quot;).</param>
        public AccessGroup(string id = default, string name = default, string externalId = default, string description = default, bool isActive = false, bool isSystem = false, AbstractText accessGroupTypeId = default, DateTime modifiedOn = default, AbstractLong modifiedBy = default, AbstractLong createdBy = default, DateTime createdOn = default)
        {
            // to ensure "id" is required (not null)
            id = id ?? throw new ArgumentNullException("id is a required property for AccessGroup and cannot be null");
            Id = id;
            // to ensure "name" is required (not null)
            name = name ?? throw new ArgumentNullException("name is a required property for AccessGroup and cannot be null");
            Name = name;
            ExternalId = externalId;
            Description = description;
            IsActive = isActive;
            IsSystem = isSystem;
            AccessGroupTypeId = accessGroupTypeId;
            ModifiedOn = modifiedOn;
            ModifiedBy = modifiedBy;
            CreatedBy = createdBy;
            CreatedOn = createdOn;
        }

        /// <summary>
        /// The identifier of access group
        /// </summary>
        /// <value>The identifier of access group</value>
        [DataMember(Name = "Id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The name of access group
        /// </summary>
        /// <value>The name of access group</value>
        [DataMember(Name = "Name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The external system code of the access group
        /// </summary>
        /// <value>The external system code of the access group</value>
        [DataMember(Name = "ExternalId", EmitDefaultValue = false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The description of access group
        /// </summary>
        /// <value>The description of access group</value>
        [DataMember(Name = "Description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Defines if record is active
        /// </summary>
        /// <value>Defines if record is active</value>
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
        /// Gets or Sets AccessGroupTypeId
        /// </summary>
        [DataMember(Name = "AccessGroupTypeId", EmitDefaultValue = false)]
        public AbstractText AccessGroupTypeId { get; set; }

        /// <summary>
        /// The date the record was updated
        /// </summary>
        /// <value>The date the record was updated</value>
        /// <example>1900-01-01T00:00Z</example>
        [DataMember(Name = "ModifiedOn", EmitDefaultValue = false)]
        public DateTime ModifiedOn { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedBy
        /// </summary>
        [DataMember(Name = "ModifiedBy", EmitDefaultValue = false)]
        public AbstractLong ModifiedBy { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "CreatedBy", EmitDefaultValue = false)]
        public AbstractLong CreatedBy { get; set; }

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
            sb.Append("class AccessGroup {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsSystem: ").Append(IsSystem).Append("\n");
            sb.Append("  AccessGroupTypeId: ").Append(AccessGroupTypeId).Append("\n");
            sb.Append("  ModifiedOn: ").Append(ModifiedOn).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
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
