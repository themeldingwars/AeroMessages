using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.BountyListActiveDetailsAck, GssVersion.V1, GssVersion.V74)]
    public partial class BountyListActiveDetailsAck
    {
        public byte Success;
        [AeroString(typeof(ushort))] public string JSON;
    }
}