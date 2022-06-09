using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 202)]
    public partial class Character_Command_SalvageRequest
    {
        [AeroArray(typeof(byte))]
        public ItemSalvageRequest[] SalvageRequests;
    }

    [AeroBlock]
    public struct ItemSalvageRequest
    {
        public ulong GUID;

        [AeroSdb("dbitems::RootItem", "sdb_id")]
        public uint SdbId;

        public uint Quantity; // (Needed when stackables like modules are salvaged in bulk)
    }
}