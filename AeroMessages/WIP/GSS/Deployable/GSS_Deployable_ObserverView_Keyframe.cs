using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.GSS.Deployable
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 35, 3)]
    public partial class Deployable_ObserverView_Keyframe
    {
        [Flags]
        public enum BitfieldMask : ulong
        {
            StatusEffects_0        = 1UL << 0,
            StatusEffects_1        = 1UL << 1,
            StatusEffects_2        = 1UL << 2,
            StatusEffects_3        = 1UL << 3,
            StatusEffects_4        = 1UL << 4,
            StatusEffects_5        = 1UL << 5,
            StatusEffects_6        = 1UL << 6,
            StatusEffects_7        = 1UL << 7,
            StatusEffects_8        = 1UL << 8,
            StatusEffects_9        = 1UL << 9,
            StatusEffects_10       = 1UL << 10,
            StatusEffects_11       = 1UL << 11,
            StatusEffects_12       = 1UL << 12,
            StatusEffects_13       = 1UL << 13,
            StatusEffects_14       = 1UL << 14,
            StatusEffects_15       = 1UL << 15,
            StatusEffects_16       = 1UL << 16,
            StatusEffects_17       = 1UL << 17,
            StatusEffects_18       = 1UL << 18,
            StatusEffects_19       = 1UL << 19,
            StatusEffects_20       = 1UL << 20,
            StatusEffects_21       = 1UL << 21,
            StatusEffects_22       = 1UL << 22,
            StatusEffects_23       = 1UL << 23,
            StatusEffects_24       = 1UL << 24,
            StatusEffects_25       = 1UL << 25,
            StatusEffects_26       = 1UL << 26,
            StatusEffects_27       = 1UL << 27,
            StatusEffects_28       = 1UL << 28,
            StatusEffects_29       = 1UL << 29,
            StatusEffects_30       = 1UL << 30,
            StatusEffects_31       = 1UL << 31,
            PersonalFactionStance  = 1UL << 32,
            ForcedMovement         = 1UL << 33,
            SinFactionsAcquiredBy  = 1UL << 34,
            SinTeamsAcquiredBy     = 1UL << 35,
            SinCardFields_0        = 1UL << 36,
            SinCardFields_1        = 1UL << 37,
            SinCardFields_2        = 1UL << 38,
            SinCardFields_3        = 1UL << 39,
            SinCardFields_4        = 1UL << 40,
            SinCardFields_5        = 1UL << 41,
            SinCardFields_6        = 1UL << 42,
            SinCardFields_7        = 1UL << 43,
            SinCardFields_8        = 1UL << 44,
            SinCardFields_9        = 1UL << 45,
            SinCardFields_10       = 1UL << 46,
            SinCardFields_11       = 1UL << 47,
            SinCardFields_12       = 1UL << 48,
            SinCardFields_13       = 1UL << 49,
            SinCardFields_14       = 1UL << 50,
            SinCardFields_15       = 1UL << 51,
            SinCardFields_16       = 1UL << 52,
            SinCardFields_17       = 1UL << 53,
            SinCardFields_18       = 1UL << 54,
            SinCardFields_19       = 1UL << 55,
            AppendageHealthPools_0 = 1UL << 56,
            AppendageHealthPools_1 = 1UL << 57,
            AppendageHealthPools_2 = 1UL << 58,
            AppendageHealthPools_3 = 1UL << 59,
            AppendageHealthPools_4 = 1UL << 60,
            AppendageHealthPools_5 = 1UL << 61,
            AppendageHealthPools_6 = 1UL << 62,
            AppendageHealthPools_7 = 1UL << 63,
        }
        
        public BitfieldMask Bitfield;

        [AeroSdb("dbcharacter::Deployable", "id")]
        public uint Type;
        public EntityId Owner;
        [AeroSdb("apt::AbilityData", "id")]
        public uint AbilitySrcId; // example in msgidx 123396
        public Vector3 Position;
        public Quaternion Orientation; // Rotation
        public Vector3 AimPosition;
        public Vector3 AimDirection;
        public uint ConstructedTime;
        public byte CurrentHealthPct;
        public int MaxHealth;
        public byte Level;

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

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.StatusEffects_0)]
        public StatusEffectData StatusEffects_0;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.StatusEffects_1)]
        public StatusEffectData StatusEffects_1;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.StatusEffects_2)]
        public StatusEffectData StatusEffects_2;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.StatusEffects_3)]
        public StatusEffectData StatusEffects_3;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.StatusEffects_4)]
        public StatusEffectData StatusEffects_4;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.StatusEffects_5)]
        public StatusEffectData StatusEffects_5;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.StatusEffects_6)]
        public StatusEffectData StatusEffects_6;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.StatusEffects_7)]
        public StatusEffectData StatusEffects_7;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.StatusEffects_8)]
        public StatusEffectData StatusEffects_8;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.StatusEffects_9)]
        public StatusEffectData StatusEffects_9;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.StatusEffects_10)]
        public StatusEffectData StatusEffects_10;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.StatusEffects_11)]
        public StatusEffectData StatusEffects_11;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.StatusEffects_12)]
        public StatusEffectData StatusEffects_12;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.StatusEffects_13)]
        public StatusEffectData StatusEffects_13;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.StatusEffects_14)]
        public StatusEffectData StatusEffects_14;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.StatusEffects_15)]
        public StatusEffectData StatusEffects_15;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.StatusEffects_16)]
        public StatusEffectData StatusEffects_16;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.StatusEffects_17)]
        public StatusEffectData StatusEffects_17;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.StatusEffects_18)]
        public StatusEffectData StatusEffects_18;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.StatusEffects_19)]
        public StatusEffectData StatusEffects_19;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.StatusEffects_20)]
        public StatusEffectData StatusEffects_20;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.StatusEffects_21)]
        public StatusEffectData StatusEffects_21;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.StatusEffects_22)]
        public StatusEffectData StatusEffects_22;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.StatusEffects_23)]
        public StatusEffectData StatusEffects_23;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.StatusEffects_24)]
        public StatusEffectData StatusEffects_24;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.StatusEffects_25)]
        public StatusEffectData StatusEffects_25;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.StatusEffects_26)]
        public StatusEffectData StatusEffects_26;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.StatusEffects_27)]
        public StatusEffectData StatusEffects_27;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.StatusEffects_28)]
        public StatusEffectData StatusEffects_28;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.StatusEffects_29)]
        public StatusEffectData StatusEffects_29;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.StatusEffects_30)]
        public StatusEffectData StatusEffects_30;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.StatusEffects_31)]
        public StatusEffectData StatusEffects_31;

        public HostilityInfoData HostilityInfo;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.PersonalFactionStance)]
        public PersonalFactionStanceData PersonalFactionStance;

        public uint GibVisualsID;


        // TODO: Bitfield - ForcedMovement
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.ForcedMovement)]
        [AeroArray(30)]
        public byte[] ForcedMovement;

        public byte SinFlags;

        // TODO: Bitfield - SinFactionsAcquiredBy
        // [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinFactionsAcquiredBy)]
        // public SinFactionsAcquiredByData SinFactionsAcquiredBy;
        // --
        // TODO: Bitfield - SinTeamsAcquiredBy
        // [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinTeamsAcquiredBy)]
        // public SinTeamsAcquiredByData SinTeamsAcquiredBy;
        // --

        public EntityId AttachedTo;

        [AeroArray(typeof(byte))]
        public ushort[] WarpaintColors;

        public byte VisualInfoGroupIndex; // TODO: Verify 

        public CharacterStatsData CharacterStats;

        [AeroSdb("dbencounterdata::SinCardTemplate", "Id")]
        //[AeroSdb("dbencounterdata::SinCardFields", "TemplateId")]
        public uint SinCardType;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_0)]
        public SinCardFieldData SinCardFields_0;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_1)]
        public SinCardFieldData SinCardFields_1;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_2)]
        public SinCardFieldData SinCardFields_2;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_3)]
        public SinCardFieldData SinCardFields_3;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_4)]
        public SinCardFieldData SinCardFields_4;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_5)]
        public SinCardFieldData SinCardFields_5;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_6)]
        public SinCardFieldData SinCardFields_6;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_7)]
        public SinCardFieldData SinCardFields_7;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_8)]
        public SinCardFieldData SinCardFields_8;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_9)]
        public SinCardFieldData SinCardFields_9;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_10)]
        public SinCardFieldData SinCardFields_10;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_11)]
        public SinCardFieldData SinCardFields_11;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_12)]
        public SinCardFieldData SinCardFields_12;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_13)]
        public SinCardFieldData SinCardFields_13;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_14)]
        public SinCardFieldData SinCardFields_14;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_15)]
        public SinCardFieldData SinCardFields_15;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_16)]
        public SinCardFieldData SinCardFields_16;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_17)]
        public SinCardFieldData SinCardFields_17;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_18)]
        public SinCardFieldData SinCardFields_18;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_19)]
        public SinCardFieldData SinCardFields_19;

        public uint ScalingLevel;

        // TODO: Bitfield - AppendageHealthPools
        /*
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.AppendageHealthPools_0)]
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.AppendageHealthPools_1)]
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.AppendageHealthPools_2)]
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.AppendageHealthPools_3)]
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.AppendageHealthPools_4)]
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.AppendageHealthPools_5)]
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.AppendageHealthPools_6)]
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.AppendageHealthPools_7)]     
         */

        public byte AppendageHealthPct_0;
        public byte AppendageHealthPct_1;
        public byte AppendageHealthPct_2;
        public byte AppendageHealthPct_3;
        public byte AppendageHealthPct_4;
        public byte AppendageHealthPct_5;
        public byte AppendageHealthPct_6;
        public byte AppendageHealthPct_7;
    }
}