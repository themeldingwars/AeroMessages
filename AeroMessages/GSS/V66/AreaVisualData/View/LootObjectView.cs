using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
using Aero.Gen;

namespace AeroMessages.GSS.V66.AreaVisualData.View
{
    [Aero(AeroGenTypes.View)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 24, 1)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 24, 3)]
    public partial class LootObjectView
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

        public byte HaveUnk3;
        [AeroIf(nameof(HaveUnk3), 1)]
        public LootObjectUnkOptionalData Unk3; // I thought this was hostility but maybe not?

        public HalfVector3 Unk4;
        public Vector3 Position;

        [AeroSdb("dbitems::RootItem", "sdb_id")]
        public uint LootSdbId;
        public byte Quantity;
        public ushort Unk5;
        public byte Unk6;
        [AeroArray(2)] public uint[] Unk7; // Unk type, this is a do while with 2 laps which doesn't match scope bubble
    }

    [AeroBlock]
    public struct LootObjectUnkOptionalData
    {
        public byte Unk1;
        public byte Unk2;
    }
}