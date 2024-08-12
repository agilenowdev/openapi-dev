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
    /// The record of Location information.
    /// </summary>
    [DataContract(Name = "LocationData")]
    public partial class LocationData : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets CountryId
        /// </summary>
        [DataMember(Name = "CountryId", EmitDefaultValue = false)]
        public EnumCountry? CountryId { get; set; }

        /// <summary>
        /// Gets or Sets TimezoneId
        /// </summary>
        [DataMember(Name = "TimezoneId", EmitDefaultValue = false)]
        public EnumTimezone? TimezoneId { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyId
        /// </summary>
        [DataMember(Name = "CurrencyId", EmitDefaultValue = false)]
        public EnumCurrency? CurrencyId { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LocationData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationData" /> class.
        /// </summary>
        /// <param name="id">The guid to identify the location..</param>
        /// <param name="externalId">The external identifier of the location..</param>
        /// <param name="name">The name of the location. The value must be unique in the system and you cannot add multiple values. (required).</param>
        /// <param name="countryId">countryId.</param>
        /// <param name="timezoneId">timezoneId.</param>
        /// <param name="currencyId">currencyId.</param>
        /// <param name="isActive">Defines if the location is active and can be used. (required) (default to false).</param>
        /// <param name="isDeleted">Defines if the location is deleted and cannot be used. (default to false).</param>
        public LocationData(string id = default, string externalId = default, string name = default, EnumCountry? countryId = default, EnumTimezone? timezoneId = default, EnumCurrency? currencyId = default, bool isActive = false, bool isDeleted = false)
        {
            // to ensure "name" is required (not null)
            name = name ?? throw new ArgumentNullException("name is a required property for LocationData and cannot be null");
            Name = name;
            IsActive = isActive;
            Id = id;
            ExternalId = externalId;
            CountryId = countryId;
            TimezoneId = timezoneId;
            CurrencyId = currencyId;
            IsDeleted = isDeleted;
        }

        /// <summary>
        /// The guid to identify the location.
        /// </summary>
        /// <value>The guid to identify the location.</value>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The external identifier of the location.
        /// </summary>
        /// <value>The external identifier of the location.</value>
        [DataMember(Name = "ExternalId", EmitDefaultValue = false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The name of the location. The value must be unique in the system and you cannot add multiple values.
        /// </summary>
        /// <value>The name of the location. The value must be unique in the system and you cannot add multiple values.</value>
        [DataMember(Name = "Name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Defines if the location is active and can be used.
        /// </summary>
        /// <value>Defines if the location is active and can be used.</value>
        /// <example>false</example>
        [DataMember(Name = "Is_Active", IsRequired = true, EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Defines if the location is deleted and cannot be used.
        /// </summary>
        /// <value>Defines if the location is deleted and cannot be used.</value>
        /// <example>false</example>
        [DataMember(Name = "Is_Deleted", EmitDefaultValue = true)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LocationData {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CountryId: ").Append(CountryId).Append("\n");
            sb.Append("  TimezoneId: ").Append(TimezoneId).Append("\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
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
