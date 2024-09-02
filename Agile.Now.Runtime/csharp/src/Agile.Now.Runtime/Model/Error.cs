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
    /// The list of errors. Throw specific exceptions based on the received error.
    /// </summary>
    [DataContract(Name = "Error")]
    public partial class Error : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Error() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        /// <param name="errors">Human-readable explanation of the errors (required).</param>
        /// <param name="type">URI identifier that categorizes the error (default to &quot;&quot;).</param>
        /// <param name="title">Brief, human-readable message about the error (default to &quot;&quot;).</param>
        /// <param name="statusCode">The HTTP response code (required).</param>
        /// <param name="instance">URI that identifies the specific occurrence of the error (default to &quot;&quot;).</param>
        /// <param name="requestKey">Provides a request key that identifies the current request. (default to &quot;&quot;).</param>
        public Error(List<string> errors = default, string type = @"", string title = @"", int statusCode = default, string instance = @"", string requestKey = @"")
        {
            // to ensure "errors" is required (not null)
            errors = errors ?? throw new ArgumentNullException("errors is a required property for Error and cannot be null");
            Errors = errors;
            StatusCode = statusCode;
            // use default value if no "type" provided
            Type = type ?? @"";
            // use default value if no "title" provided
            Title = title ?? @"";
            // use default value if no "instance" provided
            Instance = instance ?? @"";
            // use default value if no "requestKey" provided
            RequestKey = requestKey ?? @"";
        }

        /// <summary>
        /// Human-readable explanation of the errors
        /// </summary>
        /// <value>Human-readable explanation of the errors</value>
        [DataMember(Name = "Errors", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Errors { get; set; }

        /// <summary>
        /// URI identifier that categorizes the error
        /// </summary>
        /// <value>URI identifier that categorizes the error</value>
        [DataMember(Name = "Type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Brief, human-readable message about the error
        /// </summary>
        /// <value>Brief, human-readable message about the error</value>
        [DataMember(Name = "Title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// The HTTP response code
        /// </summary>
        /// <value>The HTTP response code</value>
        /// <example>400</example>
        [DataMember(Name = "StatusCode", IsRequired = true, EmitDefaultValue = true)]
        public int StatusCode { get; set; }

        /// <summary>
        /// URI that identifies the specific occurrence of the error
        /// </summary>
        /// <value>URI that identifies the specific occurrence of the error</value>
        [DataMember(Name = "Instance", EmitDefaultValue = false)]
        public string Instance { get; set; }

        /// <summary>
        /// Provides a request key that identifies the current request.
        /// </summary>
        /// <value>Provides a request key that identifies the current request.</value>
        [DataMember(Name = "RequestKey", EmitDefaultValue = false)]
        public string RequestKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Error {\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  Instance: ").Append(Instance).Append("\n");
            sb.Append("  RequestKey: ").Append(RequestKey).Append("\n");
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
