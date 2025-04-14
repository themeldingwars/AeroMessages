using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 207)]
    public partial class SlotVisualRequest
    {
        public int LoadoutId;

        [AeroSdb("dbitems::RootItem", "sdb_id")]
        public uint ItemSdbId;

        public byte SlotIdx1; // ?
        public byte SlotIdx2; // ?

        public uint Unk1;
        public uint Unk2;
        [AeroArray(typeof(byte))] public uint[] Unk3;
    }
}