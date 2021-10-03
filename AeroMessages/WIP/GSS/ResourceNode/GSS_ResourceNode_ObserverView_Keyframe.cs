using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.GSS.ResourceNode
{
    // TODO: Need a capture or replay of these, this is mostly guesswork based on shadowfields and what the client seems to like.
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 48, 3)]
    public partial class ResourceNode_ObserverView_Keyframe
    {
        [Flags]
        public enum BitfieldMask: ulong
        {
            StatusEffects_0 = 1UL << 0,
            StatusEffects_1 = 1UL << 1,
            StatusEffects_2 = 1UL << 2,
            StatusEffects_3 = 1UL << 3,
            StatusEffects_4 = 1UL << 4,
            StatusEffects_5 = 1UL << 5,
            StatusEffects_6 = 1UL << 6,
            StatusEffects_7 = 1UL << 7,
            StatusEffects_8 = 1UL << 8,
            StatusEffects_9 = 1UL << 9,
            StatusEffects_10 = 1UL << 10,
            StatusEffects_11 = 1UL << 11,
            StatusEffects_12 = 1UL << 12,
            StatusEffects_13 = 1UL << 13,
            StatusEffects_14 = 1UL << 14,
            StatusEffects_15 = 1UL << 15,
            StatusEffects_16 = 1UL << 16,
            StatusEffects_17 = 1UL << 17,
            StatusEffects_18 = 1UL << 18,
            StatusEffects_19 = 1UL << 19,
            StatusEffects_20 = 1UL << 20,
            StatusEffects_21 = 1UL << 21,
            StatusEffects_22 = 1UL << 22,
            StatusEffects_23 = 1UL << 23,
            StatusEffects_24 = 1UL << 24,
            StatusEffects_25 = 1UL << 25,
            StatusEffects_26 = 1UL << 26,
            StatusEffects_27 = 1UL << 27,
            StatusEffects_28 = 1UL << 28,
            StatusEffects_29 = 1UL << 29,
            StatusEffects_30 = 1UL << 30,
            StatusEffects_31 = 1UL << 31,
            PersonalFactionStance = 1UL << 32,
        }

        //[AeroArray(5)]
        public Ulong5ByteBitmask<BitfieldMask> Bitfield;

        [AeroSdb("dbzonemetadata::ResourceNodeType", "id")] // TODO: Verify
        public uint NodeType;

        public ThumpingCharacterInfoStruct ThumpingCharacterInfo;
        public Vector3 Position;

        [AeroSdb("dbitems::ResourceNodeBeacon", "id")]
        public uint BeaconId;
        public byte CurrentHealthPct;
        public uint MaxHealth;
        public float Progress;
        public StateInfoStruct StateInfo;

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

        public ScopeBubbleInfoData ScopeBubbleInfo;
    }

    [AeroBlock]
    public struct ThumpingCharacterInfoStruct
    {
        public EntityId OwnerId1; // total assumption, similar to vehicle
        public EntityId OwnerId2; // total assumption, similar to vehicle

        [AeroString]
        public string Owner;

        public uint UnkMaybeTime;
    }

    [AeroBlock]
    public struct StateInfoStruct
    {
       public byte State;
       public uint Time;
       public uint CountdownTime;
    }
}