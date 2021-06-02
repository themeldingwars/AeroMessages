/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 24
    TypeName: AreaVisualData::LootObjectView
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
    public partial class AreaVisualData_LootObjectView_Keyframe
    {
        [Flags]
        public enum BitfieldMask1: ushort
        {
            LootObjects_0  = 1 << 0,
            LootObjects_1  = 1 << 1,
            LootObjects_2  = 1 << 2,
            LootObjects_3  = 1 << 3,
            LootObjects_4  = 1 << 4,
            LootObjects_5  = 1 << 5,
            LootObjects_6  = 1 << 6,
            LootObjects_7  = 1 << 7,
            LootObjects_8  = 1 << 8,
            LootObjects_9  = 1 << 9,
            LootObjects_10 = 1 << 10,
            LootObjects_11 = 1 << 11,
            LootObjects_12 = 1 << 12,
            LootObjects_13 = 1 << 13,
            LootObjects_14 = 1 << 14,
            LootObjects_15 = 1 << 15,
        }
        [Flags]
        public enum BitfieldMask2: byte
        {
            LootObjects_16 = 1 << 0, // 1U << 16,
            LootObjects_17 = 1 << 1, // 1U << 17,
            LootObjects_18 = 1 << 2, // 1U << 18,
            LootObjects_19 = 1 << 3, // 1U << 19,
            LootObjects_20 = 1 << 4, // 1U << 20,
            LootObjects_21 = 1 << 5, // 1U << 21,
            LootObjects_22 = 1 << 6, // 1U << 22,
            LootObjects_23 = 1 << 7, // 1U << 23,
        }

        public BitfieldMask1 Bitfield1;
        public BitfieldMask2 Bitfield2;

        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.LootObjects_0)]
        public LootObjectData LootObjects_0;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.LootObjects_1)]
        public LootObjectData LootObjects_1;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.LootObjects_2)]
        public LootObjectData LootObjects_2;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.LootObjects_3)]
        public LootObjectData LootObjects_3;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.LootObjects_4)]
        public LootObjectData LootObjects_4;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.LootObjects_5)]
        public LootObjectData LootObjects_5;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.LootObjects_6)]
        public LootObjectData LootObjects_6;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.LootObjects_7)]
        public LootObjectData LootObjects_7;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.LootObjects_8)]
        public LootObjectData LootObjects_8;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.LootObjects_9)]
        public LootObjectData LootObjects_9;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.LootObjects_10)]
        public LootObjectData LootObjects_10;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.LootObjects_11)]
        public LootObjectData LootObjects_11;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.LootObjects_12)]
        public LootObjectData LootObjects_12;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.LootObjects_13)]
        public LootObjectData LootObjects_13;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.LootObjects_14)]
        public LootObjectData LootObjects_14;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.LootObjects_15)]
        public LootObjectData LootObjects_15;
        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.LootObjects_16)]
        public LootObjectData LootObjects_16;
        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.LootObjects_17)]
        public LootObjectData LootObjects_17;
        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.LootObjects_18)]
        public LootObjectData LootObjects_18;
        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.LootObjects_19)]
        public LootObjectData LootObjects_19;
        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.LootObjects_20)]
        public LootObjectData LootObjects_20;
        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.LootObjects_21)]
        public LootObjectData LootObjects_21;
        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.LootObjects_22)]
        public LootObjectData LootObjects_22;
        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.LootObjects_23)]
        public LootObjectData LootObjects_23;
    }

    [AeroBlock]
    public struct LootObjectData
    {
        public uint Time;
        public byte HaveEntity;

        [AeroIf(nameof(HaveEntity), 1)]
        public EntityId Entity;

        public byte HaveHostility;
        [AeroIf(nameof(HaveHostility), 1)]
        public HostilityInfoData HosilityInfo;

        [AeroArray(6)]
        public byte[] Unk4; // A direction in halfs?

        public Vector3 Position;

        [AeroSdb("dbitems::RootItem", "sdb_id")]
        public uint LootSdbId;
        public uint Quantity;

        [AeroArray(8)]
        public byte[] Unk5; // A rotation in halfs, a scopebubble, or a guid?
    }
}