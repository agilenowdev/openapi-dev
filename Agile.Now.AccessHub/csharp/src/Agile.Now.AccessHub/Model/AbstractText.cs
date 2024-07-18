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
    /// The abstract object structure
    /// </summary>
    [DataContract(Name = "AbstractText")]
    public partial class AbstractText : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractText" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AbstractText() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractText" /> class.
        /// </summary>
        /// <param name="id">The primary key of the record row. If the Id attribute is used, then it must be unique (required).</param>
        /// <param name="externalId">The external identier of the record row. If the External Id attribute is used, then it must be unique (required).</param>
        /// <param name="name">The name of the record row (required).</param>
        /// <param name="type">The type of the record object (required).</param>
        public AbstractText(string id = default, string externalId = default, string name = default, string type = default)
        {
            // to ensure "id" is required (not null)
            id = id ?? throw new ArgumentNullException("id is a required property for AbstractText and cannot be null");
            Id = id;
            // to ensure "externalId" is required (not null)
            externalId = externalId ?? throw new ArgumentNullException("externalId is a required property for AbstractText and cannot be null");
            ExternalId = externalId;
            // to ensure "name" is required (not null)
            name = name ?? throw new ArgumentNullException("name is a required property for AbstractText and cannot be null");
            Name = name;
            // to ensure "type" is required (not null)
            type = type ?? throw new ArgumentNullException("type is a required property for AbstractText and cannot be null");
            Type = type;
        }

        /// <summary>
        /// The primary key of the record row. If the Id attribute is used, then it must be unique
        /// </summary>
        /// <value>The primary key of the record row. If the Id attribute is used, then it must be unique</value>
        /// <example>3ad64ab3-bd04-46c5-b1d7-c0b34be9e5b5</example>
        [DataMember(Name = "Id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The external identier of the record row. If the External Id attribute is used, then it must be unique
        /// </summary>
        /// <value>The external identier of the record row. If the External Id attribute is used, then it must be unique</value>
        /// <example>3ad64ab3-bd04-46c5-b1d7-c0b34be9e5b5</example>
        [DataMember(Name = "ExternalId", IsRequired = true, EmitDefaultValue = true)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The name of the record row
        /// </summary>
        /// <value>The name of the record row</value>
        /// <example>Bob Normal</example>
        [DataMember(Name = "Name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The type of the record object
        /// </summary>
        /// <value>The type of the record object</value>
        /// <example>User</example>
        [DataMember(Name = "Type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AbstractText {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
