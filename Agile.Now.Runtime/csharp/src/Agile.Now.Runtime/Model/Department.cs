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
    /// The record of Department information.
    /// </summary>
    [DataContract(Name = "Department")]
    public partial class Department : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Department" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Department() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Department" /> class.
        /// </summary>
        /// <param name="id">The guid to identify the department (required).</param>
        /// <param name="externalId">The external identifier of the department.</param>
        /// <param name="name">The name of the department (required).</param>
        /// <param name="departmentTypeId">departmentTypeId (required).</param>
        /// <param name="parentDepartmentId">parentDepartmentId.</param>
        /// <param name="hierarchicalName">The hierarchical name of the department.</param>
        /// <param name="level">The department level at the hierarchy (default to 0).</param>
        /// <param name="contactName">The contact name of company or department.</param>
        /// <param name="contactEmail">The contact email of external company or department.</param>
        /// <param name="contactPhone">contactPhone.</param>
        /// <param name="countryId">countryId.</param>
        /// <param name="isActive">Defines if the department is active and can be used (required) (default to false).</param>
        /// <param name="modifiedOn">The date the record was updated (default to &quot;1900-01-01T00:00Z&quot;).</param>
        /// <param name="createdOn">The date the record was created (default to &quot;1900-01-01T00:00Z&quot;).</param>
        public Department(string id = default, string externalId = default, string name = default, AbstractText departmentTypeId = default, AbstractText parentDepartmentId = default, string hierarchicalName = default, int level = 0, string contactName = default, string contactEmail = default, string contactPhone = default, AbstractText countryId = default, bool isActive = false, DateTime modifiedOn = default, DateTime createdOn = default)
        {
            // to ensure "id" is required (not null)
            id = id ?? throw new ArgumentNullException("id is a required property for Department and cannot be null");
            Id = id;
            // to ensure "name" is required (not null)
            name = name ?? throw new ArgumentNullException("name is a required property for Department and cannot be null");
            Name = name;
            // to ensure "departmentTypeId" is required (not null)
            departmentTypeId = departmentTypeId ?? throw new ArgumentNullException("departmentTypeId is a required property for Department and cannot be null");
            DepartmentTypeId = departmentTypeId;
            IsActive = isActive;
            ExternalId = externalId;
            ParentDepartmentId = parentDepartmentId;
            HierarchicalName = hierarchicalName;
            Level = level;
            ContactName = contactName;
            ContactEmail = contactEmail;
            ContactPhone = contactPhone;
            CountryId = countryId;
            ModifiedOn = modifiedOn;
            CreatedOn = createdOn;
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
        /// Gets or Sets DepartmentTypeId
        /// </summary>
        [DataMember(Name = "DepartmentTypeId", IsRequired = true, EmitDefaultValue = true)]
        public AbstractText DepartmentTypeId { get; set; }

        /// <summary>
        /// Gets or Sets ParentDepartmentId
        /// </summary>
        [DataMember(Name = "ParentDepartmentId", EmitDefaultValue = false)]
        public AbstractText ParentDepartmentId { get; set; }

        /// <summary>
        /// The hierarchical name of the department
        /// </summary>
        /// <value>The hierarchical name of the department</value>
        [DataMember(Name = "HierarchicalName", EmitDefaultValue = false)]
        public string HierarchicalName { get; set; }

        /// <summary>
        /// The department level at the hierarchy
        /// </summary>
        /// <value>The department level at the hierarchy</value>
        /// <example>0</example>
        [DataMember(Name = "Level", EmitDefaultValue = false)]
        public int Level { get; set; }

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
        /// Gets or Sets CountryId
        /// </summary>
        [DataMember(Name = "CountryId", EmitDefaultValue = false)]
        public AbstractText CountryId { get; set; }

        /// <summary>
        /// Defines if the department is active and can be used
        /// </summary>
        /// <value>Defines if the department is active and can be used</value>
        /// <example>false</example>
        [DataMember(Name = "Is_Active", IsRequired = true, EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// The date the record was updated
        /// </summary>
        /// <value>The date the record was updated</value>
        /// <example>1900-01-01T00:00Z</example>
        [DataMember(Name = "ModifiedOn", EmitDefaultValue = false)]
        public DateTime ModifiedOn { get; set; }

        /// <summary>
        /// The date the record was created
        /// </summary>
        /// <value>The date the record was created</value>
        /// <example>1900-01-01T00:00Z</example>
        [DataMember(Name = "CreatedOn", EmitDefaultValue = false)]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Department {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DepartmentTypeId: ").Append(DepartmentTypeId).Append("\n");
            sb.Append("  ParentDepartmentId: ").Append(ParentDepartmentId).Append("\n");
            sb.Append("  HierarchicalName: ").Append(HierarchicalName).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  ContactName: ").Append(ContactName).Append("\n");
            sb.Append("  ContactEmail: ").Append(ContactEmail).Append("\n");
            sb.Append("  ContactPhone: ").Append(ContactPhone).Append("\n");
            sb.Append("  CountryId: ").Append(CountryId).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  ModifiedOn: ").Append(ModifiedOn).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
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
