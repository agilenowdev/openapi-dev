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
    /// The enum of DateFormat.
    /// </summary>
    /// <value>The enum of DateFormat.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EnumDateFormat
    {
        /// <summary>
        /// Enum DD-MM-YYYY for value: DD-MM-YYYY
        /// </summary>
        [EnumMember(Value = "DD-MM-YYYY")]
        DdMmYyyy = 1,

        /// <summary>
        /// Enum DD/MM/YYYY for value: DD/MM/YYYY
        /// </summary>
        [EnumMember(Value = "DD/MM/YYYY")]
        DdMmYyyy_1 = 2,

        /// <summary>
        /// Enum DD.MM.YYYY for value: DD.MM.YYYY
        /// </summary>
        [EnumMember(Value = "DD.MM.YYYY")]
        DdMmYyyy_2 = 3,

        /// <summary>
        /// Enum MM-DD-YYYY for value: MM-DD-YYYY
        /// </summary>
        [EnumMember(Value = "MM-DD-YYYY")]
        MmDdYyyy = 4,

        /// <summary>
        /// Enum MM/DD/YYYY for value: MM/DD/YYYY
        /// </summary>
        [EnumMember(Value = "MM/DD/YYYY")]
        MmDdYyyy_1 = 5,

        /// <summary>
        /// Enum YYYY-MM-DD for value: YYYY-MM-DD
        /// </summary>
        [EnumMember(Value = "YYYY-MM-DD")]
        YyyyMmDd = 6,

        /// <summary>
        /// Enum YYYY/MM/DD for value: YYYY/MM/DD
        /// </summary>
        [EnumMember(Value = "YYYY/MM/DD")]
        YyyyMmDd_1 = 7
    }

    /// <summary>
    /// Converts <see cref="EnumDateFormat"/> to and from the JSON value
    /// </summary>
    public static class EnumDateFormatValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="EnumDateFormat"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static EnumDateFormat FromString(string value)
        {
            return FromStringOrDefault(value) ?? throw new NotImplementedException($"Could not convert value to type EnumDateFormat: '{value}'");
        }

        /// <summary>
        /// Parses a given value to <see cref="EnumDateFormat"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static EnumDateFormat? FromStringOrDefault(string value)
        {
            if (value.Equals("DD-MM-YYYY"))
                return EnumDateFormat.DdMmYyyy;

            if (value.Equals("DD/MM/YYYY"))
                return EnumDateFormat.DdMmYyyy_1;

            if (value.Equals("DD.MM.YYYY"))
                return EnumDateFormat.DdMmYyyy_2;

            if (value.Equals("MM-DD-YYYY"))
                return EnumDateFormat.MmDdYyyy;

            if (value.Equals("MM/DD/YYYY"))
                return EnumDateFormat.MmDdYyyy_1;

            if (value.Equals("YYYY-MM-DD"))
                return EnumDateFormat.YyyyMmDd;

            if (value.Equals("YYYY/MM/DD"))
                return EnumDateFormat.YyyyMmDd_1;

            return null;
        }
    }

}
