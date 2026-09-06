using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.SalvageResponse, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
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