using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.GSS.Character
{
    [AeroBlock]
    public struct Character_CombatController_ShadowFieldUpdate
    {
        public enum ShadowFieldIndex : byte
        {
            StatusEffectsChangeTime_0  = 0x00,
            StatusEffectsChangeTime_1  = 0x01,
            StatusEffectsChangeTime_2  = 0x02,
            StatusEffectsChangeTime_3  = 0x03,
            StatusEffectsChangeTime_4  = 0x04,
            StatusEffectsChangeTime_5  = 0x05,
            StatusEffectsChangeTime_6  = 0x06,
            StatusEffectsChangeTime_7  = 0x07,
            StatusEffectsChangeTime_8  = 0x08,
            StatusEffectsChangeTime_9  = 0x09,
            StatusEffectsChangeTime_10 = 0x0a,
            StatusEffectsChangeTime_11 = 0x0b,
            StatusEffectsChangeTime_12 = 0x0c,
            StatusEffectsChangeTime_13 = 0x0d,
            StatusEffectsChangeTime_14 = 0x0e,
            StatusEffectsChangeTime_15 = 0x0f,
            StatusEffectsChangeTime_16 = 0x10,
            StatusEffectsChangeTime_17 = 0x11,
            StatusEffectsChangeTime_18 = 0x12,
            StatusEffectsChangeTime_19 = 0x13,
            StatusEffectsChangeTime_20 = 0x14,
            StatusEffectsChangeTime_21 = 0x15,
            StatusEffectsChangeTime_22 = 0x16,
            StatusEffectsChangeTime_23 = 0x17,
            StatusEffectsChangeTime_24 = 0x18,
            StatusEffectsChangeTime_25 = 0x19,
            StatusEffectsChangeTime_26 = 0x1a,
            StatusEffectsChangeTime_27 = 0x1b,
            StatusEffectsChangeTime_28 = 0x1c,
            StatusEffectsChangeTime_29 = 0x1d,
            StatusEffectsChangeTime_30 = 0x1e,
            StatusEffectsChangeTime_31 = 0x1f,
            StatusEffects_0            = 0x20,
            StatusEffects_1            = 0x21,
            StatusEffects_2            = 0x22,
            StatusEffects_3            = 0x23,
            StatusEffects_4            = 0x24,
            StatusEffects_5            = 0x25,
            StatusEffects_6            = 0x26,
            StatusEffects_7            = 0x27,
            StatusEffects_8            = 0x28,
            StatusEffects_9            = 0x29,
            StatusEffects_10           = 0x2a,
            StatusEffects_11           = 0x2b,
            StatusEffects_12           = 0x2c,
            StatusEffects_13           = 0x2d,
            StatusEffects_14           = 0x2e,
            StatusEffects_15           = 0x2f,
            StatusEffects_16           = 0x30,
            StatusEffects_17           = 0x31,
            StatusEffects_18           = 0x32,
            StatusEffects_19           = 0x33,
            StatusEffects_20           = 0x34,
            StatusEffects_21           = 0x35,
            StatusEffects_22           = 0x36,
            StatusEffects_23           = 0x37,
            StatusEffects_24           = 0x38,
            StatusEffects_25           = 0x39,
            StatusEffects_26           = 0x3a,
            StatusEffects_27           = 0x3b,
            StatusEffects_28           = 0x3c,
            StatusEffects_29           = 0x3d,
            StatusEffects_30           = 0x3e,
            StatusEffects_31           = 0x3f,
            RunSpeedMult               = 0x40,
            FwdRunSpeedMult            = 0x41,
            JumpHeightMult             = 0x42,
            AirControlMult             = 0x43,
            ThrustStrengthMult         = 0x44,
            ThrustAirControl           = 0x45,
            Friction                   = 0x46,
            AmmoConsumption            = 0x47,
            MaxTurnRate                = 0x48,
            TurnSpeed                  = 0x49,
            TimeDilation               = 0x4a,
            FireRateModifier           = 0x4b,
            AccuracyModifier           = 0x4c,
            GravityMult                = 0x4d,
            AirResistanceMult          = 0x4e,
            WeaponChargeupMod          = 0x4f,
            WeaponDamageDealtMod       = 0x50,
            FireMode_0                 = 0x51,
            FireMode_1                 = 0x52,
            Clip_0                     = 0x53,
            Clip_1                     = 0x54,
            AltClip_0                  = 0x55,
            AltClip_1                  = 0x56,
            Ammo_0                     = 0x57,
            Ammo_1                     = 0x58,
            AltAmmo_0                  = 0x59,
            AltAmmo_1                  = 0x5a,
            WeaponIndex                = 0x5b,
            WeaponFireBaseTime         = 0x5c,
            WeaponAgilityMod           = 0x5d,
            CombatFlags                = 0x5e,
            PermissionFlags            = 0x5f,
            GliderProfileId            = 0x60,
            HoverProfileId             = 0x61,
            CombatTimer_0              = 0x62,
            CombatTimer_1              = 0x63,
            Nemeses                    = 0x64,
            SuperCharge                = 0x65,
            NoSpreadFlags              = 0x66,
            AppendageHealthPools_0     = 0x67,
            AppendageHealthPools_1     = 0x68,
            AppendageHealthPools_2     = 0x69,
            AppendageHealthPools_3     = 0x6a,
            AppendageHealthPools_4     = 0x6b,
            AppendageHealthPools_5     = 0x6c,
            AppendageHealthPools_6     = 0x6d,
            AppendageHealthPools_7     = 0x6e,
            AppendageHealthPools_8     = 0x6f,
            AppendageHealthPools_9     = 0x70,
            AppendageHealthPct_0       = 0x71,
            AppendageHealthPct_1       = 0x72,
            AppendageHealthPct_2       = 0x73,
            AppendageHealthPct_3       = 0x74,
            AppendageHealthPct_4       = 0x75,
            AppendageHealthPct_5       = 0x76,
            AppendageHealthPct_6       = 0x77,
            AppendageHealthPct_7       = 0x78,
            AppendageHealthPct_8       = 0x79,
            AppendageHealthPct_9       = 0x7a,
        }

        public ShadowFieldIndex Idx;

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
        [AeroIf(nameof(Idx), ShadowFieldIndex.RunSpeedMult)]
        public StatMultiplierData RunSpeedMult;
        [AeroIf(nameof(Idx), ShadowFieldIndex.FwdRunSpeedMult)]
        public StatMultiplierData FwdRunSpeedMult;
        [AeroIf(nameof(Idx), ShadowFieldIndex.JumpHeightMult)]
        public StatMultiplierData JumpHeightMult;
        [AeroIf(nameof(Idx), ShadowFieldIndex.AirControlMult)]
        public StatMultiplierData AirControlMult;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ThrustStrengthMult)]
        public StatMultiplierData ThrustStrengthMult;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ThrustAirControl)]
        public StatMultiplierData ThrustAirControl;
        [AeroIf(nameof(Idx), ShadowFieldIndex.Friction)]
        public StatMultiplierData Friction;
        [AeroIf(nameof(Idx), ShadowFieldIndex.AmmoConsumption)]
        public StatMultiplierData AmmoConsumption;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MaxTurnRate)]
        public StatMultiplierData MaxTurnRate;
        [AeroIf(nameof(Idx), ShadowFieldIndex.TurnSpeed)]
        public StatMultiplierData TurnSpeed;
        [AeroIf(nameof(Idx), ShadowFieldIndex.TimeDilation)]
        public StatMultiplierData TimeDilation;
        [AeroIf(nameof(Idx), ShadowFieldIndex.FireRateModifier)]
        public StatMultiplierData FireRateModifier;
        [AeroIf(nameof(Idx), ShadowFieldIndex.AccuracyModifier)]
        public StatMultiplierData AccuracyModifier;
        [AeroIf(nameof(Idx), ShadowFieldIndex.GravityMult)]
        public StatMultiplierData GravityMult;
        [AeroIf(nameof(Idx), ShadowFieldIndex.AirResistanceMult)]
        public StatMultiplierData AirResistanceMult;
        [AeroIf(nameof(Idx), ShadowFieldIndex.WeaponChargeupMod)]
        public StatMultiplierData WeaponChargeupMod;
        [AeroIf(nameof(Idx), ShadowFieldIndex.WeaponDamageDealtMod)]
        public StatMultiplierData WeaponDamageDealtMod;
        [AeroIf(nameof(Idx), ShadowFieldIndex.FireMode_0)]
        public FireModeData FireMode_0;
        [AeroIf(nameof(Idx), ShadowFieldIndex.FireMode_1)]
        public FireModeData FireMode_1;
        [AeroIf(nameof(Idx), ShadowFieldIndex.Clip_0)]
        public ushort Clip_0;
        [AeroIf(nameof(Idx), ShadowFieldIndex.Clip_1)]
        public ushort Clip_1;
        [AeroIf(nameof(Idx), ShadowFieldIndex.AltClip_0)]
        public ushort AltClip_0;
        [AeroIf(nameof(Idx), ShadowFieldIndex.AltClip_1)]
        public ushort AltClip_1;
        [AeroIf(nameof(Idx), ShadowFieldIndex.Ammo_0)]
        public ushort Ammo_0;
        [AeroIf(nameof(Idx), ShadowFieldIndex.Ammo_1)]
        public ushort Ammo_1;
        [AeroIf(nameof(Idx), ShadowFieldIndex.AltAmmo_0)]
        public ushort AltAmmo_0;
        [AeroIf(nameof(Idx), ShadowFieldIndex.AltAmmo_1)]
        public ushort AltAmmo_1;
        [AeroIf(nameof(Idx), ShadowFieldIndex.WeaponIndex)]
        public WeaponIndexData WeaponIndex;
        [AeroIf(nameof(Idx), ShadowFieldIndex.WeaponFireBaseTime)]
        public WeaponFireBaseTimeData WeaponFireBaseTime;
        [AeroIf(nameof(Idx), ShadowFieldIndex.WeaponAgilityMod)]
        public float WeaponAgilityMod;
        [AeroIf(nameof(Idx), ShadowFieldIndex.CombatFlags)]
        public CombatFlagsData CombatFlags;
        [AeroIf(nameof(Idx), ShadowFieldIndex.PermissionFlags)]
        public PermissionFlagsData PermissionFlags;
        [AeroIf(nameof(Idx), ShadowFieldIndex.GliderProfileId)]
        public uint GliderProfileId;
        [AeroIf(nameof(Idx), ShadowFieldIndex.HoverProfileId)]
        public uint HoverProfileId;
        [AeroIf(nameof(Idx), ShadowFieldIndex.CombatTimer_0)]
        public uint CombatTimer_0;
        [AeroIf(nameof(Idx), ShadowFieldIndex.CombatTimer_1)]
        public byte CombatTimer_1;
        [AeroIf(nameof(Idx), ShadowFieldIndex.Nemeses)]
        public byte Nemeses; // TODO: Likely more if we have content
        [AeroIf(nameof(Idx), ShadowFieldIndex.SuperCharge)]
        public SuperChargeData SuperCharge;
        [AeroIf(nameof(Idx), ShadowFieldIndex.NoSpreadFlags)]
        public byte NoSpreadFlags;

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
        [AeroIf(nameof(Idx), ShadowFieldIndex.AppendageHealthPools_8)]
        [AeroIf(nameof(Idx), ShadowFieldIndex.AppendageHealthPools_9)]
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
        [AeroIf(nameof(Idx), ShadowFieldIndex.AppendageHealthPct_8)]
        public byte AppendageHealthPct_8;
        [AeroIf(nameof(Idx), ShadowFieldIndex.AppendageHealthPct_9)]
        public byte AppendageHealthPct_9;
    }

    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 5, 1)]
    public partial class Character_CombatController_Update
    {
        [AeroArray(-244)]
        public Character_CombatController_ShadowFieldUpdate[] Updates;
    }
}