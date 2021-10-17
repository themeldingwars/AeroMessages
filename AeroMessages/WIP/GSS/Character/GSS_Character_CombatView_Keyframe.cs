/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 11
    TypeName: Character::CombatView
    MsgId: 3
    MsgName: Keyframe
META_END
 */
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 11, 3)]
    public partial class Character_CombatView_Keyframe
    {
        [Flags]
        public enum BitfieldMask1 : uint
        {
            StatusEffects_0        = 1U << 0,
            StatusEffects_1        = 1U << 1,
            StatusEffects_2        = 1U << 2,
            StatusEffects_3        = 1U << 3,
            StatusEffects_4        = 1U << 4,
            StatusEffects_5        = 1U << 5,
            StatusEffects_6        = 1U << 6,
            StatusEffects_7        = 1U << 7,
            StatusEffects_8        = 1U << 8,
            StatusEffects_9        = 1U << 9,
            StatusEffects_10       = 1U << 10,
            StatusEffects_11       = 1U << 11,
            StatusEffects_12       = 1U << 12,
            StatusEffects_13       = 1U << 13,
            StatusEffects_14       = 1U << 14,
            StatusEffects_15       = 1U << 15,
            StatusEffects_16       = 1U << 16,
            StatusEffects_17       = 1U << 17,
            StatusEffects_18       = 1U << 18,
            StatusEffects_19       = 1U << 19,
            StatusEffects_20       = 1U << 20,
            StatusEffects_21       = 1U << 21,
            StatusEffects_22       = 1U << 22,
            StatusEffects_23       = 1U << 23,
            StatusEffects_24       = 1U << 24,
            StatusEffects_25       = 1U << 25,
            StatusEffects_26       = 1U << 26,
            StatusEffects_27       = 1U << 27,
            StatusEffects_28       = 1U << 28,
            StatusEffects_29       = 1U << 29,
            StatusEffects_30       = 1U << 30,
            StatusEffects_31       = 1U << 31,
        }
        [Flags]
        public enum BitfieldMask2 : ushort
        {
            AppendageHealthPools_0 = 1 << 0, //1 << 32,
            AppendageHealthPools_1 = 1 << 1, //1 << 33,
            AppendageHealthPools_2 = 1 << 2, //1 << 34,
            AppendageHealthPools_3 = 1 << 3, //1 << 35,
            AppendageHealthPools_4 = 1 << 4, //1 << 36,
            AppendageHealthPools_5 = 1 << 5, //1 << 37,
            AppendageHealthPools_6 = 1 << 6, //1 << 38,
            AppendageHealthPools_7 = 1 << 7, //1 << 39,
            AppendageHealthPools_8 = 1 << 8, //1 << 40,
            AppendageHealthPools_9 = 1 << 9, //1 << 41,
            NPCTargetObjId         = 1 << 10, //1 << 42,
            BattleChatterTag       = 1 << 11, //1 << 43,
        }

        public BitfieldMask1 Bitfield1;
        public BitfieldMask2 Bitfield2;

        public ushort StatusEffectsChangeTime_0;
        public ushort StatusEffectsChangeTime_1;
        public ushort StatusEffectsChangeTime_2;
        public ushort StatusEffectsChangeTime_3;
        public ushort StatusEffectsChangeTime_4;
        public ushort StatusEffectsChangeTime_5;
        public ushort StatusEffectsChangeTime_6;
        public ushort StatusEffectsChangeTime_7;
        public ushort StatusEffectsChangeTime_8;
        public ushort StatusEffectsChangeTime_9;
        public ushort StatusEffectsChangeTime_10;
        public ushort StatusEffectsChangeTime_11;
        public ushort StatusEffectsChangeTime_12;
        public ushort StatusEffectsChangeTime_13;
        public ushort StatusEffectsChangeTime_14;
        public ushort StatusEffectsChangeTime_15;
        public ushort StatusEffectsChangeTime_16;
        public ushort StatusEffectsChangeTime_17;
        public ushort StatusEffectsChangeTime_18;
        public ushort StatusEffectsChangeTime_19;
        public ushort StatusEffectsChangeTime_20;
        public ushort StatusEffectsChangeTime_21;
        public ushort StatusEffectsChangeTime_22;
        public ushort StatusEffectsChangeTime_23;
        public ushort StatusEffectsChangeTime_24;
        public ushort StatusEffectsChangeTime_25;
        public ushort StatusEffectsChangeTime_26;
        public ushort StatusEffectsChangeTime_27;
        public ushort StatusEffectsChangeTime_28;
        public ushort StatusEffectsChangeTime_29;
        public ushort StatusEffectsChangeTime_30;
        public ushort StatusEffectsChangeTime_31;

        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.StatusEffects_0)]
        public StatusEffectData StatusEffects_0;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.StatusEffects_1)]
        public StatusEffectData StatusEffects_1;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.StatusEffects_2)]
        public StatusEffectData StatusEffects_2;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.StatusEffects_3)]
        public StatusEffectData StatusEffects_3;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.StatusEffects_4)]
        public StatusEffectData StatusEffects_4;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.StatusEffects_5)]
        public StatusEffectData StatusEffects_5;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.StatusEffects_6)]
        public StatusEffectData StatusEffects_6;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.StatusEffects_7)]
        public StatusEffectData StatusEffects_7;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.StatusEffects_8)]
        public StatusEffectData StatusEffects_8;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.StatusEffects_9)]
        public StatusEffectData StatusEffects_9;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.StatusEffects_10)]
        public StatusEffectData StatusEffects_10;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.StatusEffects_11)]
        public StatusEffectData StatusEffects_11;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.StatusEffects_12)]
        public StatusEffectData StatusEffects_12;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.StatusEffects_13)]
        public StatusEffectData StatusEffects_13;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.StatusEffects_14)]
        public StatusEffectData StatusEffects_14;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.StatusEffects_15)]
        public StatusEffectData StatusEffects_15;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.StatusEffects_16)]
        public StatusEffectData StatusEffects_16;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.StatusEffects_17)]
        public StatusEffectData StatusEffects_17;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.StatusEffects_18)]
        public StatusEffectData StatusEffects_18;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.StatusEffects_19)]
        public StatusEffectData StatusEffects_19;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.StatusEffects_20)]
        public StatusEffectData StatusEffects_20;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.StatusEffects_21)]
        public StatusEffectData StatusEffects_21;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.StatusEffects_22)]
        public StatusEffectData StatusEffects_22;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.StatusEffects_23)]
        public StatusEffectData StatusEffects_23;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.StatusEffects_24)]
        public StatusEffectData StatusEffects_24;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.StatusEffects_25)]
        public StatusEffectData StatusEffects_25;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.StatusEffects_26)]
        public StatusEffectData StatusEffects_26;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.StatusEffects_27)]
        public StatusEffectData StatusEffects_27;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.StatusEffects_28)]
        public StatusEffectData StatusEffects_28;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.StatusEffects_29)]
        public StatusEffectData StatusEffects_29;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.StatusEffects_30)]
        public StatusEffectData StatusEffects_30;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.StatusEffects_31)]
        public StatusEffectData StatusEffects_31;

        public FireModeData FireMode_0;
        public FireModeData FireMode_1;

        public ushort Ammo_0;
        public ushort Ammo_1;
        public ushort AltAmmo_0;
        public ushort AltAmmo_1;
        public WeaponIndexData WeaponIndex;
        public uint ClipEmptyBegin;
        public uint ClipEmptyEnd;
        public uint WeaponBurstFired;
        public uint WeaponBurstEnded;
        public uint WeaponBurstCancelled;
        public uint WeaponReloaded;
        public uint WeaponReloadCancelled;
        public float WeaponAgilityMod;
        public uint AbilityCooldownEndMs_0;
        public uint AbilityCooldownEndMs_1;
        public uint AbilityCooldownEndMs_2;
        public uint AbilityCooldownEndMs_3;
        public uint EquipmentLoadTime;
        public CombatFlagsData CombatFlags;

        // TODO: Bitfield - AppendageHealthPools
        /*
        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.AppendageHealthPools_0)]
        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.AppendageHealthPools_1)]
        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.AppendageHealthPools_2)]
        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.AppendageHealthPools_3)]
        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.AppendageHealthPools_4)]
        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.AppendageHealthPools_5)]
        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.AppendageHealthPools_6)]
        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.AppendageHealthPools_7)]
        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.AppendageHealthPools_8)]
        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.AppendageHealthPools_9)]
         */

        public byte AppendageHealthPct_0;
        public byte AppendageHealthPct_1;
        public byte AppendageHealthPct_2;
        public byte AppendageHealthPct_3;
        public byte AppendageHealthPct_4;
        public byte AppendageHealthPct_5;
        public byte AppendageHealthPct_6;
        public byte AppendageHealthPct_7;
        public byte AppendageHealthPct_8;
        public byte AppendageHealthPct_9;


        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.NPCTargetObjId)]
        [AeroArray(8)]
        public byte[] NPCTargetObjId;

        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.BattleChatterTag)]
        [AeroArray(2)]
        public byte[] BattleChatterTag;

        [AeroArray(8)]
        public byte[] MimicParent; // Have yet to find a proper example, but ends up being 0s consistently so thats good

        [AeroArray(12)]
        public byte[] MimicOffset; // Many cases of values but not sure what they are, hardly fitting for floats, maybe something packed
    }
}