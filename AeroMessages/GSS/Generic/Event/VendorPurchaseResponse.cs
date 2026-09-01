using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.VendorPurchaseResponse, GssVersion.V1, GssVersion.V67)]
    public partial class VendorPurchaseResponse
    {
        public byte Success;
        public ulong ProductId;
        public ulong PriceId;
        public uint VendorId;
        [AeroString] public string Code; // Tries to default to "PURCHASE_SUCCESSFUL" if Success is not 0
    }
}