using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 132)]
    public partial class SimulateLootPickup
    {
        public LootItem Item;
        public byte Unk1;
        public byte HaveUnk2;
        [AeroIf(nameof(HaveUnk2), 1)]
        public ulong Unk2;
    }

    [AeroBlock]
    public struct LootItem
    {
        [AeroSdb("dbitems::RootItem", "sdb_id")]
        public uint LootSdbID;
        public ushort Unk1;
        public ushort Unk2;
        public ushort Unk3;
        public uint Unk4;
        public uint Unk5;
        public byte Unk6;
    }
}