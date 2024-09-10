/*
 * Agile.Now.Runtime API
 *
 * Agile.Now.Runtime is a dynamic and secure REST API designed to streamline the management of users, their access groups, user groups, organizations, locations, applications, and roles within a single-tenant environment. This API provides a robust, scalable, and secure platform for businesses to manage user access and organizational structures effectively. It supports both Role-Based Access Control (RBAC) and Attribute-Based Access Control (ABAC) to ensure fine-grained security and flexibility.
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
    /// This structure represents an abstract object with a primary key of type Text. It is used to encapsulate detailed information about related entities.
    /// </summary>
    [DataContract(Name = "AbstractText")]
    public partial class AbstractText : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractText" /> class.
        /// </summary>
        /// <param name="id">The primary key of the record. It uniquely identifies each record within the dataset. This attribute is required and must be unique across all records..</param>
        /// <param name="externalId">An external identifier for the record, which can be used to link the record to external systems or datasets. This attribute is optional but should be unique if provided..</param>
        /// <param name="name">The name of the record. This attribute provides a human-readable identifier for the record, making it easier to recognize and differentiate records in lists or other displays. This attribute is optional..</param>
        /// <param name="type">The type of the record object. This attribute is used to classify the record into specific categories or types, helping to organize and manage different kinds of records. This attribute is optional..</param>
        public AbstractText(string id = default, string externalId = default, string name = default, string type = default)
        {
            Id = id;
            ExternalId = externalId;
            Name = name;
            Type = type;
        }

        /// <summary>
        /// The primary key of the record. It uniquely identifies each record within the dataset. This attribute is required and must be unique across all records.
        /// </summary>
        /// <value>The primary key of the record. It uniquely identifies each record within the dataset. This attribute is required and must be unique across all records.</value>
        /// <example>3ad64ab3-bd04-46c5-b1d7-c0b34be9e5b5</example>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// An external identifier for the record, which can be used to link the record to external systems or datasets. This attribute is optional but should be unique if provided.
        /// </summary>
        /// <value>An external identifier for the record, which can be used to link the record to external systems or datasets. This attribute is optional but should be unique if provided.</value>
        /// <example>3ad64ab3-bd04-46c5-b1d7-c0b34be9e5b5</example>
        [DataMember(Name = "ExternalId", EmitDefaultValue = false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The name of the record. This attribute provides a human-readable identifier for the record, making it easier to recognize and differentiate records in lists or other displays. This attribute is optional.
        /// </summary>
        /// <value>The name of the record. This attribute provides a human-readable identifier for the record, making it easier to recognize and differentiate records in lists or other displays. This attribute is optional.</value>
        /// <example>Bob Normal</example>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The type of the record object. This attribute is used to classify the record into specific categories or types, helping to organize and manage different kinds of records. This attribute is optional.
        /// </summary>
        /// <value>The type of the record object. This attribute is used to classify the record into specific categories or types, helping to organize and manage different kinds of records. This attribute is optional.</value>
        /// <example>User</example>
        [DataMember(Name = "Type", EmitDefaultValue = false)]
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
