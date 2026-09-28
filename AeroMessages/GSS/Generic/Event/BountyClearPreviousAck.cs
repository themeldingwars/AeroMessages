using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.GSS.Character;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.BountyClearPreviousAck, GssVersion.V1, GssVersion.V74)]
    public partial class BountyClearPreviousAck
    {
        public byte Success;
        public BountyCategory Category;
    }
}