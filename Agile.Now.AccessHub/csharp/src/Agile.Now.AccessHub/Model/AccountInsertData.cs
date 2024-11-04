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
    /// The record of Account information.
    /// </summary>
    [DataContract(Name = "AccountInsertData")]
    public partial class AccountInsertData : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets LanguageId
        /// </summary>
        [DataMember(Name = "LanguageId", EmitDefaultValue = false)]
        public EnumLanguage? LanguageId { get; set; }

        /// <summary>
        /// Gets or Sets TimezoneId
        /// </summary>
        [DataMember(Name = "TimezoneId", EmitDefaultValue = false)]
        public EnumTimezone? TimezoneId { get; set; }

        /// <summary>
        /// Gets or Sets DateFormatId
        /// </summary>
        [DataMember(Name = "DateFormatId", EmitDefaultValue = false)]
        public EnumDateFormat? DateFormatId { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountInsertData" /> class.
        /// </summary>
        /// <param name="id">The identifier of account..</param>
        /// <param name="name">The name of the account..</param>
        /// <param name="firstName">Person's first name..</param>
        /// <param name="lastName">Person's last name..</param>
        /// <param name="phone">The phone number of account. The phone number is unique in the system..</param>
        /// <param name="phoneVerified">Indicates whether the phone number has been verified. (default to false).</param>
        /// <param name="email">The e-mail of account. The email is unique in the system..</param>
        /// <param name="languageId">languageId.</param>
        /// <param name="timezoneId">timezoneId.</param>
        /// <param name="dateFormatId">dateFormatId.</param>
        /// <param name="username">Username used to log in into the system. The username is unique in the system. The value must be unique in the system and you cannot add multiple values..</param>
        /// <param name="externalId">External Authentication identifier. Example Azure AD guid. The value must be unique in the system and you cannot add multiple values..</param>
        /// <param name="notifyByEmail">Defines if a person should get notifications via e-mail. (default to false).</param>
        /// <param name="notifyBySMS">Defines if a contact should get notifications via SMS. (default to false).</param>
        /// <param name="isActive">Defines if the account is active and can be used. (default to false).</param>
        public AccountInsertData(string id = default, string name = default, string firstName = default, string lastName = default, string phone = default, bool phoneVerified = false, string email = default, EnumLanguage? languageId = default, EnumTimezone? timezoneId = default, EnumDateFormat? dateFormatId = default, string username = default, string externalId = default, bool notifyByEmail = false, bool notifyBySMS = false, bool isActive = false)
        {
            Id = id;
            Name = name;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            PhoneVerified = phoneVerified;
            Email = email;
            LanguageId = languageId;
            TimezoneId = timezoneId;
            DateFormatId = dateFormatId;
            Username = username;
            ExternalId = externalId;
            NotifyByEmail = notifyByEmail;
            NotifyBySMS = notifyBySMS;
            IsActive = isActive;
        }

        /// <summary>
        /// The identifier of account.
        /// </summary>
        /// <value>The identifier of account.</value>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The name of the account.
        /// </summary>
        /// <value>The name of the account.</value>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Person's first name.
        /// </summary>
        /// <value>Person&#39;s first name.</value>
        [DataMember(Name = "FirstName", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Person's last name.
        /// </summary>
        /// <value>Person&#39;s last name.</value>
        [DataMember(Name = "LastName", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// The phone number of account. The phone number is unique in the system.
        /// </summary>
        /// <value>The phone number of account. The phone number is unique in the system.</value>
        [DataMember(Name = "Phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// Indicates whether the phone number has been verified.
        /// </summary>
        /// <value>Indicates whether the phone number has been verified.</value>
        /// <example>false</example>
        [DataMember(Name = "PhoneVerified", EmitDefaultValue = true)]
        public bool PhoneVerified { get; set; }

        /// <summary>
        /// The e-mail of account. The email is unique in the system.
        /// </summary>
        /// <value>The e-mail of account. The email is unique in the system.</value>
        [DataMember(Name = "Email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Username used to log in into the system. The username is unique in the system. The value must be unique in the system and you cannot add multiple values.
        /// </summary>
        /// <value>Username used to log in into the system. The username is unique in the system. The value must be unique in the system and you cannot add multiple values.</value>
        [DataMember(Name = "Username", EmitDefaultValue = false)]
        public string Username { get; set; }

        /// <summary>
        /// External Authentication identifier. Example Azure AD guid. The value must be unique in the system and you cannot add multiple values.
        /// </summary>
        /// <value>External Authentication identifier. Example Azure AD guid. The value must be unique in the system and you cannot add multiple values.</value>
        [DataMember(Name = "ExternalId", EmitDefaultValue = false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Defines if a person should get notifications via e-mail.
        /// </summary>
        /// <value>Defines if a person should get notifications via e-mail.</value>
        /// <example>false</example>
        [DataMember(Name = "NotifyByEmail", EmitDefaultValue = true)]
        public bool NotifyByEmail { get; set; }

        /// <summary>
        /// Defines if a contact should get notifications via SMS.
        /// </summary>
        /// <value>Defines if a contact should get notifications via SMS.</value>
        /// <example>false</example>
        [DataMember(Name = "NotifyBySMS", EmitDefaultValue = true)]
        public bool NotifyBySMS { get; set; }

        /// <summary>
        /// Defines if the account is active and can be used.
        /// </summary>
        /// <value>Defines if the account is active and can be used.</value>
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
            sb.Append("class AccountInsertData {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  PhoneVerified: ").Append(PhoneVerified).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  LanguageId: ").Append(LanguageId).Append("\n");
            sb.Append("  TimezoneId: ").Append(TimezoneId).Append("\n");
            sb.Append("  DateFormatId: ").Append(DateFormatId).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  NotifyByEmail: ").Append(NotifyByEmail).Append("\n");
            sb.Append("  NotifyBySMS: ").Append(NotifyBySMS).Append("\n");
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
