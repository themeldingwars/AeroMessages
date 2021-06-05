using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.GSS.Deployable
{
    [AeroBlock]
    public struct Deployable_ObserverView_ShadowFieldUpdate
    {
        public enum ShadowFieldIndex : byte
        {
            Type                       = 0x00,
            OwningEntity               = 0x01,
            AbilitySrcId               = 0x02,
            Position                   = 0x03,
            Orientation                = 0x04,
            AimPosition                = 0x05,
            AimDirection               = 0x06,
            ConstructedTime            = 0x07,
            CurrentHealthPct           = 0x08, // % integer
            MaxHealth                  = 0x09,
            Level                      = 0x0a,
            StatusEffectsChangeTime_0  = 0x0b,
            StatusEffectsChangeTime_1  = 0x0c,
            StatusEffectsChangeTime_2  = 0x0d,
            StatusEffectsChangeTime_3  = 0x0e,
            StatusEffectsChangeTime_4  = 0x0f,
            StatusEffectsChangeTime_5  = 0x10,
            StatusEffectsChangeTime_6  = 0x11,
            StatusEffectsChangeTime_7  = 0x12,
            StatusEffectsChangeTime_8  = 0x13,
            StatusEffectsChangeTime_9  = 0x14,
            StatusEffectsChangeTime_10 = 0x15,
            StatusEffectsChangeTime_11 = 0x16,
            StatusEffectsChangeTime_12 = 0x17,
            StatusEffectsChangeTime_13 = 0x18,
            StatusEffectsChangeTime_14 = 0x19,
            StatusEffectsChangeTime_15 = 0x1a,
            StatusEffectsChangeTime_16 = 0x1b,
            StatusEffectsChangeTime_17 = 0x1c,
            StatusEffectsChangeTime_18 = 0x1d,
            StatusEffectsChangeTime_19 = 0x1e,
            StatusEffectsChangeTime_20 = 0x1f,
            StatusEffectsChangeTime_21 = 0x20,
            StatusEffectsChangeTime_22 = 0x21,
            StatusEffectsChangeTime_23 = 0x22,
            StatusEffectsChangeTime_24 = 0x23,
            StatusEffectsChangeTime_25 = 0x24,
            StatusEffectsChangeTime_26 = 0x25,
            StatusEffectsChangeTime_27 = 0x26,
            StatusEffectsChangeTime_28 = 0x27,
            StatusEffectsChangeTime_29 = 0x28,
            StatusEffectsChangeTime_30 = 0x29,
            StatusEffectsChangeTime_31 = 0x2a,
            StatusEffects_0            = 0x2b,
            StatusEffects_1            = 0x2c,
            StatusEffects_2            = 0x2d,
            StatusEffects_3            = 0x2e,
            StatusEffects_4            = 0x2f,
            StatusEffects_5            = 0x30,
            StatusEffects_6            = 0x31,
            StatusEffects_7            = 0x32,
            StatusEffects_8            = 0x33,
            StatusEffects_9            = 0x34,
            StatusEffects_10           = 0x35,
            StatusEffects_11           = 0x36,
            StatusEffects_12           = 0x37,
            StatusEffects_13           = 0x38,
            StatusEffects_14           = 0x39,
            StatusEffects_15           = 0x3a,
            StatusEffects_16           = 0x3b,
            StatusEffects_17           = 0x3c,
            StatusEffects_18           = 0x3d,
            StatusEffects_19           = 0x3e,
            StatusEffects_20           = 0x3f,
            StatusEffects_21           = 0x40,
            StatusEffects_22           = 0x41,
            StatusEffects_23           = 0x42,
            StatusEffects_24           = 0x43,
            StatusEffects_25           = 0x44,
            StatusEffects_26           = 0x45,
            StatusEffects_27           = 0x46,
            StatusEffects_28           = 0x47,
            StatusEffects_29           = 0x48,
            StatusEffects_30           = 0x49,
            StatusEffects_31           = 0x4a,
            HostilityInfo              = 0x4b,
            PersonalFactionStance      = 0x4c,
            GibVisualsID               = 0x4d,
            ForcedMovement             = 0x4e,
            SinFlags                   = 0x4f,
            SinFactionsAcquiredBy      = 0x50,
            SinTeamsAcquiredBy         = 0x51,
            AttachedTo                 = 0x52,
            WarpaintColors             = 0x53,
            VisualInfoGroupIndex       = 0x54,
            CharacterStats             = 0x55,
            SinCardType                = 0x56,
            SinCardFields_0            = 0x57,
            SinCardFields_1            = 0x58,
            SinCardFields_2            = 0x59,
            SinCardFields_3            = 0x5a,
            SinCardFields_4            = 0x5b,
            SinCardFields_5            = 0x5c,
            SinCardFields_6            = 0x5d,
            SinCardFields_7            = 0x5e,
            SinCardFields_8            = 0x5f,
            SinCardFields_9            = 0x60,
            SinCardFields_10           = 0x61,
            SinCardFields_11           = 0x62,
            SinCardFields_12           = 0x63,
            SinCardFields_13           = 0x64,
            SinCardFields_14           = 0x65,
            SinCardFields_15           = 0x66,
            SinCardFields_16           = 0x67,
            SinCardFields_17           = 0x68,
            SinCardFields_18           = 0x69,
            SinCardFields_19           = 0x6a,
            ScalingLevel               = 0x6b,
            AppendageHealthPools_0     = 0x6c,
            AppendageHealthPools_1     = 0x6d,
            AppendageHealthPools_2     = 0x6e,
            AppendageHealthPools_3     = 0x6f,
            AppendageHealthPools_4     = 0x70,
            AppendageHealthPools_5     = 0x71,
            AppendageHealthPools_6     = 0x72,
            AppendageHealthPools_7     = 0x73,
            AppendageHealthPct_0       = 0x74,
            AppendageHealthPct_1       = 0x75,
            AppendageHealthPct_2       = 0x76,
            AppendageHealthPct_3       = 0x77,
            AppendageHealthPct_4       = 0x78,
            AppendageHealthPct_5       = 0x79,
            AppendageHealthPct_6       = 0x7a,
            AppendageHealthPct_7       = 0x7b,
        }

        public ShadowFieldIndex Idx;

        [AeroIf(nameof(Idx), ShadowFieldIndex.Type)]
        [AeroSdb("dbcharacter::Deployable", "id")]
        public uint Type;
        [AeroIf(nameof(Idx), ShadowFieldIndex.OwningEntity)]
        public EntityId OwningEntity;
        [AeroIf(nameof(Idx), ShadowFieldIndex.AbilitySrcId)]
        [AeroSdb("apt::AbilityData", "id")]
        public uint AbilitySrcId; // example in msgidx 123396
        [AeroIf(nameof(Idx), ShadowFieldIndex.Position)]
        public Vector3 Position;
        [AeroIf(nameof(Idx), ShadowFieldIndex.Orientation)]
        public Quaternion Orientation; // Rotation
        [AeroIf(nameof(Idx), ShadowFieldIndex.AimPosition)]
        public Vector3 AimPosition;
        [AeroIf(nameof(Idx), ShadowFieldIndex.AimDirection)]
        public Vector3 AimDirection;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ConstructedTime)]
        public uint ConstructedTime;
        [AeroIf(nameof(Idx), ShadowFieldIndex.CurrentHealthPct)]
        public byte CurrentHealthPct;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MaxHealth)]
        public int MaxHealth;
        [AeroIf(nameof(Idx), ShadowFieldIndex.Level)]
        public byte Level;

        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_0)]
        public ushort StatusEffectsChangeTime_0;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_1)]
        public ushort StatusEffectsChangeTime_1;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_2)]
        public ushort StatusEffectsChangeTime_2;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_3)]
        public ushort StatusEffectsChangeTime_3;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_4)]
        public ushort StatusEffectsChangeTime_4;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_5)]
        public ushort StatusEffectsChangeTime_5;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_6)]
        public ushort StatusEffectsChangeTime_6;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_7)]
        public ushort StatusEffectsChangeTime_7;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_8)]
        public ushort StatusEffectsChangeTime_8;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_9)]
        public ushort StatusEffectsChangeTime_9;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_10)]
        public ushort StatusEffectsChangeTime_10;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_11)]
        public ushort StatusEffectsChangeTime_11;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_12)]
        public ushort StatusEffectsChangeTime_12;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_13)]
        public ushort StatusEffectsChangeTime_13;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_14)]
        public ushort StatusEffectsChangeTime_14;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_15)]
        public ushort StatusEffectsChangeTime_15;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_16)]
        public ushort StatusEffectsChangeTime_16;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_17)]
        public ushort StatusEffectsChangeTime_17;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_18)]
        public ushort StatusEffectsChangeTime_18;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_19)]
        public ushort StatusEffectsChangeTime_19;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_20)]
        public ushort StatusEffectsChangeTime_20;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_21)]
        public ushort StatusEffectsChangeTime_21;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_22)]
        public ushort StatusEffectsChangeTime_22;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_23)]
        public ushort StatusEffectsChangeTime_23;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_24)]
        public ushort StatusEffectsChangeTime_24;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_25)]
        public ushort StatusEffectsChangeTime_25;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_26)]
        public ushort StatusEffectsChangeTime_26;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_27)]
        public ushort StatusEffectsChangeTime_27;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_28)]
        public ushort StatusEffectsChangeTime_28;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_29)]
        public ushort StatusEffectsChangeTime_29;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_30)]
        public ushort StatusEffectsChangeTime_30;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_31)]
        public ushort StatusEffectsChangeTime_31;

        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_0)]
        public StatusEffectData StatusEffects_0;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_1)]
        public StatusEffectData StatusEffects_1;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_2)]
        public StatusEffectData StatusEffects_2;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_3)]
        public StatusEffectData StatusEffects_3;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_4)]
        public StatusEffectData StatusEffects_4;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_5)]
        public StatusEffectData StatusEffects_5;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_6)]
        public StatusEffectData StatusEffects_6;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_7)]
        public StatusEffectData StatusEffects_7;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_8)]
        public StatusEffectData StatusEffects_8;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_9)]
        public StatusEffectData StatusEffects_9;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_10)]
        public StatusEffectData StatusEffects_10;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_11)]
        public StatusEffectData StatusEffects_11;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_12)]
        public StatusEffectData StatusEffects_12;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_13)]
        public StatusEffectData StatusEffects_13;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_14)]
        public StatusEffectData StatusEffects_14;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_15)]
        public StatusEffectData StatusEffects_15;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_16)]
        public StatusEffectData StatusEffects_16;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_17)]
        public StatusEffectData StatusEffects_17;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_18)]
        public StatusEffectData StatusEffects_18;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_19)]
        public StatusEffectData StatusEffects_19;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_20)]
        public StatusEffectData StatusEffects_20;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_21)]
        public StatusEffectData StatusEffects_21;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_22)]
        public StatusEffectData StatusEffects_22;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_23)]
        public StatusEffectData StatusEffects_23;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_24)]
        public StatusEffectData StatusEffects_24;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_25)]
        public StatusEffectData StatusEffects_25;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_26)]
        public StatusEffectData StatusEffects_26;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_27)]
        public StatusEffectData StatusEffects_27;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_28)]
        public StatusEffectData StatusEffects_28;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_29)]
        public StatusEffectData StatusEffects_29;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_30)]
        public StatusEffectData StatusEffects_30;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_31)]
        public StatusEffectData StatusEffects_31;

        [AeroIf(nameof(Idx), ShadowFieldIndex.HostilityInfo)]
        public HostilityInfoData HostilityInfo;

        [AeroIf(nameof(Idx), ShadowFieldIndex.PersonalFactionStance)]
        public PersonalFactionStanceData PersonalFactionStance;

        [AeroIf(nameof(Idx), ShadowFieldIndex.GibVisualsID)]
        public uint GibVisualsID;


        // TODO: Bitfield - ForcedMovement
        // [AeroIf(nameof(Idx), ShadowFieldIndex.ForcedMovement)]

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

        [AeroIf(nameof(Idx), ShadowFieldIndex.AttachedTo)]
        public EntityId AttachedTo;

        [AeroIf(nameof(Idx), ShadowFieldIndex.WarpaintColors)]
        [AeroArray(typeof(byte))]
        public ushort[] WarpaintColors;

        [AeroIf(nameof(Idx), ShadowFieldIndex.VisualInfoGroupIndex)]
        public byte VisualInfoGroupIndex; // TODO: Verify 

        [AeroIf(nameof(Idx), ShadowFieldIndex.CharacterStats)]
        public CharacterStatsData CharacterStats;

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

        [AeroIf(nameof(Idx), ShadowFieldIndex.ScalingLevel)]
        public uint ScalingLevel;

        // TODO: Bitfield - AppendageHealthPools
        /*
        [AeroIf(nameof(Idx), ShadowFieldIndex.AppendageHealthPools_0)]
        [AeroIf(nameof(Idx), ShadowFieldIndex.AppendageHealthPools_1)]
        [AeroIf(nameof(Idx), ShadowFieldIndex.AppendageHealthPools_2)]
        [AeroIf(nameof(Idx), ShadowFieldIndex.AppendageHealthPools_3)]
        [AeroIf(nameof(Idx), ShadowFieldIndex.AppendageHealthPools_4)]
        [AeroIf(nameof(Idx), ShadowFieldIndex.AppendageHealthPools_5)]
        [AeroIf(nameof(Idx), ShadowFieldIndex.AppendageHealthPools_6)]
        [AeroIf(nameof(Idx), ShadowFieldIndex.AppendageHealthPools_7)]    
         */

        [AeroIf(nameof(Idx), ShadowFieldIndex.AppendageHealthPct_0)]
        public byte AppendageHealthPct_0;
        [AeroIf(nameof(Idx), ShadowFieldIndex.AppendageHealthPct_1)]
        public byte AppendageHealthPct_1;
        [AeroIf(nameof(Idx), ShadowFieldIndex.AppendageHealthPct_2)]
        public byte AppendageHealthPct_2;
        [AeroIf(nameof(Idx), ShadowFieldIndex.AppendageHealthPct_3)]
        public byte AppendageHealthPct_3;
        [AeroIf(nameof(Idx), ShadowFieldIndex.AppendageHealthPct_4)]
        public byte AppendageHealthPct_4;
        [AeroIf(nameof(Idx), ShadowFieldIndex.AppendageHealthPct_5)]
        public byte AppendageHealthPct_5;
        [AeroIf(nameof(Idx), ShadowFieldIndex.AppendageHealthPct_6)]
        public byte AppendageHealthPct_6;
        [AeroIf(nameof(Idx), ShadowFieldIndex.AppendageHealthPct_7)]
        public byte AppendageHealthPct_7;
    }

    [Aero]
    public partial class Deployable_ObserverView_Update
    {
        [AeroArray(-6)]
        public Deployable_ObserverView_ShadowFieldUpdate[] Updates;
    }
}