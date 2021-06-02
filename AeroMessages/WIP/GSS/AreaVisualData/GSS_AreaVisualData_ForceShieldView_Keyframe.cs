/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 25
    TypeName: AreaVisualData::ForceShieldView
    MsgId: 3
    MsgName: Keyframe
META_END
 */
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.GSS.AreaVisualData
{
    [Aero]
    public partial class AreaVisualData_ForceShieldView_Keyframe
    {
        [Flags]
        public enum BitfieldMask: uint
        {
            ForceShields_0  = 1U << 0,
            ForceShields_1  = 1U << 1,
            ForceShields_2  = 1U << 2,
            ForceShields_3  = 1U << 3,
            ForceShields_4  = 1U << 4,
            ForceShields_5  = 1U << 5,
            ForceShields_6  = 1U << 6,
            ForceShields_7  = 1U << 7,
            ForceShields_8  = 1U << 8,
            ForceShields_9  = 1U << 9,
            ForceShields_10 = 1U << 10,
            ForceShields_11 = 1U << 11,
            ForceShields_12 = 1U << 12,
            ForceShields_13 = 1U << 13,
            ForceShields_14 = 1U << 14,
            ForceShields_15 = 1U << 15,
            ForceShields_16 = 1U << 16,
            ForceShields_17 = 1U << 17,
            ForceShields_18 = 1U << 18,
            ForceShields_19 = 1U << 19,
            ForceShields_20 = 1U << 20,
            ForceShields_21 = 1U << 21,
            ForceShields_22 = 1U << 22,
            ForceShields_23 = 1U << 23,
            ForceShields_24 = 1U << 24,
            ForceShields_25 = 1U << 25,
            ForceShields_26 = 1U << 26,
            ForceShields_27 = 1U << 27,
            ForceShields_28 = 1U << 28,
            ForceShields_29 = 1U << 29,
            ForceShields_30 = 1U << 30,
            ForceShields_31 = 1U << 31,
        }

        public BitfieldMask Bitfield;
        public Vector3 Position;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.ForceShields_0)]
        public ForceShieldData ForceShields_0;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.ForceShields_1)]
        public ForceShieldData ForceShields_1;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.ForceShields_2)]
        public ForceShieldData ForceShields_2;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.ForceShields_3)]
        public ForceShieldData ForceShields_3;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.ForceShields_4)]
        public ForceShieldData ForceShields_4;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.ForceShields_5)]
        public ForceShieldData ForceShields_5;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.ForceShields_6)]
        public ForceShieldData ForceShields_6;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.ForceShields_7)]
        public ForceShieldData ForceShields_7;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.ForceShields_8)]
        public ForceShieldData ForceShields_8;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.ForceShields_9)]
        public ForceShieldData ForceShields_9;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.ForceShields_10)]
        public ForceShieldData ForceShields_10;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.ForceShields_11)]
        public ForceShieldData ForceShields_11;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.ForceShields_12)]
        public ForceShieldData ForceShields_12;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.ForceShields_13)]
        public ForceShieldData ForceShields_13;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.ForceShields_14)]
        public ForceShieldData ForceShields_14;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.ForceShields_15)]
        public ForceShieldData ForceShields_15;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.ForceShields_16)]
        public ForceShieldData ForceShields_16;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.ForceShields_17)]
        public ForceShieldData ForceShields_17;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.ForceShields_18)]
        public ForceShieldData ForceShields_18;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.ForceShields_19)]
        public ForceShieldData ForceShields_19;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.ForceShields_20)]
        public ForceShieldData ForceShields_20;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.ForceShields_21)]
        public ForceShieldData ForceShields_21;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.ForceShields_22)]
        public ForceShieldData ForceShields_22;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.ForceShields_23)]
        public ForceShieldData ForceShields_23;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.ForceShields_24)]
        public ForceShieldData ForceShields_24;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.ForceShields_25)]
        public ForceShieldData ForceShields_25;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.ForceShields_26)]
        public ForceShieldData ForceShields_26;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.ForceShields_27)]
        public ForceShieldData ForceShields_27;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.ForceShields_28)]
        public ForceShieldData ForceShields_28;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.ForceShields_29)]
        public ForceShieldData ForceShields_29;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.ForceShields_30)]
        public ForceShieldData ForceShields_30;
        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.ForceShields_31)]
        public ForceShieldData ForceShields_31;

        public ScopeBubbleInfoData ScopeBubbleInfo;
    }

    [AeroBlock]
    public struct ForceShieldData
    {
        // TODO: Need to verify
        //[AeroSDB("dbzonemetadata::ForceShieldType", "id")]
        public uint MaybeType;
        
        public HalfVector3 Position;
        
        public HalfVector4 Orientation;
        
        public HalfVector3 Direction;

        public byte Unk2;
        public HostilityInfoData HosilityInfo;
    }
}