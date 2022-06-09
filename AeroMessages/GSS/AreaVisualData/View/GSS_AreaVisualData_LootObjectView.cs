using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
using Aero.Gen;

namespace AeroMessages.GSS.AreaVisualData
{
    [Aero(AeroGenTypes.View)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 24, 1)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 24, 3)]
    public partial class AreaVisualData_LootObjectView
    {
        [AeroNullable] private LootObjectData LootObjects_0;
        [AeroNullable] private LootObjectData LootObjects_1;
        [AeroNullable] private LootObjectData LootObjects_2;
        [AeroNullable] private LootObjectData LootObjects_3;
        [AeroNullable] private LootObjectData LootObjects_4;
        [AeroNullable] private LootObjectData LootObjects_5;
        [AeroNullable] private LootObjectData LootObjects_6;
        [AeroNullable] private LootObjectData LootObjects_7;
        [AeroNullable] private LootObjectData LootObjects_8;
        [AeroNullable] private LootObjectData LootObjects_9;
        [AeroNullable] private LootObjectData LootObjects_10;
        [AeroNullable] private LootObjectData LootObjects_11;
        [AeroNullable] private LootObjectData LootObjects_12;
        [AeroNullable] private LootObjectData LootObjects_13;
        [AeroNullable] private LootObjectData LootObjects_14;
        [AeroNullable] private LootObjectData LootObjects_15;
        [AeroNullable] private LootObjectData LootObjects_16;
        [AeroNullable] private LootObjectData LootObjects_17;
        [AeroNullable] private LootObjectData LootObjects_18;
        [AeroNullable] private LootObjectData LootObjects_19;
        [AeroNullable] private LootObjectData LootObjects_20;
        [AeroNullable] private LootObjectData LootObjects_21;
        [AeroNullable] private LootObjectData LootObjects_22;
        [AeroNullable] private LootObjectData LootObjects_23;
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
        public HostilityInfoData HostilityInfo;

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