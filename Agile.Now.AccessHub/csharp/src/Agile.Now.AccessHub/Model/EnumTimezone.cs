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
        /// Enum (GMT+04:30) Kabul for value: Afghanistan Standard Time
        /// </summary>
        [EnumMember(Value = "Afghanistan Standard Time")]
        Gmt0430Kabul = 1,

        /// <summary>
        /// Enum (GMT-09:00) Alaska for value: Alaskan Standard Time
        /// </summary>
        [EnumMember(Value = "Alaskan Standard Time")]
        Gmt0900Alaska = 2,

        /// <summary>
        /// Enum (GMT+03:00) Kuwait, Riyadh for value: Arab Standard Time
        /// </summary>
        [EnumMember(Value = "Arab Standard Time")]
        Gmt0300KuwaitRiyadh = 3,

        /// <summary>
        /// Enum (GMT+04:00) Abu Dhabi, Muscat for value: Arabian Standard Time
        /// </summary>
        [EnumMember(Value = "Arabian Standard Time")]
        Gmt0400AbuDhabiMuscat = 4,

        /// <summary>
        /// Enum (GMT+03:00) Baghdad for value: Arabic Standard Time
        /// </summary>
        [EnumMember(Value = "Arabic Standard Time")]
        Gmt0300Baghdad = 5,

        /// <summary>
        /// Enum (GMT-03:00) Buenos Aires for value: Argentina Standard Time
        /// </summary>
        [EnumMember(Value = "Argentina Standard Time")]
        Gmt0300BuenosAires = 6,

        /// <summary>
        /// Enum (GMT-04:00) Atlantic Time (Canada) for value: Atlantic Standard Time
        /// </summary>
        [EnumMember(Value = "Atlantic Standard Time")]
        Gmt0400AtlanticTimeCanada = 7,

        /// <summary>
        /// Enum (GMT+09:30) Darwin for value: AUS Central Standard Time
        /// </summary>
        [EnumMember(Value = "AUS Central Standard Time")]
        Gmt0930Darwin = 8,

        /// <summary>
        /// Enum (GMT+10:00) Canberra, Melbourne, Sydney for value: AUS Eastern Standard Time
        /// </summary>
        [EnumMember(Value = "AUS Eastern Standard Time")]
        Gmt1000CanberraMelbourneSydney = 9,

        /// <summary>
        /// Enum (GMT+04:00) Baku for value: Azerbaijan Standard Time
        /// </summary>
        [EnumMember(Value = "Azerbaijan Standard Time")]
        Gmt0400Baku = 10,

        /// <summary>
        /// Enum (GMT-01:00) Azores for value: Azores Standard Time
        /// </summary>
        [EnumMember(Value = "Azores Standard Time")]
        Gmt0100Azores = 11,

        /// <summary>
        /// Enum (GMT-06:00) Saskatchewan for value: Canada Central Standard Time
        /// </summary>
        [EnumMember(Value = "Canada Central Standard Time")]
        Gmt0600Saskatchewan = 12,

        /// <summary>
        /// Enum (GMT-01:00) Cape Verde Is. for value: Cape Verde Standard Time
        /// </summary>
        [EnumMember(Value = "Cape Verde Standard Time")]
        Gmt0100CapeVerdeIs = 13,

        /// <summary>
        /// Enum (GMT+04:00) Yerevan for value: Caucasus Standard Time
        /// </summary>
        [EnumMember(Value = "Caucasus Standard Time")]
        Gmt0400Yerevan = 14,

        /// <summary>
        /// Enum (GMT+09:30) Adelaide for value: Cen. Australia Standard Time
        /// </summary>
        [EnumMember(Value = "Cen. Australia Standard Time")]
        Gmt0930Adelaide = 15,

        /// <summary>
        /// Enum (GMT-06:00) Central America for value: Central America Standard Time
        /// </summary>
        [EnumMember(Value = "Central America Standard Time")]
        Gmt0600CentralAmerica = 16,

        /// <summary>
        /// Enum (GMT+06:00) Astana, Dhaka for value: Central Asia Standard Time
        /// </summary>
        [EnumMember(Value = "Central Asia Standard Time")]
        Gmt0600AstanaDhaka = 17,

        /// <summary>
        /// Enum (GMT-04:00) Manaus for value: Central Brazilian Standard Time
        /// </summary>
        [EnumMember(Value = "Central Brazilian Standard Time")]
        Gmt0400Manaus = 18,

        /// <summary>
        /// Enum (GMT+01:00) Belgrade, Bratislava, Budapest, Ljubljana, Prague for value: Central Europe Standard Time
        /// </summary>
        [EnumMember(Value = "Central Europe Standard Time")]
        Gmt0100BelgradeBratislavaBudapestLjubljanaPrague = 19,

        /// <summary>
        /// Enum (GMT+01:00) Sarajevo, Skopje, Warsaw, Zagreb for value: Central European Standard Time
        /// </summary>
        [EnumMember(Value = "Central European Standard Time")]
        Gmt0100SarajevoSkopjeWarsawZagreb = 20,

        /// <summary>
        /// Enum (GMT+11:00) Magadan, Solomon Is., New Caledonia for value: Central Pacific Standard Time
        /// </summary>
        [EnumMember(Value = "Central Pacific Standard Time")]
        Gmt1100MagadanSolomonIsNewCaledonia = 21,

        /// <summary>
        /// Enum (GMT-06:00) Central Time (US &amp; Canada) for value: Central Standard Time
        /// </summary>
        [EnumMember(Value = "Central Standard Time")]
        Gmt0600CentralTimeUsCanada = 22,

        /// <summary>
        /// Enum (GMT-06:00) Guadalajara, Mexico City, Monterrey for value: Central Standard Time (Mexico)
        /// </summary>
        [EnumMember(Value = "Central Standard Time (Mexico)")]
        Gmt0600GuadalajaraMexicoCityMonterrey = 23,

        /// <summary>
        /// Enum (GMT+08:00) Beijing, Chongqing, Hong Kong, Urumqi for value: China Standard Time
        /// </summary>
        [EnumMember(Value = "China Standard Time")]
        Gmt0800BeijingChongqingHongKongUrumqi = 24,

        /// <summary>
        /// Enum (GMT-12:00) International Date Line West for value: Dateline Standard Time
        /// </summary>
        [EnumMember(Value = "Dateline Standard Time")]
        Gmt1200InternationalDateLineWest = 25,

        /// <summary>
        /// Enum (GMT+03:00) Nairobi for value: E. Africa Standard Time
        /// </summary>
        [EnumMember(Value = "E. Africa Standard Time")]
        Gmt0300Nairobi = 26,

        /// <summary>
        /// Enum (GMT+10:00) Brisbane for value: E. Australia Standard Time
        /// </summary>
        [EnumMember(Value = "E. Australia Standard Time")]
        Gmt1000Brisbane = 27,

        /// <summary>
        /// Enum (GMT+02:00) Minsk for value: E. Europe Standard Time
        /// </summary>
        [EnumMember(Value = "E. Europe Standard Time")]
        Gmt0200Minsk = 28,

        /// <summary>
        /// Enum (GMT-03:00) Brasilia for value: E. South America Standard Time
        /// </summary>
        [EnumMember(Value = "E. South America Standard Time")]
        Gmt0300Brasilia = 29,

        /// <summary>
        /// Enum (GMT-05:00) Eastern Time (US &amp; Canada) for value: Eastern Standard Time
        /// </summary>
        [EnumMember(Value = "Eastern Standard Time")]
        Gmt0500EasternTimeUsCanada = 30,

        /// <summary>
        /// Enum (GMT+02:00) Cairo for value: Egypt Standard Time
        /// </summary>
        [EnumMember(Value = "Egypt Standard Time")]
        Gmt0200Cairo = 31,

        /// <summary>
        /// Enum (GMT+05:00) Ekaterinburg for value: Ekaterinburg Standard Time
        /// </summary>
        [EnumMember(Value = "Ekaterinburg Standard Time")]
        Gmt0500Ekaterinburg = 32,

        /// <summary>
        /// Enum (GMT+12:00) Fiji, Kamchatka, Marshall Is. for value: Fiji Standard Time
        /// </summary>
        [EnumMember(Value = "Fiji Standard Time")]
        Gmt1200FijiKamchatkaMarshallIs = 33,

        /// <summary>
        /// Enum (GMT+02:00) Helsinki, Kyiv, Riga, Sofia, Tallinn, Vilnius for value: FLE Standard Time
        /// </summary>
        [EnumMember(Value = "FLE Standard Time")]
        Gmt0200HelsinkiKyivRigaSofiaTallinnVilnius = 34,

        /// <summary>
        /// Enum (GMT+03:00) Tbilisi for value: Georgian Standard Time
        /// </summary>
        [EnumMember(Value = "Georgian Standard Time")]
        Gmt0300Tbilisi = 35,

        /// <summary>
        /// Enum (GMT) Greenwich Mean Time : Dublin, Edinburgh, Lisbon, London for value: GMT Standard Time
        /// </summary>
        [EnumMember(Value = "GMT Standard Time")]
        GmtGreenwichMeanTimeDublinEdinburghLisbonLondon = 36,

        /// <summary>
        /// Enum (GMT-03:00) Greenland for value: Greenland Standard Time
        /// </summary>
        [EnumMember(Value = "Greenland Standard Time")]
        Gmt0300Greenland = 37,

        /// <summary>
        /// Enum (GMT) Monrovia, Reykjavik for value: Greenwich Standard Time
        /// </summary>
        [EnumMember(Value = "Greenwich Standard Time")]
        GmtMonroviaReykjavik = 38,

        /// <summary>
        /// Enum (GMT+02:00) Athens, Bucharest, Istanbul for value: GTB Standard Time
        /// </summary>
        [EnumMember(Value = "GTB Standard Time")]
        Gmt0200AthensBucharestIstanbul = 39,

        /// <summary>
        /// Enum (GMT-10:00) Hawaii for value: Hawaiian Standard Time
        /// </summary>
        [EnumMember(Value = "Hawaiian Standard Time")]
        Gmt1000Hawaii = 40,

        /// <summary>
        /// Enum (GMT+05:30) Chennai, Kolkata, Mumbai, New Delhi for value: India Standard Time
        /// </summary>
        [EnumMember(Value = "India Standard Time")]
        Gmt0530ChennaiKolkataMumbaiNewDelhi = 41,

        /// <summary>
        /// Enum (GMT+03:30) Tehran for value: Iran Standard Time
        /// </summary>
        [EnumMember(Value = "Iran Standard Time")]
        Gmt0330Tehran = 42,

        /// <summary>
        /// Enum (GMT+02:00) Jerusalem for value: Israel Standard Time
        /// </summary>
        [EnumMember(Value = "Israel Standard Time")]
        Gmt0200Jerusalem = 43,

        /// <summary>
        /// Enum (GMT+02:00) Amman for value: Jordan Standard Time
        /// </summary>
        [EnumMember(Value = "Jordan Standard Time")]
        Gmt0200Amman = 44,

        /// <summary>
        /// Enum (GMT+09:00) Seoul for value: Korea Standard Time
        /// </summary>
        [EnumMember(Value = "Korea Standard Time")]
        Gmt0900Seoul = 45,

        /// <summary>
        /// Enum (GMT+04:00) Port Louis for value: Mauritius Standard Time
        /// </summary>
        [EnumMember(Value = "Mauritius Standard Time")]
        Gmt0400PortLouis = 46,

        /// <summary>
        /// Enum (GMT-02:00) Mid-Atlantic for value: Mid-Atlantic Standard Time
        /// </summary>
        [EnumMember(Value = "Mid-Atlantic Standard Time")]
        Gmt0200MidAtlantic = 47,

        /// <summary>
        /// Enum (GMT+02:00) Beirut for value: Middle East Standard Time
        /// </summary>
        [EnumMember(Value = "Middle East Standard Time")]
        Gmt0200Beirut = 48,

        /// <summary>
        /// Enum (GMT-03:00) Montevideo for value: Montevideo Standard Time
        /// </summary>
        [EnumMember(Value = "Montevideo Standard Time")]
        Gmt0300Montevideo = 49,

        /// <summary>
        /// Enum (GMT) Casablanca for value: Morocco Standard Time
        /// </summary>
        [EnumMember(Value = "Morocco Standard Time")]
        GmtCasablanca = 50,

        /// <summary>
        /// Enum (GMT-07:00) Mountain Time (US &amp; Canada) for value: Mountain Standard Time
        /// </summary>
        [EnumMember(Value = "Mountain Standard Time")]
        Gmt0700MountainTimeUsCanada = 51,

        /// <summary>
        /// Enum (GMT-07:00) Chihuahua, La Paz, Mazatlan for value: Mountain Standard Time (Mexico)
        /// </summary>
        [EnumMember(Value = "Mountain Standard Time (Mexico)")]
        Gmt0700ChihuahuaLaPazMazatlan = 52,

        /// <summary>
        /// Enum (GMT+06:30) Yangon (Rangoon) for value: Myanmar Standard Time
        /// </summary>
        [EnumMember(Value = "Myanmar Standard Time")]
        Gmt0630YangonRangoon = 53,

        /// <summary>
        /// Enum (GMT+06:00) Almaty, Novosibirsk for value: N. Central Asia Standard Time
        /// </summary>
        [EnumMember(Value = "N. Central Asia Standard Time")]
        Gmt0600AlmatyNovosibirsk = 54,

        /// <summary>
        /// Enum (GMT+02:00) Windhoek for value: Namibia Standard Time
        /// </summary>
        [EnumMember(Value = "Namibia Standard Time")]
        Gmt0200Windhoek = 55,

        /// <summary>
        /// Enum (GMT+05:45) Kathmandu for value: Nepal Standard Time
        /// </summary>
        [EnumMember(Value = "Nepal Standard Time")]
        Gmt0545Kathmandu = 56,

        /// <summary>
        /// Enum (GMT+12:00) Auckland, Wellington for value: New Zealand Standard Time
        /// </summary>
        [EnumMember(Value = "New Zealand Standard Time")]
        Gmt1200AucklandWellington = 57,

        /// <summary>
        /// Enum (GMT-03:30) Newfoundland for value: Newfoundland Standard Time
        /// </summary>
        [EnumMember(Value = "Newfoundland Standard Time")]
        Gmt0330Newfoundland = 58,

        /// <summary>
        /// Enum (GMT+08:00) Irkutsk, Ulaan Bataar for value: North Asia East Standard Time
        /// </summary>
        [EnumMember(Value = "North Asia East Standard Time")]
        Gmt0800IrkutskUlaanBataar = 59,

        /// <summary>
        /// Enum (GMT+07:00) Krasnoyarsk for value: North Asia Standard Time
        /// </summary>
        [EnumMember(Value = "North Asia Standard Time")]
        Gmt0700Krasnoyarsk = 60,

        /// <summary>
        /// Enum (GMT-04:00) Santiago for value: Pacific SA Standard Time
        /// </summary>
        [EnumMember(Value = "Pacific SA Standard Time")]
        Gmt0400Santiago = 61,

        /// <summary>
        /// Enum (GMT-08:00) Pacific Time (US &amp; Canada) for value: Pacific Standard Time
        /// </summary>
        [EnumMember(Value = "Pacific Standard Time")]
        Gmt0800PacificTimeUsCanada = 62,

        /// <summary>
        /// Enum (GMT-08:00) Tijuana, Baja California for value: Pacific Standard Time (Mexico)
        /// </summary>
        [EnumMember(Value = "Pacific Standard Time (Mexico)")]
        Gmt0800TijuanaBajaCalifornia = 63,

        /// <summary>
        /// Enum (GMT+05:00) Islamabad, Karachi for value: Pakistan Standard Time
        /// </summary>
        [EnumMember(Value = "Pakistan Standard Time")]
        Gmt0500IslamabadKarachi = 64,

        /// <summary>
        /// Enum (GMT+01:00) Brussels, Copenhagen, Madrid, Paris for value: Romance Standard Time
        /// </summary>
        [EnumMember(Value = "Romance Standard Time")]
        Gmt0100BrusselsCopenhagenMadridParis = 65,

        /// <summary>
        /// Enum (GMT+03:00) Moscow, St. Petersburg, Volgograd for value: Russian Standard Time
        /// </summary>
        [EnumMember(Value = "Russian Standard Time")]
        Gmt0300MoscowStPetersburgVolgograd = 66,

        /// <summary>
        /// Enum (GMT-03:00) Georgetown for value: SA Eastern Standard Time
        /// </summary>
        [EnumMember(Value = "SA Eastern Standard Time")]
        Gmt0300Georgetown = 67,

        /// <summary>
        /// Enum (GMT-05:00) Bogota, Lima, Quito, Rio Branco for value: SA Pacific Standard Time
        /// </summary>
        [EnumMember(Value = "SA Pacific Standard Time")]
        Gmt0500BogotaLimaQuitoRioBranco = 68,

        /// <summary>
        /// Enum (GMT-04:00) La Paz for value: SA Western Standard Time
        /// </summary>
        [EnumMember(Value = "SA Western Standard Time")]
        Gmt0400LaPaz = 69,

        /// <summary>
        /// Enum (GMT-11:00) Midway Island, Samoa for value: Samoa Standard Time
        /// </summary>
        [EnumMember(Value = "Samoa Standard Time")]
        Gmt1100MidwayIslandSamoa = 70,

        /// <summary>
        /// Enum (GMT+07:00) Bangkok, Hanoi, Jakarta for value: SE Asia Standard Time
        /// </summary>
        [EnumMember(Value = "SE Asia Standard Time")]
        Gmt0700BangkokHanoiJakarta = 71,

        /// <summary>
        /// Enum (GMT+08:00) Kuala Lumpur, Singapore for value: Singapore Standard Time
        /// </summary>
        [EnumMember(Value = "Singapore Standard Time")]
        Gmt0800KualaLumpurSingapore = 72,

        /// <summary>
        /// Enum (GMT+02:00) Harare, Pretoria for value: South Africa Standard Time
        /// </summary>
        [EnumMember(Value = "South Africa Standard Time")]
        Gmt0200HararePretoria = 73,

        /// <summary>
        /// Enum (GMT+05:30) Sri Jayawardenepura for value: Sri Lanka Standard Time
        /// </summary>
        [EnumMember(Value = "Sri Lanka Standard Time")]
        Gmt0530SriJayawardenepura = 74,

        /// <summary>
        /// Enum (GMT+08:00) Taipei for value: Taipei Standard Time
        /// </summary>
        [EnumMember(Value = "Taipei Standard Time")]
        Gmt0800Taipei = 75,

        /// <summary>
        /// Enum (GMT+10:00) Hobart for value: Tasmania Standard Time
        /// </summary>
        [EnumMember(Value = "Tasmania Standard Time")]
        Gmt1000Hobart = 76,

        /// <summary>
        /// Enum (GMT+09:00) Osaka, Sapporo, Tokyo for value: Tokyo Standard Time
        /// </summary>
        [EnumMember(Value = "Tokyo Standard Time")]
        Gmt0900OsakaSapporoTokyo = 77,

        /// <summary>
        /// Enum (GMT+13:00) Nuku&#39;alofa for value: Tonga Standard Time
        /// </summary>
        [EnumMember(Value = "Tonga Standard Time")]
        Gmt1300NukuAlofa = 78,

        /// <summary>
        /// Enum (GMT-05:00) Indiana (East) for value: US Eastern Standard Time
        /// </summary>
        [EnumMember(Value = "US Eastern Standard Time")]
        Gmt0500IndianaEast = 79,

        /// <summary>
        /// Enum (GMT-07:00) Arizona for value: US Mountain Standard Time
        /// </summary>
        [EnumMember(Value = "US Mountain Standard Time")]
        Gmt0700Arizona = 80,

        /// <summary>
        /// Enum UTC for value: UTC
        /// </summary>
        [EnumMember(Value = "UTC")]
        Utc = 81,

        /// <summary>
        /// Enum (GMT-04:30) Caracas for value: Venezuela Standard Time
        /// </summary>
        [EnumMember(Value = "Venezuela Standard Time")]
        Gmt0430Caracas = 82,

        /// <summary>
        /// Enum (GMT+10:00) Vladivostok for value: Vladivostok Standard Time
        /// </summary>
        [EnumMember(Value = "Vladivostok Standard Time")]
        Gmt1000Vladivostok = 83,

        /// <summary>
        /// Enum (GMT+08:00) Perth for value: W. Australia Standard Time
        /// </summary>
        [EnumMember(Value = "W. Australia Standard Time")]
        Gmt0800Perth = 84,

        /// <summary>
        /// Enum (GMT+01:00) West Central Africa for value: W. Central Africa Standard Time
        /// </summary>
        [EnumMember(Value = "W. Central Africa Standard Time")]
        Gmt0100WestCentralAfrica = 85,

        /// <summary>
        /// Enum (GMT+01:00) Amsterdam, Berlin, Bern, Rome, Stockholm, Vienna for value: W. Europe Standard Time
        /// </summary>
        [EnumMember(Value = "W. Europe Standard Time")]
        Gmt0100AmsterdamBerlinBernRomeStockholmVienna = 86,

        /// <summary>
        /// Enum (GMT+05:00) Tashkent for value: West Asia Standard Time
        /// </summary>
        [EnumMember(Value = "West Asia Standard Time")]
        Gmt0500Tashkent = 87,

        /// <summary>
        /// Enum (GMT+10:00) Guam, Port Moresby for value: West Pacific Standard Time
        /// </summary>
        [EnumMember(Value = "West Pacific Standard Time")]
        Gmt1000GuamPortMoresby = 88,

        /// <summary>
        /// Enum (GMT+09:00) Yakutsk for value: Yakutsk Standard Time
        /// </summary>
        [EnumMember(Value = "Yakutsk Standard Time")]
        Gmt0900Yakutsk = 89
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
                return EnumTimezone.Gmt0430Kabul;

            if (value.Equals("Alaskan Standard Time"))
                return EnumTimezone.Gmt0900Alaska;

            if (value.Equals("Arab Standard Time"))
                return EnumTimezone.Gmt0300KuwaitRiyadh;

            if (value.Equals("Arabian Standard Time"))
                return EnumTimezone.Gmt0400AbuDhabiMuscat;

            if (value.Equals("Arabic Standard Time"))
                return EnumTimezone.Gmt0300Baghdad;

            if (value.Equals("Argentina Standard Time"))
                return EnumTimezone.Gmt0300BuenosAires;

            if (value.Equals("Atlantic Standard Time"))
                return EnumTimezone.Gmt0400AtlanticTimeCanada;

            if (value.Equals("AUS Central Standard Time"))
                return EnumTimezone.Gmt0930Darwin;

            if (value.Equals("AUS Eastern Standard Time"))
                return EnumTimezone.Gmt1000CanberraMelbourneSydney;

            if (value.Equals("Azerbaijan Standard Time"))
                return EnumTimezone.Gmt0400Baku;

            if (value.Equals("Azores Standard Time"))
                return EnumTimezone.Gmt0100Azores;

            if (value.Equals("Canada Central Standard Time"))
                return EnumTimezone.Gmt0600Saskatchewan;

            if (value.Equals("Cape Verde Standard Time"))
                return EnumTimezone.Gmt0100CapeVerdeIs;

            if (value.Equals("Caucasus Standard Time"))
                return EnumTimezone.Gmt0400Yerevan;

            if (value.Equals("Cen. Australia Standard Time"))
                return EnumTimezone.Gmt0930Adelaide;

            if (value.Equals("Central America Standard Time"))
                return EnumTimezone.Gmt0600CentralAmerica;

            if (value.Equals("Central Asia Standard Time"))
                return EnumTimezone.Gmt0600AstanaDhaka;

            if (value.Equals("Central Brazilian Standard Time"))
                return EnumTimezone.Gmt0400Manaus;

            if (value.Equals("Central Europe Standard Time"))
                return EnumTimezone.Gmt0100BelgradeBratislavaBudapestLjubljanaPrague;

            if (value.Equals("Central European Standard Time"))
                return EnumTimezone.Gmt0100SarajevoSkopjeWarsawZagreb;

            if (value.Equals("Central Pacific Standard Time"))
                return EnumTimezone.Gmt1100MagadanSolomonIsNewCaledonia;

            if (value.Equals("Central Standard Time"))
                return EnumTimezone.Gmt0600CentralTimeUsCanada;

            if (value.Equals("Central Standard Time (Mexico)"))
                return EnumTimezone.Gmt0600GuadalajaraMexicoCityMonterrey;

            if (value.Equals("China Standard Time"))
                return EnumTimezone.Gmt0800BeijingChongqingHongKongUrumqi;

            if (value.Equals("Dateline Standard Time"))
                return EnumTimezone.Gmt1200InternationalDateLineWest;

            if (value.Equals("E. Africa Standard Time"))
                return EnumTimezone.Gmt0300Nairobi;

            if (value.Equals("E. Australia Standard Time"))
                return EnumTimezone.Gmt1000Brisbane;

            if (value.Equals("E. Europe Standard Time"))
                return EnumTimezone.Gmt0200Minsk;

            if (value.Equals("E. South America Standard Time"))
                return EnumTimezone.Gmt0300Brasilia;

            if (value.Equals("Eastern Standard Time"))
                return EnumTimezone.Gmt0500EasternTimeUsCanada;

            if (value.Equals("Egypt Standard Time"))
                return EnumTimezone.Gmt0200Cairo;

            if (value.Equals("Ekaterinburg Standard Time"))
                return EnumTimezone.Gmt0500Ekaterinburg;

            if (value.Equals("Fiji Standard Time"))
                return EnumTimezone.Gmt1200FijiKamchatkaMarshallIs;

            if (value.Equals("FLE Standard Time"))
                return EnumTimezone.Gmt0200HelsinkiKyivRigaSofiaTallinnVilnius;

            if (value.Equals("Georgian Standard Time"))
                return EnumTimezone.Gmt0300Tbilisi;

            if (value.Equals("GMT Standard Time"))
                return EnumTimezone.GmtGreenwichMeanTimeDublinEdinburghLisbonLondon;

            if (value.Equals("Greenland Standard Time"))
                return EnumTimezone.Gmt0300Greenland;

            if (value.Equals("Greenwich Standard Time"))
                return EnumTimezone.GmtMonroviaReykjavik;

            if (value.Equals("GTB Standard Time"))
                return EnumTimezone.Gmt0200AthensBucharestIstanbul;

            if (value.Equals("Hawaiian Standard Time"))
                return EnumTimezone.Gmt1000Hawaii;

            if (value.Equals("India Standard Time"))
                return EnumTimezone.Gmt0530ChennaiKolkataMumbaiNewDelhi;

            if (value.Equals("Iran Standard Time"))
                return EnumTimezone.Gmt0330Tehran;

            if (value.Equals("Israel Standard Time"))
                return EnumTimezone.Gmt0200Jerusalem;

            if (value.Equals("Jordan Standard Time"))
                return EnumTimezone.Gmt0200Amman;

            if (value.Equals("Korea Standard Time"))
                return EnumTimezone.Gmt0900Seoul;

            if (value.Equals("Mauritius Standard Time"))
                return EnumTimezone.Gmt0400PortLouis;

            if (value.Equals("Mid-Atlantic Standard Time"))
                return EnumTimezone.Gmt0200MidAtlantic;

            if (value.Equals("Middle East Standard Time"))
                return EnumTimezone.Gmt0200Beirut;

            if (value.Equals("Montevideo Standard Time"))
                return EnumTimezone.Gmt0300Montevideo;

            if (value.Equals("Morocco Standard Time"))
                return EnumTimezone.GmtCasablanca;

            if (value.Equals("Mountain Standard Time"))
                return EnumTimezone.Gmt0700MountainTimeUsCanada;

            if (value.Equals("Mountain Standard Time (Mexico)"))
                return EnumTimezone.Gmt0700ChihuahuaLaPazMazatlan;

            if (value.Equals("Myanmar Standard Time"))
                return EnumTimezone.Gmt0630YangonRangoon;

            if (value.Equals("N. Central Asia Standard Time"))
                return EnumTimezone.Gmt0600AlmatyNovosibirsk;

            if (value.Equals("Namibia Standard Time"))
                return EnumTimezone.Gmt0200Windhoek;

            if (value.Equals("Nepal Standard Time"))
                return EnumTimezone.Gmt0545Kathmandu;

            if (value.Equals("New Zealand Standard Time"))
                return EnumTimezone.Gmt1200AucklandWellington;

            if (value.Equals("Newfoundland Standard Time"))
                return EnumTimezone.Gmt0330Newfoundland;

            if (value.Equals("North Asia East Standard Time"))
                return EnumTimezone.Gmt0800IrkutskUlaanBataar;

            if (value.Equals("North Asia Standard Time"))
                return EnumTimezone.Gmt0700Krasnoyarsk;

            if (value.Equals("Pacific SA Standard Time"))
                return EnumTimezone.Gmt0400Santiago;

            if (value.Equals("Pacific Standard Time"))
                return EnumTimezone.Gmt0800PacificTimeUsCanada;

            if (value.Equals("Pacific Standard Time (Mexico)"))
                return EnumTimezone.Gmt0800TijuanaBajaCalifornia;

            if (value.Equals("Pakistan Standard Time"))
                return EnumTimezone.Gmt0500IslamabadKarachi;

            if (value.Equals("Romance Standard Time"))
                return EnumTimezone.Gmt0100BrusselsCopenhagenMadridParis;

            if (value.Equals("Russian Standard Time"))
                return EnumTimezone.Gmt0300MoscowStPetersburgVolgograd;

            if (value.Equals("SA Eastern Standard Time"))
                return EnumTimezone.Gmt0300Georgetown;

            if (value.Equals("SA Pacific Standard Time"))
                return EnumTimezone.Gmt0500BogotaLimaQuitoRioBranco;

            if (value.Equals("SA Western Standard Time"))
                return EnumTimezone.Gmt0400LaPaz;

            if (value.Equals("Samoa Standard Time"))
                return EnumTimezone.Gmt1100MidwayIslandSamoa;

            if (value.Equals("SE Asia Standard Time"))
                return EnumTimezone.Gmt0700BangkokHanoiJakarta;

            if (value.Equals("Singapore Standard Time"))
                return EnumTimezone.Gmt0800KualaLumpurSingapore;

            if (value.Equals("South Africa Standard Time"))
                return EnumTimezone.Gmt0200HararePretoria;

            if (value.Equals("Sri Lanka Standard Time"))
                return EnumTimezone.Gmt0530SriJayawardenepura;

            if (value.Equals("Taipei Standard Time"))
                return EnumTimezone.Gmt0800Taipei;

            if (value.Equals("Tasmania Standard Time"))
                return EnumTimezone.Gmt1000Hobart;

            if (value.Equals("Tokyo Standard Time"))
                return EnumTimezone.Gmt0900OsakaSapporoTokyo;

            if (value.Equals("Tonga Standard Time"))
                return EnumTimezone.Gmt1300NukuAlofa;

            if (value.Equals("US Eastern Standard Time"))
                return EnumTimezone.Gmt0500IndianaEast;

            if (value.Equals("US Mountain Standard Time"))
                return EnumTimezone.Gmt0700Arizona;

            if (value.Equals("UTC"))
                return EnumTimezone.Utc;

            if (value.Equals("Venezuela Standard Time"))
                return EnumTimezone.Gmt0430Caracas;

            if (value.Equals("Vladivostok Standard Time"))
                return EnumTimezone.Gmt1000Vladivostok;

            if (value.Equals("W. Australia Standard Time"))
                return EnumTimezone.Gmt0800Perth;

            if (value.Equals("W. Central Africa Standard Time"))
                return EnumTimezone.Gmt0100WestCentralAfrica;

            if (value.Equals("W. Europe Standard Time"))
                return EnumTimezone.Gmt0100AmsterdamBerlinBernRomeStockholmVienna;

            if (value.Equals("West Asia Standard Time"))
                return EnumTimezone.Gmt0500Tashkent;

            if (value.Equals("West Pacific Standard Time"))
                return EnumTimezone.Gmt1000GuamPortMoresby;

            if (value.Equals("Yakutsk Standard Time"))
                return EnumTimezone.Gmt0900Yakutsk;

            return null;
        }
    }

}
