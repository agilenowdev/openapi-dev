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
    /// The enum of PermissionType.
    /// </summary>
    /// <value>The enum of PermissionType.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EnumPermissionType
    {
        /// <summary>
        /// Enum Create for value: Create
        /// </summary>
        [EnumMember(Value = "Create")]
        Create = 1,

        /// <summary>
        /// Enum Read for value: Read
        /// </summary>
        [EnumMember(Value = "Read")]
        Read = 2,

        /// <summary>
        /// Enum Update for value: Update
        /// </summary>
        [EnumMember(Value = "Update")]
        Update = 3,

        /// <summary>
        /// Enum Delete for value: Delete
        /// </summary>
        [EnumMember(Value = "Delete")]
        Delete = 4,

        /// <summary>
        /// Enum Details for value: Details
        /// </summary>
        [EnumMember(Value = "Details")]
        Details = 5,

        /// <summary>
        /// Enum Export for value: Export
        /// </summary>
        [EnumMember(Value = "Export")]
        Export = 6,

        /// <summary>
        /// Enum Import for value: Import
        /// </summary>
        [EnumMember(Value = "Import")]
        Import = 7,

        /// <summary>
        /// Enum Generic for value: Generic
        /// </summary>
        [EnumMember(Value = "Generic")]
        Generic = 8
    }

    /// <summary>
    /// Converts <see cref="EnumPermissionType"/> to and from the JSON value
    /// </summary>
    public static class EnumPermissionTypeValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="EnumPermissionType"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static EnumPermissionType FromString(string value)
        {
            return FromStringOrDefault(value) ?? throw new NotImplementedException($"Could not convert value to type EnumPermissionType: '{value}'");
        }

        /// <summary>
        /// Parses a given value to <see cref="EnumPermissionType"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static EnumPermissionType? FromStringOrDefault(string value)
        {
            if (value.Equals("Create"))
                return EnumPermissionType.Create;

            if (value.Equals("Read"))
                return EnumPermissionType.Read;

            if (value.Equals("Update"))
                return EnumPermissionType.Update;

            if (value.Equals("Delete"))
                return EnumPermissionType.Delete;

            if (value.Equals("Details"))
                return EnumPermissionType.Details;

            if (value.Equals("Export"))
                return EnumPermissionType.Export;

            if (value.Equals("Import"))
                return EnumPermissionType.Import;

            if (value.Equals("Generic"))
                return EnumPermissionType.Generic;

            return null;
        }
    }

}
