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
    /// List validation for entity attribute
    /// </summary>
    [DataContract(Name = "ListValidation")]
    public partial class ListValidation : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListValidation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListValidation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListValidation" /> class.
        /// </summary>
        /// <param name="name">The name of the entity field. (required).</param>
        /// <param name="fieldName">The field name of relation database table.  Example;  The field name is &amp;quot;TenantId&amp;quot; and is associated with the &amp;quot;Tenant&amp;quot; table. You want to use in the &amp;quot;Tenant&amp;quot; table &amp;quot;Name&amp;quot; field fetching data. Once &amp;quot;Name&amp;quot; is specified, the validation service retrieves the tenant identifier from the &amp;quot;Tenant&amp;quot; table based on the &amp;quot;Name&amp;quot; field..</param>
        /// <param name="required">If True, the value is required. (default to false).</param>
        /// <param name="unique">If True, the value must be unique in the database and you cannot add multiple values. (default to false).</param>
        /// <param name="max">The max value of input value..</param>
        /// <param name="min">The min value of input value..</param>
        /// <param name="pattern">The pattern of the validation. Searches the input string for an occurrence of a regular expression..</param>
        /// <param name="defaultValue">The default value of row. If the value of the field is empty, the service automatically sets the value in the field. If the value does not match the data type, the value is cleaned. Remember data types..</param>
        public ListValidation(string name = default, string fieldName = default, bool required = false, bool unique = false, string max = default, string min = default, string pattern = default, string defaultValue = default)
        {
            // to ensure "name" is required (not null)
            name = name ?? throw new ArgumentNullException("name is a required property for ListValidation and cannot be null");
            Name = name;
            FieldName = fieldName;
            Required = required;
            Unique = unique;
            Max = max;
            Min = min;
            Pattern = pattern;
            DefaultValue = defaultValue;
        }

        /// <summary>
        /// The name of the entity field.
        /// </summary>
        /// <value>The name of the entity field.</value>
        [DataMember(Name = "Name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The field name of relation database table.  Example;  The field name is &amp;quot;TenantId&amp;quot; and is associated with the &amp;quot;Tenant&amp;quot; table. You want to use in the &amp;quot;Tenant&amp;quot; table &amp;quot;Name&amp;quot; field fetching data. Once &amp;quot;Name&amp;quot; is specified, the validation service retrieves the tenant identifier from the &amp;quot;Tenant&amp;quot; table based on the &amp;quot;Name&amp;quot; field.
        /// </summary>
        /// <value>The field name of relation database table.  Example;  The field name is &amp;quot;TenantId&amp;quot; and is associated with the &amp;quot;Tenant&amp;quot; table. You want to use in the &amp;quot;Tenant&amp;quot; table &amp;quot;Name&amp;quot; field fetching data. Once &amp;quot;Name&amp;quot; is specified, the validation service retrieves the tenant identifier from the &amp;quot;Tenant&amp;quot; table based on the &amp;quot;Name&amp;quot; field.</value>
        [DataMember(Name = "FieldName", EmitDefaultValue = false)]
        public string FieldName { get; set; }

        /// <summary>
        /// If True, the value is required.
        /// </summary>
        /// <value>If True, the value is required.</value>
        /// <example>false</example>
        [DataMember(Name = "Required", EmitDefaultValue = true)]
        public bool Required { get; set; }

        /// <summary>
        /// If True, the value must be unique in the database and you cannot add multiple values.
        /// </summary>
        /// <value>If True, the value must be unique in the database and you cannot add multiple values.</value>
        /// <example>false</example>
        [DataMember(Name = "Unique", EmitDefaultValue = true)]
        public bool Unique { get; set; }

        /// <summary>
        /// The max value of input value.
        /// </summary>
        /// <value>The max value of input value.</value>
        [DataMember(Name = "Max", EmitDefaultValue = false)]
        public string Max { get; set; }

        /// <summary>
        /// The min value of input value.
        /// </summary>
        /// <value>The min value of input value.</value>
        [DataMember(Name = "Min", EmitDefaultValue = false)]
        public string Min { get; set; }

        /// <summary>
        /// The pattern of the validation. Searches the input string for an occurrence of a regular expression.
        /// </summary>
        /// <value>The pattern of the validation. Searches the input string for an occurrence of a regular expression.</value>
        [DataMember(Name = "Pattern", EmitDefaultValue = false)]
        public string Pattern { get; set; }

        /// <summary>
        /// The default value of row. If the value of the field is empty, the service automatically sets the value in the field. If the value does not match the data type, the value is cleaned. Remember data types.
        /// </summary>
        /// <value>The default value of row. If the value of the field is empty, the service automatically sets the value in the field. If the value does not match the data type, the value is cleaned. Remember data types.</value>
        [DataMember(Name = "DefaultValue", EmitDefaultValue = false)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListValidation {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Unique: ").Append(Unique).Append("\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
            sb.Append("  Min: ").Append(Min).Append("\n");
            sb.Append("  Pattern: ").Append(Pattern).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
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
