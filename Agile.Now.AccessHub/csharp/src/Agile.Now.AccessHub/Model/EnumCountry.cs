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
    /// The enum of Country.
    /// </summary>
    /// <value>The enum of Country.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EnumCountry
    {
        /// <summary>
        /// Enum Afghanistan for value: AFG
        /// </summary>
        [EnumMember(Value = "AFG")]
        Afghanistan = 1,

        /// <summary>
        /// Enum Aland Islands for value: ALA
        /// </summary>
        [EnumMember(Value = "ALA")]
        AlandIslands = 2,

        /// <summary>
        /// Enum Albania for value: ALB
        /// </summary>
        [EnumMember(Value = "ALB")]
        Albania = 3,

        /// <summary>
        /// Enum Algeria for value: DZA
        /// </summary>
        [EnumMember(Value = "DZA")]
        Algeria = 4,

        /// <summary>
        /// Enum American Samoa for value: ASM
        /// </summary>
        [EnumMember(Value = "ASM")]
        AmericanSamoa = 5,

        /// <summary>
        /// Enum Andorra for value: AND
        /// </summary>
        [EnumMember(Value = "AND")]
        Andorra = 6,

        /// <summary>
        /// Enum Angola for value: AGO
        /// </summary>
        [EnumMember(Value = "AGO")]
        Angola = 7,

        /// <summary>
        /// Enum Anguilla for value: AIA
        /// </summary>
        [EnumMember(Value = "AIA")]
        Anguilla = 8,

        /// <summary>
        /// Enum Antarctica for value: ATA
        /// </summary>
        [EnumMember(Value = "ATA")]
        Antarctica = 9,

        /// <summary>
        /// Enum Antigua and Barbuda for value: ATG
        /// </summary>
        [EnumMember(Value = "ATG")]
        AntiguaAndBarbuda = 10,

        /// <summary>
        /// Enum Argentina for value: ARG
        /// </summary>
        [EnumMember(Value = "ARG")]
        Argentina = 11,

        /// <summary>
        /// Enum Armenia for value: ARM
        /// </summary>
        [EnumMember(Value = "ARM")]
        Armenia = 12,

        /// <summary>
        /// Enum Aruba for value: ABW
        /// </summary>
        [EnumMember(Value = "ABW")]
        Aruba = 13,

        /// <summary>
        /// Enum Australia for value: AUS
        /// </summary>
        [EnumMember(Value = "AUS")]
        Australia = 14,

        /// <summary>
        /// Enum Austria for value: AUT
        /// </summary>
        [EnumMember(Value = "AUT")]
        Austria = 15,

        /// <summary>
        /// Enum Azerbaijan for value: AZE
        /// </summary>
        [EnumMember(Value = "AZE")]
        Azerbaijan = 16,

        /// <summary>
        /// Enum Azores for value: AZO
        /// </summary>
        [EnumMember(Value = "AZO")]
        Azores = 17,

        /// <summary>
        /// Enum Bahamas for value: BHS
        /// </summary>
        [EnumMember(Value = "BHS")]
        Bahamas = 18,

        /// <summary>
        /// Enum Bahrain for value: BHR
        /// </summary>
        [EnumMember(Value = "BHR")]
        Bahrain = 19,

        /// <summary>
        /// Enum Bangladesh for value: BGD
        /// </summary>
        [EnumMember(Value = "BGD")]
        Bangladesh = 20,

        /// <summary>
        /// Enum Barbados for value: BRB
        /// </summary>
        [EnumMember(Value = "BRB")]
        Barbados = 21,

        /// <summary>
        /// Enum Belarus for value: BLR
        /// </summary>
        [EnumMember(Value = "BLR")]
        Belarus = 22,

        /// <summary>
        /// Enum Belgium for value: BEL
        /// </summary>
        [EnumMember(Value = "BEL")]
        Belgium = 23,

        /// <summary>
        /// Enum Belize for value: BLZ
        /// </summary>
        [EnumMember(Value = "BLZ")]
        Belize = 24,

        /// <summary>
        /// Enum Benin for value: BEN
        /// </summary>
        [EnumMember(Value = "BEN")]
        Benin = 25,

        /// <summary>
        /// Enum Bermuda for value: BMU
        /// </summary>
        [EnumMember(Value = "BMU")]
        Bermuda = 26,

        /// <summary>
        /// Enum Bhutan for value: BTN
        /// </summary>
        [EnumMember(Value = "BTN")]
        Bhutan = 27,

        /// <summary>
        /// Enum Bolivia for value: BOL
        /// </summary>
        [EnumMember(Value = "BOL")]
        Bolivia = 28,

        /// <summary>
        /// Enum Bosnia and Herzegovina for value: BIH
        /// </summary>
        [EnumMember(Value = "BIH")]
        BosniaAndHerzegovina = 29,

        /// <summary>
        /// Enum Botswana for value: BWA
        /// </summary>
        [EnumMember(Value = "BWA")]
        Botswana = 30,

        /// <summary>
        /// Enum Bouvet Island for value: BVT
        /// </summary>
        [EnumMember(Value = "BVT")]
        BouvetIsland = 31,

        /// <summary>
        /// Enum Brazil for value: BRA
        /// </summary>
        [EnumMember(Value = "BRA")]
        Brazil = 32,

        /// <summary>
        /// Enum British Indian Ocean Territory for value: IOT
        /// </summary>
        [EnumMember(Value = "IOT")]
        BritishIndianOceanTerritory = 33,

        /// <summary>
        /// Enum British Virgin Islands for value: VGB
        /// </summary>
        [EnumMember(Value = "VGB")]
        BritishVirginIslands = 34,

        /// <summary>
        /// Enum Brunei Darussalam for value: BRN
        /// </summary>
        [EnumMember(Value = "BRN")]
        BruneiDarussalam = 35,

        /// <summary>
        /// Enum Bulgaria for value: BGR
        /// </summary>
        [EnumMember(Value = "BGR")]
        Bulgaria = 36,

        /// <summary>
        /// Enum Burkina Faso for value: BFA
        /// </summary>
        [EnumMember(Value = "BFA")]
        BurkinaFaso = 37,

        /// <summary>
        /// Enum Burundi for value: BDI
        /// </summary>
        [EnumMember(Value = "BDI")]
        Burundi = 38,

        /// <summary>
        /// Enum Cambodia for value: KHM
        /// </summary>
        [EnumMember(Value = "KHM")]
        Cambodia = 39,

        /// <summary>
        /// Enum Cameroon for value: CMR
        /// </summary>
        [EnumMember(Value = "CMR")]
        Cameroon = 40,

        /// <summary>
        /// Enum Canada for value: CAN
        /// </summary>
        [EnumMember(Value = "CAN")]
        Canada = 41,

        /// <summary>
        /// Enum Cape Verde for value: CPV
        /// </summary>
        [EnumMember(Value = "CPV")]
        CapeVerde = 42,

        /// <summary>
        /// Enum Cayman Islands for value: CYM
        /// </summary>
        [EnumMember(Value = "CYM")]
        CaymanIslands = 43,

        /// <summary>
        /// Enum Central African Republic for value: CAF
        /// </summary>
        [EnumMember(Value = "CAF")]
        CentralAfricanRepublic = 44,

        /// <summary>
        /// Enum Chad for value: TCD
        /// </summary>
        [EnumMember(Value = "TCD")]
        Chad = 45,

        /// <summary>
        /// Enum Chile for value: CHL
        /// </summary>
        [EnumMember(Value = "CHL")]
        Chile = 46,

        /// <summary>
        /// Enum China for value: CHN
        /// </summary>
        [EnumMember(Value = "CHN")]
        China = 47,

        /// <summary>
        /// Enum Christmas Island for value: CXR
        /// </summary>
        [EnumMember(Value = "CXR")]
        ChristmasIsland = 48,

        /// <summary>
        /// Enum Cocos (Keeling) Islands for value: CCK
        /// </summary>
        [EnumMember(Value = "CCK")]
        CocosKeelingIslands = 49,

        /// <summary>
        /// Enum Colombia for value: COL
        /// </summary>
        [EnumMember(Value = "COL")]
        Colombia = 50,

        /// <summary>
        /// Enum Comoros for value: COM
        /// </summary>
        [EnumMember(Value = "COM")]
        Comoros = 51,

        /// <summary>
        /// Enum Congo (Brazzaville) for value: COG
        /// </summary>
        [EnumMember(Value = "COG")]
        CongoBrazzaville = 52,

        /// <summary>
        /// Enum Cook Islands for value: COK
        /// </summary>
        [EnumMember(Value = "COK")]
        CookIslands = 53,

        /// <summary>
        /// Enum Costa Rica for value: CRI
        /// </summary>
        [EnumMember(Value = "CRI")]
        CostaRica = 54,

        /// <summary>
        /// Enum C�te d&#39;Ivoire for value: CIV
        /// </summary>
        [EnumMember(Value = "CIV")]
        CTeDIvoire = 55,

        /// <summary>
        /// Enum Croatia for value: HRV
        /// </summary>
        [EnumMember(Value = "HRV")]
        Croatia = 56,

        /// <summary>
        /// Enum Cuba for value: CUB
        /// </summary>
        [EnumMember(Value = "CUB")]
        Cuba = 57,

        /// <summary>
        /// Enum Cyprus for value: CYP
        /// </summary>
        [EnumMember(Value = "CYP")]
        Cyprus = 58,

        /// <summary>
        /// Enum Czech Republic for value: CZE
        /// </summary>
        [EnumMember(Value = "CZE")]
        CzechRepublic = 59,

        /// <summary>
        /// Enum Democratic Republic of the Congo for value: COD
        /// </summary>
        [EnumMember(Value = "COD")]
        DemocraticRepublicOfTheCongo = 60,

        /// <summary>
        /// Enum Denmark for value: DNK
        /// </summary>
        [EnumMember(Value = "DNK")]
        Denmark = 61,

        /// <summary>
        /// Enum Djibouti for value: DJI
        /// </summary>
        [EnumMember(Value = "DJI")]
        Djibouti = 62,

        /// <summary>
        /// Enum Dominica for value: DMA
        /// </summary>
        [EnumMember(Value = "DMA")]
        Dominica = 63,

        /// <summary>
        /// Enum Dominican Republic for value: DOM
        /// </summary>
        [EnumMember(Value = "DOM")]
        DominicanRepublic = 64,

        /// <summary>
        /// Enum Ecuador for value: ECU
        /// </summary>
        [EnumMember(Value = "ECU")]
        Ecuador = 65,

        /// <summary>
        /// Enum Egypt for value: EGY
        /// </summary>
        [EnumMember(Value = "EGY")]
        Egypt = 66,

        /// <summary>
        /// Enum El Salvador for value: SLV
        /// </summary>
        [EnumMember(Value = "SLV")]
        ElSalvador = 67,

        /// <summary>
        /// Enum Equatorial Guinea for value: GNQ
        /// </summary>
        [EnumMember(Value = "GNQ")]
        EquatorialGuinea = 68,

        /// <summary>
        /// Enum Eritrea for value: ERI
        /// </summary>
        [EnumMember(Value = "ERI")]
        Eritrea = 69,

        /// <summary>
        /// Enum Estonia for value: EST
        /// </summary>
        [EnumMember(Value = "EST")]
        Estonia = 70,

        /// <summary>
        /// Enum Eswatini for value: SWZ
        /// </summary>
        [EnumMember(Value = "SWZ")]
        Eswatini = 71,

        /// <summary>
        /// Enum Ethiopia for value: ETH
        /// </summary>
        [EnumMember(Value = "ETH")]
        Ethiopia = 72,

        /// <summary>
        /// Enum Europe diplomat for value: EUE
        /// </summary>
        [EnumMember(Value = "EUE")]
        EuropeDiplomat = 73,

        /// <summary>
        /// Enum Falkland Islands (Malvinas) for value: FLK
        /// </summary>
        [EnumMember(Value = "FLK")]
        FalklandIslandsMalvinas = 74,

        /// <summary>
        /// Enum Faroe Islands for value: FRO
        /// </summary>
        [EnumMember(Value = "FRO")]
        FaroeIslands = 75,

        /// <summary>
        /// Enum Federated States of Micronesia for value: FSM
        /// </summary>
        [EnumMember(Value = "FSM")]
        FederatedStatesOfMicronesia = 76,

        /// <summary>
        /// Enum Fiji for value: FJI
        /// </summary>
        [EnumMember(Value = "FJI")]
        Fiji = 77,

        /// <summary>
        /// Enum Finland for value: FIN
        /// </summary>
        [EnumMember(Value = "FIN")]
        Finland = 78,

        /// <summary>
        /// Enum France for value: FRA
        /// </summary>
        [EnumMember(Value = "FRA")]
        France = 79,

        /// <summary>
        /// Enum French Guiana for value: GUF
        /// </summary>
        [EnumMember(Value = "GUF")]
        FrenchGuiana = 80,

        /// <summary>
        /// Enum French Polynesia for value: PYF
        /// </summary>
        [EnumMember(Value = "PYF")]
        FrenchPolynesia = 81,

        /// <summary>
        /// Enum French Southern Territories for value: ATF
        /// </summary>
        [EnumMember(Value = "ATF")]
        FrenchSouthernTerritories = 82,

        /// <summary>
        /// Enum Gabon for value: GAB
        /// </summary>
        [EnumMember(Value = "GAB")]
        Gabon = 83,

        /// <summary>
        /// Enum Gambia for value: GMB
        /// </summary>
        [EnumMember(Value = "GMB")]
        Gambia = 84,

        /// <summary>
        /// Enum Georgia for value: GEO
        /// </summary>
        [EnumMember(Value = "GEO")]
        Georgia = 85,

        /// <summary>
        /// Enum Germany for value: DEU
        /// </summary>
        [EnumMember(Value = "DEU")]
        Germany = 86,

        /// <summary>
        /// Enum Ghana for value: GHA
        /// </summary>
        [EnumMember(Value = "GHA")]
        Ghana = 87,

        /// <summary>
        /// Enum Gibraltar for value: GIB
        /// </summary>
        [EnumMember(Value = "GIB")]
        Gibraltar = 88,

        /// <summary>
        /// Enum Greece for value: GRC
        /// </summary>
        [EnumMember(Value = "GRC")]
        Greece = 89,

        /// <summary>
        /// Enum Greenland for value: GRL
        /// </summary>
        [EnumMember(Value = "GRL")]
        Greenland = 90,

        /// <summary>
        /// Enum Grenada for value: GRD
        /// </summary>
        [EnumMember(Value = "GRD")]
        Grenada = 91,

        /// <summary>
        /// Enum Guadeloupe for value: GLP
        /// </summary>
        [EnumMember(Value = "GLP")]
        Guadeloupe = 92,

        /// <summary>
        /// Enum Guam for value: GUM
        /// </summary>
        [EnumMember(Value = "GUM")]
        Guam = 93,

        /// <summary>
        /// Enum Guatemala for value: GTM
        /// </summary>
        [EnumMember(Value = "GTM")]
        Guatemala = 94,

        /// <summary>
        /// Enum Guernsey for value: GGY
        /// </summary>
        [EnumMember(Value = "GGY")]
        Guernsey = 95,

        /// <summary>
        /// Enum Guinea for value: GIN
        /// </summary>
        [EnumMember(Value = "GIN")]
        Guinea = 96,

        /// <summary>
        /// Enum Guinea-Bissau for value: GNB
        /// </summary>
        [EnumMember(Value = "GNB")]
        GuineaBissau = 97,

        /// <summary>
        /// Enum Guyana for value: GUY
        /// </summary>
        [EnumMember(Value = "GUY")]
        Guyana = 98,

        /// <summary>
        /// Enum Haiti for value: HTI
        /// </summary>
        [EnumMember(Value = "HTI")]
        Haiti = 99,

        /// <summary>
        /// Enum Heard Island and Mcdonald Islands for value: HMD
        /// </summary>
        [EnumMember(Value = "HMD")]
        HeardIslandAndMcdonaldIslands = 100,

        /// <summary>
        /// Enum Holy See (Vatican City State) for value: VAT
        /// </summary>
        [EnumMember(Value = "VAT")]
        HolySeeVaticanCityState = 101,

        /// <summary>
        /// Enum Honduras for value: HND
        /// </summary>
        [EnumMember(Value = "HND")]
        Honduras = 102,

        /// <summary>
        /// Enum Hong Kong (CN) for value: HKG
        /// </summary>
        [EnumMember(Value = "HKG")]
        HongKongCn = 103,

        /// <summary>
        /// Enum Hungary for value: HUN
        /// </summary>
        [EnumMember(Value = "HUN")]
        Hungary = 104,

        /// <summary>
        /// Enum Iceland for value: ISL
        /// </summary>
        [EnumMember(Value = "ISL")]
        Iceland = 105,

        /// <summary>
        /// Enum India for value: IND
        /// </summary>
        [EnumMember(Value = "IND")]
        India = 106,

        /// <summary>
        /// Enum Indonesia for value: IDN
        /// </summary>
        [EnumMember(Value = "IDN")]
        Indonesia = 107,

        /// <summary>
        /// Enum Iran for value: IRN
        /// </summary>
        [EnumMember(Value = "IRN")]
        Iran = 108,

        /// <summary>
        /// Enum Iraq for value: IRQ
        /// </summary>
        [EnumMember(Value = "IRQ")]
        Iraq = 109,

        /// <summary>
        /// Enum Ireland for value: IRL
        /// </summary>
        [EnumMember(Value = "IRL")]
        Ireland = 110,

        /// <summary>
        /// Enum Isle of Man for value: IMN
        /// </summary>
        [EnumMember(Value = "IMN")]
        IsleOfMan = 111,

        /// <summary>
        /// Enum Israel for value: ISR
        /// </summary>
        [EnumMember(Value = "ISR")]
        Israel = 112,

        /// <summary>
        /// Enum Italy for value: ITA
        /// </summary>
        [EnumMember(Value = "ITA")]
        Italy = 113,

        /// <summary>
        /// Enum Jamaica for value: JAM
        /// </summary>
        [EnumMember(Value = "JAM")]
        Jamaica = 114,

        /// <summary>
        /// Enum Japan for value: JPN
        /// </summary>
        [EnumMember(Value = "JPN")]
        Japan = 115,

        /// <summary>
        /// Enum Jersey for value: JEY
        /// </summary>
        [EnumMember(Value = "JEY")]
        Jersey = 116,

        /// <summary>
        /// Enum Jordan for value: JOR
        /// </summary>
        [EnumMember(Value = "JOR")]
        Jordan = 117,

        /// <summary>
        /// Enum Kazakhstan for value: KAZ
        /// </summary>
        [EnumMember(Value = "KAZ")]
        Kazakhstan = 118,

        /// <summary>
        /// Enum Kenya for value: KEN
        /// </summary>
        [EnumMember(Value = "KEN")]
        Kenya = 119,

        /// <summary>
        /// Enum Kiribati for value: KIR
        /// </summary>
        [EnumMember(Value = "KIR")]
        Kiribati = 120,

        /// <summary>
        /// Enum Kosovo for value: XKX
        /// </summary>
        [EnumMember(Value = "XKX")]
        Kosovo = 121,

        /// <summary>
        /// Enum Kuwait for value: KWT
        /// </summary>
        [EnumMember(Value = "KWT")]
        Kuwait = 122,

        /// <summary>
        /// Enum Kyrgyzstan for value: KGZ
        /// </summary>
        [EnumMember(Value = "KGZ")]
        Kyrgyzstan = 123,

        /// <summary>
        /// Enum Lao PDR for value: LAO
        /// </summary>
        [EnumMember(Value = "LAO")]
        LaoPdr = 124,

        /// <summary>
        /// Enum Latvia for value: LVA
        /// </summary>
        [EnumMember(Value = "LVA")]
        Latvia = 125,

        /// <summary>
        /// Enum Lebanon for value: LBN
        /// </summary>
        [EnumMember(Value = "LBN")]
        Lebanon = 126,

        /// <summary>
        /// Enum Lesotho for value: LSO
        /// </summary>
        [EnumMember(Value = "LSO")]
        Lesotho = 127,

        /// <summary>
        /// Enum Liberia for value: LBR
        /// </summary>
        [EnumMember(Value = "LBR")]
        Liberia = 128,

        /// <summary>
        /// Enum Libya for value: LBY
        /// </summary>
        [EnumMember(Value = "LBY")]
        Libya = 129,

        /// <summary>
        /// Enum Liechtenstein for value: LIE
        /// </summary>
        [EnumMember(Value = "LIE")]
        Liechtenstein = 130,

        /// <summary>
        /// Enum Lithuania for value: LTU
        /// </summary>
        [EnumMember(Value = "LTU")]
        Lithuania = 131,

        /// <summary>
        /// Enum Luxembourg for value: LUX
        /// </summary>
        [EnumMember(Value = "LUX")]
        Luxembourg = 132,

        /// <summary>
        /// Enum Macao (CN) for value: MAC
        /// </summary>
        [EnumMember(Value = "MAC")]
        MacaoCn = 133,

        /// <summary>
        /// Enum Macedonia for value: MKD
        /// </summary>
        [EnumMember(Value = "MKD")]
        Macedonia = 134,

        /// <summary>
        /// Enum Madagascar for value: MDG
        /// </summary>
        [EnumMember(Value = "MDG")]
        Madagascar = 135,

        /// <summary>
        /// Enum Malawi for value: MWI
        /// </summary>
        [EnumMember(Value = "MWI")]
        Malawi = 136,

        /// <summary>
        /// Enum Malaysia for value: MYS
        /// </summary>
        [EnumMember(Value = "MYS")]
        Malaysia = 137,

        /// <summary>
        /// Enum Maldives for value: MDV
        /// </summary>
        [EnumMember(Value = "MDV")]
        Maldives = 138,

        /// <summary>
        /// Enum Mali for value: MLI
        /// </summary>
        [EnumMember(Value = "MLI")]
        Mali = 139,

        /// <summary>
        /// Enum Malta for value: MLT
        /// </summary>
        [EnumMember(Value = "MLT")]
        Malta = 140,

        /// <summary>
        /// Enum Marshall Islands for value: MHL
        /// </summary>
        [EnumMember(Value = "MHL")]
        MarshallIslands = 141,

        /// <summary>
        /// Enum Martinique for value: MTQ
        /// </summary>
        [EnumMember(Value = "MTQ")]
        Martinique = 142,

        /// <summary>
        /// Enum Mauritania for value: MRT
        /// </summary>
        [EnumMember(Value = "MRT")]
        Mauritania = 143,

        /// <summary>
        /// Enum Mauritius for value: MUS
        /// </summary>
        [EnumMember(Value = "MUS")]
        Mauritius = 144,

        /// <summary>
        /// Enum Mayotte for value: MYT
        /// </summary>
        [EnumMember(Value = "MYT")]
        Mayotte = 145,

        /// <summary>
        /// Enum Mexico for value: MEX
        /// </summary>
        [EnumMember(Value = "MEX")]
        Mexico = 146,

        /// <summary>
        /// Enum Moldova for value: MDA
        /// </summary>
        [EnumMember(Value = "MDA")]
        Moldova = 147,

        /// <summary>
        /// Enum Monaco for value: MCO
        /// </summary>
        [EnumMember(Value = "MCO")]
        Monaco = 148,

        /// <summary>
        /// Enum Mongolia for value: MNG
        /// </summary>
        [EnumMember(Value = "MNG")]
        Mongolia = 149,

        /// <summary>
        /// Enum Montenegro for value: MNE
        /// </summary>
        [EnumMember(Value = "MNE")]
        Montenegro = 150,

        /// <summary>
        /// Enum Montserrat for value: MSR
        /// </summary>
        [EnumMember(Value = "MSR")]
        Montserrat = 151,

        /// <summary>
        /// Enum Morocco for value: MAR
        /// </summary>
        [EnumMember(Value = "MAR")]
        Morocco = 152,

        /// <summary>
        /// Enum Mozambique for value: MOZ
        /// </summary>
        [EnumMember(Value = "MOZ")]
        Mozambique = 153,

        /// <summary>
        /// Enum Myanmar for value: MMR
        /// </summary>
        [EnumMember(Value = "MMR")]
        Myanmar = 154,

        /// <summary>
        /// Enum Namibia for value: NAM
        /// </summary>
        [EnumMember(Value = "NAM")]
        Namibia = 155,

        /// <summary>
        /// Enum Nauru for value: NRU
        /// </summary>
        [EnumMember(Value = "NRU")]
        Nauru = 156,

        /// <summary>
        /// Enum Nepal for value: NPL
        /// </summary>
        [EnumMember(Value = "NPL")]
        Nepal = 157,

        /// <summary>
        /// Enum Netherlands for value: NLD
        /// </summary>
        [EnumMember(Value = "NLD")]
        Netherlands = 158,

        /// <summary>
        /// Enum Netherlands Antilles for value: ANT
        /// </summary>
        [EnumMember(Value = "ANT")]
        NetherlandsAntilles = 159,

        /// <summary>
        /// Enum New Caledonia for value: NCL
        /// </summary>
        [EnumMember(Value = "NCL")]
        NewCaledonia = 160,

        /// <summary>
        /// Enum New Zealand for value: NZL
        /// </summary>
        [EnumMember(Value = "NZL")]
        NewZealand = 161,

        /// <summary>
        /// Enum Nicaragua for value: NIC
        /// </summary>
        [EnumMember(Value = "NIC")]
        Nicaragua = 162,

        /// <summary>
        /// Enum Niger for value: NER
        /// </summary>
        [EnumMember(Value = "NER")]
        Niger = 163,

        /// <summary>
        /// Enum Nigeria for value: NGA
        /// </summary>
        [EnumMember(Value = "NGA")]
        Nigeria = 164,

        /// <summary>
        /// Enum Niue for value: NIU
        /// </summary>
        [EnumMember(Value = "NIU")]
        Niue = 165,

        /// <summary>
        /// Enum Norfolk Island for value: NFK
        /// </summary>
        [EnumMember(Value = "NFK")]
        NorfolkIsland = 166,

        /// <summary>
        /// Enum North Korea for value: PRK
        /// </summary>
        [EnumMember(Value = "PRK")]
        NorthKorea = 167,

        /// <summary>
        /// Enum Northern Mariana Islands for value: MNP
        /// </summary>
        [EnumMember(Value = "MNP")]
        NorthernMarianaIslands = 168,

        /// <summary>
        /// Enum Norway for value: NOR
        /// </summary>
        [EnumMember(Value = "NOR")]
        Norway = 169,

        /// <summary>
        /// Enum Oman for value: OMN
        /// </summary>
        [EnumMember(Value = "OMN")]
        Oman = 170,

        /// <summary>
        /// Enum Pakistan for value: PAK
        /// </summary>
        [EnumMember(Value = "PAK")]
        Pakistan = 171,

        /// <summary>
        /// Enum Palau for value: PLW
        /// </summary>
        [EnumMember(Value = "PLW")]
        Palau = 172,

        /// <summary>
        /// Enum Palestinian Territory, Occupied for value: PSE
        /// </summary>
        [EnumMember(Value = "PSE")]
        PalestinianTerritoryOccupied = 173,

        /// <summary>
        /// Enum Panama for value: PAN
        /// </summary>
        [EnumMember(Value = "PAN")]
        Panama = 174,

        /// <summary>
        /// Enum Papua New Guinea for value: PNG
        /// </summary>
        [EnumMember(Value = "PNG")]
        PapuaNewGuinea = 175,

        /// <summary>
        /// Enum Paraguay for value: PRY
        /// </summary>
        [EnumMember(Value = "PRY")]
        Paraguay = 176,

        /// <summary>
        /// Enum Peru for value: PER
        /// </summary>
        [EnumMember(Value = "PER")]
        Peru = 177,

        /// <summary>
        /// Enum Philippines for value: PHL
        /// </summary>
        [EnumMember(Value = "PHL")]
        Philippines = 178,

        /// <summary>
        /// Enum Pitcairn Island for value: PCN
        /// </summary>
        [EnumMember(Value = "PCN")]
        PitcairnIsland = 179,

        /// <summary>
        /// Enum Poland for value: POL
        /// </summary>
        [EnumMember(Value = "POL")]
        Poland = 180,

        /// <summary>
        /// Enum Portugal for value: PRT
        /// </summary>
        [EnumMember(Value = "PRT")]
        Portugal = 181,

        /// <summary>
        /// Enum Puerto Rico for value: PRI
        /// </summary>
        [EnumMember(Value = "PRI")]
        PuertoRico = 182,

        /// <summary>
        /// Enum Qatar for value: QAT
        /// </summary>
        [EnumMember(Value = "QAT")]
        Qatar = 183,

        /// <summary>
        /// Enum R�union for value: REU
        /// </summary>
        [EnumMember(Value = "REU")]
        RUnion = 184,

        /// <summary>
        /// Enum Romania for value: ROU
        /// </summary>
        [EnumMember(Value = "ROU")]
        Romania = 185,

        /// <summary>
        /// Enum Russian Federation for value: RUS
        /// </summary>
        [EnumMember(Value = "RUS")]
        RussianFederation = 186,

        /// <summary>
        /// Enum Rwanda for value: RWA
        /// </summary>
        [EnumMember(Value = "RWA")]
        Rwanda = 187,

        /// <summary>
        /// Enum Saint Helena for value: SHN
        /// </summary>
        [EnumMember(Value = "SHN")]
        SaintHelena = 188,

        /// <summary>
        /// Enum Saint Kitts and Nevis for value: KNA
        /// </summary>
        [EnumMember(Value = "KNA")]
        SaintKittsAndNevis = 189,

        /// <summary>
        /// Enum Saint Lucia for value: LCA
        /// </summary>
        [EnumMember(Value = "LCA")]
        SaintLucia = 190,

        /// <summary>
        /// Enum Saint Pierre and Miquelon for value: SPM
        /// </summary>
        [EnumMember(Value = "SPM")]
        SaintPierreAndMiquelon = 191,

        /// <summary>
        /// Enum Saint Vincent and Grenadines for value: VCT
        /// </summary>
        [EnumMember(Value = "VCT")]
        SaintVincentAndGrenadines = 192,

        /// <summary>
        /// Enum Saint-Barth�lemy for value: BLM
        /// </summary>
        [EnumMember(Value = "BLM")]
        SaintBarthLemy = 193,

        /// <summary>
        /// Enum Saint-Martin (French part) for value: MAF
        /// </summary>
        [EnumMember(Value = "MAF")]
        SaintMartinFrenchPart = 194,

        /// <summary>
        /// Enum Samoa for value: WSM
        /// </summary>
        [EnumMember(Value = "WSM")]
        Samoa = 195,

        /// <summary>
        /// Enum San Marino for value: SMR
        /// </summary>
        [EnumMember(Value = "SMR")]
        SanMarino = 196,

        /// <summary>
        /// Enum Sao Tome and Principe for value: STP
        /// </summary>
        [EnumMember(Value = "STP")]
        SaoTomeAndPrincipe = 197,

        /// <summary>
        /// Enum Saudi Arabia for value: SAU
        /// </summary>
        [EnumMember(Value = "SAU")]
        SaudiArabia = 198,

        /// <summary>
        /// Enum Senegal for value: SEN
        /// </summary>
        [EnumMember(Value = "SEN")]
        Senegal = 199,

        /// <summary>
        /// Enum Serbia for value: SRB
        /// </summary>
        [EnumMember(Value = "SRB")]
        Serbia = 200,

        /// <summary>
        /// Enum Seychelles for value: SYC
        /// </summary>
        [EnumMember(Value = "SYC")]
        Seychelles = 201,

        /// <summary>
        /// Enum Sierra Leone for value: SLE
        /// </summary>
        [EnumMember(Value = "SLE")]
        SierraLeone = 202,

        /// <summary>
        /// Enum Singapore for value: SGP
        /// </summary>
        [EnumMember(Value = "SGP")]
        Singapore = 203,

        /// <summary>
        /// Enum Slovakia for value: SVK
        /// </summary>
        [EnumMember(Value = "SVK")]
        Slovakia = 204,

        /// <summary>
        /// Enum Slovenia for value: SVN
        /// </summary>
        [EnumMember(Value = "SVN")]
        Slovenia = 205,

        /// <summary>
        /// Enum Solomon Islands for value: SLB
        /// </summary>
        [EnumMember(Value = "SLB")]
        SolomonIslands = 206,

        /// <summary>
        /// Enum Somalia for value: SOM
        /// </summary>
        [EnumMember(Value = "SOM")]
        Somalia = 207,

        /// <summary>
        /// Enum Somaliland for value: SOL
        /// </summary>
        [EnumMember(Value = "SOL")]
        Somaliland = 208,

        /// <summary>
        /// Enum South Africa for value: ZAF
        /// </summary>
        [EnumMember(Value = "ZAF")]
        SouthAfrica = 209,

        /// <summary>
        /// Enum South Georgia and the South Sandwich Islands for value: SGS
        /// </summary>
        [EnumMember(Value = "SGS")]
        SouthGeorgiaAndTheSouthSandwichIslands = 210,

        /// <summary>
        /// Enum South Korea for value: KOR
        /// </summary>
        [EnumMember(Value = "KOR")]
        SouthKorea = 211,

        /// <summary>
        /// Enum South Sudan for value: SSD
        /// </summary>
        [EnumMember(Value = "SSD")]
        SouthSudan = 212,

        /// <summary>
        /// Enum Spain for value: ESP
        /// </summary>
        [EnumMember(Value = "ESP")]
        Spain = 213,

        /// <summary>
        /// Enum Sri Lanka for value: LKA
        /// </summary>
        [EnumMember(Value = "LKA")]
        SriLanka = 214,

        /// <summary>
        /// Enum Sudan for value: SDN
        /// </summary>
        [EnumMember(Value = "SDN")]
        Sudan = 215,

        /// <summary>
        /// Enum Suriname for value: SUR
        /// </summary>
        [EnumMember(Value = "SUR")]
        Suriname = 216,

        /// <summary>
        /// Enum Svalbard and Jan Mayen Islands for value: SJM
        /// </summary>
        [EnumMember(Value = "SJM")]
        SvalbardAndJanMayenIslands = 217,

        /// <summary>
        /// Enum Sweden for value: SWE
        /// </summary>
        [EnumMember(Value = "SWE")]
        Sweden = 218,

        /// <summary>
        /// Enum Switzerland for value: CHE
        /// </summary>
        [EnumMember(Value = "CHE")]
        Switzerland = 219,

        /// <summary>
        /// Enum Syrian Arab Republic (Syria) for value: SYR
        /// </summary>
        [EnumMember(Value = "SYR")]
        SyrianArabRepublicSyria = 220,

        /// <summary>
        /// Enum Taiwan (CN) for value: TWN
        /// </summary>
        [EnumMember(Value = "TWN")]
        TaiwanCn = 221,

        /// <summary>
        /// Enum Tajikistan for value: TJK
        /// </summary>
        [EnumMember(Value = "TJK")]
        Tajikistan = 222,

        /// <summary>
        /// Enum Tanzania for value: TZA
        /// </summary>
        [EnumMember(Value = "TZA")]
        Tanzania = 223,

        /// <summary>
        /// Enum Thailand for value: THA
        /// </summary>
        [EnumMember(Value = "THA")]
        Thailand = 224,

        /// <summary>
        /// Enum Timor-Leste for value: TLS
        /// </summary>
        [EnumMember(Value = "TLS")]
        TimorLeste = 225,

        /// <summary>
        /// Enum Togo for value: TGO
        /// </summary>
        [EnumMember(Value = "TGO")]
        Togo = 226,

        /// <summary>
        /// Enum Tokelau for value: TKL
        /// </summary>
        [EnumMember(Value = "TKL")]
        Tokelau = 227,

        /// <summary>
        /// Enum Tonga for value: TON
        /// </summary>
        [EnumMember(Value = "TON")]
        Tonga = 228,

        /// <summary>
        /// Enum Trinidad and Tobago for value: TTO
        /// </summary>
        [EnumMember(Value = "TTO")]
        TrinidadAndTobago = 229,

        /// <summary>
        /// Enum Tunisia for value: TUN
        /// </summary>
        [EnumMember(Value = "TUN")]
        Tunisia = 230,

        /// <summary>
        /// Enum Turkey for value: TUR
        /// </summary>
        [EnumMember(Value = "TUR")]
        Turkey = 231,

        /// <summary>
        /// Enum Turkmenistan for value: TKM
        /// </summary>
        [EnumMember(Value = "TKM")]
        Turkmenistan = 232,

        /// <summary>
        /// Enum Turks and Caicos Islands for value: TCA
        /// </summary>
        [EnumMember(Value = "TCA")]
        TurksAndCaicosIslands = 233,

        /// <summary>
        /// Enum Tuvalu for value: TUV
        /// </summary>
        [EnumMember(Value = "TUV")]
        Tuvalu = 234,

        /// <summary>
        /// Enum Uganda for value: UGA
        /// </summary>
        [EnumMember(Value = "UGA")]
        Uganda = 235,

        /// <summary>
        /// Enum Ukraine for value: UKR
        /// </summary>
        [EnumMember(Value = "UKR")]
        Ukraine = 236,

        /// <summary>
        /// Enum United Arab Emirates for value: ARE
        /// </summary>
        [EnumMember(Value = "ARE")]
        UnitedArabEmirates = 237,

        /// <summary>
        /// Enum United Kingdom for value: GBR
        /// </summary>
        [EnumMember(Value = "GBR")]
        UnitedKingdom = 238,

        /// <summary>
        /// Enum United States Minor Outlying Islands for value: UMI
        /// </summary>
        [EnumMember(Value = "UMI")]
        UnitedStatesMinorOutlyingIslands = 239,

        /// <summary>
        /// Enum United States of America for value: USA
        /// </summary>
        [EnumMember(Value = "USA")]
        UnitedStatesOfAmerica = 240,

        /// <summary>
        /// Enum Uruguay for value: URY
        /// </summary>
        [EnumMember(Value = "URY")]
        Uruguay = 241,

        /// <summary>
        /// Enum Uzbekistan for value: UZB
        /// </summary>
        [EnumMember(Value = "UZB")]
        Uzbekistan = 242,

        /// <summary>
        /// Enum Vanuatu for value: VUT
        /// </summary>
        [EnumMember(Value = "VUT")]
        Vanuatu = 243,

        /// <summary>
        /// Enum Venezuela for value: VEN
        /// </summary>
        [EnumMember(Value = "VEN")]
        Venezuela = 244,

        /// <summary>
        /// Enum Vietnam for value: VNM
        /// </summary>
        [EnumMember(Value = "VNM")]
        Vietnam = 245,

        /// <summary>
        /// Enum Virgin Islands, US for value: VIR
        /// </summary>
        [EnumMember(Value = "VIR")]
        VirginIslandsUs = 246,

        /// <summary>
        /// Enum Wallis and Futuna Islands for value: WLF
        /// </summary>
        [EnumMember(Value = "WLF")]
        WallisAndFutunaIslands = 247,

        /// <summary>
        /// Enum Western Sahara for value: ESH
        /// </summary>
        [EnumMember(Value = "ESH")]
        WesternSahara = 248,

        /// <summary>
        /// Enum Yemen for value: YEM
        /// </summary>
        [EnumMember(Value = "YEM")]
        Yemen = 249,

        /// <summary>
        /// Enum Zambia for value: ZMB
        /// </summary>
        [EnumMember(Value = "ZMB")]
        Zambia = 250,

        /// <summary>
        /// Enum Zimbabwe for value: ZWE
        /// </summary>
        [EnumMember(Value = "ZWE")]
        Zimbabwe = 251
    }

    /// <summary>
    /// Converts <see cref="EnumCountry"/> to and from the JSON value
    /// </summary>
    public static class EnumCountryValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="EnumCountry"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static EnumCountry FromString(string value)
        {
            return FromStringOrDefault(value) ?? throw new NotImplementedException($"Could not convert value to type EnumCountry: '{value}'");
        }

        /// <summary>
        /// Parses a given value to <see cref="EnumCountry"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static EnumCountry? FromStringOrDefault(string value)
        {
            if (value.Equals("AFG"))
                return EnumCountry.Afghanistan;

            if (value.Equals("ALA"))
                return EnumCountry.AlandIslands;

            if (value.Equals("ALB"))
                return EnumCountry.Albania;

            if (value.Equals("DZA"))
                return EnumCountry.Algeria;

            if (value.Equals("ASM"))
                return EnumCountry.AmericanSamoa;

            if (value.Equals("AND"))
                return EnumCountry.Andorra;

            if (value.Equals("AGO"))
                return EnumCountry.Angola;

            if (value.Equals("AIA"))
                return EnumCountry.Anguilla;

            if (value.Equals("ATA"))
                return EnumCountry.Antarctica;

            if (value.Equals("ATG"))
                return EnumCountry.AntiguaAndBarbuda;

            if (value.Equals("ARG"))
                return EnumCountry.Argentina;

            if (value.Equals("ARM"))
                return EnumCountry.Armenia;

            if (value.Equals("ABW"))
                return EnumCountry.Aruba;

            if (value.Equals("AUS"))
                return EnumCountry.Australia;

            if (value.Equals("AUT"))
                return EnumCountry.Austria;

            if (value.Equals("AZE"))
                return EnumCountry.Azerbaijan;

            if (value.Equals("AZO"))
                return EnumCountry.Azores;

            if (value.Equals("BHS"))
                return EnumCountry.Bahamas;

            if (value.Equals("BHR"))
                return EnumCountry.Bahrain;

            if (value.Equals("BGD"))
                return EnumCountry.Bangladesh;

            if (value.Equals("BRB"))
                return EnumCountry.Barbados;

            if (value.Equals("BLR"))
                return EnumCountry.Belarus;

            if (value.Equals("BEL"))
                return EnumCountry.Belgium;

            if (value.Equals("BLZ"))
                return EnumCountry.Belize;

            if (value.Equals("BEN"))
                return EnumCountry.Benin;

            if (value.Equals("BMU"))
                return EnumCountry.Bermuda;

            if (value.Equals("BTN"))
                return EnumCountry.Bhutan;

            if (value.Equals("BOL"))
                return EnumCountry.Bolivia;

            if (value.Equals("BIH"))
                return EnumCountry.BosniaAndHerzegovina;

            if (value.Equals("BWA"))
                return EnumCountry.Botswana;

            if (value.Equals("BVT"))
                return EnumCountry.BouvetIsland;

            if (value.Equals("BRA"))
                return EnumCountry.Brazil;

            if (value.Equals("IOT"))
                return EnumCountry.BritishIndianOceanTerritory;

            if (value.Equals("VGB"))
                return EnumCountry.BritishVirginIslands;

            if (value.Equals("BRN"))
                return EnumCountry.BruneiDarussalam;

            if (value.Equals("BGR"))
                return EnumCountry.Bulgaria;

            if (value.Equals("BFA"))
                return EnumCountry.BurkinaFaso;

            if (value.Equals("BDI"))
                return EnumCountry.Burundi;

            if (value.Equals("KHM"))
                return EnumCountry.Cambodia;

            if (value.Equals("CMR"))
                return EnumCountry.Cameroon;

            if (value.Equals("CAN"))
                return EnumCountry.Canada;

            if (value.Equals("CPV"))
                return EnumCountry.CapeVerde;

            if (value.Equals("CYM"))
                return EnumCountry.CaymanIslands;

            if (value.Equals("CAF"))
                return EnumCountry.CentralAfricanRepublic;

            if (value.Equals("TCD"))
                return EnumCountry.Chad;

            if (value.Equals("CHL"))
                return EnumCountry.Chile;

            if (value.Equals("CHN"))
                return EnumCountry.China;

            if (value.Equals("CXR"))
                return EnumCountry.ChristmasIsland;

            if (value.Equals("CCK"))
                return EnumCountry.CocosKeelingIslands;

            if (value.Equals("COL"))
                return EnumCountry.Colombia;

            if (value.Equals("COM"))
                return EnumCountry.Comoros;

            if (value.Equals("COG"))
                return EnumCountry.CongoBrazzaville;

            if (value.Equals("COK"))
                return EnumCountry.CookIslands;

            if (value.Equals("CRI"))
                return EnumCountry.CostaRica;

            if (value.Equals("CIV"))
                return EnumCountry.CTeDIvoire;

            if (value.Equals("HRV"))
                return EnumCountry.Croatia;

            if (value.Equals("CUB"))
                return EnumCountry.Cuba;

            if (value.Equals("CYP"))
                return EnumCountry.Cyprus;

            if (value.Equals("CZE"))
                return EnumCountry.CzechRepublic;

            if (value.Equals("COD"))
                return EnumCountry.DemocraticRepublicOfTheCongo;

            if (value.Equals("DNK"))
                return EnumCountry.Denmark;

            if (value.Equals("DJI"))
                return EnumCountry.Djibouti;

            if (value.Equals("DMA"))
                return EnumCountry.Dominica;

            if (value.Equals("DOM"))
                return EnumCountry.DominicanRepublic;

            if (value.Equals("ECU"))
                return EnumCountry.Ecuador;

            if (value.Equals("EGY"))
                return EnumCountry.Egypt;

            if (value.Equals("SLV"))
                return EnumCountry.ElSalvador;

            if (value.Equals("GNQ"))
                return EnumCountry.EquatorialGuinea;

            if (value.Equals("ERI"))
                return EnumCountry.Eritrea;

            if (value.Equals("EST"))
                return EnumCountry.Estonia;

            if (value.Equals("SWZ"))
                return EnumCountry.Eswatini;

            if (value.Equals("ETH"))
                return EnumCountry.Ethiopia;

            if (value.Equals("EUE"))
                return EnumCountry.EuropeDiplomat;

            if (value.Equals("FLK"))
                return EnumCountry.FalklandIslandsMalvinas;

            if (value.Equals("FRO"))
                return EnumCountry.FaroeIslands;

            if (value.Equals("FSM"))
                return EnumCountry.FederatedStatesOfMicronesia;

            if (value.Equals("FJI"))
                return EnumCountry.Fiji;

            if (value.Equals("FIN"))
                return EnumCountry.Finland;

            if (value.Equals("FRA"))
                return EnumCountry.France;

            if (value.Equals("GUF"))
                return EnumCountry.FrenchGuiana;

            if (value.Equals("PYF"))
                return EnumCountry.FrenchPolynesia;

            if (value.Equals("ATF"))
                return EnumCountry.FrenchSouthernTerritories;

            if (value.Equals("GAB"))
                return EnumCountry.Gabon;

            if (value.Equals("GMB"))
                return EnumCountry.Gambia;

            if (value.Equals("GEO"))
                return EnumCountry.Georgia;

            if (value.Equals("DEU"))
                return EnumCountry.Germany;

            if (value.Equals("GHA"))
                return EnumCountry.Ghana;

            if (value.Equals("GIB"))
                return EnumCountry.Gibraltar;

            if (value.Equals("GRC"))
                return EnumCountry.Greece;

            if (value.Equals("GRL"))
                return EnumCountry.Greenland;

            if (value.Equals("GRD"))
                return EnumCountry.Grenada;

            if (value.Equals("GLP"))
                return EnumCountry.Guadeloupe;

            if (value.Equals("GUM"))
                return EnumCountry.Guam;

            if (value.Equals("GTM"))
                return EnumCountry.Guatemala;

            if (value.Equals("GGY"))
                return EnumCountry.Guernsey;

            if (value.Equals("GIN"))
                return EnumCountry.Guinea;

            if (value.Equals("GNB"))
                return EnumCountry.GuineaBissau;

            if (value.Equals("GUY"))
                return EnumCountry.Guyana;

            if (value.Equals("HTI"))
                return EnumCountry.Haiti;

            if (value.Equals("HMD"))
                return EnumCountry.HeardIslandAndMcdonaldIslands;

            if (value.Equals("VAT"))
                return EnumCountry.HolySeeVaticanCityState;

            if (value.Equals("HND"))
                return EnumCountry.Honduras;

            if (value.Equals("HKG"))
                return EnumCountry.HongKongCn;

            if (value.Equals("HUN"))
                return EnumCountry.Hungary;

            if (value.Equals("ISL"))
                return EnumCountry.Iceland;

            if (value.Equals("IND"))
                return EnumCountry.India;

            if (value.Equals("IDN"))
                return EnumCountry.Indonesia;

            if (value.Equals("IRN"))
                return EnumCountry.Iran;

            if (value.Equals("IRQ"))
                return EnumCountry.Iraq;

            if (value.Equals("IRL"))
                return EnumCountry.Ireland;

            if (value.Equals("IMN"))
                return EnumCountry.IsleOfMan;

            if (value.Equals("ISR"))
                return EnumCountry.Israel;

            if (value.Equals("ITA"))
                return EnumCountry.Italy;

            if (value.Equals("JAM"))
                return EnumCountry.Jamaica;

            if (value.Equals("JPN"))
                return EnumCountry.Japan;

            if (value.Equals("JEY"))
                return EnumCountry.Jersey;

            if (value.Equals("JOR"))
                return EnumCountry.Jordan;

            if (value.Equals("KAZ"))
                return EnumCountry.Kazakhstan;

            if (value.Equals("KEN"))
                return EnumCountry.Kenya;

            if (value.Equals("KIR"))
                return EnumCountry.Kiribati;

            if (value.Equals("XKX"))
                return EnumCountry.Kosovo;

            if (value.Equals("KWT"))
                return EnumCountry.Kuwait;

            if (value.Equals("KGZ"))
                return EnumCountry.Kyrgyzstan;

            if (value.Equals("LAO"))
                return EnumCountry.LaoPdr;

            if (value.Equals("LVA"))
                return EnumCountry.Latvia;

            if (value.Equals("LBN"))
                return EnumCountry.Lebanon;

            if (value.Equals("LSO"))
                return EnumCountry.Lesotho;

            if (value.Equals("LBR"))
                return EnumCountry.Liberia;

            if (value.Equals("LBY"))
                return EnumCountry.Libya;

            if (value.Equals("LIE"))
                return EnumCountry.Liechtenstein;

            if (value.Equals("LTU"))
                return EnumCountry.Lithuania;

            if (value.Equals("LUX"))
                return EnumCountry.Luxembourg;

            if (value.Equals("MAC"))
                return EnumCountry.MacaoCn;

            if (value.Equals("MKD"))
                return EnumCountry.Macedonia;

            if (value.Equals("MDG"))
                return EnumCountry.Madagascar;

            if (value.Equals("MWI"))
                return EnumCountry.Malawi;

            if (value.Equals("MYS"))
                return EnumCountry.Malaysia;

            if (value.Equals("MDV"))
                return EnumCountry.Maldives;

            if (value.Equals("MLI"))
                return EnumCountry.Mali;

            if (value.Equals("MLT"))
                return EnumCountry.Malta;

            if (value.Equals("MHL"))
                return EnumCountry.MarshallIslands;

            if (value.Equals("MTQ"))
                return EnumCountry.Martinique;

            if (value.Equals("MRT"))
                return EnumCountry.Mauritania;

            if (value.Equals("MUS"))
                return EnumCountry.Mauritius;

            if (value.Equals("MYT"))
                return EnumCountry.Mayotte;

            if (value.Equals("MEX"))
                return EnumCountry.Mexico;

            if (value.Equals("MDA"))
                return EnumCountry.Moldova;

            if (value.Equals("MCO"))
                return EnumCountry.Monaco;

            if (value.Equals("MNG"))
                return EnumCountry.Mongolia;

            if (value.Equals("MNE"))
                return EnumCountry.Montenegro;

            if (value.Equals("MSR"))
                return EnumCountry.Montserrat;

            if (value.Equals("MAR"))
                return EnumCountry.Morocco;

            if (value.Equals("MOZ"))
                return EnumCountry.Mozambique;

            if (value.Equals("MMR"))
                return EnumCountry.Myanmar;

            if (value.Equals("NAM"))
                return EnumCountry.Namibia;

            if (value.Equals("NRU"))
                return EnumCountry.Nauru;

            if (value.Equals("NPL"))
                return EnumCountry.Nepal;

            if (value.Equals("NLD"))
                return EnumCountry.Netherlands;

            if (value.Equals("ANT"))
                return EnumCountry.NetherlandsAntilles;

            if (value.Equals("NCL"))
                return EnumCountry.NewCaledonia;

            if (value.Equals("NZL"))
                return EnumCountry.NewZealand;

            if (value.Equals("NIC"))
                return EnumCountry.Nicaragua;

            if (value.Equals("NER"))
                return EnumCountry.Niger;

            if (value.Equals("NGA"))
                return EnumCountry.Nigeria;

            if (value.Equals("NIU"))
                return EnumCountry.Niue;

            if (value.Equals("NFK"))
                return EnumCountry.NorfolkIsland;

            if (value.Equals("PRK"))
                return EnumCountry.NorthKorea;

            if (value.Equals("MNP"))
                return EnumCountry.NorthernMarianaIslands;

            if (value.Equals("NOR"))
                return EnumCountry.Norway;

            if (value.Equals("OMN"))
                return EnumCountry.Oman;

            if (value.Equals("PAK"))
                return EnumCountry.Pakistan;

            if (value.Equals("PLW"))
                return EnumCountry.Palau;

            if (value.Equals("PSE"))
                return EnumCountry.PalestinianTerritoryOccupied;

            if (value.Equals("PAN"))
                return EnumCountry.Panama;

            if (value.Equals("PNG"))
                return EnumCountry.PapuaNewGuinea;

            if (value.Equals("PRY"))
                return EnumCountry.Paraguay;

            if (value.Equals("PER"))
                return EnumCountry.Peru;

            if (value.Equals("PHL"))
                return EnumCountry.Philippines;

            if (value.Equals("PCN"))
                return EnumCountry.PitcairnIsland;

            if (value.Equals("POL"))
                return EnumCountry.Poland;

            if (value.Equals("PRT"))
                return EnumCountry.Portugal;

            if (value.Equals("PRI"))
                return EnumCountry.PuertoRico;

            if (value.Equals("QAT"))
                return EnumCountry.Qatar;

            if (value.Equals("REU"))
                return EnumCountry.RUnion;

            if (value.Equals("ROU"))
                return EnumCountry.Romania;

            if (value.Equals("RUS"))
                return EnumCountry.RussianFederation;

            if (value.Equals("RWA"))
                return EnumCountry.Rwanda;

            if (value.Equals("SHN"))
                return EnumCountry.SaintHelena;

            if (value.Equals("KNA"))
                return EnumCountry.SaintKittsAndNevis;

            if (value.Equals("LCA"))
                return EnumCountry.SaintLucia;

            if (value.Equals("SPM"))
                return EnumCountry.SaintPierreAndMiquelon;

            if (value.Equals("VCT"))
                return EnumCountry.SaintVincentAndGrenadines;

            if (value.Equals("BLM"))
                return EnumCountry.SaintBarthLemy;

            if (value.Equals("MAF"))
                return EnumCountry.SaintMartinFrenchPart;

            if (value.Equals("WSM"))
                return EnumCountry.Samoa;

            if (value.Equals("SMR"))
                return EnumCountry.SanMarino;

            if (value.Equals("STP"))
                return EnumCountry.SaoTomeAndPrincipe;

            if (value.Equals("SAU"))
                return EnumCountry.SaudiArabia;

            if (value.Equals("SEN"))
                return EnumCountry.Senegal;

            if (value.Equals("SRB"))
                return EnumCountry.Serbia;

            if (value.Equals("SYC"))
                return EnumCountry.Seychelles;

            if (value.Equals("SLE"))
                return EnumCountry.SierraLeone;

            if (value.Equals("SGP"))
                return EnumCountry.Singapore;

            if (value.Equals("SVK"))
                return EnumCountry.Slovakia;

            if (value.Equals("SVN"))
                return EnumCountry.Slovenia;

            if (value.Equals("SLB"))
                return EnumCountry.SolomonIslands;

            if (value.Equals("SOM"))
                return EnumCountry.Somalia;

            if (value.Equals("SOL"))
                return EnumCountry.Somaliland;

            if (value.Equals("ZAF"))
                return EnumCountry.SouthAfrica;

            if (value.Equals("SGS"))
                return EnumCountry.SouthGeorgiaAndTheSouthSandwichIslands;

            if (value.Equals("KOR"))
                return EnumCountry.SouthKorea;

            if (value.Equals("SSD"))
                return EnumCountry.SouthSudan;

            if (value.Equals("ESP"))
                return EnumCountry.Spain;

            if (value.Equals("LKA"))
                return EnumCountry.SriLanka;

            if (value.Equals("SDN"))
                return EnumCountry.Sudan;

            if (value.Equals("SUR"))
                return EnumCountry.Suriname;

            if (value.Equals("SJM"))
                return EnumCountry.SvalbardAndJanMayenIslands;

            if (value.Equals("SWE"))
                return EnumCountry.Sweden;

            if (value.Equals("CHE"))
                return EnumCountry.Switzerland;

            if (value.Equals("SYR"))
                return EnumCountry.SyrianArabRepublicSyria;

            if (value.Equals("TWN"))
                return EnumCountry.TaiwanCn;

            if (value.Equals("TJK"))
                return EnumCountry.Tajikistan;

            if (value.Equals("TZA"))
                return EnumCountry.Tanzania;

            if (value.Equals("THA"))
                return EnumCountry.Thailand;

            if (value.Equals("TLS"))
                return EnumCountry.TimorLeste;

            if (value.Equals("TGO"))
                return EnumCountry.Togo;

            if (value.Equals("TKL"))
                return EnumCountry.Tokelau;

            if (value.Equals("TON"))
                return EnumCountry.Tonga;

            if (value.Equals("TTO"))
                return EnumCountry.TrinidadAndTobago;

            if (value.Equals("TUN"))
                return EnumCountry.Tunisia;

            if (value.Equals("TUR"))
                return EnumCountry.Turkey;

            if (value.Equals("TKM"))
                return EnumCountry.Turkmenistan;

            if (value.Equals("TCA"))
                return EnumCountry.TurksAndCaicosIslands;

            if (value.Equals("TUV"))
                return EnumCountry.Tuvalu;

            if (value.Equals("UGA"))
                return EnumCountry.Uganda;

            if (value.Equals("UKR"))
                return EnumCountry.Ukraine;

            if (value.Equals("ARE"))
                return EnumCountry.UnitedArabEmirates;

            if (value.Equals("GBR"))
                return EnumCountry.UnitedKingdom;

            if (value.Equals("UMI"))
                return EnumCountry.UnitedStatesMinorOutlyingIslands;

            if (value.Equals("USA"))
                return EnumCountry.UnitedStatesOfAmerica;

            if (value.Equals("URY"))
                return EnumCountry.Uruguay;

            if (value.Equals("UZB"))
                return EnumCountry.Uzbekistan;

            if (value.Equals("VUT"))
                return EnumCountry.Vanuatu;

            if (value.Equals("VEN"))
                return EnumCountry.Venezuela;

            if (value.Equals("VNM"))
                return EnumCountry.Vietnam;

            if (value.Equals("VIR"))
                return EnumCountry.VirginIslandsUs;

            if (value.Equals("WLF"))
                return EnumCountry.WallisAndFutunaIslands;

            if (value.Equals("ESH"))
                return EnumCountry.WesternSahara;

            if (value.Equals("YEM"))
                return EnumCountry.Yemen;

            if (value.Equals("ZMB"))
                return EnumCountry.Zambia;

            if (value.Equals("ZWE"))
                return EnumCountry.Zimbabwe;

            return null;
        }
    }

}
