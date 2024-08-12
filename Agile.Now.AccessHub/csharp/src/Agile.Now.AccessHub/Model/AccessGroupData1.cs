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
    [DataContract(Name = "AccessGroupData1")]
    public partial class AccessGroupData1 : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessGroupData1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccessGroupData1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessGroupData1" /> class.
        /// </summary>
        /// <param name="id">The identifier of user access group. (default to 0).</param>
        /// <param name="accessGroupId">accessGroupId (required).</param>
        /// <param name="createdOn">The date when the record was created. (required) (default to &quot;1900-01-01T00:00Z&quot;).</param>
        public AccessGroupData1(long id = 0, FieldType accessGroupId = default, DateTime createdOn = default)
        {
            // to ensure "accessGroupId" is required (not null)
            accessGroupId = accessGroupId ?? throw new ArgumentNullException("accessGroupId is a required property for AccessGroupData1 and cannot be null");
            AccessGroupId = accessGroupId;
            CreatedOn = createdOn;
            Id = id;
        }

        /// <summary>
        /// The identifier of user access group.
        /// </summary>
        /// <value>The identifier of user access group.</value>
        /// <example>0</example>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets AccessGroupId
        /// </summary>
        [DataMember(Name = "AccessGroupId", IsRequired = true, EmitDefaultValue = true)]
        public FieldType AccessGroupId { get; set; }

        /// <summary>
        /// The date when the record was created.
        /// </summary>
        /// <value>The date when the record was created.</value>
        /// <example>1900-01-01T00:00Z</example>
        [DataMember(Name = "CreatedOn", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccessGroupData1 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AccessGroupId: ").Append(AccessGroupId).Append("\n");
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
