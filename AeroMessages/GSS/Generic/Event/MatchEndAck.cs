using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.MatchEndAck, GssVersion.V1, GssVersion.V67)]
    public partial class MatchEndAck
    {
        public ulong Unk1;
    }
}