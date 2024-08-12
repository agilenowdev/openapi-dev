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
    /// The data loading record of Department importing
    /// </summary>
    [DataContract(Name = "DepartmentsData")]
    public partial class DepartmentsData : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DepartmentsData" /> class.
        /// </summary>
        /// <param name="extra">List validation for entity attribute.</param>
        /// <param name="isFullValidation">If the value is true, the data quality of all fields are checked. This has an effect on performance. (default to false).</param>
        /// <param name="departments">The list of `Department` data record for import.</param>
        public DepartmentsData(List<ListValidation> extra = default, bool isFullValidation = false, List<DepartmentText> departments = default)
        {
            Extra = extra;
            IsFullValidation = isFullValidation;
            Departments = departments;
        }

        /// <summary>
        /// List validation for entity attribute
        /// </summary>
        /// <value>List validation for entity attribute</value>
        [DataMember(Name = "Extra", EmitDefaultValue = false)]
        public List<ListValidation> Extra { get; set; }

        /// <summary>
        /// If the value is true, the data quality of all fields are checked. This has an effect on performance.
        /// </summary>
        /// <value>If the value is true, the data quality of all fields are checked. This has an effect on performance.</value>
        /// <example>false</example>
        [DataMember(Name = "IsFullValidation", EmitDefaultValue = true)]
        public bool IsFullValidation { get; set; }

        /// <summary>
        /// The list of `Department` data record for import
        /// </summary>
        /// <value>The list of &#x60;Department&#x60; data record for import</value>
        [DataMember(Name = "Departments", EmitDefaultValue = false)]
        public List<DepartmentText> Departments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DepartmentsData {\n");
            sb.Append("  Extra: ").Append(Extra).Append("\n");
            sb.Append("  IsFullValidation: ").Append(IsFullValidation).Append("\n");
            sb.Append("  Departments: ").Append(Departments).Append("\n");
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
