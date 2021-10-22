using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.GSS.Vehicle
{
    [AeroBlock]
    public struct Vehicle_ObserverView_ShadowFieldUpdate
    {
        public enum ShadowFieldIndex : byte
        {
            VehicleType           = 0x00,
            Configuration         = 0x01,
            Flags                 = 0x02,
            EngineState           = 0x03,
            PathState             = 0x04,
            OwnerId               = 0x05,
            OwnerName             = 0x06,
            OwnerLocalString      = 0x07,
            OccupantIds_0         = 0x08,
            OccupantIds_1         = 0x09,
            OccupantIds_2         = 0x0a,
            OccupantIds_3         = 0x0b,
            OccupantIds_4         = 0x0c,
            OccupantIds_5         = 0x0d,
            DeployableIds_0       = 0x0e,
            DeployableIds_1       = 0x0f,
            DeployableIds_2       = 0x10,
            DeployableIds_3       = 0x11,
            DeployableIds_4       = 0x12,
            DeployableIds_5       = 0x13,
            DeployableIds_6       = 0x14,
            DeployableIds_7       = 0x15,
            DeployableIds_8       = 0x16,
            DeployableIds_9       = 0x17,
            SnapMount             = 0x18,
            ProcessDelay          = 0x19,
            HostilityInfo         = 0x1a,
            PersonalFactionStance = 0x1b,
            CurrentHealth         = 0x1c,
            MaxHealth             = 0x1d,
            CurrentShields        = 0x1e,
            MaxShields            = 0x1f,
            SinFlags              = 0x20,
            SinFactionsAcquiredBy = 0x21,
            SinTeamsAcquiredBy    = 0x22,
            WaterLevelAndDesc     = 0x23,
            EffectsFlags          = 0x24,
            SinCardType           = 0x25,
            SinCardFields_0       = 0x26,
            SinCardFields_1       = 0x27,
            SinCardFields_2       = 0x28,
            SinCardFields_3       = 0x29,
            SinCardFields_4       = 0x2a,
            SinCardFields_5       = 0x2b,
            SinCardFields_6       = 0x2c,
            SinCardFields_7       = 0x2d,
            SinCardFields_8       = 0x2e,
            SinCardFields_9       = 0x2f,
            SinCardFields_10      = 0x30,
            SinCardFields_11      = 0x31,
            SinCardFields_12      = 0x32,
            SinCardFields_13      = 0x33,
            SinCardFields_14      = 0x34,
            SinCardFields_15      = 0x35,
            SinCardFields_16      = 0x36,
            SinCardFields_17      = 0x37,
            SinCardFields_18      = 0x38,
            SinCardFields_19      = 0x39,
            SinCardFields_20      = 0x3a,
            SinCardFields_21      = 0x3b,
            SinCardFields_22      = 0x3c,
            ScopeBubbleInfo       = 0x3d,
            ScalingLevel          = 0x3e,
        }

        public ShadowFieldIndex Idx;

        [AeroIf(nameof(Idx), ShadowFieldIndex.VehicleType)]
        [AeroSdb("vcs::VehicleInfo", "id")]
        public ushort VehicleID;

        [AeroIf(nameof(Idx), ShadowFieldIndex.Configuration)]
        [AeroArray(32)]
        public byte[] Configuration;

        [AeroIf(nameof(Idx), ShadowFieldIndex.Flags)]
        [AeroArray(4)]
        public byte[] Flags;

        [AeroIf(nameof(Idx), ShadowFieldIndex.EngineState)]
        public byte EngineState; // 0 - off, 1 - ignition, 2 - drivable
        [AeroIf(nameof(Idx), ShadowFieldIndex.PathState)]
        public byte PathState;
        [AeroIf(nameof(Idx), ShadowFieldIndex.OwnerId)]
        public EntityId OwnerId;

        [AeroIf(nameof(Idx), ShadowFieldIndex.OwnerName)]
        [AeroString]
        public string OwnerName;

        [AeroIf(nameof(Idx), ShadowFieldIndex.OwnerLocalString)]
        [AeroSdb("dblocalization::LocalizedText", "id")]
        public uint OwnerLocalString;

        [AeroIf(nameof(Idx), ShadowFieldIndex.OccupantIds_0)]
        public EntityId OccupantIds_0;
        [AeroIf(nameof(Idx), ShadowFieldIndex.OccupantIds_1)]
        public EntityId OccupantIds_1;
        [AeroIf(nameof(Idx), ShadowFieldIndex.OccupantIds_2)]
        public EntityId OccupantIds_2;
        [AeroIf(nameof(Idx), ShadowFieldIndex.OccupantIds_3)]
        public EntityId OccupantIds_3;
        [AeroIf(nameof(Idx), ShadowFieldIndex.OccupantIds_4)]
        public EntityId OccupantIds_4;
        [AeroIf(nameof(Idx), ShadowFieldIndex.OccupantIds_5)]
        public EntityId OccupantIds_5;

        [AeroIf(nameof(Idx), ShadowFieldIndex.DeployableIds_0)]
        [AeroArray(13)]
        public byte[] DeployableIds_0;
        [AeroIf(nameof(Idx), ShadowFieldIndex.DeployableIds_1)]
        [AeroArray(13)]
        public byte[] DeployableIds_1;
        [AeroIf(nameof(Idx), ShadowFieldIndex.DeployableIds_2)]
        [AeroArray(13)]
        public byte[] DeployableIds_2;
        [AeroIf(nameof(Idx), ShadowFieldIndex.DeployableIds_3)]
        [AeroArray(13)]
        public byte[] DeployableIds_3;
        [AeroIf(nameof(Idx), ShadowFieldIndex.DeployableIds_4)]
        [AeroArray(13)]
        public byte[] DeployableIds_4;
        [AeroIf(nameof(Idx), ShadowFieldIndex.DeployableIds_5)]
        [AeroArray(13)]
        public byte[] DeployableIds_5;
        [AeroIf(nameof(Idx), ShadowFieldIndex.DeployableIds_6)]
        [AeroArray(13)]
        public byte[] DeployableIds_6;
        [AeroIf(nameof(Idx), ShadowFieldIndex.DeployableIds_7)]
        [AeroArray(13)]
        public byte[] DeployableIds_7;
        [AeroIf(nameof(Idx), ShadowFieldIndex.DeployableIds_8)]
        [AeroArray(13)]
        public byte[] DeployableIds_8;
        [AeroIf(nameof(Idx), ShadowFieldIndex.DeployableIds_9)]
        [AeroArray(13)]
        public byte[] DeployableIds_9;

        [AeroIf(nameof(Idx), ShadowFieldIndex.SnapMount)]
        public byte SnapMount;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ProcessDelay)]
        public uint ProcessDelay;
        [AeroIf(nameof(Idx), ShadowFieldIndex.HostilityInfo)]
        public HostilityInfoData HostilityInfo;
        [AeroIf(nameof(Idx), ShadowFieldIndex.PersonalFactionStance)]
        public PersonalFactionStanceData PersonalFactionStance;
        [AeroIf(nameof(Idx), ShadowFieldIndex.CurrentHealth)]
        public uint CurrentHealth;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MaxHealth)]
        public uint MaxHealth;
        [AeroIf(nameof(Idx), ShadowFieldIndex.CurrentShields)]
        public uint CurrentShields;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MaxShields)]
        public uint MaxShields;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinFlags)]
        public byte SinFlags;

        // TODO: Bitfield - SinFactionsAcquiredBy
        //[AeroIf(nameof(Idx), ShadowFieldIndex.SinFactionsAcquiredBy)]// 
        //public SinFactionsAcquiredByData SinFactionsAcquiredBy;
        // --
        // TODO: Bitfield - SinTeamsAcquiredBy
        //[AeroIf(nameof(Idx), ShadowFieldIndex.SinTeamsAcquiredBy)]// 
        //public SinTeamsAcquiredByData SinTeamsAcquiredBy;
        // --

        [AeroIf(nameof(Idx), ShadowFieldIndex.WaterLevelAndDesc)]
        public byte WaterLevelAndDesc;
        [AeroIf(nameof(Idx), ShadowFieldIndex.EffectsFlags)]
        public byte EffectsFlags;

        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardType)]
        [AeroSdb("dbencounterdata::SinCardTemplate", "Id")]
        //[AeroSdb("dbencounterdata::SinCardFields", "TemplateId")]
        public uint SinCardType;
        
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_0)]
        public SinCardFieldData SinCardFields_0;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_1)]
        public SinCardFieldData SinCardFields_1;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_2)]
        public SinCardFieldData SinCardFields_2;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_3)]
        public SinCardFieldData SinCardFields_3;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_4)]
        public SinCardFieldData SinCardFields_4;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_5)]
        public SinCardFieldData SinCardFields_5;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_6)]
        public SinCardFieldData SinCardFields_6;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_7)]
        public SinCardFieldData SinCardFields_7;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_8)]
        public SinCardFieldData SinCardFields_8;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_9)]
        public SinCardFieldData SinCardFields_9;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_10)]
        public SinCardFieldData SinCardFields_10;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_11)]
        public SinCardFieldData SinCardFields_11;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_12)]
        public SinCardFieldData SinCardFields_12;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_13)]
        public SinCardFieldData SinCardFields_13;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_14)]
        public SinCardFieldData SinCardFields_14;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_15)]
        public SinCardFieldData SinCardFields_15;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_16)]
        public SinCardFieldData SinCardFields_16;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_17)]
        public SinCardFieldData SinCardFields_17;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_18)]
        public SinCardFieldData SinCardFields_18;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_19)]
        public SinCardFieldData SinCardFields_19;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_20)]
        public SinCardFieldData SinCardFields_20;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_21)]
        public SinCardFieldData SinCardFields_21;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_22)]
        public SinCardFieldData SinCardFields_22;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ScopeBubbleInfo)]
        public ScopeBubbleInfoData ScopeBubbleInfo;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ScalingLevel)]
        public uint ScalingLevel;
    }

    //[Aero]
    //[AeroMessageId(MsgType.GSS, MsgSrc.Message, 29, 1)]
    public partial class Vehicle_ObserverView_Update
    {
        [AeroArray(-124)]
        public Vehicle_ObserverView_ShadowFieldUpdate[] Updates;
    }
}