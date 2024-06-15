using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 75)]
    public partial class BountyClearAck
    {
        public byte Success;
        public byte Unk2; // Count or category?
    }
}