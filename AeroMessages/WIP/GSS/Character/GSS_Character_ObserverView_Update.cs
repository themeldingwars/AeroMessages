using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.GSS.Character
{
    [AeroBlock]
    public struct Character_ObserverView_ShadowFieldUpdate
    {
        public enum ShadowFieldIndex : byte
        {
            StaticInfo              = 0x00,
            SpawnTime               = 0x01,
            EffectsFlags            = 0x02,
            GibVisualsID            = 0x03,
            ProcessDelay            = 0x04,
            CharacterState          = 0x05,
            HostilityInfo           = 0x06,
            PersonalFactionStance   = 0x07,
            CurrentHealthPct        = 0x08,
            MaxHealth               = 0x09,
            EmoteID                 = 0x0a,
            AttachedTo              = 0x0b,
            SnapMount               = 0x0c,
            SinFlags                = 0x0d,
            SinFactionsAcquiredBy   = 0x0e,
            SinTeamsAcquiredBy      = 0x0f,
            ArmyGUID                = 0x10,
            OwnerId                 = 0x11,
            NPCType                 = 0x12,
            DockedParams            = 0x13,
            LookAtTarget            = 0x14,
            WaterLevelAndDesc       = 0x15,
            CarryableObjects_0      = 0x16,
            CarryableObjects_1      = 0x17,
            CarryableObjects_2      = 0x18,
            RespawnTimes            = 0x19,
            SinCardType             = 0x1a,
            SinCardFields_0         = 0x1b,
            SinCardFields_1         = 0x1c,
            SinCardFields_2         = 0x1d,
            SinCardFields_3         = 0x1e,
            SinCardFields_4         = 0x1f,
            SinCardFields_5         = 0x20,
            SinCardFields_6         = 0x21,
            SinCardFields_7         = 0x22,
            SinCardFields_8         = 0x23,
            SinCardFields_9         = 0x24,
            SinCardFields_10        = 0x25,
            SinCardFields_11        = 0x26,
            SinCardFields_12        = 0x27,
            SinCardFields_13        = 0x28,
            SinCardFields_14        = 0x29,
            SinCardFields_15        = 0x2a,
            SinCardFields_16        = 0x2b,
            SinCardFields_17        = 0x2c,
            SinCardFields_18        = 0x2d,
            SinCardFields_19        = 0x2e,
            SinCardFields_20        = 0x2f,
            SinCardFields_21        = 0x30,
            SinCardFields_22        = 0x31,
            AssetOverrides          = 0x32,
        }

        public ShadowFieldIndex Idx;

        [AeroIf(nameof(Idx), ShadowFieldIndex.StaticInfo)]
        public StaticInfoData StaticInfo;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SpawnTime)]
        public uint SpawnTime;
        [AeroIf(nameof(Idx), ShadowFieldIndex.EffectsFlags)]
        public byte EffectsFlags;
        [AeroIf(nameof(Idx), ShadowFieldIndex.GibVisualsID)]
        public GibVisuals GibVisualsID;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ProcessDelay)]
        public uint ProcessDelay;
        [AeroIf(nameof(Idx), ShadowFieldIndex.CharacterState)]
        public CharacterStateData CharacterState; 
        [AeroIf(nameof(Idx), ShadowFieldIndex.HostilityInfo)]
        public HostilityInfoData HostilityInfo;
        [AeroIf(nameof(Idx), ShadowFieldIndex.PersonalFactionStance)]
        public PersonalFactionStanceData PersonalFactionStance;
        [AeroIf(nameof(Idx), ShadowFieldIndex.CurrentHealthPct)]
        public byte CurrentHealthPct;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MaxHealth)]
        public MaxVital MaxHealth;
        [AeroIf(nameof(Idx), ShadowFieldIndex.EmoteID)]
        public EmoteData EmoteID;
        [AeroIf(nameof(Idx), ShadowFieldIndex.AttachedTo)]
        public AttachedToData AttachedTo;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SnapMount)]
        public byte SnapMount;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinFlags)]
        public byte SinFlags;

        // TODO: Bitfield - SinFactionsAcquiredBy
        // [AeroIf(nameof(Idx), ShadowFieldIndex.SinFactionsAcquiredBy)]
        // public SinFactionsAcquiredByData SinFactionsAcquiredBy;
        // --
        // TODO: Bitfield - SinTeamsAcquiredBy
        // [AeroIf(nameof(Idx), ShadowFieldIndex.SinTeamsAcquiredBy)]
        // public SinTeamsAcquiredByData SinTeamsAcquiredBy;
        // --

        [AeroIf(nameof(Idx), ShadowFieldIndex.ArmyGUID)]
        public ulong ArmyGUID;
        [AeroIf(nameof(Idx), ShadowFieldIndex.OwnerId)]
        public ulong OwnerId;
        [AeroIf(nameof(Idx), ShadowFieldIndex.NPCType)]
        public uint NPCType;

        [AeroIf(nameof(Idx), ShadowFieldIndex.DockedParams)]
        [AeroArray(21)]
        public byte[] DockedParams;

        [AeroIf(nameof(Idx), ShadowFieldIndex.LookAtTarget)]
        public LookAtTargetData LookAtTarget;
        [AeroIf(nameof(Idx), ShadowFieldIndex.WaterLevelAndDesc)]
        public byte WaterLevelAndDesc;

        // TODO: Bitfield - CarryableObjects_0
        // [AeroIf(nameof(Idx), ShadowFieldIndex.CarryableObjects_0)]
        // -
        // TODO: Bitfield - CarryableObjects_1
        // [AeroIf(nameof(Idx), ShadowFieldIndex.CarryableObjects_1)]
        // -
        // TODO: Bitfield - CarryableObjects_2
        // [AeroIf(nameof(Idx), ShadowFieldIndex.CarryableObjects_2)]
        // -

        [AeroIf(nameof(Idx), ShadowFieldIndex.RespawnTimes)]
        public RespawnTimesData RespawnTimes;

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
        [AeroIf(nameof(Idx), ShadowFieldIndex.AssetOverrides)]
        public byte AssetOverrides;
    }

    [Aero]
    public partial class Character_ObserverView_Update
    {
        [AeroArray(-100)]
        public Character_ObserverView_ShadowFieldUpdate[] Updates;
    }
}