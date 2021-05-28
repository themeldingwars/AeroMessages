/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 13
    TypeName: Character::TinyObjectView
    MsgId: 3
    MsgName: Keyframe
META_END
 */
using Aero.Gen.Attributes;
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_TinyObjectView_Keyframe
    {
        [Flags]
        public enum BitfieldMask : uint
        {
            TinyObjects_0         = 1U << 0,
            TinyObjects_1         = 1U << 1,
            TinyObjects_2         = 1U << 2,
            TinyObjects_3         = 1U << 3,
            TinyObjects_4         = 1U << 4,
            TinyObjects_5         = 1U << 5,
            TinyObjects_6         = 1U << 6,
            TinyObjects_7         = 1U << 7,
            TinyObjects_8         = 1U << 8,
            TinyObjects_9         = 1U << 9,
            TinyObjects_10       = 1U << 10,
            TinyObjects_11       = 1U << 11,
            TinyObjects_12       = 1U << 12,
            TinyObjects_13       = 1U << 13,
            TinyObjects_14       = 1U << 14,
            TinyObjects_15       = 1U << 15,
            TinyObjects_16       = 1U << 16,
            TinyObjects_17       = 1U << 17,
            TinyObjects_18       = 1U << 18,
            TinyObjects_19       = 1U << 19,
            TinyObjects_20       = 1U << 20,
            TinyObjects_21       = 1U << 21,
            TinyObjects_22       = 1U << 22,
            TinyObjects_23       = 1U << 23,
            TinyObjects_24       = 1U << 24,
            TinyObjects_25       = 1U << 25,
            TinyObjects_26       = 1U << 26,
            TinyObjects_27       = 1U << 27,
            TinyObjects_28       = 1U << 28,
            TinyObjects_29       = 1U << 29,
            TinyObjects_30       = 1U << 30,
            TinyObjects_31       = 1U << 31,
        }

        public BitfieldMask Bitfield;

        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.TinyObjects_0)]
        public TinyObjectData TinyObjects_0;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.TinyObjects_1)]
        public TinyObjectData TinyObjects_1;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.TinyObjects_2)]
        public TinyObjectData TinyObjects_2;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.TinyObjects_3)]
        public TinyObjectData TinyObjects_3;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.TinyObjects_4)]
        public TinyObjectData TinyObjects_4;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.TinyObjects_5)]
        public TinyObjectData TinyObjects_5;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.TinyObjects_6)]
        public TinyObjectData TinyObjects_6;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.TinyObjects_7)]
        public TinyObjectData TinyObjects_7;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.TinyObjects_8)]
        public TinyObjectData TinyObjects_8;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.TinyObjects_9)]
        public TinyObjectData TinyObjects_9;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.TinyObjects_10)]
        public TinyObjectData TinyObjects_10;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.TinyObjects_11)]
        public TinyObjectData TinyObjects_11;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.TinyObjects_12)]
        public TinyObjectData TinyObjects_12;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.TinyObjects_13)]
        public TinyObjectData TinyObjects_13;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.TinyObjects_14)]
        public TinyObjectData TinyObjects_14;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.TinyObjects_15)]
        public TinyObjectData TinyObjects_15;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.TinyObjects_16)]
        public TinyObjectData TinyObjects_16;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.TinyObjects_17)]
        public TinyObjectData TinyObjects_17;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.TinyObjects_18)]
        public TinyObjectData TinyObjects_18;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.TinyObjects_19)]
        public TinyObjectData TinyObjects_19;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.TinyObjects_20)]
        public TinyObjectData TinyObjects_20;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.TinyObjects_21)]
        public TinyObjectData TinyObjects_21;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.TinyObjects_22)]
        public TinyObjectData TinyObjects_22;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.TinyObjects_23)]
        public TinyObjectData TinyObjects_23;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.TinyObjects_24)]
        public TinyObjectData TinyObjects_24;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.TinyObjects_25)]
        public TinyObjectData TinyObjects_25;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.TinyObjects_26)]
        public TinyObjectData TinyObjects_26;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.TinyObjects_27)]
        public TinyObjectData TinyObjects_27;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.TinyObjects_28)]
        public TinyObjectData TinyObjects_28;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.TinyObjects_29)]
        public TinyObjectData TinyObjects_29;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.TinyObjects_30)]
        public TinyObjectData TinyObjects_30;
        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.TinyObjects_31)]
        public TinyObjectData TinyObjects_31;
    }

    [AeroBlock]
    public struct TinyObjectData
    {
        public ushort TypeId;
        public Vector3 Position;
        public HostilityInfoData HostilityInfo;
    }
}