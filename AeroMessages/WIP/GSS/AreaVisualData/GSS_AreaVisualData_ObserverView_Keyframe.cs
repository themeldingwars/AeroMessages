/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 20
    TypeName: AreaVisualData::ObserverView
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
    public partial class AreaVisualData_ObserverView_Keyframe
    {
        [Flags]
        public enum BitfieldMask1: ushort
        {
            ContextFlags_0  = 1 << 0,
            ContextFlags_1  = 1 << 1,
            ContextFlags_2  = 1 << 2,
            ContextFlags_3  = 1 << 3,
            ContextFlags_4  = 1 << 4,
            ContextFlags_5  = 1 << 5,
            ContextFlags_6  = 1 << 6,
            ContextFlags_7  = 1 << 7,
            ContextFlags_8  = 1 << 8,
            ContextFlags_9  = 1 << 9,
            ContextFlags_10 = 1 << 10,
            ContextFlags_11 = 1 << 11,
            ContextFlags_12 = 1 << 12,
            ContextFlags_13 = 1 << 13,
            ContextFlags_14 = 1 << 14,
            ContextFlags_15 = 1 << 15,
        }

        [Flags]
        public enum BitfieldMask2: ushort
        {
            ContextFlags_16 = 1 << 0,
            ContextFlags_17 = 1 << 1,
            ContextFlags_18 = 1 << 2,
            ContextFlags_19 = 1 << 3,
            ContextFlags_20 = 1 << 4,
            ContextFlags_21 = 1 << 5,
            ContextFlags_22 = 1 << 6,
            ContextFlags_23 = 1 << 7,
            ContextTeams_0  = 1 << 8,
            ContextTeams_1  = 1 << 9,
            ContextTeams_2  = 1 << 10,
            ContextTeams_3  = 1 << 11,
        }

        public BitfieldMask1 Bitfield1;
        public BitfieldMask2 Bitfield2;
        public Vector3 Position;
        public ScopeBubbleInfoData ScopeBubbleInfo;

        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.ContextFlags_0)]
        public ContextFlag ContextFlags_0;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.ContextFlags_1)]
        public ContextFlag ContextFlags_1;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.ContextFlags_2)]
        public ContextFlag ContextFlags_2;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.ContextFlags_3)]
        public ContextFlag ContextFlags_3;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.ContextFlags_4)]
        public ContextFlag ContextFlags_4;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.ContextFlags_5)]
        public ContextFlag ContextFlags_5;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.ContextFlags_6)]
        public ContextFlag ContextFlags_6;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.ContextFlags_7)]
        public ContextFlag ContextFlags_7;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.ContextFlags_8)]
        public ContextFlag ContextFlags_8;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.ContextFlags_9)]
        public ContextFlag ContextFlags_9;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.ContextFlags_10)]
        public ContextFlag ContextFlags_10;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.ContextFlags_11)]
        public ContextFlag ContextFlags_11;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.ContextFlags_12)]
        public ContextFlag ContextFlags_12;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.ContextFlags_13)]
        public ContextFlag ContextFlags_13;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.ContextFlags_14)]
        public ContextFlag ContextFlags_14;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.ContextFlags_15)]
        public ContextFlag ContextFlags_15;

        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.ContextFlags_16)]
        public ContextFlag ContextFlags_16;
        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.ContextFlags_17)]
        public ContextFlag ContextFlags_17;
        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.ContextFlags_18)]
        public ContextFlag ContextFlags_18;
        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.ContextFlags_19)]
        public ContextFlag ContextFlags_19;
        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.ContextFlags_20)]
        public ContextFlag ContextFlags_20;
        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.ContextFlags_21)]
        public ContextFlag ContextFlags_21;
        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.ContextFlags_22)]
        public ContextFlag ContextFlags_22;
        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.ContextFlags_23)]
        public ContextFlag ContextFlags_23;

        // TODO: Bitfield - ContextTeams
        /*
        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.ContextTeams_0)]
        public ContextTeam ContextTeams_0;
        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.ContextTeams_1)]
        public ContextTeam ContextTeams_1;
        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.ContextTeams_2)]
        public ContextTeam ContextTeams_2;
        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.ContextTeams_3)]
        public ContextTeam ContextTeams_3;
        */
    }

    [AeroBlock]
    public struct ContextFlag
    {
        [AeroArray(3)]
        public byte[] Unk;
    }

    /*
    [AeroBlock]
    public struct ContextTeam
    {
        // TODO
    }
     */
}