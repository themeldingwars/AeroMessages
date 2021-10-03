using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.GSS.Vehicle
{
    [AeroBlock]
    public struct Vehicle_CombatController_ShadowFieldUpdate
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
            SlottedAbility_0           = 0x40,
            SlottedAbility_1           = 0x41,
            SlottedAbility_2           = 0x42,
            SlottedAbility_3           = 0x43,
            SlottedAbility_4           = 0x44,
            SlottedAbility_5           = 0x45,
            SlottedAbility_6           = 0x46,
            SlottedAbility_7           = 0x47,
            SlottedAbility_8           = 0x48,
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
        [AeroIf(nameof(Idx), ShadowFieldIndex.SlottedAbility_0)]
        [AeroSdb("apt::AbilityData", "id")]
        public uint SlottedAbility_0;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SlottedAbility_1)]
        [AeroSdb("apt::AbilityData", "id")]
        public uint SlottedAbility_1;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SlottedAbility_2)]
        [AeroSdb("apt::AbilityData", "id")]
        public uint SlottedAbility_2;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SlottedAbility_3)]
        [AeroSdb("apt::AbilityData", "id")]
        public uint SlottedAbility_3;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SlottedAbility_4)]
        [AeroSdb("apt::AbilityData", "id")]
        public uint SlottedAbility_4;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SlottedAbility_5)]
        [AeroSdb("apt::AbilityData", "id")]
        public uint SlottedAbility_5;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SlottedAbility_6)]
        [AeroSdb("apt::AbilityData", "id")]
        public uint SlottedAbility_6;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SlottedAbility_7)]
        [AeroSdb("apt::AbilityData", "id")]
        public uint SlottedAbility_7;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SlottedAbility_8)]
        [AeroSdb("apt::AbilityData", "id")]
        public uint SlottedAbility_8;
    }

    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 28, 1)]
    public partial class Vehicle_CombatController_Update
    {
        [AeroArray(-144)]
        public Vehicle_CombatController_ShadowFieldUpdate[] Updates;
    }
}