using Aero.Gen.Attributes;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 121)]
    public partial class VendorPurchaseResponse
    {
        public byte Success;
        public ulong ProductId;
        public ulong PriceId;
        public uint VendorId;
        [AeroString] public string Code; // Tries to default to "PURCHASE_SUCCESSFUL" if Success is not 0
    }
}