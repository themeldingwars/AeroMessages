using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using Aero.Gen;

namespace AeroMessages.GSS.AreaVisualData.View
{
    [Aero(AeroGenTypes.View)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssAreaVisualDataView.LootObjectView, GssVersion.V1, GssVersion.V74)]
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

        public byte HaveFaction;
        [AeroIf(nameof(HaveFaction), 1)]
        public LootObjectUnkOptionalData Faction; // only sent when there is no owning Entity

        public HalfVector3 OriginOffset; // Position + OriginOffset = point the loot was dropped from
        public Vector3 Position;

        [AeroSdb("dbitems::RootItem", "sdb_id")]
        public uint LootSdbId;
        public byte Quantity;
        public ushort Unk5;
        public byte Unk6;
        [AeroSdb("dbitems::ItemModule", "id")]
        [AeroArray(2)] public uint[] ItemModules; // 0 = none
    }

    [AeroBlock]
    public struct LootObjectUnkOptionalData
    {
        [AeroSdb("dbcharacter::Faction", "id")]
        public byte FactionId;
        public byte Unk2;
    }
}