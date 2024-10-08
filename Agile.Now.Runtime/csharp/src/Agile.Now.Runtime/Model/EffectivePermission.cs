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
    /// The record of EffectivePermission information.
    /// </summary>
    [DataContract(Name = "EffectivePermission")]
    public partial class EffectivePermission : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EffectivePermission" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EffectivePermission() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EffectivePermission" /> class.
        /// </summary>
        /// <param name="id">The identifier of entity (required).</param>
        /// <param name="accessRoleId">accessRoleId (required).</param>
        /// <param name="accessGroupTypeId">accessGroupTypeId.</param>
        /// <param name="create">Create access of role (default to false).</param>
        /// <param name="read">Read access of role (default to false).</param>
        /// <param name="update">Update access of role (default to false).</param>
        /// <param name="delete">Delete access of role (default to false).</param>
        /// <param name="details">Details access of role (default to false).</param>
        /// <param name="export">Export access of role (default to false).</param>
        /// <param name="import">Import access of role (default to false).</param>
        /// <param name="generic">Generic access without CRUD of role (default to false).</param>
        /// <param name="createdOn">The date the record was created (default to &quot;1900-01-01T00:00Z&quot;).</param>
        public EffectivePermission(string id = default, AbstractText accessRoleId = default, AbstractText accessGroupTypeId = default, bool create = false, bool read = false, bool update = false, bool delete = false, bool details = false, bool export = false, bool import = false, bool generic = false, DateTime createdOn = default)
        {
            // to ensure "id" is required (not null)
            id = id ?? throw new ArgumentNullException("id is a required property for EffectivePermission and cannot be null");
            Id = id;
            // to ensure "accessRoleId" is required (not null)
            accessRoleId = accessRoleId ?? throw new ArgumentNullException("accessRoleId is a required property for EffectivePermission and cannot be null");
            AccessRoleId = accessRoleId;
            AccessGroupTypeId = accessGroupTypeId;
            Create = create;
            Read = read;
            Update = update;
            Delete = delete;
            Details = details;
            Export = export;
            Import = import;
            Generic = generic;
            CreatedOn = createdOn;
        }

        /// <summary>
        /// The identifier of entity
        /// </summary>
        /// <value>The identifier of entity</value>
        [DataMember(Name = "Id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets AccessRoleId
        /// </summary>
        [DataMember(Name = "AccessRoleId", IsRequired = true, EmitDefaultValue = true)]
        public AbstractText AccessRoleId { get; set; }

        /// <summary>
        /// Gets or Sets AccessGroupTypeId
        /// </summary>
        [DataMember(Name = "AccessGroupTypeId", EmitDefaultValue = false)]
        public AbstractText AccessGroupTypeId { get; set; }

        /// <summary>
        /// Create access of role
        /// </summary>
        /// <value>Create access of role</value>
        /// <example>false</example>
        [DataMember(Name = "Create", EmitDefaultValue = true)]
        public bool Create { get; set; }

        /// <summary>
        /// Read access of role
        /// </summary>
        /// <value>Read access of role</value>
        /// <example>false</example>
        [DataMember(Name = "Read", EmitDefaultValue = true)]
        public bool Read { get; set; }

        /// <summary>
        /// Update access of role
        /// </summary>
        /// <value>Update access of role</value>
        /// <example>false</example>
        [DataMember(Name = "Update", EmitDefaultValue = true)]
        public bool Update { get; set; }

        /// <summary>
        /// Delete access of role
        /// </summary>
        /// <value>Delete access of role</value>
        /// <example>false</example>
        [DataMember(Name = "Delete", EmitDefaultValue = true)]
        public bool Delete { get; set; }

        /// <summary>
        /// Details access of role
        /// </summary>
        /// <value>Details access of role</value>
        /// <example>false</example>
        [DataMember(Name = "Details", EmitDefaultValue = true)]
        public bool Details { get; set; }

        /// <summary>
        /// Export access of role
        /// </summary>
        /// <value>Export access of role</value>
        /// <example>false</example>
        [DataMember(Name = "Export", EmitDefaultValue = true)]
        public bool Export { get; set; }

        /// <summary>
        /// Import access of role
        /// </summary>
        /// <value>Import access of role</value>
        /// <example>false</example>
        [DataMember(Name = "Import", EmitDefaultValue = true)]
        public bool Import { get; set; }

        /// <summary>
        /// Generic access without CRUD of role
        /// </summary>
        /// <value>Generic access without CRUD of role</value>
        /// <example>false</example>
        [DataMember(Name = "Generic", EmitDefaultValue = true)]
        public bool Generic { get; set; }

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
            sb.Append("class EffectivePermission {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AccessRoleId: ").Append(AccessRoleId).Append("\n");
            sb.Append("  AccessGroupTypeId: ").Append(AccessGroupTypeId).Append("\n");
            sb.Append("  Create: ").Append(Create).Append("\n");
            sb.Append("  Read: ").Append(Read).Append("\n");
            sb.Append("  Update: ").Append(Update).Append("\n");
            sb.Append("  Delete: ").Append(Delete).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Export: ").Append(Export).Append("\n");
            sb.Append("  Import: ").Append(Import).Append("\n");
            sb.Append("  Generic: ").Append(Generic).Append("\n");
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
