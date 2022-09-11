using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Control
{
    [Aero]
    [AeroMessageId(MsgType.Control, MsgSrc.Both, 3)]
    public partial class GSSAck
    {
        public ushort NextSeqNum;
        public ushort AckForNum;
    }
}