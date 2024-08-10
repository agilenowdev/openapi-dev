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
    /// The field object structure. This structure allows users to specify any related entity field and its corresponding value. When saving data, the system automatically retrieves and assigns the primary key value from the system database table based on the provided field name and value.
    /// </summary>
    [DataContract(Name = "FieldType")]
    public partial class FieldType : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FieldType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldType" /> class.
        /// </summary>
        /// <param name="field">The name of the data field. This can be any field name from the related database table, such as 'Email' from the User table or 'Name' from the Department table..</param>
        /// <param name="value">The value corresponding to the specified data field. This value is used to identify the record in the related database table. For example, it could be an email address, a department name, or an external system's identifier. (required).</param>
        public FieldType(string field = default, string value = default)
        {
            Value = value;
            Field = field;
        }

        /// <summary>
        /// The name of the data field. This can be any field name from the related database table, such as 'Email' from the User table or 'Name' from the Department table.
        /// </summary>
        /// <value>The name of the data field. This can be any field name from the related database table, such as &#39;Email&#39; from the User table or &#39;Name&#39; from the Department table.</value>
        [DataMember(Name = "Field", EmitDefaultValue = false)]
        public string Field { get; set; }

        /// <summary>
        /// The value corresponding to the specified data field. This value is used to identify the record in the related database table. For example, it could be an email address, a department name, or an external system's identifier.
        /// </summary>
        /// <value>The value corresponding to the specified data field. This value is used to identify the record in the related database table. For example, it could be an email address, a department name, or an external system&#39;s identifier.</value>
        [DataMember(Name = "Value", EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FieldType {\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
