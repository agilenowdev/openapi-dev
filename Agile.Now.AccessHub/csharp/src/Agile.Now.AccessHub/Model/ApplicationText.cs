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
    /// The record of Application information.
    /// </summary>
    [DataContract(Name = "ApplicationText")]
    public partial class ApplicationText : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationText" /> class.
        /// </summary>
        /// <param name="id">The identifier of  access group application..</param>
        /// <param name="parentApplicationId">The identifier of the parent access application.  You can assign a role to a different access application and this allows for a user-friendly application/role structure..</param>
        /// <param name="accessApplicationId">The identifier of the access application.  You can assign a role to a different access application and this allows for a user-friendly application/role structure..</param>
        /// <param name="isActive">Defines if record is active. (default to false).</param>
        public ApplicationText(string id = default, string parentApplicationId = default, string accessApplicationId = default, bool isActive = false)
        {
            Id = id;
            ParentApplicationId = parentApplicationId;
            AccessApplicationId = accessApplicationId;
            IsActive = isActive;
        }

        /// <summary>
        /// The identifier of  access group application.
        /// </summary>
        /// <value>The identifier of  access group application.</value>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The identifier of the parent access application.  You can assign a role to a different access application and this allows for a user-friendly application/role structure.
        /// </summary>
        /// <value>The identifier of the parent access application.  You can assign a role to a different access application and this allows for a user-friendly application/role structure.</value>
        [DataMember(Name = "ParentApplicationId", EmitDefaultValue = false)]
        public string ParentApplicationId { get; set; }

        /// <summary>
        /// The identifier of the access application.  You can assign a role to a different access application and this allows for a user-friendly application/role structure.
        /// </summary>
        /// <value>The identifier of the access application.  You can assign a role to a different access application and this allows for a user-friendly application/role structure.</value>
        [DataMember(Name = "AccessApplicationId", EmitDefaultValue = false)]
        public string AccessApplicationId { get; set; }

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
            sb.Append("class ApplicationText {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ParentApplicationId: ").Append(ParentApplicationId).Append("\n");
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
