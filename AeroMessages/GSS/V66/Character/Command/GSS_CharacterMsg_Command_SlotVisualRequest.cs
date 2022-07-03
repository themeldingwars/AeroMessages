using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 207)]
    public partial class SlotVisualRequest
    {
        public uint LoadoutId;

        [AeroSdb("dbitems::RootItem", "sdb_id")]
        public uint ItemSdbId;

        public byte SlotIdx1; // ?
        public byte SlotIdx2; // ?

        [AeroArray(9)]
        public byte[] Unk;
    }
}