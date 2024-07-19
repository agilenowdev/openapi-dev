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
    /// The enum of Language.
    /// </summary>
    /// <value>The enum of Language.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EnumLanguage
    {
        /// <summary>
        /// Enum Arabic for value: ar-ae
        /// </summary>
        [EnumMember(Value = "ar-ae")]
        Arabic = 1,

        /// <summary>
        /// Enum Bengali for value: bn-IN
        /// </summary>
        [EnumMember(Value = "bn-IN")]
        Bengali = 2,

        /// <summary>
        /// Enum Chinese for value: zh-CN
        /// </summary>
        [EnumMember(Value = "zh-CN")]
        Chinese = 3,

        /// <summary>
        /// Enum Danish for value: da-dk
        /// </summary>
        [EnumMember(Value = "da-dk")]
        Danish = 4,

        /// <summary>
        /// Enum English for value: en-US
        /// </summary>
        [EnumMember(Value = "en-US")]
        English = 5,

        /// <summary>
        /// Enum Faroese for value: fo-fo
        /// </summary>
        [EnumMember(Value = "fo-fo")]
        Faroese = 6,

        /// <summary>
        /// Enum Finnish for value: fi-FI
        /// </summary>
        [EnumMember(Value = "fi-FI")]
        Finnish = 7,

        /// <summary>
        /// Enum French for value: fr-FR
        /// </summary>
        [EnumMember(Value = "fr-FR")]
        French = 8,

        /// <summary>
        /// Enum German for value: de-DE
        /// </summary>
        [EnumMember(Value = "de-DE")]
        German = 9,

        /// <summary>
        /// Enum Hindi for value: hi-IN
        /// </summary>
        [EnumMember(Value = "hi-IN")]
        Hindi = 10,

        /// <summary>
        /// Enum Japanese for value: ja-JP
        /// </summary>
        [EnumMember(Value = "ja-JP")]
        Japanese = 11,

        /// <summary>
        /// Enum Korean for value: ko-KR
        /// </summary>
        [EnumMember(Value = "ko-KR")]
        Korean = 12,

        /// <summary>
        /// Enum Malay for value: ms-MY
        /// </summary>
        [EnumMember(Value = "ms-MY")]
        Malay = 13,

        /// <summary>
        /// Enum Portuguese for value: pt-PT
        /// </summary>
        [EnumMember(Value = "pt-PT")]
        Portuguese = 14,

        /// <summary>
        /// Enum Russian for value: ru-RU
        /// </summary>
        [EnumMember(Value = "ru-RU")]
        Russian = 15,

        /// <summary>
        /// Enum Spanish for value: es-ES
        /// </summary>
        [EnumMember(Value = "es-ES")]
        Spanish = 16,

        /// <summary>
        /// Enum Swedish for value: sv-se
        /// </summary>
        [EnumMember(Value = "sv-se")]
        Swedish = 17,

        /// <summary>
        /// Enum Turkish for value: tr-TR
        /// </summary>
        [EnumMember(Value = "tr-TR")]
        Turkish = 18,

        /// <summary>
        /// Enum Urdu for value: ur-IN
        /// </summary>
        [EnumMember(Value = "ur-IN")]
        Urdu = 19
    }

    /// <summary>
    /// Converts <see cref="EnumLanguage"/> to and from the JSON value
    /// </summary>
    public static class EnumLanguageValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="EnumLanguage"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static EnumLanguage FromString(string value)
        {
            return FromStringOrDefault(value) ?? throw new NotImplementedException($"Could not convert value to type EnumLanguage: '{value}'");
        }

        /// <summary>
        /// Parses a given value to <see cref="EnumLanguage"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static EnumLanguage? FromStringOrDefault(string value)
        {
            if (value.Equals("ar-ae"))
                return EnumLanguage.Arabic;

            if (value.Equals("bn-IN"))
                return EnumLanguage.Bengali;

            if (value.Equals("zh-CN"))
                return EnumLanguage.Chinese;

            if (value.Equals("da-dk"))
                return EnumLanguage.Danish;

            if (value.Equals("en-US"))
                return EnumLanguage.English;

            if (value.Equals("fo-fo"))
                return EnumLanguage.Faroese;

            if (value.Equals("fi-FI"))
                return EnumLanguage.Finnish;

            if (value.Equals("fr-FR"))
                return EnumLanguage.French;

            if (value.Equals("de-DE"))
                return EnumLanguage.German;

            if (value.Equals("hi-IN"))
                return EnumLanguage.Hindi;

            if (value.Equals("ja-JP"))
                return EnumLanguage.Japanese;

            if (value.Equals("ko-KR"))
                return EnumLanguage.Korean;

            if (value.Equals("ms-MY"))
                return EnumLanguage.Malay;

            if (value.Equals("pt-PT"))
                return EnumLanguage.Portuguese;

            if (value.Equals("ru-RU"))
                return EnumLanguage.Russian;

            if (value.Equals("es-ES"))
                return EnumLanguage.Spanish;

            if (value.Equals("sv-se"))
                return EnumLanguage.Swedish;

            if (value.Equals("tr-TR"))
                return EnumLanguage.Turkish;

            if (value.Equals("ur-IN"))
                return EnumLanguage.Urdu;

            return null;
        }
    }

}
