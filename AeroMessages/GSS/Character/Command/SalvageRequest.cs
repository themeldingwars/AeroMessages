using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.SalvageRequest, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
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