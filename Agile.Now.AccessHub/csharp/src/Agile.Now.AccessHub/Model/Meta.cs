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
    /// The object provides metadata about the list of items returned in the API response. It typically includes information that helps clients understand and work with the data.
    /// </summary>
    [DataContract(Name = "Meta")]
    public partial class Meta : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Meta" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Meta() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Meta" /> class.
        /// </summary>
        /// <param name="totalItems">This field represents the total number of items available in the entire dataset, not just the items returned in the current response. It's useful for implementing pagination, as clients can use it to calculate the number of pages or total available items. (required) (default to 0).</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It's often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (required) (default to 1).</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed. (required) (default to 50).</param>
        /// <param name="type">The type of the record (required).</param>
        public Meta(int totalItems = 0, int currentPage = 1, int pageSize = 50, string type = default)
        {
            TotalItems = totalItems;
            CurrentPage = currentPage;
            PageSize = pageSize;
            // to ensure "type" is required (not null)
            type = type ?? throw new ArgumentNullException("type is a required property for Meta and cannot be null");
            Type = type;
        }

        /// <summary>
        /// This field represents the total number of items available in the entire dataset, not just the items returned in the current response. It's useful for implementing pagination, as clients can use it to calculate the number of pages or total available items.
        /// </summary>
        /// <value>This field represents the total number of items available in the entire dataset, not just the items returned in the current response. It&#39;s useful for implementing pagination, as clients can use it to calculate the number of pages or total available items.</value>
        /// <example>1000</example>
        [DataMember(Name = "TotalItems", IsRequired = true, EmitDefaultValue = true)]
        public int TotalItems { get; set; }

        /// <summary>
        /// This field specifies the current page of results being returned. It's often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved.
        /// </summary>
        /// <value>This field specifies the current page of results being returned. It&#39;s often used in conjunction with &#x60;PageSize&#x60; to manage pagination by indicating which subset of the total data is currently being retrieved.</value>
        /// <example>50</example>
        [DataMember(Name = "CurrentPage", IsRequired = true, EmitDefaultValue = true)]
        public int CurrentPage { get; set; }

        /// <summary>
        /// The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.
        /// </summary>
        /// <value>The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.</value>
        /// <example>50</example>
        [DataMember(Name = "PageSize", IsRequired = true, EmitDefaultValue = true)]
        public int PageSize { get; set; }

        /// <summary>
        /// The type of the record
        /// </summary>
        /// <value>The type of the record</value>
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
            sb.Append("class Meta {\n");
            sb.Append("  TotalItems: ").Append(TotalItems).Append("\n");
            sb.Append("  CurrentPage: ").Append(CurrentPage).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
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
