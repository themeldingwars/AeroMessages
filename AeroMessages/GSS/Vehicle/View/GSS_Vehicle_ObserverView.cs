using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
using Aero.Gen;

namespace AeroMessages.GSS.Vehicle
{
    [Aero(AeroGenTypes.View)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 29, 1)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 29, 3)]
    public partial class Vehicle_ObserverView
    {
        [AeroSdb("vcs::VehicleInfo", "id")]
        private ushort VehicleType;

        [AeroArray(32)]
        private byte[] Configuration;

        [AeroArray(4)]
        private byte[] Flags;

        private byte EngineState; // 0x03, 0 - off, 1 - ignition, 2 - drivable
        private byte PathState;
        private EntityId OwnerId;

        [AeroString]
        private string OwnerName;

        [AeroSdb("dblocalization::LocalizedText", "id")]
        private uint OwnerLocalString;

        private EntityId OccupantIds_0;
        private EntityId OccupantIds_1;
        private EntityId OccupantIds_2;
        private EntityId OccupantIds_3;
        private EntityId OccupantIds_4;
        private EntityId OccupantIds_5;

        [AeroArray(13)]
        private byte[] DeployableIds_0;
        [AeroArray(13)]
        private byte[] DeployableIds_1;
        [AeroArray(13)]
        private byte[] DeployableIds_2;
        [AeroArray(13)]
        private byte[] DeployableIds_3;
        [AeroArray(13)]
        private byte[] DeployableIds_4;
        [AeroArray(13)]
        private byte[] DeployableIds_5;
        [AeroArray(13)]
        private byte[] DeployableIds_6;
        [AeroArray(13)]
        private byte[] DeployableIds_7;
        [AeroArray(13)]
        private byte[] DeployableIds_8;
        [AeroArray(13)]
        private byte[] DeployableIds_9;

        private byte SnapMount;
        private uint ProcessDelay;
        private HostilityInfoData HostilityInfo;
        
        [AeroNullable] private PersonalFactionStanceData PersonalFactionStance;

        private uint CurrentHealth;
        private uint MaxHealth;
        private uint CurrentShields;
        private uint MaxShields;
        private byte SinFlags;

        // TODO: Bitfield - SinFactionsAcquiredBy
        [AeroNullable] private SinFactionsAcquiredByData SinFactionsAcquiredBy;
        // --
        // TODO: Bitfield - SinTeamsAcquiredBy
        [AeroNullable] private SinTeamsAcquiredByData SinTeamsAcquiredBy;
        // --

        private byte WaterLevelAndDesc;
        private byte EffectsFlags;

        [AeroSdb("dbencounterdata::SinCardTemplate", "Id")]
        //[AeroSdb("dbencounterdata::SinCardFields", "TemplateId")]
        private uint SinCardType;
        
        [AeroNullable] private SinCardFieldData SinCardFields_0;

        [AeroNullable] private SinCardFieldData SinCardFields_1;

        [AeroNullable] private SinCardFieldData SinCardFields_2;

        [AeroNullable] private SinCardFieldData SinCardFields_3;

        [AeroNullable] private SinCardFieldData SinCardFields_4;

        [AeroNullable] private SinCardFieldData SinCardFields_5;

        [AeroNullable] private SinCardFieldData SinCardFields_6;

        [AeroNullable] private SinCardFieldData SinCardFields_7;

        [AeroNullable] private SinCardFieldData SinCardFields_8;

        [AeroNullable] private SinCardFieldData SinCardFields_9;

        [AeroNullable] private SinCardFieldData SinCardFields_10;

        [AeroNullable] private SinCardFieldData SinCardFields_11;

        [AeroNullable] private SinCardFieldData SinCardFields_12;

        [AeroNullable] private SinCardFieldData SinCardFields_13;

        [AeroNullable] private SinCardFieldData SinCardFields_14;

        [AeroNullable] private SinCardFieldData SinCardFields_15;

        [AeroNullable] private SinCardFieldData SinCardFields_16;

        [AeroNullable] private SinCardFieldData SinCardFields_17;

        [AeroNullable] private SinCardFieldData SinCardFields_18;

        [AeroNullable] private SinCardFieldData SinCardFields_19;

        [AeroNullable] private SinCardFieldData SinCardFields_20;

        [AeroNullable] private SinCardFieldData SinCardFields_21;

        [AeroNullable] private SinCardFieldData SinCardFields_22;

        private ScopeBubbleInfoData ScopeBubbleInfo;
        private uint ScalingLevel;
    }
}