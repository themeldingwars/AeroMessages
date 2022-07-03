using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 150)]
    public partial class SalvageResponse
    {
        public byte Unk1;

        [AeroArray(typeof(byte))]
        public ItemSalvageResponse[] SalvageResponses;
    }

    [AeroBlock]
    public struct ItemSalvageResponse
    {
        public ulong GUID;

        [AeroSdb("dbitems::RootItem", "sdb_id")]
        public uint SdbId;

        public uint Quantity; // (Needed when stackables like modules are salvaged in bulk)
    }
}