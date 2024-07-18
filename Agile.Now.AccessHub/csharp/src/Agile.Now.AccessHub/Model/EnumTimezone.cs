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
    /// The enum of Timezone.
    /// </summary>
    /// <value>The enum of Timezone.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EnumTimezone
    {
        /// <summary>
        /// Enum AfghanistanStandardTime for value: Afghanistan Standard Time
        /// </summary>
        [EnumMember(Value = "Afghanistan Standard Time")]
        AfghanistanStandardTime = 1,

        /// <summary>
        /// Enum AlaskanStandardTime for value: Alaskan Standard Time
        /// </summary>
        [EnumMember(Value = "Alaskan Standard Time")]
        AlaskanStandardTime = 2,

        /// <summary>
        /// Enum ArabStandardTime for value: Arab Standard Time
        /// </summary>
        [EnumMember(Value = "Arab Standard Time")]
        ArabStandardTime = 3,

        /// <summary>
        /// Enum ArabianStandardTime for value: Arabian Standard Time
        /// </summary>
        [EnumMember(Value = "Arabian Standard Time")]
        ArabianStandardTime = 4,

        /// <summary>
        /// Enum ArabicStandardTime for value: Arabic Standard Time
        /// </summary>
        [EnumMember(Value = "Arabic Standard Time")]
        ArabicStandardTime = 5,

        /// <summary>
        /// Enum ArgentinaStandardTime for value: Argentina Standard Time
        /// </summary>
        [EnumMember(Value = "Argentina Standard Time")]
        ArgentinaStandardTime = 6,

        /// <summary>
        /// Enum AtlanticStandardTime for value: Atlantic Standard Time
        /// </summary>
        [EnumMember(Value = "Atlantic Standard Time")]
        AtlanticStandardTime = 7,

        /// <summary>
        /// Enum AUSCentralStandardTime for value: AUS Central Standard Time
        /// </summary>
        [EnumMember(Value = "AUS Central Standard Time")]
        AUSCentralStandardTime = 8,

        /// <summary>
        /// Enum AUSEasternStandardTime for value: AUS Eastern Standard Time
        /// </summary>
        [EnumMember(Value = "AUS Eastern Standard Time")]
        AUSEasternStandardTime = 9,

        /// <summary>
        /// Enum AzerbaijanStandardTime for value: Azerbaijan Standard Time
        /// </summary>
        [EnumMember(Value = "Azerbaijan Standard Time")]
        AzerbaijanStandardTime = 10,

        /// <summary>
        /// Enum AzoresStandardTime for value: Azores Standard Time
        /// </summary>
        [EnumMember(Value = "Azores Standard Time")]
        AzoresStandardTime = 11,

        /// <summary>
        /// Enum CanadaCentralStandardTime for value: Canada Central Standard Time
        /// </summary>
        [EnumMember(Value = "Canada Central Standard Time")]
        CanadaCentralStandardTime = 12,

        /// <summary>
        /// Enum CapeVerdeStandardTime for value: Cape Verde Standard Time
        /// </summary>
        [EnumMember(Value = "Cape Verde Standard Time")]
        CapeVerdeStandardTime = 13,

        /// <summary>
        /// Enum CaucasusStandardTime for value: Caucasus Standard Time
        /// </summary>
        [EnumMember(Value = "Caucasus Standard Time")]
        CaucasusStandardTime = 14,

        /// <summary>
        /// Enum CenAustraliaStandardTime for value: Cen. Australia Standard Time
        /// </summary>
        [EnumMember(Value = "Cen. Australia Standard Time")]
        CenAustraliaStandardTime = 15,

        /// <summary>
        /// Enum CentralAmericaStandardTime for value: Central America Standard Time
        /// </summary>
        [EnumMember(Value = "Central America Standard Time")]
        CentralAmericaStandardTime = 16,

        /// <summary>
        /// Enum CentralAsiaStandardTime for value: Central Asia Standard Time
        /// </summary>
        [EnumMember(Value = "Central Asia Standard Time")]
        CentralAsiaStandardTime = 17,

        /// <summary>
        /// Enum CentralBrazilianStandardTime for value: Central Brazilian Standard Time
        /// </summary>
        [EnumMember(Value = "Central Brazilian Standard Time")]
        CentralBrazilianStandardTime = 18,

        /// <summary>
        /// Enum CentralEuropeStandardTime for value: Central Europe Standard Time
        /// </summary>
        [EnumMember(Value = "Central Europe Standard Time")]
        CentralEuropeStandardTime = 19,

        /// <summary>
        /// Enum CentralEuropeanStandardTime for value: Central European Standard Time
        /// </summary>
        [EnumMember(Value = "Central European Standard Time")]
        CentralEuropeanStandardTime = 20,

        /// <summary>
        /// Enum CentralPacificStandardTime for value: Central Pacific Standard Time
        /// </summary>
        [EnumMember(Value = "Central Pacific Standard Time")]
        CentralPacificStandardTime = 21,

        /// <summary>
        /// Enum CentralStandardTime for value: Central Standard Time
        /// </summary>
        [EnumMember(Value = "Central Standard Time")]
        CentralStandardTime = 22,

        /// <summary>
        /// Enum CentralStandardTimeMexico for value: Central Standard Time (Mexico)
        /// </summary>
        [EnumMember(Value = "Central Standard Time (Mexico)")]
        CentralStandardTimeMexico = 23,

        /// <summary>
        /// Enum ChinaStandardTime for value: China Standard Time
        /// </summary>
        [EnumMember(Value = "China Standard Time")]
        ChinaStandardTime = 24,

        /// <summary>
        /// Enum DatelineStandardTime for value: Dateline Standard Time
        /// </summary>
        [EnumMember(Value = "Dateline Standard Time")]
        DatelineStandardTime = 25,

        /// <summary>
        /// Enum EAfricaStandardTime for value: E. Africa Standard Time
        /// </summary>
        [EnumMember(Value = "E. Africa Standard Time")]
        EAfricaStandardTime = 26,

        /// <summary>
        /// Enum EAustraliaStandardTime for value: E. Australia Standard Time
        /// </summary>
        [EnumMember(Value = "E. Australia Standard Time")]
        EAustraliaStandardTime = 27,

        /// <summary>
        /// Enum EEuropeStandardTime for value: E. Europe Standard Time
        /// </summary>
        [EnumMember(Value = "E. Europe Standard Time")]
        EEuropeStandardTime = 28,

        /// <summary>
        /// Enum ESouthAmericaStandardTime for value: E. South America Standard Time
        /// </summary>
        [EnumMember(Value = "E. South America Standard Time")]
        ESouthAmericaStandardTime = 29,

        /// <summary>
        /// Enum EasternStandardTime for value: Eastern Standard Time
        /// </summary>
        [EnumMember(Value = "Eastern Standard Time")]
        EasternStandardTime = 30,

        /// <summary>
        /// Enum EgyptStandardTime for value: Egypt Standard Time
        /// </summary>
        [EnumMember(Value = "Egypt Standard Time")]
        EgyptStandardTime = 31,

        /// <summary>
        /// Enum EkaterinburgStandardTime for value: Ekaterinburg Standard Time
        /// </summary>
        [EnumMember(Value = "Ekaterinburg Standard Time")]
        EkaterinburgStandardTime = 32,

        /// <summary>
        /// Enum FijiStandardTime for value: Fiji Standard Time
        /// </summary>
        [EnumMember(Value = "Fiji Standard Time")]
        FijiStandardTime = 33,

        /// <summary>
        /// Enum FLEStandardTime for value: FLE Standard Time
        /// </summary>
        [EnumMember(Value = "FLE Standard Time")]
        FLEStandardTime = 34,

        /// <summary>
        /// Enum GeorgianStandardTime for value: Georgian Standard Time
        /// </summary>
        [EnumMember(Value = "Georgian Standard Time")]
        GeorgianStandardTime = 35,

        /// <summary>
        /// Enum GMTStandardTime for value: GMT Standard Time
        /// </summary>
        [EnumMember(Value = "GMT Standard Time")]
        GMTStandardTime = 36,

        /// <summary>
        /// Enum GreenlandStandardTime for value: Greenland Standard Time
        /// </summary>
        [EnumMember(Value = "Greenland Standard Time")]
        GreenlandStandardTime = 37,

        /// <summary>
        /// Enum GreenwichStandardTime for value: Greenwich Standard Time
        /// </summary>
        [EnumMember(Value = "Greenwich Standard Time")]
        GreenwichStandardTime = 38,

        /// <summary>
        /// Enum GTBStandardTime for value: GTB Standard Time
        /// </summary>
        [EnumMember(Value = "GTB Standard Time")]
        GTBStandardTime = 39,

        /// <summary>
        /// Enum HawaiianStandardTime for value: Hawaiian Standard Time
        /// </summary>
        [EnumMember(Value = "Hawaiian Standard Time")]
        HawaiianStandardTime = 40,

        /// <summary>
        /// Enum IndiaStandardTime for value: India Standard Time
        /// </summary>
        [EnumMember(Value = "India Standard Time")]
        IndiaStandardTime = 41,

        /// <summary>
        /// Enum IranStandardTime for value: Iran Standard Time
        /// </summary>
        [EnumMember(Value = "Iran Standard Time")]
        IranStandardTime = 42,

        /// <summary>
        /// Enum IsraelStandardTime for value: Israel Standard Time
        /// </summary>
        [EnumMember(Value = "Israel Standard Time")]
        IsraelStandardTime = 43,

        /// <summary>
        /// Enum JordanStandardTime for value: Jordan Standard Time
        /// </summary>
        [EnumMember(Value = "Jordan Standard Time")]
        JordanStandardTime = 44,

        /// <summary>
        /// Enum KoreaStandardTime for value: Korea Standard Time
        /// </summary>
        [EnumMember(Value = "Korea Standard Time")]
        KoreaStandardTime = 45,

        /// <summary>
        /// Enum MauritiusStandardTime for value: Mauritius Standard Time
        /// </summary>
        [EnumMember(Value = "Mauritius Standard Time")]
        MauritiusStandardTime = 46,

        /// <summary>
        /// Enum MidAtlanticStandardTime for value: Mid-Atlantic Standard Time
        /// </summary>
        [EnumMember(Value = "Mid-Atlantic Standard Time")]
        MidAtlanticStandardTime = 47,

        /// <summary>
        /// Enum MiddleEastStandardTime for value: Middle East Standard Time
        /// </summary>
        [EnumMember(Value = "Middle East Standard Time")]
        MiddleEastStandardTime = 48,

        /// <summary>
        /// Enum MontevideoStandardTime for value: Montevideo Standard Time
        /// </summary>
        [EnumMember(Value = "Montevideo Standard Time")]
        MontevideoStandardTime = 49,

        /// <summary>
        /// Enum MoroccoStandardTime for value: Morocco Standard Time
        /// </summary>
        [EnumMember(Value = "Morocco Standard Time")]
        MoroccoStandardTime = 50,

        /// <summary>
        /// Enum MountainStandardTime for value: Mountain Standard Time
        /// </summary>
        [EnumMember(Value = "Mountain Standard Time")]
        MountainStandardTime = 51,

        /// <summary>
        /// Enum MountainStandardTimeMexico for value: Mountain Standard Time (Mexico)
        /// </summary>
        [EnumMember(Value = "Mountain Standard Time (Mexico)")]
        MountainStandardTimeMexico = 52,

        /// <summary>
        /// Enum MyanmarStandardTime for value: Myanmar Standard Time
        /// </summary>
        [EnumMember(Value = "Myanmar Standard Time")]
        MyanmarStandardTime = 53,

        /// <summary>
        /// Enum NCentralAsiaStandardTime for value: N. Central Asia Standard Time
        /// </summary>
        [EnumMember(Value = "N. Central Asia Standard Time")]
        NCentralAsiaStandardTime = 54,

        /// <summary>
        /// Enum NamibiaStandardTime for value: Namibia Standard Time
        /// </summary>
        [EnumMember(Value = "Namibia Standard Time")]
        NamibiaStandardTime = 55,

        /// <summary>
        /// Enum NepalStandardTime for value: Nepal Standard Time
        /// </summary>
        [EnumMember(Value = "Nepal Standard Time")]
        NepalStandardTime = 56,

        /// <summary>
        /// Enum NewZealandStandardTime for value: New Zealand Standard Time
        /// </summary>
        [EnumMember(Value = "New Zealand Standard Time")]
        NewZealandStandardTime = 57,

        /// <summary>
        /// Enum NewfoundlandStandardTime for value: Newfoundland Standard Time
        /// </summary>
        [EnumMember(Value = "Newfoundland Standard Time")]
        NewfoundlandStandardTime = 58,

        /// <summary>
        /// Enum NorthAsiaEastStandardTime for value: North Asia East Standard Time
        /// </summary>
        [EnumMember(Value = "North Asia East Standard Time")]
        NorthAsiaEastStandardTime = 59,

        /// <summary>
        /// Enum NorthAsiaStandardTime for value: North Asia Standard Time
        /// </summary>
        [EnumMember(Value = "North Asia Standard Time")]
        NorthAsiaStandardTime = 60,

        /// <summary>
        /// Enum PacificSAStandardTime for value: Pacific SA Standard Time
        /// </summary>
        [EnumMember(Value = "Pacific SA Standard Time")]
        PacificSAStandardTime = 61,

        /// <summary>
        /// Enum PacificStandardTime for value: Pacific Standard Time
        /// </summary>
        [EnumMember(Value = "Pacific Standard Time")]
        PacificStandardTime = 62,

        /// <summary>
        /// Enum PacificStandardTimeMexico for value: Pacific Standard Time (Mexico)
        /// </summary>
        [EnumMember(Value = "Pacific Standard Time (Mexico)")]
        PacificStandardTimeMexico = 63,

        /// <summary>
        /// Enum PakistanStandardTime for value: Pakistan Standard Time
        /// </summary>
        [EnumMember(Value = "Pakistan Standard Time")]
        PakistanStandardTime = 64,

        /// <summary>
        /// Enum RomanceStandardTime for value: Romance Standard Time
        /// </summary>
        [EnumMember(Value = "Romance Standard Time")]
        RomanceStandardTime = 65,

        /// <summary>
        /// Enum RussianStandardTime for value: Russian Standard Time
        /// </summary>
        [EnumMember(Value = "Russian Standard Time")]
        RussianStandardTime = 66,

        /// <summary>
        /// Enum SAEasternStandardTime for value: SA Eastern Standard Time
        /// </summary>
        [EnumMember(Value = "SA Eastern Standard Time")]
        SAEasternStandardTime = 67,

        /// <summary>
        /// Enum SAPacificStandardTime for value: SA Pacific Standard Time
        /// </summary>
        [EnumMember(Value = "SA Pacific Standard Time")]
        SAPacificStandardTime = 68,

        /// <summary>
        /// Enum SAWesternStandardTime for value: SA Western Standard Time
        /// </summary>
        [EnumMember(Value = "SA Western Standard Time")]
        SAWesternStandardTime = 69,

        /// <summary>
        /// Enum SamoaStandardTime for value: Samoa Standard Time
        /// </summary>
        [EnumMember(Value = "Samoa Standard Time")]
        SamoaStandardTime = 70,

        /// <summary>
        /// Enum SEAsiaStandardTime for value: SE Asia Standard Time
        /// </summary>
        [EnumMember(Value = "SE Asia Standard Time")]
        SEAsiaStandardTime = 71,

        /// <summary>
        /// Enum SingaporeStandardTime for value: Singapore Standard Time
        /// </summary>
        [EnumMember(Value = "Singapore Standard Time")]
        SingaporeStandardTime = 72,

        /// <summary>
        /// Enum SouthAfricaStandardTime for value: South Africa Standard Time
        /// </summary>
        [EnumMember(Value = "South Africa Standard Time")]
        SouthAfricaStandardTime = 73,

        /// <summary>
        /// Enum SriLankaStandardTime for value: Sri Lanka Standard Time
        /// </summary>
        [EnumMember(Value = "Sri Lanka Standard Time")]
        SriLankaStandardTime = 74,

        /// <summary>
        /// Enum TaipeiStandardTime for value: Taipei Standard Time
        /// </summary>
        [EnumMember(Value = "Taipei Standard Time")]
        TaipeiStandardTime = 75,

        /// <summary>
        /// Enum TasmaniaStandardTime for value: Tasmania Standard Time
        /// </summary>
        [EnumMember(Value = "Tasmania Standard Time")]
        TasmaniaStandardTime = 76,

        /// <summary>
        /// Enum TokyoStandardTime for value: Tokyo Standard Time
        /// </summary>
        [EnumMember(Value = "Tokyo Standard Time")]
        TokyoStandardTime = 77,

        /// <summary>
        /// Enum TongaStandardTime for value: Tonga Standard Time
        /// </summary>
        [EnumMember(Value = "Tonga Standard Time")]
        TongaStandardTime = 78,

        /// <summary>
        /// Enum USEasternStandardTime for value: US Eastern Standard Time
        /// </summary>
        [EnumMember(Value = "US Eastern Standard Time")]
        USEasternStandardTime = 79,

        /// <summary>
        /// Enum USMountainStandardTime for value: US Mountain Standard Time
        /// </summary>
        [EnumMember(Value = "US Mountain Standard Time")]
        USMountainStandardTime = 80,

        /// <summary>
        /// Enum UTC for value: UTC
        /// </summary>
        [EnumMember(Value = "UTC")]
        UTC = 81,

        /// <summary>
        /// Enum VenezuelaStandardTime for value: Venezuela Standard Time
        /// </summary>
        [EnumMember(Value = "Venezuela Standard Time")]
        VenezuelaStandardTime = 82,

        /// <summary>
        /// Enum VladivostokStandardTime for value: Vladivostok Standard Time
        /// </summary>
        [EnumMember(Value = "Vladivostok Standard Time")]
        VladivostokStandardTime = 83,

        /// <summary>
        /// Enum WAustraliaStandardTime for value: W. Australia Standard Time
        /// </summary>
        [EnumMember(Value = "W. Australia Standard Time")]
        WAustraliaStandardTime = 84,

        /// <summary>
        /// Enum WCentralAfricaStandardTime for value: W. Central Africa Standard Time
        /// </summary>
        [EnumMember(Value = "W. Central Africa Standard Time")]
        WCentralAfricaStandardTime = 85,

        /// <summary>
        /// Enum WEuropeStandardTime for value: W. Europe Standard Time
        /// </summary>
        [EnumMember(Value = "W. Europe Standard Time")]
        WEuropeStandardTime = 86,

        /// <summary>
        /// Enum WestAsiaStandardTime for value: West Asia Standard Time
        /// </summary>
        [EnumMember(Value = "West Asia Standard Time")]
        WestAsiaStandardTime = 87,

        /// <summary>
        /// Enum WestPacificStandardTime for value: West Pacific Standard Time
        /// </summary>
        [EnumMember(Value = "West Pacific Standard Time")]
        WestPacificStandardTime = 88,

        /// <summary>
        /// Enum YakutskStandardTime for value: Yakutsk Standard Time
        /// </summary>
        [EnumMember(Value = "Yakutsk Standard Time")]
        YakutskStandardTime = 89
    }

    /// <summary>
    /// Converts <see cref="EnumTimezone"/> to and from the JSON value
    /// </summary>
    public static class EnumTimezoneValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="EnumTimezone"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static EnumTimezone FromString(string value)
        {
            return FromStringOrDefault(value) ?? throw new NotImplementedException($"Could not convert value to type EnumTimezone: '{value}'");
        }

        /// <summary>
        /// Parses a given value to <see cref="EnumTimezone"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static EnumTimezone? FromStringOrDefault(string value)
        {
            if (value.Equals("Afghanistan Standard Time"))
                return EnumTimezone.AfghanistanStandardTime;

            if (value.Equals("Alaskan Standard Time"))
                return EnumTimezone.AlaskanStandardTime;

            if (value.Equals("Arab Standard Time"))
                return EnumTimezone.ArabStandardTime;

            if (value.Equals("Arabian Standard Time"))
                return EnumTimezone.ArabianStandardTime;

            if (value.Equals("Arabic Standard Time"))
                return EnumTimezone.ArabicStandardTime;

            if (value.Equals("Argentina Standard Time"))
                return EnumTimezone.ArgentinaStandardTime;

            if (value.Equals("Atlantic Standard Time"))
                return EnumTimezone.AtlanticStandardTime;

            if (value.Equals("AUS Central Standard Time"))
                return EnumTimezone.AUSCentralStandardTime;

            if (value.Equals("AUS Eastern Standard Time"))
                return EnumTimezone.AUSEasternStandardTime;

            if (value.Equals("Azerbaijan Standard Time"))
                return EnumTimezone.AzerbaijanStandardTime;

            if (value.Equals("Azores Standard Time"))
                return EnumTimezone.AzoresStandardTime;

            if (value.Equals("Canada Central Standard Time"))
                return EnumTimezone.CanadaCentralStandardTime;

            if (value.Equals("Cape Verde Standard Time"))
                return EnumTimezone.CapeVerdeStandardTime;

            if (value.Equals("Caucasus Standard Time"))
                return EnumTimezone.CaucasusStandardTime;

            if (value.Equals("Cen. Australia Standard Time"))
                return EnumTimezone.CenAustraliaStandardTime;

            if (value.Equals("Central America Standard Time"))
                return EnumTimezone.CentralAmericaStandardTime;

            if (value.Equals("Central Asia Standard Time"))
                return EnumTimezone.CentralAsiaStandardTime;

            if (value.Equals("Central Brazilian Standard Time"))
                return EnumTimezone.CentralBrazilianStandardTime;

            if (value.Equals("Central Europe Standard Time"))
                return EnumTimezone.CentralEuropeStandardTime;

            if (value.Equals("Central European Standard Time"))
                return EnumTimezone.CentralEuropeanStandardTime;

            if (value.Equals("Central Pacific Standard Time"))
                return EnumTimezone.CentralPacificStandardTime;

            if (value.Equals("Central Standard Time"))
                return EnumTimezone.CentralStandardTime;

            if (value.Equals("Central Standard Time (Mexico)"))
                return EnumTimezone.CentralStandardTimeMexico;

            if (value.Equals("China Standard Time"))
                return EnumTimezone.ChinaStandardTime;

            if (value.Equals("Dateline Standard Time"))
                return EnumTimezone.DatelineStandardTime;

            if (value.Equals("E. Africa Standard Time"))
                return EnumTimezone.EAfricaStandardTime;

            if (value.Equals("E. Australia Standard Time"))
                return EnumTimezone.EAustraliaStandardTime;

            if (value.Equals("E. Europe Standard Time"))
                return EnumTimezone.EEuropeStandardTime;

            if (value.Equals("E. South America Standard Time"))
                return EnumTimezone.ESouthAmericaStandardTime;

            if (value.Equals("Eastern Standard Time"))
                return EnumTimezone.EasternStandardTime;

            if (value.Equals("Egypt Standard Time"))
                return EnumTimezone.EgyptStandardTime;

            if (value.Equals("Ekaterinburg Standard Time"))
                return EnumTimezone.EkaterinburgStandardTime;

            if (value.Equals("Fiji Standard Time"))
                return EnumTimezone.FijiStandardTime;

            if (value.Equals("FLE Standard Time"))
                return EnumTimezone.FLEStandardTime;

            if (value.Equals("Georgian Standard Time"))
                return EnumTimezone.GeorgianStandardTime;

            if (value.Equals("GMT Standard Time"))
                return EnumTimezone.GMTStandardTime;

            if (value.Equals("Greenland Standard Time"))
                return EnumTimezone.GreenlandStandardTime;

            if (value.Equals("Greenwich Standard Time"))
                return EnumTimezone.GreenwichStandardTime;

            if (value.Equals("GTB Standard Time"))
                return EnumTimezone.GTBStandardTime;

            if (value.Equals("Hawaiian Standard Time"))
                return EnumTimezone.HawaiianStandardTime;

            if (value.Equals("India Standard Time"))
                return EnumTimezone.IndiaStandardTime;

            if (value.Equals("Iran Standard Time"))
                return EnumTimezone.IranStandardTime;

            if (value.Equals("Israel Standard Time"))
                return EnumTimezone.IsraelStandardTime;

            if (value.Equals("Jordan Standard Time"))
                return EnumTimezone.JordanStandardTime;

            if (value.Equals("Korea Standard Time"))
                return EnumTimezone.KoreaStandardTime;

            if (value.Equals("Mauritius Standard Time"))
                return EnumTimezone.MauritiusStandardTime;

            if (value.Equals("Mid-Atlantic Standard Time"))
                return EnumTimezone.MidAtlanticStandardTime;

            if (value.Equals("Middle East Standard Time"))
                return EnumTimezone.MiddleEastStandardTime;

            if (value.Equals("Montevideo Standard Time"))
                return EnumTimezone.MontevideoStandardTime;

            if (value.Equals("Morocco Standard Time"))
                return EnumTimezone.MoroccoStandardTime;

            if (value.Equals("Mountain Standard Time"))
                return EnumTimezone.MountainStandardTime;

            if (value.Equals("Mountain Standard Time (Mexico)"))
                return EnumTimezone.MountainStandardTimeMexico;

            if (value.Equals("Myanmar Standard Time"))
                return EnumTimezone.MyanmarStandardTime;

            if (value.Equals("N. Central Asia Standard Time"))
                return EnumTimezone.NCentralAsiaStandardTime;

            if (value.Equals("Namibia Standard Time"))
                return EnumTimezone.NamibiaStandardTime;

            if (value.Equals("Nepal Standard Time"))
                return EnumTimezone.NepalStandardTime;

            if (value.Equals("New Zealand Standard Time"))
                return EnumTimezone.NewZealandStandardTime;

            if (value.Equals("Newfoundland Standard Time"))
                return EnumTimezone.NewfoundlandStandardTime;

            if (value.Equals("North Asia East Standard Time"))
                return EnumTimezone.NorthAsiaEastStandardTime;

            if (value.Equals("North Asia Standard Time"))
                return EnumTimezone.NorthAsiaStandardTime;

            if (value.Equals("Pacific SA Standard Time"))
                return EnumTimezone.PacificSAStandardTime;

            if (value.Equals("Pacific Standard Time"))
                return EnumTimezone.PacificStandardTime;

            if (value.Equals("Pacific Standard Time (Mexico)"))
                return EnumTimezone.PacificStandardTimeMexico;

            if (value.Equals("Pakistan Standard Time"))
                return EnumTimezone.PakistanStandardTime;

            if (value.Equals("Romance Standard Time"))
                return EnumTimezone.RomanceStandardTime;

            if (value.Equals("Russian Standard Time"))
                return EnumTimezone.RussianStandardTime;

            if (value.Equals("SA Eastern Standard Time"))
                return EnumTimezone.SAEasternStandardTime;

            if (value.Equals("SA Pacific Standard Time"))
                return EnumTimezone.SAPacificStandardTime;

            if (value.Equals("SA Western Standard Time"))
                return EnumTimezone.SAWesternStandardTime;

            if (value.Equals("Samoa Standard Time"))
                return EnumTimezone.SamoaStandardTime;

            if (value.Equals("SE Asia Standard Time"))
                return EnumTimezone.SEAsiaStandardTime;

            if (value.Equals("Singapore Standard Time"))
                return EnumTimezone.SingaporeStandardTime;

            if (value.Equals("South Africa Standard Time"))
                return EnumTimezone.SouthAfricaStandardTime;

            if (value.Equals("Sri Lanka Standard Time"))
                return EnumTimezone.SriLankaStandardTime;

            if (value.Equals("Taipei Standard Time"))
                return EnumTimezone.TaipeiStandardTime;

            if (value.Equals("Tasmania Standard Time"))
                return EnumTimezone.TasmaniaStandardTime;

            if (value.Equals("Tokyo Standard Time"))
                return EnumTimezone.TokyoStandardTime;

            if (value.Equals("Tonga Standard Time"))
                return EnumTimezone.TongaStandardTime;

            if (value.Equals("US Eastern Standard Time"))
                return EnumTimezone.USEasternStandardTime;

            if (value.Equals("US Mountain Standard Time"))
                return EnumTimezone.USMountainStandardTime;

            if (value.Equals("UTC"))
                return EnumTimezone.UTC;

            if (value.Equals("Venezuela Standard Time"))
                return EnumTimezone.VenezuelaStandardTime;

            if (value.Equals("Vladivostok Standard Time"))
                return EnumTimezone.VladivostokStandardTime;

            if (value.Equals("W. Australia Standard Time"))
                return EnumTimezone.WAustraliaStandardTime;

            if (value.Equals("W. Central Africa Standard Time"))
                return EnumTimezone.WCentralAfricaStandardTime;

            if (value.Equals("W. Europe Standard Time"))
                return EnumTimezone.WEuropeStandardTime;

            if (value.Equals("West Asia Standard Time"))
                return EnumTimezone.WestAsiaStandardTime;

            if (value.Equals("West Pacific Standard Time"))
                return EnumTimezone.WestPacificStandardTime;

            if (value.Equals("Yakutsk Standard Time"))
                return EnumTimezone.YakutskStandardTime;

            return null;
        }
    }

}
