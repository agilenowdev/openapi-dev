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
    /// The record of Role information.
    /// </summary>
    [DataContract(Name = "RoleData1")]
    public partial class RoleData1 : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleData1" /> class.
        /// </summary>
        /// <param name="id">The identifier of the role..</param>
        /// <param name="name">Name of role. The value must be unique in the system and you cannot add multiple values..</param>
        /// <param name="roleKey"> The key used to identify the role must be unique within each workspace. The value must be unique in the system and you cannot add multiple values..</param>
        /// <param name="fullName">Full name of role. Example Application 1 \\ Espace 1 \\ Role 1..</param>
        /// <param name="description">The description of access group..</param>
        /// <param name="externalId">The external system code of the role..</param>
        /// <param name="accessApplicationId">accessApplicationId.</param>
        /// <param name="isActive">Defines if record is active. (default to false).</param>
        public RoleData1(string id = default, string name = default, string roleKey = default, string fullName = default, string description = default, string externalId = default, FieldType accessApplicationId = default, bool isActive = false)
        {
            Id = id;
            Name = name;
            RoleKey = roleKey;
            FullName = fullName;
            Description = description;
            ExternalId = externalId;
            AccessApplicationId = accessApplicationId;
            IsActive = isActive;
        }

        /// <summary>
        /// The identifier of the role.
        /// </summary>
        /// <value>The identifier of the role.</value>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Name of role. The value must be unique in the system and you cannot add multiple values.
        /// </summary>
        /// <value>Name of role. The value must be unique in the system and you cannot add multiple values.</value>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        ///  The key used to identify the role must be unique within each workspace. The value must be unique in the system and you cannot add multiple values.
        /// </summary>
        /// <value> The key used to identify the role must be unique within each workspace. The value must be unique in the system and you cannot add multiple values.</value>
        [DataMember(Name = "RoleKey", EmitDefaultValue = false)]
        public string RoleKey { get; set; }

        /// <summary>
        /// Full name of role. Example Application 1 \\ Espace 1 \\ Role 1.
        /// </summary>
        /// <value>Full name of role. Example Application 1 \\ Espace 1 \\ Role 1.</value>
        [DataMember(Name = "FullName", EmitDefaultValue = false)]
        public string FullName { get; set; }

        /// <summary>
        /// The description of access group.
        /// </summary>
        /// <value>The description of access group.</value>
        [DataMember(Name = "Description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The external system code of the role.
        /// </summary>
        /// <value>The external system code of the role.</value>
        [DataMember(Name = "ExternalId", EmitDefaultValue = false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets AccessApplicationId
        /// </summary>
        [DataMember(Name = "AccessApplicationId", EmitDefaultValue = false)]
        public FieldType AccessApplicationId { get; set; }

        /// <summary>
        /// Defines if record is active.
        /// </summary>
        /// <value>Defines if record is active.</value>
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
            sb.Append("class RoleData1 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RoleKey: ").Append(RoleKey).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  AccessApplicationId: ").Append(AccessApplicationId).Append("\n");
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
