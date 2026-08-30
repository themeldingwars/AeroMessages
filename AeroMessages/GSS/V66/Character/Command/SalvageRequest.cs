using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.SalvageRequest, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class SalvageRequest
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