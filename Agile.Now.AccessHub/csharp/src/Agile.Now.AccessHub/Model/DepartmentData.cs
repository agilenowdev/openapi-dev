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
    /// The record of Department information.
    /// </summary>
    [DataContract(Name = "DepartmentData")]
    public partial class DepartmentData : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets DepartmentTypeId
        /// </summary>
        [DataMember(Name = "DepartmentTypeId", IsRequired = true, EmitDefaultValue = true)]
        public EnumDepartmentType DepartmentTypeId { get; set; }

        /// <summary>
        /// Gets or Sets CountryId
        /// </summary>
        [DataMember(Name = "CountryId", EmitDefaultValue = false)]
        public EnumCountry? CountryId { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DepartmentData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DepartmentData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DepartmentData" /> class.
        /// </summary>
        /// <param name="id">The guid to identify the department (required).</param>
        /// <param name="externalId">The external identifier of the department.</param>
        /// <param name="name">The name of the department (required).</param>
        /// <param name="departmentTypeId">departmentTypeId (required).</param>
        /// <param name="parentDepartmentId">parentDepartmentId.</param>
        /// <param name="contactName">The contact name of company or department.</param>
        /// <param name="contactEmail">The contact email of external company or department.</param>
        /// <param name="contactPhone">contactPhone.</param>
        /// <param name="ownerId">ownerId.</param>
        /// <param name="countryId">countryId.</param>
        /// <param name="isActive">Defines if the department is active and can be used (required) (default to false).</param>
        public DepartmentData(string id = default, string externalId = default, string name = default, EnumDepartmentType departmentTypeId = default, FieldType parentDepartmentId = default, string contactName = default, string contactEmail = default, string contactPhone = default, FieldType ownerId = default, EnumCountry? countryId = default, bool isActive = false)
        {
            // to ensure "id" is required (not null)
            id = id ?? throw new ArgumentNullException("id is a required property for DepartmentData and cannot be null");
            Id = id;
            // to ensure "name" is required (not null)
            name = name ?? throw new ArgumentNullException("name is a required property for DepartmentData and cannot be null");
            Name = name;
            DepartmentTypeId = departmentTypeId;
            IsActive = isActive;
            ExternalId = externalId;
            ParentDepartmentId = parentDepartmentId;
            ContactName = contactName;
            ContactEmail = contactEmail;
            ContactPhone = contactPhone;
            OwnerId = ownerId;
            CountryId = countryId;
        }

        /// <summary>
        /// The guid to identify the department
        /// </summary>
        /// <value>The guid to identify the department</value>
        [DataMember(Name = "Id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The external identifier of the department
        /// </summary>
        /// <value>The external identifier of the department</value>
        [DataMember(Name = "ExternalId", EmitDefaultValue = false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The name of the department
        /// </summary>
        /// <value>The name of the department</value>
        [DataMember(Name = "Name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ParentDepartmentId
        /// </summary>
        [DataMember(Name = "ParentDepartmentId", EmitDefaultValue = false)]
        public FieldType ParentDepartmentId { get; set; }

        /// <summary>
        /// The contact name of company or department
        /// </summary>
        /// <value>The contact name of company or department</value>
        [DataMember(Name = "ContactName", EmitDefaultValue = false)]
        public string ContactName { get; set; }

        /// <summary>
        /// The contact email of external company or department
        /// </summary>
        /// <value>The contact email of external company or department</value>
        [DataMember(Name = "ContactEmail", EmitDefaultValue = false)]
        public string ContactEmail { get; set; }

        /// <summary>
        /// Gets or Sets ContactPhone
        /// </summary>
        [DataMember(Name = "ContactPhone", EmitDefaultValue = false)]
        public string ContactPhone { get; set; }

        /// <summary>
        /// Gets or Sets OwnerId
        /// </summary>
        [DataMember(Name = "OwnerId", EmitDefaultValue = false)]
        public FieldType OwnerId { get; set; }

        /// <summary>
        /// Defines if the department is active and can be used
        /// </summary>
        /// <value>Defines if the department is active and can be used</value>
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
            sb.Append("class DepartmentData {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DepartmentTypeId: ").Append(DepartmentTypeId).Append("\n");
            sb.Append("  ParentDepartmentId: ").Append(ParentDepartmentId).Append("\n");
            sb.Append("  ContactName: ").Append(ContactName).Append("\n");
            sb.Append("  ContactEmail: ").Append(ContactEmail).Append("\n");
            sb.Append("  ContactPhone: ").Append(ContactPhone).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  CountryId: ").Append(CountryId).Append("\n");
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
