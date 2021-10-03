/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 51
    TypeName: CarryableObject::ObserverView
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
namespace AeroMessages.GSS.CarryableObject
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 51, 3)]
    public partial class CarryableObject_ObserverView_Keyframe
    {
        [Flags]
        public enum BitfieldMask1 : uint
        {
            PersonalFactionStance = 1U << 0, // assumption
            CarryingCharacterId   = 1U << 1, // guess
            ForcedMovement        = 1U << 2, // guess,
            StatusEffects_0       = 1U << 3,
            StatusEffects_1       = 1U << 4,
            StatusEffects_2       = 1U << 5,
            StatusEffects_3       = 1U << 6,
            StatusEffects_4       = 1U << 7,
            StatusEffects_5       = 1U << 8,
            StatusEffects_6       = 1U << 9,
            StatusEffects_7       = 1U << 10,
            StatusEffects_8       = 1U << 11,
            StatusEffects_9       = 1U << 12,
            StatusEffects_10      = 1U << 13,
            StatusEffects_11      = 1U << 14,
            StatusEffects_12      = 1U << 15,
            StatusEffects_13      = 1U << 16,
            StatusEffects_14      = 1U << 17,
            StatusEffects_15      = 1U << 18,
            StatusEffects_16      = 1U << 19,
            StatusEffects_17      = 1U << 20,
            StatusEffects_18      = 1U << 21,
            StatusEffects_19      = 1U << 22,
            StatusEffects_20      = 1U << 23,
            StatusEffects_21      = 1U << 24,
            StatusEffects_22      = 1U << 25,
            StatusEffects_23      = 1U << 26,
            StatusEffects_24      = 1U << 27,
            StatusEffects_25      = 1U << 28,
            StatusEffects_26      = 1U << 29,
            StatusEffects_27      = 1U << 30,
            StatusEffects_28      = 1U << 31,
        }

        [Flags]
        public enum BitfieldMask2 : uint
        {
            StatusEffects_29 = 1U << 0,
            StatusEffects_30 = 1U << 1,
            StatusEffects_31 = 1U << 2,
            SinCardFields_0  = 1U << 3,
            SinCardFields_1  = 1U << 4,
            SinCardFields_2  = 1U << 5,
            SinCardFields_3  = 1U << 6,
            SinCardFields_4  = 1U << 7,
            SinCardFields_5  = 1U << 8,
            SinCardFields_6  = 1U << 9,
            SinCardFields_7  = 1U << 10,
            SinCardFields_8  = 1U << 11,
            SinCardFields_9  = 1U << 12,
            SinCardFields_10 = 1U << 13,
            SinCardFields_11 = 1U << 14,
            SinCardFields_12 = 1U << 15,
            SinCardFields_13 = 1U << 16,
            SinCardFields_14 = 1U << 17,
            SinCardFields_15 = 1U << 18,
            SinCardFields_16 = 1U << 19,
            SinCardFields_17 = 1U << 20,
            SinCardFields_18 = 1U << 21,
            SinCardFields_19 = 1U << 22,
            SinCardFields_20 = 1U << 23,
            SinCardFields_21 = 1U << 24,
            SinCardFields_22 = 1U << 25,
            ThrownField      = 1U << 26, // guess
            SeekField        = 1U << 27, // guess
            BounceField      = 1U << 28, // guess
        }

        public BitfieldMask1 Bitfield1;
        public BitfieldMask2 Bitfield2;

        [AeroSdb("dbitems::CarryableObject", "id")]
        public uint CarryableObjectTypeId;

        [AeroString]
        public string Name;

        public Vector3 Position;
        public Quaternion Orientation;

        public HostilityData Hostility; // Different from usual?

        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.PersonalFactionStance)]
        public PersonalFactionStanceData PersonalFactionStance;

        public EntityId CarryingCharacterId;


        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.ForcedMovement)]
        [AeroArray(30)]
        public byte[] ForcedMovement; // TODO: Needs indepth parsing, first byte is type/flags.

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
        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.StatusEffects_29)]
        public StatusEffectData StatusEffects_29;
        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.StatusEffects_30)]
        public StatusEffectData StatusEffects_30;
        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.StatusEffects_31)]
        public StatusEffectData StatusEffects_31;

        public byte AllowFriendlyPickup; // guess
        public byte AllowHostilePickup; // guess

        [AeroSdb("dbencounterdata::SinCardTemplate", "Id")]
        //[AeroSdb("dbencounterdata::SinCardFields", "TemplateId")]
        public uint SinCardType;

        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.SinCardFields_0)]
        public SinCardFieldData SinCardFields_0;

        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.SinCardFields_1)]
        public SinCardFieldData SinCardFields_1;

        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.SinCardFields_2)]
        public SinCardFieldData SinCardFields_2;

        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.SinCardFields_3)]
        public SinCardFieldData SinCardFields_3;

        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.SinCardFields_4)]
        public SinCardFieldData SinCardFields_4;

        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.SinCardFields_5)]
        public SinCardFieldData SinCardFields_5;

        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.SinCardFields_6)]
        public SinCardFieldData SinCardFields_6;

        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.SinCardFields_7)]
        public SinCardFieldData SinCardFields_7;

        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.SinCardFields_8)]
        public SinCardFieldData SinCardFields_8;

        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.SinCardFields_9)]
        public SinCardFieldData SinCardFields_9;

        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.SinCardFields_10)]
        public SinCardFieldData SinCardFields_10;

        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.SinCardFields_11)]
        public SinCardFieldData SinCardFields_11;

        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.SinCardFields_12)]
        public SinCardFieldData SinCardFields_12;

        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.SinCardFields_13)]
        public SinCardFieldData SinCardFields_13;

        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.SinCardFields_14)]
        public SinCardFieldData SinCardFields_14;

        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.SinCardFields_15)]
        public SinCardFieldData SinCardFields_15;

        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.SinCardFields_16)]
        public SinCardFieldData SinCardFields_16;

        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.SinCardFields_17)]
        public SinCardFieldData SinCardFields_17;

        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.SinCardFields_18)]
        public SinCardFieldData SinCardFields_18;

        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.SinCardFields_19)]
        public SinCardFieldData SinCardFields_19;

        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.SinCardFields_20)]
        public SinCardFieldData SinCardFields_20;

        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.SinCardFields_21)]
        public SinCardFieldData SinCardFields_21;

        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.SinCardFields_22)]
        public SinCardFieldData SinCardFields_22;

        public byte VisualInfoGroupIndex; // TODO: Verify


        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.ThrownField)]
        public ThrownFieldData ThrownField;

        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.SeekField)]
        public SeekFieldData SeekField;

        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.BounceField)]
        public BounceFieldData BounceField;

        public ScopeBubbleInfoData ScopeBubbleInfo;
    }

    [AeroBlock]
    public struct ThrownFieldData
    {
        [AeroArray(4)]
        public float[] ThrownField_Unk1_Floats;
        public byte ThrownField_Unk2_Byte;
    }

    [AeroBlock]
    public struct SeekFieldData
    {
        // TODO:
    }

    [AeroBlock]
    public struct BounceFieldData
    {
        public Vector3 Position;
        public Vector3 MaybeVelocity;
        public uint Time;
    }
}