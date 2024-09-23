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
    /// The record of User information.
    /// </summary>
    [DataContract(Name = "User1")]
    public partial class User1 : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected User1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="User1" /> class.
        /// </summary>
        /// <param name="id">Unique identifier of the user. (required) (default to 0).</param>
        /// <param name="name">Full name of the user..</param>
        /// <param name="username">Login name of the user..</param>
        /// <param name="email">Email contact of the user..</param>
        /// <param name="mobilePhone">Mobile phone number of the user..</param>
        /// <param name="externalId">The user identifier in an external system to the Platform..</param>
        /// <param name="creationDate">The date the user was created. (required) (default to &quot;1900-01-01T00:00Z&quot;).</param>
        /// <param name="lastLogin">Last time the user logged in the application. (default to &quot;1900-01-01T00:00Z&quot;).</param>
        /// <param name="isActive">Indicates if the user is still active. (required) (default to false).</param>
        public User1(int id = 0, string name = default, string username = default, string email = default, string mobilePhone = default, string externalId = default, DateTime creationDate = default, DateTime lastLogin = default, bool isActive = false)
        {
            Id = id;
            CreationDate = creationDate;
            IsActive = isActive;
            Name = name;
            Username = username;
            Email = email;
            MobilePhone = mobilePhone;
            ExternalId = externalId;
            LastLogin = lastLogin;
        }

        /// <summary>
        /// Unique identifier of the user.
        /// </summary>
        /// <value>Unique identifier of the user.</value>
        /// <example>0</example>
        [DataMember(Name = "Id", IsRequired = true, EmitDefaultValue = true)]
        public int Id { get; set; }

        /// <summary>
        /// Full name of the user.
        /// </summary>
        /// <value>Full name of the user.</value>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Login name of the user.
        /// </summary>
        /// <value>Login name of the user.</value>
        [DataMember(Name = "Username", EmitDefaultValue = false)]
        public string Username { get; set; }

        /// <summary>
        /// Email contact of the user.
        /// </summary>
        /// <value>Email contact of the user.</value>
        [DataMember(Name = "Email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Mobile phone number of the user.
        /// </summary>
        /// <value>Mobile phone number of the user.</value>
        [DataMember(Name = "MobilePhone", EmitDefaultValue = false)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// The user identifier in an external system to the Platform.
        /// </summary>
        /// <value>The user identifier in an external system to the Platform.</value>
        [DataMember(Name = "External_Id", EmitDefaultValue = false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The date the user was created.
        /// </summary>
        /// <value>The date the user was created.</value>
        /// <example>1900-01-01T00:00Z</example>
        [DataMember(Name = "Creation_Date", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Last time the user logged in the application.
        /// </summary>
        /// <value>Last time the user logged in the application.</value>
        /// <example>1900-01-01T00:00Z</example>
        [DataMember(Name = "Last_Login", EmitDefaultValue = false)]
        public DateTime LastLogin { get; set; }

        /// <summary>
        /// Indicates if the user is still active.
        /// </summary>
        /// <value>Indicates if the user is still active.</value>
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
            sb.Append("class User1 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  MobilePhone: ").Append(MobilePhone).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  LastLogin: ").Append(LastLogin).Append("\n");
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
