using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.BountyListAvailableAck, GssVersion.V1, GssVersion.V67)]
    public partial class BountyListAvailableAck
    {
        public byte Success;
        [AeroString(typeof(ushort))] public string JSON;
    }
}