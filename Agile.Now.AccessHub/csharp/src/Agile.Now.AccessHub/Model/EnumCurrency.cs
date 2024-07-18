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
    /// The enum of Currency.
    /// </summary>
    /// <value>The enum of Currency.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EnumCurrency
    {
        /// <summary>
        /// Enum AUD for value: AUD
        /// </summary>
        [EnumMember(Value = "AUD")]
        AUD = 1,

        /// <summary>
        /// Enum BHD for value: BHD
        /// </summary>
        [EnumMember(Value = "BHD")]
        BHD = 2,

        /// <summary>
        /// Enum BGN for value: BGN
        /// </summary>
        [EnumMember(Value = "BGN")]
        BGN = 3,

        /// <summary>
        /// Enum CAD for value: CAD
        /// </summary>
        [EnumMember(Value = "CAD")]
        CAD = 4,

        /// <summary>
        /// Enum CNY for value: CNY
        /// </summary>
        [EnumMember(Value = "CNY")]
        CNY = 5,

        /// <summary>
        /// Enum HRK for value: HRK
        /// </summary>
        [EnumMember(Value = "HRK")]
        HRK = 6,

        /// <summary>
        /// Enum CZK for value: CZK
        /// </summary>
        [EnumMember(Value = "CZK")]
        CZK = 7,

        /// <summary>
        /// Enum DKK for value: DKK
        /// </summary>
        [EnumMember(Value = "DKK")]
        DKK = 8,

        /// <summary>
        /// Enum AED for value: AED
        /// </summary>
        [EnumMember(Value = "AED")]
        AED = 9,

        /// <summary>
        /// Enum EUR for value: EUR
        /// </summary>
        [EnumMember(Value = "EUR")]
        EUR = 10,

        /// <summary>
        /// Enum GBP for value: GBP
        /// </summary>
        [EnumMember(Value = "GBP")]
        GBP = 11,

        /// <summary>
        /// Enum HKD for value: HKD
        /// </summary>
        [EnumMember(Value = "HKD")]
        HKD = 12,

        /// <summary>
        /// Enum HUF for value: HUF
        /// </summary>
        [EnumMember(Value = "HUF")]
        HUF = 13,

        /// <summary>
        /// Enum ISK for value: ISK
        /// </summary>
        [EnumMember(Value = "ISK")]
        ISK = 14,

        /// <summary>
        /// Enum JPY for value: JPY
        /// </summary>
        [EnumMember(Value = "JPY")]
        JPY = 15,

        /// <summary>
        /// Enum NOK for value: NOK
        /// </summary>
        [EnumMember(Value = "NOK")]
        NOK = 16,

        /// <summary>
        /// Enum PLN for value: PLN
        /// </summary>
        [EnumMember(Value = "PLN")]
        PLN = 17,

        /// <summary>
        /// Enum RUB for value: RUB
        /// </summary>
        [EnumMember(Value = "RUB")]
        RUB = 18,

        /// <summary>
        /// Enum SGD for value: SGD
        /// </summary>
        [EnumMember(Value = "SGD")]
        SGD = 19,

        /// <summary>
        /// Enum SEK for value: SEK
        /// </summary>
        [EnumMember(Value = "SEK")]
        SEK = 20,

        /// <summary>
        /// Enum CHF for value: CHF
        /// </summary>
        [EnumMember(Value = "CHF")]
        CHF = 21,

        /// <summary>
        /// Enum THB for value: THB
        /// </summary>
        [EnumMember(Value = "THB")]
        THB = 22,

        /// <summary>
        /// Enum TRY for value: TRY
        /// </summary>
        [EnumMember(Value = "TRY")]
        TRY = 23,

        /// <summary>
        /// Enum UAH for value: UAH
        /// </summary>
        [EnumMember(Value = "UAH")]
        UAH = 24,

        /// <summary>
        /// Enum USD for value: USD
        /// </summary>
        [EnumMember(Value = "USD")]
        USD = 25
    }

    /// <summary>
    /// Converts <see cref="EnumCurrency"/> to and from the JSON value
    /// </summary>
    public static class EnumCurrencyValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="EnumCurrency"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static EnumCurrency FromString(string value)
        {
            return FromStringOrDefault(value) ?? throw new NotImplementedException($"Could not convert value to type EnumCurrency: '{value}'");
        }

        /// <summary>
        /// Parses a given value to <see cref="EnumCurrency"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static EnumCurrency? FromStringOrDefault(string value)
        {
            if (value.Equals("AUD"))
                return EnumCurrency.AUD;

            if (value.Equals("BHD"))
                return EnumCurrency.BHD;

            if (value.Equals("BGN"))
                return EnumCurrency.BGN;

            if (value.Equals("CAD"))
                return EnumCurrency.CAD;

            if (value.Equals("CNY"))
                return EnumCurrency.CNY;

            if (value.Equals("HRK"))
                return EnumCurrency.HRK;

            if (value.Equals("CZK"))
                return EnumCurrency.CZK;

            if (value.Equals("DKK"))
                return EnumCurrency.DKK;

            if (value.Equals("AED"))
                return EnumCurrency.AED;

            if (value.Equals("EUR"))
                return EnumCurrency.EUR;

            if (value.Equals("GBP"))
                return EnumCurrency.GBP;

            if (value.Equals("HKD"))
                return EnumCurrency.HKD;

            if (value.Equals("HUF"))
                return EnumCurrency.HUF;

            if (value.Equals("ISK"))
                return EnumCurrency.ISK;

            if (value.Equals("JPY"))
                return EnumCurrency.JPY;

            if (value.Equals("NOK"))
                return EnumCurrency.NOK;

            if (value.Equals("PLN"))
                return EnumCurrency.PLN;

            if (value.Equals("RUB"))
                return EnumCurrency.RUB;

            if (value.Equals("SGD"))
                return EnumCurrency.SGD;

            if (value.Equals("SEK"))
                return EnumCurrency.SEK;

            if (value.Equals("CHF"))
                return EnumCurrency.CHF;

            if (value.Equals("THB"))
                return EnumCurrency.THB;

            if (value.Equals("TRY"))
                return EnumCurrency.TRY;

            if (value.Equals("UAH"))
                return EnumCurrency.UAH;

            if (value.Equals("USD"))
                return EnumCurrency.USD;

            return null;
        }
    }

}
