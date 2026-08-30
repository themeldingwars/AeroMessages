using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.BountyListPreviousAck, GssVersion.V1, GssVersion.V67)]
    public partial class BountyListPreviousAck
    {
        public byte Success;
        [AeroString(typeof(ushort))] public string JSON;
    }
}