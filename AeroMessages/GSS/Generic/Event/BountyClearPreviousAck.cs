using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.BountyClearPreviousAck, GssVersion.V1, GssVersion.V67)]
    public partial class BountyClearPreviousAck
    {
        public byte Success;
        public byte Unk2; // Count or category?
    }
}