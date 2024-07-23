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
        /// Enum Australian Dollar for value: AUD
        /// </summary>
        [EnumMember(Value = "AUD")]
        AustralianDollar = 1,

        /// <summary>
        /// Enum Bahraini Dinar for value: BHD
        /// </summary>
        [EnumMember(Value = "BHD")]
        BahrainiDinar = 2,

        /// <summary>
        /// Enum Bulgarian Lev for value: BGN
        /// </summary>
        [EnumMember(Value = "BGN")]
        BulgarianLev = 3,

        /// <summary>
        /// Enum Canadian Dollar for value: CAD
        /// </summary>
        [EnumMember(Value = "CAD")]
        CanadianDollar = 4,

        /// <summary>
        /// Enum Chinese Yuan Renminbi for value: CNY
        /// </summary>
        [EnumMember(Value = "CNY")]
        ChineseYuanRenminbi = 5,

        /// <summary>
        /// Enum Croatian Kuna for value: HRK
        /// </summary>
        [EnumMember(Value = "HRK")]
        CroatianKuna = 6,

        /// <summary>
        /// Enum Czech Koruna for value: CZK
        /// </summary>
        [EnumMember(Value = "CZK")]
        CzechKoruna = 7,

        /// <summary>
        /// Enum Danish Krone for value: DKK
        /// </summary>
        [EnumMember(Value = "DKK")]
        DanishKrone = 8,

        /// <summary>
        /// Enum Emirati Dirham for value: AED
        /// </summary>
        [EnumMember(Value = "AED")]
        EmiratiDirham = 9,

        /// <summary>
        /// Enum Euro for value: EUR
        /// </summary>
        [EnumMember(Value = "EUR")]
        Euro = 10,

        /// <summary>
        /// Enum Great British Pound for value: GBP
        /// </summary>
        [EnumMember(Value = "GBP")]
        GreatBritishPound = 11,

        /// <summary>
        /// Enum Hong Kong Dollar for value: HKD
        /// </summary>
        [EnumMember(Value = "HKD")]
        HongKongDollar = 12,

        /// <summary>
        /// Enum Hungarian Forint for value: HUF
        /// </summary>
        [EnumMember(Value = "HUF")]
        HungarianForint = 13,

        /// <summary>
        /// Enum Icelandic krona for value: ISK
        /// </summary>
        [EnumMember(Value = "ISK")]
        IcelandicKrona = 14,

        /// <summary>
        /// Enum Japanese Yen for value: JPY
        /// </summary>
        [EnumMember(Value = "JPY")]
        JapaneseYen = 15,

        /// <summary>
        /// Enum Norwegian Krone for value: NOK
        /// </summary>
        [EnumMember(Value = "NOK")]
        NorwegianKrone = 16,

        /// <summary>
        /// Enum Polish Zloty for value: PLN
        /// </summary>
        [EnumMember(Value = "PLN")]
        PolishZloty = 17,

        /// <summary>
        /// Enum Russian Ruble for value: RUB
        /// </summary>
        [EnumMember(Value = "RUB")]
        RussianRuble = 18,

        /// <summary>
        /// Enum Singapore Dollar for value: SGD
        /// </summary>
        [EnumMember(Value = "SGD")]
        SingaporeDollar = 19,

        /// <summary>
        /// Enum Swedish Kroner for value: SEK
        /// </summary>
        [EnumMember(Value = "SEK")]
        SwedishKroner = 20,

        /// <summary>
        /// Enum Swiss Franc for value: CHF
        /// </summary>
        [EnumMember(Value = "CHF")]
        SwissFranc = 21,

        /// <summary>
        /// Enum Thailand Baht for value: THB
        /// </summary>
        [EnumMember(Value = "THB")]
        ThailandBaht = 22,

        /// <summary>
        /// Enum Turkish Lira for value: TRY
        /// </summary>
        [EnumMember(Value = "TRY")]
        TurkishLira = 23,

        /// <summary>
        /// Enum Ukrainian hryvnia for value: UAH
        /// </summary>
        [EnumMember(Value = "UAH")]
        UkrainianHryvnia = 24,

        /// <summary>
        /// Enum United States Dollar for value: USD
        /// </summary>
        [EnumMember(Value = "USD")]
        UnitedStatesDollar = 25
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
                return EnumCurrency.AustralianDollar;

            if (value.Equals("BHD"))
                return EnumCurrency.BahrainiDinar;

            if (value.Equals("BGN"))
                return EnumCurrency.BulgarianLev;

            if (value.Equals("CAD"))
                return EnumCurrency.CanadianDollar;

            if (value.Equals("CNY"))
                return EnumCurrency.ChineseYuanRenminbi;

            if (value.Equals("HRK"))
                return EnumCurrency.CroatianKuna;

            if (value.Equals("CZK"))
                return EnumCurrency.CzechKoruna;

            if (value.Equals("DKK"))
                return EnumCurrency.DanishKrone;

            if (value.Equals("AED"))
                return EnumCurrency.EmiratiDirham;

            if (value.Equals("EUR"))
                return EnumCurrency.Euro;

            if (value.Equals("GBP"))
                return EnumCurrency.GreatBritishPound;

            if (value.Equals("HKD"))
                return EnumCurrency.HongKongDollar;

            if (value.Equals("HUF"))
                return EnumCurrency.HungarianForint;

            if (value.Equals("ISK"))
                return EnumCurrency.IcelandicKrona;

            if (value.Equals("JPY"))
                return EnumCurrency.JapaneseYen;

            if (value.Equals("NOK"))
                return EnumCurrency.NorwegianKrone;

            if (value.Equals("PLN"))
                return EnumCurrency.PolishZloty;

            if (value.Equals("RUB"))
                return EnumCurrency.RussianRuble;

            if (value.Equals("SGD"))
                return EnumCurrency.SingaporeDollar;

            if (value.Equals("SEK"))
                return EnumCurrency.SwedishKroner;

            if (value.Equals("CHF"))
                return EnumCurrency.SwissFranc;

            if (value.Equals("THB"))
                return EnumCurrency.ThailandBaht;

            if (value.Equals("TRY"))
                return EnumCurrency.TurkishLira;

            if (value.Equals("UAH"))
                return EnumCurrency.UkrainianHryvnia;

            if (value.Equals("USD"))
                return EnumCurrency.UnitedStatesDollar;

            return null;
        }
    }

}
