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
    /// The record of Tenant information.
    /// </summary>
    [DataContract(Name = "Tenant")]
    public partial class Tenant : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tenant" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Tenant() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Tenant" /> class.
        /// </summary>
        /// <param name="id">id (required) (default to 0).</param>
        /// <param name="name">name (required).</param>
        /// <param name="espaceId">espaceId (required).</param>
        /// <param name="isActive">isActive (required) (default to false).</param>
        public Tenant(int id = 0, string name = default, AbstractLong espaceId = default, bool isActive = false)
        {
            Id = id;
            // to ensure "name" is required (not null)
            name = name ?? throw new ArgumentNullException("name is a required property for Tenant and cannot be null");
            Name = name;
            // to ensure "espaceId" is required (not null)
            espaceId = espaceId ?? throw new ArgumentNullException("espaceId is a required property for Tenant and cannot be null");
            EspaceId = espaceId;
            IsActive = isActive;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <example>0</example>
        [DataMember(Name = "Id", IsRequired = true, EmitDefaultValue = true)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets EspaceId
        /// </summary>
        [DataMember(Name = "Espace_Id", IsRequired = true, EmitDefaultValue = true)]
        public AbstractLong EspaceId { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "Is_Active", IsRequired = true, EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Tenant {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  EspaceId: ").Append(EspaceId).Append("\n");
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
