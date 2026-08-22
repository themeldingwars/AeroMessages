using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 45)]
    public partial class MatchEndAck
    {
        public ulong Unk1;
    }
}