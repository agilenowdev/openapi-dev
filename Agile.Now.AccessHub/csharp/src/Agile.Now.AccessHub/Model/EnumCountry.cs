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
        /// Enum AFG for value: AFG
        /// </summary>
        [EnumMember(Value = "AFG")]
        AFG = 1,

        /// <summary>
        /// Enum ALA for value: ALA
        /// </summary>
        [EnumMember(Value = "ALA")]
        ALA = 2,

        /// <summary>
        /// Enum ALB for value: ALB
        /// </summary>
        [EnumMember(Value = "ALB")]
        ALB = 3,

        /// <summary>
        /// Enum DZA for value: DZA
        /// </summary>
        [EnumMember(Value = "DZA")]
        DZA = 4,

        /// <summary>
        /// Enum ASM for value: ASM
        /// </summary>
        [EnumMember(Value = "ASM")]
        ASM = 5,

        /// <summary>
        /// Enum AND for value: AND
        /// </summary>
        [EnumMember(Value = "AND")]
        AND = 6,

        /// <summary>
        /// Enum AGO for value: AGO
        /// </summary>
        [EnumMember(Value = "AGO")]
        AGO = 7,

        /// <summary>
        /// Enum AIA for value: AIA
        /// </summary>
        [EnumMember(Value = "AIA")]
        AIA = 8,

        /// <summary>
        /// Enum ATA for value: ATA
        /// </summary>
        [EnumMember(Value = "ATA")]
        ATA = 9,

        /// <summary>
        /// Enum ATG for value: ATG
        /// </summary>
        [EnumMember(Value = "ATG")]
        ATG = 10,

        /// <summary>
        /// Enum ARG for value: ARG
        /// </summary>
        [EnumMember(Value = "ARG")]
        ARG = 11,

        /// <summary>
        /// Enum ARM for value: ARM
        /// </summary>
        [EnumMember(Value = "ARM")]
        ARM = 12,

        /// <summary>
        /// Enum ABW for value: ABW
        /// </summary>
        [EnumMember(Value = "ABW")]
        ABW = 13,

        /// <summary>
        /// Enum AUS for value: AUS
        /// </summary>
        [EnumMember(Value = "AUS")]
        AUS = 14,

        /// <summary>
        /// Enum AUT for value: AUT
        /// </summary>
        [EnumMember(Value = "AUT")]
        AUT = 15,

        /// <summary>
        /// Enum AZE for value: AZE
        /// </summary>
        [EnumMember(Value = "AZE")]
        AZE = 16,

        /// <summary>
        /// Enum AZO for value: AZO
        /// </summary>
        [EnumMember(Value = "AZO")]
        AZO = 17,

        /// <summary>
        /// Enum BHS for value: BHS
        /// </summary>
        [EnumMember(Value = "BHS")]
        BHS = 18,

        /// <summary>
        /// Enum BHR for value: BHR
        /// </summary>
        [EnumMember(Value = "BHR")]
        BHR = 19,

        /// <summary>
        /// Enum BGD for value: BGD
        /// </summary>
        [EnumMember(Value = "BGD")]
        BGD = 20,

        /// <summary>
        /// Enum BRB for value: BRB
        /// </summary>
        [EnumMember(Value = "BRB")]
        BRB = 21,

        /// <summary>
        /// Enum BLR for value: BLR
        /// </summary>
        [EnumMember(Value = "BLR")]
        BLR = 22,

        /// <summary>
        /// Enum BEL for value: BEL
        /// </summary>
        [EnumMember(Value = "BEL")]
        BEL = 23,

        /// <summary>
        /// Enum BLZ for value: BLZ
        /// </summary>
        [EnumMember(Value = "BLZ")]
        BLZ = 24,

        /// <summary>
        /// Enum BEN for value: BEN
        /// </summary>
        [EnumMember(Value = "BEN")]
        BEN = 25,

        /// <summary>
        /// Enum BMU for value: BMU
        /// </summary>
        [EnumMember(Value = "BMU")]
        BMU = 26,

        /// <summary>
        /// Enum BTN for value: BTN
        /// </summary>
        [EnumMember(Value = "BTN")]
        BTN = 27,

        /// <summary>
        /// Enum BOL for value: BOL
        /// </summary>
        [EnumMember(Value = "BOL")]
        BOL = 28,

        /// <summary>
        /// Enum BIH for value: BIH
        /// </summary>
        [EnumMember(Value = "BIH")]
        BIH = 29,

        /// <summary>
        /// Enum BWA for value: BWA
        /// </summary>
        [EnumMember(Value = "BWA")]
        BWA = 30,

        /// <summary>
        /// Enum BVT for value: BVT
        /// </summary>
        [EnumMember(Value = "BVT")]
        BVT = 31,

        /// <summary>
        /// Enum BRA for value: BRA
        /// </summary>
        [EnumMember(Value = "BRA")]
        BRA = 32,

        /// <summary>
        /// Enum IOT for value: IOT
        /// </summary>
        [EnumMember(Value = "IOT")]
        IOT = 33,

        /// <summary>
        /// Enum VGB for value: VGB
        /// </summary>
        [EnumMember(Value = "VGB")]
        VGB = 34,

        /// <summary>
        /// Enum BRN for value: BRN
        /// </summary>
        [EnumMember(Value = "BRN")]
        BRN = 35,

        /// <summary>
        /// Enum BGR for value: BGR
        /// </summary>
        [EnumMember(Value = "BGR")]
        BGR = 36,

        /// <summary>
        /// Enum BFA for value: BFA
        /// </summary>
        [EnumMember(Value = "BFA")]
        BFA = 37,

        /// <summary>
        /// Enum BDI for value: BDI
        /// </summary>
        [EnumMember(Value = "BDI")]
        BDI = 38,

        /// <summary>
        /// Enum KHM for value: KHM
        /// </summary>
        [EnumMember(Value = "KHM")]
        KHM = 39,

        /// <summary>
        /// Enum CMR for value: CMR
        /// </summary>
        [EnumMember(Value = "CMR")]
        CMR = 40,

        /// <summary>
        /// Enum CAN for value: CAN
        /// </summary>
        [EnumMember(Value = "CAN")]
        CAN = 41,

        /// <summary>
        /// Enum CPV for value: CPV
        /// </summary>
        [EnumMember(Value = "CPV")]
        CPV = 42,

        /// <summary>
        /// Enum CYM for value: CYM
        /// </summary>
        [EnumMember(Value = "CYM")]
        CYM = 43,

        /// <summary>
        /// Enum CAF for value: CAF
        /// </summary>
        [EnumMember(Value = "CAF")]
        CAF = 44,

        /// <summary>
        /// Enum TCD for value: TCD
        /// </summary>
        [EnumMember(Value = "TCD")]
        TCD = 45,

        /// <summary>
        /// Enum CHL for value: CHL
        /// </summary>
        [EnumMember(Value = "CHL")]
        CHL = 46,

        /// <summary>
        /// Enum CHN for value: CHN
        /// </summary>
        [EnumMember(Value = "CHN")]
        CHN = 47,

        /// <summary>
        /// Enum CXR for value: CXR
        /// </summary>
        [EnumMember(Value = "CXR")]
        CXR = 48,

        /// <summary>
        /// Enum CCK for value: CCK
        /// </summary>
        [EnumMember(Value = "CCK")]
        CCK = 49,

        /// <summary>
        /// Enum COL for value: COL
        /// </summary>
        [EnumMember(Value = "COL")]
        COL = 50,

        /// <summary>
        /// Enum COM for value: COM
        /// </summary>
        [EnumMember(Value = "COM")]
        COM = 51,

        /// <summary>
        /// Enum COG for value: COG
        /// </summary>
        [EnumMember(Value = "COG")]
        COG = 52,

        /// <summary>
        /// Enum COK for value: COK
        /// </summary>
        [EnumMember(Value = "COK")]
        COK = 53,

        /// <summary>
        /// Enum CRI for value: CRI
        /// </summary>
        [EnumMember(Value = "CRI")]
        CRI = 54,

        /// <summary>
        /// Enum CIV for value: CIV
        /// </summary>
        [EnumMember(Value = "CIV")]
        CIV = 55,

        /// <summary>
        /// Enum HRV for value: HRV
        /// </summary>
        [EnumMember(Value = "HRV")]
        HRV = 56,

        /// <summary>
        /// Enum CUB for value: CUB
        /// </summary>
        [EnumMember(Value = "CUB")]
        CUB = 57,

        /// <summary>
        /// Enum CYP for value: CYP
        /// </summary>
        [EnumMember(Value = "CYP")]
        CYP = 58,

        /// <summary>
        /// Enum CZE for value: CZE
        /// </summary>
        [EnumMember(Value = "CZE")]
        CZE = 59,

        /// <summary>
        /// Enum COD for value: COD
        /// </summary>
        [EnumMember(Value = "COD")]
        COD = 60,

        /// <summary>
        /// Enum DNK for value: DNK
        /// </summary>
        [EnumMember(Value = "DNK")]
        DNK = 61,

        /// <summary>
        /// Enum DJI for value: DJI
        /// </summary>
        [EnumMember(Value = "DJI")]
        DJI = 62,

        /// <summary>
        /// Enum DMA for value: DMA
        /// </summary>
        [EnumMember(Value = "DMA")]
        DMA = 63,

        /// <summary>
        /// Enum DOM for value: DOM
        /// </summary>
        [EnumMember(Value = "DOM")]
        DOM = 64,

        /// <summary>
        /// Enum ECU for value: ECU
        /// </summary>
        [EnumMember(Value = "ECU")]
        ECU = 65,

        /// <summary>
        /// Enum EGY for value: EGY
        /// </summary>
        [EnumMember(Value = "EGY")]
        EGY = 66,

        /// <summary>
        /// Enum SLV for value: SLV
        /// </summary>
        [EnumMember(Value = "SLV")]
        SLV = 67,

        /// <summary>
        /// Enum GNQ for value: GNQ
        /// </summary>
        [EnumMember(Value = "GNQ")]
        GNQ = 68,

        /// <summary>
        /// Enum ERI for value: ERI
        /// </summary>
        [EnumMember(Value = "ERI")]
        ERI = 69,

        /// <summary>
        /// Enum EST for value: EST
        /// </summary>
        [EnumMember(Value = "EST")]
        EST = 70,

        /// <summary>
        /// Enum SWZ for value: SWZ
        /// </summary>
        [EnumMember(Value = "SWZ")]
        SWZ = 71,

        /// <summary>
        /// Enum ETH for value: ETH
        /// </summary>
        [EnumMember(Value = "ETH")]
        ETH = 72,

        /// <summary>
        /// Enum EUE for value: EUE
        /// </summary>
        [EnumMember(Value = "EUE")]
        EUE = 73,

        /// <summary>
        /// Enum FLK for value: FLK
        /// </summary>
        [EnumMember(Value = "FLK")]
        FLK = 74,

        /// <summary>
        /// Enum FRO for value: FRO
        /// </summary>
        [EnumMember(Value = "FRO")]
        FRO = 75,

        /// <summary>
        /// Enum FSM for value: FSM
        /// </summary>
        [EnumMember(Value = "FSM")]
        FSM = 76,

        /// <summary>
        /// Enum FJI for value: FJI
        /// </summary>
        [EnumMember(Value = "FJI")]
        FJI = 77,

        /// <summary>
        /// Enum FIN for value: FIN
        /// </summary>
        [EnumMember(Value = "FIN")]
        FIN = 78,

        /// <summary>
        /// Enum FRA for value: FRA
        /// </summary>
        [EnumMember(Value = "FRA")]
        FRA = 79,

        /// <summary>
        /// Enum GUF for value: GUF
        /// </summary>
        [EnumMember(Value = "GUF")]
        GUF = 80,

        /// <summary>
        /// Enum PYF for value: PYF
        /// </summary>
        [EnumMember(Value = "PYF")]
        PYF = 81,

        /// <summary>
        /// Enum ATF for value: ATF
        /// </summary>
        [EnumMember(Value = "ATF")]
        ATF = 82,

        /// <summary>
        /// Enum GAB for value: GAB
        /// </summary>
        [EnumMember(Value = "GAB")]
        GAB = 83,

        /// <summary>
        /// Enum GMB for value: GMB
        /// </summary>
        [EnumMember(Value = "GMB")]
        GMB = 84,

        /// <summary>
        /// Enum GEO for value: GEO
        /// </summary>
        [EnumMember(Value = "GEO")]
        GEO = 85,

        /// <summary>
        /// Enum DEU for value: DEU
        /// </summary>
        [EnumMember(Value = "DEU")]
        DEU = 86,

        /// <summary>
        /// Enum GHA for value: GHA
        /// </summary>
        [EnumMember(Value = "GHA")]
        GHA = 87,

        /// <summary>
        /// Enum GIB for value: GIB
        /// </summary>
        [EnumMember(Value = "GIB")]
        GIB = 88,

        /// <summary>
        /// Enum GRC for value: GRC
        /// </summary>
        [EnumMember(Value = "GRC")]
        GRC = 89,

        /// <summary>
        /// Enum GRL for value: GRL
        /// </summary>
        [EnumMember(Value = "GRL")]
        GRL = 90,

        /// <summary>
        /// Enum GRD for value: GRD
        /// </summary>
        [EnumMember(Value = "GRD")]
        GRD = 91,

        /// <summary>
        /// Enum GLP for value: GLP
        /// </summary>
        [EnumMember(Value = "GLP")]
        GLP = 92,

        /// <summary>
        /// Enum GUM for value: GUM
        /// </summary>
        [EnumMember(Value = "GUM")]
        GUM = 93,

        /// <summary>
        /// Enum GTM for value: GTM
        /// </summary>
        [EnumMember(Value = "GTM")]
        GTM = 94,

        /// <summary>
        /// Enum GGY for value: GGY
        /// </summary>
        [EnumMember(Value = "GGY")]
        GGY = 95,

        /// <summary>
        /// Enum GIN for value: GIN
        /// </summary>
        [EnumMember(Value = "GIN")]
        GIN = 96,

        /// <summary>
        /// Enum GNB for value: GNB
        /// </summary>
        [EnumMember(Value = "GNB")]
        GNB = 97,

        /// <summary>
        /// Enum GUY for value: GUY
        /// </summary>
        [EnumMember(Value = "GUY")]
        GUY = 98,

        /// <summary>
        /// Enum HTI for value: HTI
        /// </summary>
        [EnumMember(Value = "HTI")]
        HTI = 99,

        /// <summary>
        /// Enum HMD for value: HMD
        /// </summary>
        [EnumMember(Value = "HMD")]
        HMD = 100,

        /// <summary>
        /// Enum VAT for value: VAT
        /// </summary>
        [EnumMember(Value = "VAT")]
        VAT = 101,

        /// <summary>
        /// Enum HND for value: HND
        /// </summary>
        [EnumMember(Value = "HND")]
        HND = 102,

        /// <summary>
        /// Enum HKG for value: HKG
        /// </summary>
        [EnumMember(Value = "HKG")]
        HKG = 103,

        /// <summary>
        /// Enum HUN for value: HUN
        /// </summary>
        [EnumMember(Value = "HUN")]
        HUN = 104,

        /// <summary>
        /// Enum ISL for value: ISL
        /// </summary>
        [EnumMember(Value = "ISL")]
        ISL = 105,

        /// <summary>
        /// Enum IND for value: IND
        /// </summary>
        [EnumMember(Value = "IND")]
        IND = 106,

        /// <summary>
        /// Enum IDN for value: IDN
        /// </summary>
        [EnumMember(Value = "IDN")]
        IDN = 107,

        /// <summary>
        /// Enum IRN for value: IRN
        /// </summary>
        [EnumMember(Value = "IRN")]
        IRN = 108,

        /// <summary>
        /// Enum IRQ for value: IRQ
        /// </summary>
        [EnumMember(Value = "IRQ")]
        IRQ = 109,

        /// <summary>
        /// Enum IRL for value: IRL
        /// </summary>
        [EnumMember(Value = "IRL")]
        IRL = 110,

        /// <summary>
        /// Enum IMN for value: IMN
        /// </summary>
        [EnumMember(Value = "IMN")]
        IMN = 111,

        /// <summary>
        /// Enum ISR for value: ISR
        /// </summary>
        [EnumMember(Value = "ISR")]
        ISR = 112,

        /// <summary>
        /// Enum ITA for value: ITA
        /// </summary>
        [EnumMember(Value = "ITA")]
        ITA = 113,

        /// <summary>
        /// Enum JAM for value: JAM
        /// </summary>
        [EnumMember(Value = "JAM")]
        JAM = 114,

        /// <summary>
        /// Enum JPN for value: JPN
        /// </summary>
        [EnumMember(Value = "JPN")]
        JPN = 115,

        /// <summary>
        /// Enum JEY for value: JEY
        /// </summary>
        [EnumMember(Value = "JEY")]
        JEY = 116,

        /// <summary>
        /// Enum JOR for value: JOR
        /// </summary>
        [EnumMember(Value = "JOR")]
        JOR = 117,

        /// <summary>
        /// Enum KAZ for value: KAZ
        /// </summary>
        [EnumMember(Value = "KAZ")]
        KAZ = 118,

        /// <summary>
        /// Enum KEN for value: KEN
        /// </summary>
        [EnumMember(Value = "KEN")]
        KEN = 119,

        /// <summary>
        /// Enum KIR for value: KIR
        /// </summary>
        [EnumMember(Value = "KIR")]
        KIR = 120,

        /// <summary>
        /// Enum XKX for value: XKX
        /// </summary>
        [EnumMember(Value = "XKX")]
        XKX = 121,

        /// <summary>
        /// Enum KWT for value: KWT
        /// </summary>
        [EnumMember(Value = "KWT")]
        KWT = 122,

        /// <summary>
        /// Enum KGZ for value: KGZ
        /// </summary>
        [EnumMember(Value = "KGZ")]
        KGZ = 123,

        /// <summary>
        /// Enum LAO for value: LAO
        /// </summary>
        [EnumMember(Value = "LAO")]
        LAO = 124,

        /// <summary>
        /// Enum LVA for value: LVA
        /// </summary>
        [EnumMember(Value = "LVA")]
        LVA = 125,

        /// <summary>
        /// Enum LBN for value: LBN
        /// </summary>
        [EnumMember(Value = "LBN")]
        LBN = 126,

        /// <summary>
        /// Enum LSO for value: LSO
        /// </summary>
        [EnumMember(Value = "LSO")]
        LSO = 127,

        /// <summary>
        /// Enum LBR for value: LBR
        /// </summary>
        [EnumMember(Value = "LBR")]
        LBR = 128,

        /// <summary>
        /// Enum LBY for value: LBY
        /// </summary>
        [EnumMember(Value = "LBY")]
        LBY = 129,

        /// <summary>
        /// Enum LIE for value: LIE
        /// </summary>
        [EnumMember(Value = "LIE")]
        LIE = 130,

        /// <summary>
        /// Enum LTU for value: LTU
        /// </summary>
        [EnumMember(Value = "LTU")]
        LTU = 131,

        /// <summary>
        /// Enum LUX for value: LUX
        /// </summary>
        [EnumMember(Value = "LUX")]
        LUX = 132,

        /// <summary>
        /// Enum MAC for value: MAC
        /// </summary>
        [EnumMember(Value = "MAC")]
        MAC = 133,

        /// <summary>
        /// Enum MKD for value: MKD
        /// </summary>
        [EnumMember(Value = "MKD")]
        MKD = 134,

        /// <summary>
        /// Enum MDG for value: MDG
        /// </summary>
        [EnumMember(Value = "MDG")]
        MDG = 135,

        /// <summary>
        /// Enum MWI for value: MWI
        /// </summary>
        [EnumMember(Value = "MWI")]
        MWI = 136,

        /// <summary>
        /// Enum MYS for value: MYS
        /// </summary>
        [EnumMember(Value = "MYS")]
        MYS = 137,

        /// <summary>
        /// Enum MDV for value: MDV
        /// </summary>
        [EnumMember(Value = "MDV")]
        MDV = 138,

        /// <summary>
        /// Enum MLI for value: MLI
        /// </summary>
        [EnumMember(Value = "MLI")]
        MLI = 139,

        /// <summary>
        /// Enum MLT for value: MLT
        /// </summary>
        [EnumMember(Value = "MLT")]
        MLT = 140,

        /// <summary>
        /// Enum MHL for value: MHL
        /// </summary>
        [EnumMember(Value = "MHL")]
        MHL = 141,

        /// <summary>
        /// Enum MTQ for value: MTQ
        /// </summary>
        [EnumMember(Value = "MTQ")]
        MTQ = 142,

        /// <summary>
        /// Enum MRT for value: MRT
        /// </summary>
        [EnumMember(Value = "MRT")]
        MRT = 143,

        /// <summary>
        /// Enum MUS for value: MUS
        /// </summary>
        [EnumMember(Value = "MUS")]
        MUS = 144,

        /// <summary>
        /// Enum MYT for value: MYT
        /// </summary>
        [EnumMember(Value = "MYT")]
        MYT = 145,

        /// <summary>
        /// Enum MEX for value: MEX
        /// </summary>
        [EnumMember(Value = "MEX")]
        MEX = 146,

        /// <summary>
        /// Enum MDA for value: MDA
        /// </summary>
        [EnumMember(Value = "MDA")]
        MDA = 147,

        /// <summary>
        /// Enum MCO for value: MCO
        /// </summary>
        [EnumMember(Value = "MCO")]
        MCO = 148,

        /// <summary>
        /// Enum MNG for value: MNG
        /// </summary>
        [EnumMember(Value = "MNG")]
        MNG = 149,

        /// <summary>
        /// Enum MNE for value: MNE
        /// </summary>
        [EnumMember(Value = "MNE")]
        MNE = 150,

        /// <summary>
        /// Enum MSR for value: MSR
        /// </summary>
        [EnumMember(Value = "MSR")]
        MSR = 151,

        /// <summary>
        /// Enum MAR for value: MAR
        /// </summary>
        [EnumMember(Value = "MAR")]
        MAR = 152,

        /// <summary>
        /// Enum MOZ for value: MOZ
        /// </summary>
        [EnumMember(Value = "MOZ")]
        MOZ = 153,

        /// <summary>
        /// Enum MMR for value: MMR
        /// </summary>
        [EnumMember(Value = "MMR")]
        MMR = 154,

        /// <summary>
        /// Enum NAM for value: NAM
        /// </summary>
        [EnumMember(Value = "NAM")]
        NAM = 155,

        /// <summary>
        /// Enum NRU for value: NRU
        /// </summary>
        [EnumMember(Value = "NRU")]
        NRU = 156,

        /// <summary>
        /// Enum NPL for value: NPL
        /// </summary>
        [EnumMember(Value = "NPL")]
        NPL = 157,

        /// <summary>
        /// Enum NLD for value: NLD
        /// </summary>
        [EnumMember(Value = "NLD")]
        NLD = 158,

        /// <summary>
        /// Enum ANT for value: ANT
        /// </summary>
        [EnumMember(Value = "ANT")]
        ANT = 159,

        /// <summary>
        /// Enum NCL for value: NCL
        /// </summary>
        [EnumMember(Value = "NCL")]
        NCL = 160,

        /// <summary>
        /// Enum NZL for value: NZL
        /// </summary>
        [EnumMember(Value = "NZL")]
        NZL = 161,

        /// <summary>
        /// Enum NIC for value: NIC
        /// </summary>
        [EnumMember(Value = "NIC")]
        NIC = 162,

        /// <summary>
        /// Enum NER for value: NER
        /// </summary>
        [EnumMember(Value = "NER")]
        NER = 163,

        /// <summary>
        /// Enum NGA for value: NGA
        /// </summary>
        [EnumMember(Value = "NGA")]
        NGA = 164,

        /// <summary>
        /// Enum NIU for value: NIU
        /// </summary>
        [EnumMember(Value = "NIU")]
        NIU = 165,

        /// <summary>
        /// Enum NFK for value: NFK
        /// </summary>
        [EnumMember(Value = "NFK")]
        NFK = 166,

        /// <summary>
        /// Enum PRK for value: PRK
        /// </summary>
        [EnumMember(Value = "PRK")]
        PRK = 167,

        /// <summary>
        /// Enum MNP for value: MNP
        /// </summary>
        [EnumMember(Value = "MNP")]
        MNP = 168,

        /// <summary>
        /// Enum NOR for value: NOR
        /// </summary>
        [EnumMember(Value = "NOR")]
        NOR = 169,

        /// <summary>
        /// Enum OMN for value: OMN
        /// </summary>
        [EnumMember(Value = "OMN")]
        OMN = 170,

        /// <summary>
        /// Enum PAK for value: PAK
        /// </summary>
        [EnumMember(Value = "PAK")]
        PAK = 171,

        /// <summary>
        /// Enum PLW for value: PLW
        /// </summary>
        [EnumMember(Value = "PLW")]
        PLW = 172,

        /// <summary>
        /// Enum PSE for value: PSE
        /// </summary>
        [EnumMember(Value = "PSE")]
        PSE = 173,

        /// <summary>
        /// Enum PAN for value: PAN
        /// </summary>
        [EnumMember(Value = "PAN")]
        PAN = 174,

        /// <summary>
        /// Enum PNG for value: PNG
        /// </summary>
        [EnumMember(Value = "PNG")]
        PNG = 175,

        /// <summary>
        /// Enum PRY for value: PRY
        /// </summary>
        [EnumMember(Value = "PRY")]
        PRY = 176,

        /// <summary>
        /// Enum PER for value: PER
        /// </summary>
        [EnumMember(Value = "PER")]
        PER = 177,

        /// <summary>
        /// Enum PHL for value: PHL
        /// </summary>
        [EnumMember(Value = "PHL")]
        PHL = 178,

        /// <summary>
        /// Enum PCN for value: PCN
        /// </summary>
        [EnumMember(Value = "PCN")]
        PCN = 179,

        /// <summary>
        /// Enum POL for value: POL
        /// </summary>
        [EnumMember(Value = "POL")]
        POL = 180,

        /// <summary>
        /// Enum PRT for value: PRT
        /// </summary>
        [EnumMember(Value = "PRT")]
        PRT = 181,

        /// <summary>
        /// Enum PRI for value: PRI
        /// </summary>
        [EnumMember(Value = "PRI")]
        PRI = 182,

        /// <summary>
        /// Enum QAT for value: QAT
        /// </summary>
        [EnumMember(Value = "QAT")]
        QAT = 183,

        /// <summary>
        /// Enum REU for value: REU
        /// </summary>
        [EnumMember(Value = "REU")]
        REU = 184,

        /// <summary>
        /// Enum ROU for value: ROU
        /// </summary>
        [EnumMember(Value = "ROU")]
        ROU = 185,

        /// <summary>
        /// Enum RUS for value: RUS
        /// </summary>
        [EnumMember(Value = "RUS")]
        RUS = 186,

        /// <summary>
        /// Enum RWA for value: RWA
        /// </summary>
        [EnumMember(Value = "RWA")]
        RWA = 187,

        /// <summary>
        /// Enum SHN for value: SHN
        /// </summary>
        [EnumMember(Value = "SHN")]
        SHN = 188,

        /// <summary>
        /// Enum KNA for value: KNA
        /// </summary>
        [EnumMember(Value = "KNA")]
        KNA = 189,

        /// <summary>
        /// Enum LCA for value: LCA
        /// </summary>
        [EnumMember(Value = "LCA")]
        LCA = 190,

        /// <summary>
        /// Enum SPM for value: SPM
        /// </summary>
        [EnumMember(Value = "SPM")]
        SPM = 191,

        /// <summary>
        /// Enum VCT for value: VCT
        /// </summary>
        [EnumMember(Value = "VCT")]
        VCT = 192,

        /// <summary>
        /// Enum BLM for value: BLM
        /// </summary>
        [EnumMember(Value = "BLM")]
        BLM = 193,

        /// <summary>
        /// Enum MAF for value: MAF
        /// </summary>
        [EnumMember(Value = "MAF")]
        MAF = 194,

        /// <summary>
        /// Enum WSM for value: WSM
        /// </summary>
        [EnumMember(Value = "WSM")]
        WSM = 195,

        /// <summary>
        /// Enum SMR for value: SMR
        /// </summary>
        [EnumMember(Value = "SMR")]
        SMR = 196,

        /// <summary>
        /// Enum STP for value: STP
        /// </summary>
        [EnumMember(Value = "STP")]
        STP = 197,

        /// <summary>
        /// Enum SAU for value: SAU
        /// </summary>
        [EnumMember(Value = "SAU")]
        SAU = 198,

        /// <summary>
        /// Enum SEN for value: SEN
        /// </summary>
        [EnumMember(Value = "SEN")]
        SEN = 199,

        /// <summary>
        /// Enum SRB for value: SRB
        /// </summary>
        [EnumMember(Value = "SRB")]
        SRB = 200,

        /// <summary>
        /// Enum SYC for value: SYC
        /// </summary>
        [EnumMember(Value = "SYC")]
        SYC = 201,

        /// <summary>
        /// Enum SLE for value: SLE
        /// </summary>
        [EnumMember(Value = "SLE")]
        SLE = 202,

        /// <summary>
        /// Enum SGP for value: SGP
        /// </summary>
        [EnumMember(Value = "SGP")]
        SGP = 203,

        /// <summary>
        /// Enum SVK for value: SVK
        /// </summary>
        [EnumMember(Value = "SVK")]
        SVK = 204,

        /// <summary>
        /// Enum SVN for value: SVN
        /// </summary>
        [EnumMember(Value = "SVN")]
        SVN = 205,

        /// <summary>
        /// Enum SLB for value: SLB
        /// </summary>
        [EnumMember(Value = "SLB")]
        SLB = 206,

        /// <summary>
        /// Enum SOM for value: SOM
        /// </summary>
        [EnumMember(Value = "SOM")]
        SOM = 207,

        /// <summary>
        /// Enum SOL for value: SOL
        /// </summary>
        [EnumMember(Value = "SOL")]
        SOL = 208,

        /// <summary>
        /// Enum ZAF for value: ZAF
        /// </summary>
        [EnumMember(Value = "ZAF")]
        ZAF = 209,

        /// <summary>
        /// Enum SGS for value: SGS
        /// </summary>
        [EnumMember(Value = "SGS")]
        SGS = 210,

        /// <summary>
        /// Enum KOR for value: KOR
        /// </summary>
        [EnumMember(Value = "KOR")]
        KOR = 211,

        /// <summary>
        /// Enum SSD for value: SSD
        /// </summary>
        [EnumMember(Value = "SSD")]
        SSD = 212,

        /// <summary>
        /// Enum ESP for value: ESP
        /// </summary>
        [EnumMember(Value = "ESP")]
        ESP = 213,

        /// <summary>
        /// Enum LKA for value: LKA
        /// </summary>
        [EnumMember(Value = "LKA")]
        LKA = 214,

        /// <summary>
        /// Enum SDN for value: SDN
        /// </summary>
        [EnumMember(Value = "SDN")]
        SDN = 215,

        /// <summary>
        /// Enum SUR for value: SUR
        /// </summary>
        [EnumMember(Value = "SUR")]
        SUR = 216,

        /// <summary>
        /// Enum SJM for value: SJM
        /// </summary>
        [EnumMember(Value = "SJM")]
        SJM = 217,

        /// <summary>
        /// Enum SWE for value: SWE
        /// </summary>
        [EnumMember(Value = "SWE")]
        SWE = 218,

        /// <summary>
        /// Enum CHE for value: CHE
        /// </summary>
        [EnumMember(Value = "CHE")]
        CHE = 219,

        /// <summary>
        /// Enum SYR for value: SYR
        /// </summary>
        [EnumMember(Value = "SYR")]
        SYR = 220,

        /// <summary>
        /// Enum TWN for value: TWN
        /// </summary>
        [EnumMember(Value = "TWN")]
        TWN = 221,

        /// <summary>
        /// Enum TJK for value: TJK
        /// </summary>
        [EnumMember(Value = "TJK")]
        TJK = 222,

        /// <summary>
        /// Enum TZA for value: TZA
        /// </summary>
        [EnumMember(Value = "TZA")]
        TZA = 223,

        /// <summary>
        /// Enum THA for value: THA
        /// </summary>
        [EnumMember(Value = "THA")]
        THA = 224,

        /// <summary>
        /// Enum TLS for value: TLS
        /// </summary>
        [EnumMember(Value = "TLS")]
        TLS = 225,

        /// <summary>
        /// Enum TGO for value: TGO
        /// </summary>
        [EnumMember(Value = "TGO")]
        TGO = 226,

        /// <summary>
        /// Enum TKL for value: TKL
        /// </summary>
        [EnumMember(Value = "TKL")]
        TKL = 227,

        /// <summary>
        /// Enum TON for value: TON
        /// </summary>
        [EnumMember(Value = "TON")]
        TON = 228,

        /// <summary>
        /// Enum TTO for value: TTO
        /// </summary>
        [EnumMember(Value = "TTO")]
        TTO = 229,

        /// <summary>
        /// Enum TUN for value: TUN
        /// </summary>
        [EnumMember(Value = "TUN")]
        TUN = 230,

        /// <summary>
        /// Enum TUR for value: TUR
        /// </summary>
        [EnumMember(Value = "TUR")]
        TUR = 231,

        /// <summary>
        /// Enum TKM for value: TKM
        /// </summary>
        [EnumMember(Value = "TKM")]
        TKM = 232,

        /// <summary>
        /// Enum TCA for value: TCA
        /// </summary>
        [EnumMember(Value = "TCA")]
        TCA = 233,

        /// <summary>
        /// Enum TUV for value: TUV
        /// </summary>
        [EnumMember(Value = "TUV")]
        TUV = 234,

        /// <summary>
        /// Enum UGA for value: UGA
        /// </summary>
        [EnumMember(Value = "UGA")]
        UGA = 235,

        /// <summary>
        /// Enum UKR for value: UKR
        /// </summary>
        [EnumMember(Value = "UKR")]
        UKR = 236,

        /// <summary>
        /// Enum ARE for value: ARE
        /// </summary>
        [EnumMember(Value = "ARE")]
        ARE = 237,

        /// <summary>
        /// Enum GBR for value: GBR
        /// </summary>
        [EnumMember(Value = "GBR")]
        GBR = 238,

        /// <summary>
        /// Enum UMI for value: UMI
        /// </summary>
        [EnumMember(Value = "UMI")]
        UMI = 239,

        /// <summary>
        /// Enum USA for value: USA
        /// </summary>
        [EnumMember(Value = "USA")]
        USA = 240,

        /// <summary>
        /// Enum URY for value: URY
        /// </summary>
        [EnumMember(Value = "URY")]
        URY = 241,

        /// <summary>
        /// Enum UZB for value: UZB
        /// </summary>
        [EnumMember(Value = "UZB")]
        UZB = 242,

        /// <summary>
        /// Enum VUT for value: VUT
        /// </summary>
        [EnumMember(Value = "VUT")]
        VUT = 243,

        /// <summary>
        /// Enum VEN for value: VEN
        /// </summary>
        [EnumMember(Value = "VEN")]
        VEN = 244,

        /// <summary>
        /// Enum VNM for value: VNM
        /// </summary>
        [EnumMember(Value = "VNM")]
        VNM = 245,

        /// <summary>
        /// Enum VIR for value: VIR
        /// </summary>
        [EnumMember(Value = "VIR")]
        VIR = 246,

        /// <summary>
        /// Enum WLF for value: WLF
        /// </summary>
        [EnumMember(Value = "WLF")]
        WLF = 247,

        /// <summary>
        /// Enum ESH for value: ESH
        /// </summary>
        [EnumMember(Value = "ESH")]
        ESH = 248,

        /// <summary>
        /// Enum YEM for value: YEM
        /// </summary>
        [EnumMember(Value = "YEM")]
        YEM = 249,

        /// <summary>
        /// Enum ZMB for value: ZMB
        /// </summary>
        [EnumMember(Value = "ZMB")]
        ZMB = 250,

        /// <summary>
        /// Enum ZWE for value: ZWE
        /// </summary>
        [EnumMember(Value = "ZWE")]
        ZWE = 251
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
                return EnumCountry.AFG;

            if (value.Equals("ALA"))
                return EnumCountry.ALA;

            if (value.Equals("ALB"))
                return EnumCountry.ALB;

            if (value.Equals("DZA"))
                return EnumCountry.DZA;

            if (value.Equals("ASM"))
                return EnumCountry.ASM;

            if (value.Equals("AND"))
                return EnumCountry.AND;

            if (value.Equals("AGO"))
                return EnumCountry.AGO;

            if (value.Equals("AIA"))
                return EnumCountry.AIA;

            if (value.Equals("ATA"))
                return EnumCountry.ATA;

            if (value.Equals("ATG"))
                return EnumCountry.ATG;

            if (value.Equals("ARG"))
                return EnumCountry.ARG;

            if (value.Equals("ARM"))
                return EnumCountry.ARM;

            if (value.Equals("ABW"))
                return EnumCountry.ABW;

            if (value.Equals("AUS"))
                return EnumCountry.AUS;

            if (value.Equals("AUT"))
                return EnumCountry.AUT;

            if (value.Equals("AZE"))
                return EnumCountry.AZE;

            if (value.Equals("AZO"))
                return EnumCountry.AZO;

            if (value.Equals("BHS"))
                return EnumCountry.BHS;

            if (value.Equals("BHR"))
                return EnumCountry.BHR;

            if (value.Equals("BGD"))
                return EnumCountry.BGD;

            if (value.Equals("BRB"))
                return EnumCountry.BRB;

            if (value.Equals("BLR"))
                return EnumCountry.BLR;

            if (value.Equals("BEL"))
                return EnumCountry.BEL;

            if (value.Equals("BLZ"))
                return EnumCountry.BLZ;

            if (value.Equals("BEN"))
                return EnumCountry.BEN;

            if (value.Equals("BMU"))
                return EnumCountry.BMU;

            if (value.Equals("BTN"))
                return EnumCountry.BTN;

            if (value.Equals("BOL"))
                return EnumCountry.BOL;

            if (value.Equals("BIH"))
                return EnumCountry.BIH;

            if (value.Equals("BWA"))
                return EnumCountry.BWA;

            if (value.Equals("BVT"))
                return EnumCountry.BVT;

            if (value.Equals("BRA"))
                return EnumCountry.BRA;

            if (value.Equals("IOT"))
                return EnumCountry.IOT;

            if (value.Equals("VGB"))
                return EnumCountry.VGB;

            if (value.Equals("BRN"))
                return EnumCountry.BRN;

            if (value.Equals("BGR"))
                return EnumCountry.BGR;

            if (value.Equals("BFA"))
                return EnumCountry.BFA;

            if (value.Equals("BDI"))
                return EnumCountry.BDI;

            if (value.Equals("KHM"))
                return EnumCountry.KHM;

            if (value.Equals("CMR"))
                return EnumCountry.CMR;

            if (value.Equals("CAN"))
                return EnumCountry.CAN;

            if (value.Equals("CPV"))
                return EnumCountry.CPV;

            if (value.Equals("CYM"))
                return EnumCountry.CYM;

            if (value.Equals("CAF"))
                return EnumCountry.CAF;

            if (value.Equals("TCD"))
                return EnumCountry.TCD;

            if (value.Equals("CHL"))
                return EnumCountry.CHL;

            if (value.Equals("CHN"))
                return EnumCountry.CHN;

            if (value.Equals("CXR"))
                return EnumCountry.CXR;

            if (value.Equals("CCK"))
                return EnumCountry.CCK;

            if (value.Equals("COL"))
                return EnumCountry.COL;

            if (value.Equals("COM"))
                return EnumCountry.COM;

            if (value.Equals("COG"))
                return EnumCountry.COG;

            if (value.Equals("COK"))
                return EnumCountry.COK;

            if (value.Equals("CRI"))
                return EnumCountry.CRI;

            if (value.Equals("CIV"))
                return EnumCountry.CIV;

            if (value.Equals("HRV"))
                return EnumCountry.HRV;

            if (value.Equals("CUB"))
                return EnumCountry.CUB;

            if (value.Equals("CYP"))
                return EnumCountry.CYP;

            if (value.Equals("CZE"))
                return EnumCountry.CZE;

            if (value.Equals("COD"))
                return EnumCountry.COD;

            if (value.Equals("DNK"))
                return EnumCountry.DNK;

            if (value.Equals("DJI"))
                return EnumCountry.DJI;

            if (value.Equals("DMA"))
                return EnumCountry.DMA;

            if (value.Equals("DOM"))
                return EnumCountry.DOM;

            if (value.Equals("ECU"))
                return EnumCountry.ECU;

            if (value.Equals("EGY"))
                return EnumCountry.EGY;

            if (value.Equals("SLV"))
                return EnumCountry.SLV;

            if (value.Equals("GNQ"))
                return EnumCountry.GNQ;

            if (value.Equals("ERI"))
                return EnumCountry.ERI;

            if (value.Equals("EST"))
                return EnumCountry.EST;

            if (value.Equals("SWZ"))
                return EnumCountry.SWZ;

            if (value.Equals("ETH"))
                return EnumCountry.ETH;

            if (value.Equals("EUE"))
                return EnumCountry.EUE;

            if (value.Equals("FLK"))
                return EnumCountry.FLK;

            if (value.Equals("FRO"))
                return EnumCountry.FRO;

            if (value.Equals("FSM"))
                return EnumCountry.FSM;

            if (value.Equals("FJI"))
                return EnumCountry.FJI;

            if (value.Equals("FIN"))
                return EnumCountry.FIN;

            if (value.Equals("FRA"))
                return EnumCountry.FRA;

            if (value.Equals("GUF"))
                return EnumCountry.GUF;

            if (value.Equals("PYF"))
                return EnumCountry.PYF;

            if (value.Equals("ATF"))
                return EnumCountry.ATF;

            if (value.Equals("GAB"))
                return EnumCountry.GAB;

            if (value.Equals("GMB"))
                return EnumCountry.GMB;

            if (value.Equals("GEO"))
                return EnumCountry.GEO;

            if (value.Equals("DEU"))
                return EnumCountry.DEU;

            if (value.Equals("GHA"))
                return EnumCountry.GHA;

            if (value.Equals("GIB"))
                return EnumCountry.GIB;

            if (value.Equals("GRC"))
                return EnumCountry.GRC;

            if (value.Equals("GRL"))
                return EnumCountry.GRL;

            if (value.Equals("GRD"))
                return EnumCountry.GRD;

            if (value.Equals("GLP"))
                return EnumCountry.GLP;

            if (value.Equals("GUM"))
                return EnumCountry.GUM;

            if (value.Equals("GTM"))
                return EnumCountry.GTM;

            if (value.Equals("GGY"))
                return EnumCountry.GGY;

            if (value.Equals("GIN"))
                return EnumCountry.GIN;

            if (value.Equals("GNB"))
                return EnumCountry.GNB;

            if (value.Equals("GUY"))
                return EnumCountry.GUY;

            if (value.Equals("HTI"))
                return EnumCountry.HTI;

            if (value.Equals("HMD"))
                return EnumCountry.HMD;

            if (value.Equals("VAT"))
                return EnumCountry.VAT;

            if (value.Equals("HND"))
                return EnumCountry.HND;

            if (value.Equals("HKG"))
                return EnumCountry.HKG;

            if (value.Equals("HUN"))
                return EnumCountry.HUN;

            if (value.Equals("ISL"))
                return EnumCountry.ISL;

            if (value.Equals("IND"))
                return EnumCountry.IND;

            if (value.Equals("IDN"))
                return EnumCountry.IDN;

            if (value.Equals("IRN"))
                return EnumCountry.IRN;

            if (value.Equals("IRQ"))
                return EnumCountry.IRQ;

            if (value.Equals("IRL"))
                return EnumCountry.IRL;

            if (value.Equals("IMN"))
                return EnumCountry.IMN;

            if (value.Equals("ISR"))
                return EnumCountry.ISR;

            if (value.Equals("ITA"))
                return EnumCountry.ITA;

            if (value.Equals("JAM"))
                return EnumCountry.JAM;

            if (value.Equals("JPN"))
                return EnumCountry.JPN;

            if (value.Equals("JEY"))
                return EnumCountry.JEY;

            if (value.Equals("JOR"))
                return EnumCountry.JOR;

            if (value.Equals("KAZ"))
                return EnumCountry.KAZ;

            if (value.Equals("KEN"))
                return EnumCountry.KEN;

            if (value.Equals("KIR"))
                return EnumCountry.KIR;

            if (value.Equals("XKX"))
                return EnumCountry.XKX;

            if (value.Equals("KWT"))
                return EnumCountry.KWT;

            if (value.Equals("KGZ"))
                return EnumCountry.KGZ;

            if (value.Equals("LAO"))
                return EnumCountry.LAO;

            if (value.Equals("LVA"))
                return EnumCountry.LVA;

            if (value.Equals("LBN"))
                return EnumCountry.LBN;

            if (value.Equals("LSO"))
                return EnumCountry.LSO;

            if (value.Equals("LBR"))
                return EnumCountry.LBR;

            if (value.Equals("LBY"))
                return EnumCountry.LBY;

            if (value.Equals("LIE"))
                return EnumCountry.LIE;

            if (value.Equals("LTU"))
                return EnumCountry.LTU;

            if (value.Equals("LUX"))
                return EnumCountry.LUX;

            if (value.Equals("MAC"))
                return EnumCountry.MAC;

            if (value.Equals("MKD"))
                return EnumCountry.MKD;

            if (value.Equals("MDG"))
                return EnumCountry.MDG;

            if (value.Equals("MWI"))
                return EnumCountry.MWI;

            if (value.Equals("MYS"))
                return EnumCountry.MYS;

            if (value.Equals("MDV"))
                return EnumCountry.MDV;

            if (value.Equals("MLI"))
                return EnumCountry.MLI;

            if (value.Equals("MLT"))
                return EnumCountry.MLT;

            if (value.Equals("MHL"))
                return EnumCountry.MHL;

            if (value.Equals("MTQ"))
                return EnumCountry.MTQ;

            if (value.Equals("MRT"))
                return EnumCountry.MRT;

            if (value.Equals("MUS"))
                return EnumCountry.MUS;

            if (value.Equals("MYT"))
                return EnumCountry.MYT;

            if (value.Equals("MEX"))
                return EnumCountry.MEX;

            if (value.Equals("MDA"))
                return EnumCountry.MDA;

            if (value.Equals("MCO"))
                return EnumCountry.MCO;

            if (value.Equals("MNG"))
                return EnumCountry.MNG;

            if (value.Equals("MNE"))
                return EnumCountry.MNE;

            if (value.Equals("MSR"))
                return EnumCountry.MSR;

            if (value.Equals("MAR"))
                return EnumCountry.MAR;

            if (value.Equals("MOZ"))
                return EnumCountry.MOZ;

            if (value.Equals("MMR"))
                return EnumCountry.MMR;

            if (value.Equals("NAM"))
                return EnumCountry.NAM;

            if (value.Equals("NRU"))
                return EnumCountry.NRU;

            if (value.Equals("NPL"))
                return EnumCountry.NPL;

            if (value.Equals("NLD"))
                return EnumCountry.NLD;

            if (value.Equals("ANT"))
                return EnumCountry.ANT;

            if (value.Equals("NCL"))
                return EnumCountry.NCL;

            if (value.Equals("NZL"))
                return EnumCountry.NZL;

            if (value.Equals("NIC"))
                return EnumCountry.NIC;

            if (value.Equals("NER"))
                return EnumCountry.NER;

            if (value.Equals("NGA"))
                return EnumCountry.NGA;

            if (value.Equals("NIU"))
                return EnumCountry.NIU;

            if (value.Equals("NFK"))
                return EnumCountry.NFK;

            if (value.Equals("PRK"))
                return EnumCountry.PRK;

            if (value.Equals("MNP"))
                return EnumCountry.MNP;

            if (value.Equals("NOR"))
                return EnumCountry.NOR;

            if (value.Equals("OMN"))
                return EnumCountry.OMN;

            if (value.Equals("PAK"))
                return EnumCountry.PAK;

            if (value.Equals("PLW"))
                return EnumCountry.PLW;

            if (value.Equals("PSE"))
                return EnumCountry.PSE;

            if (value.Equals("PAN"))
                return EnumCountry.PAN;

            if (value.Equals("PNG"))
                return EnumCountry.PNG;

            if (value.Equals("PRY"))
                return EnumCountry.PRY;

            if (value.Equals("PER"))
                return EnumCountry.PER;

            if (value.Equals("PHL"))
                return EnumCountry.PHL;

            if (value.Equals("PCN"))
                return EnumCountry.PCN;

            if (value.Equals("POL"))
                return EnumCountry.POL;

            if (value.Equals("PRT"))
                return EnumCountry.PRT;

            if (value.Equals("PRI"))
                return EnumCountry.PRI;

            if (value.Equals("QAT"))
                return EnumCountry.QAT;

            if (value.Equals("REU"))
                return EnumCountry.REU;

            if (value.Equals("ROU"))
                return EnumCountry.ROU;

            if (value.Equals("RUS"))
                return EnumCountry.RUS;

            if (value.Equals("RWA"))
                return EnumCountry.RWA;

            if (value.Equals("SHN"))
                return EnumCountry.SHN;

            if (value.Equals("KNA"))
                return EnumCountry.KNA;

            if (value.Equals("LCA"))
                return EnumCountry.LCA;

            if (value.Equals("SPM"))
                return EnumCountry.SPM;

            if (value.Equals("VCT"))
                return EnumCountry.VCT;

            if (value.Equals("BLM"))
                return EnumCountry.BLM;

            if (value.Equals("MAF"))
                return EnumCountry.MAF;

            if (value.Equals("WSM"))
                return EnumCountry.WSM;

            if (value.Equals("SMR"))
                return EnumCountry.SMR;

            if (value.Equals("STP"))
                return EnumCountry.STP;

            if (value.Equals("SAU"))
                return EnumCountry.SAU;

            if (value.Equals("SEN"))
                return EnumCountry.SEN;

            if (value.Equals("SRB"))
                return EnumCountry.SRB;

            if (value.Equals("SYC"))
                return EnumCountry.SYC;

            if (value.Equals("SLE"))
                return EnumCountry.SLE;

            if (value.Equals("SGP"))
                return EnumCountry.SGP;

            if (value.Equals("SVK"))
                return EnumCountry.SVK;

            if (value.Equals("SVN"))
                return EnumCountry.SVN;

            if (value.Equals("SLB"))
                return EnumCountry.SLB;

            if (value.Equals("SOM"))
                return EnumCountry.SOM;

            if (value.Equals("SOL"))
                return EnumCountry.SOL;

            if (value.Equals("ZAF"))
                return EnumCountry.ZAF;

            if (value.Equals("SGS"))
                return EnumCountry.SGS;

            if (value.Equals("KOR"))
                return EnumCountry.KOR;

            if (value.Equals("SSD"))
                return EnumCountry.SSD;

            if (value.Equals("ESP"))
                return EnumCountry.ESP;

            if (value.Equals("LKA"))
                return EnumCountry.LKA;

            if (value.Equals("SDN"))
                return EnumCountry.SDN;

            if (value.Equals("SUR"))
                return EnumCountry.SUR;

            if (value.Equals("SJM"))
                return EnumCountry.SJM;

            if (value.Equals("SWE"))
                return EnumCountry.SWE;

            if (value.Equals("CHE"))
                return EnumCountry.CHE;

            if (value.Equals("SYR"))
                return EnumCountry.SYR;

            if (value.Equals("TWN"))
                return EnumCountry.TWN;

            if (value.Equals("TJK"))
                return EnumCountry.TJK;

            if (value.Equals("TZA"))
                return EnumCountry.TZA;

            if (value.Equals("THA"))
                return EnumCountry.THA;

            if (value.Equals("TLS"))
                return EnumCountry.TLS;

            if (value.Equals("TGO"))
                return EnumCountry.TGO;

            if (value.Equals("TKL"))
                return EnumCountry.TKL;

            if (value.Equals("TON"))
                return EnumCountry.TON;

            if (value.Equals("TTO"))
                return EnumCountry.TTO;

            if (value.Equals("TUN"))
                return EnumCountry.TUN;

            if (value.Equals("TUR"))
                return EnumCountry.TUR;

            if (value.Equals("TKM"))
                return EnumCountry.TKM;

            if (value.Equals("TCA"))
                return EnumCountry.TCA;

            if (value.Equals("TUV"))
                return EnumCountry.TUV;

            if (value.Equals("UGA"))
                return EnumCountry.UGA;

            if (value.Equals("UKR"))
                return EnumCountry.UKR;

            if (value.Equals("ARE"))
                return EnumCountry.ARE;

            if (value.Equals("GBR"))
                return EnumCountry.GBR;

            if (value.Equals("UMI"))
                return EnumCountry.UMI;

            if (value.Equals("USA"))
                return EnumCountry.USA;

            if (value.Equals("URY"))
                return EnumCountry.URY;

            if (value.Equals("UZB"))
                return EnumCountry.UZB;

            if (value.Equals("VUT"))
                return EnumCountry.VUT;

            if (value.Equals("VEN"))
                return EnumCountry.VEN;

            if (value.Equals("VNM"))
                return EnumCountry.VNM;

            if (value.Equals("VIR"))
                return EnumCountry.VIR;

            if (value.Equals("WLF"))
                return EnumCountry.WLF;

            if (value.Equals("ESH"))
                return EnumCountry.ESH;

            if (value.Equals("YEM"))
                return EnumCountry.YEM;

            if (value.Equals("ZMB"))
                return EnumCountry.ZMB;

            if (value.Equals("ZWE"))
                return EnumCountry.ZWE;

            return null;
        }
    }

}
