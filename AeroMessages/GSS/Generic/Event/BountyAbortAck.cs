using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.BountyAbortAck, GssVersion.V1, GssVersion.V74)]
    public partial class BountyAbortAck
    {
        public uint BountyDefId;
        public byte Success;
        public byte Reason; // [0-4]
    }
}