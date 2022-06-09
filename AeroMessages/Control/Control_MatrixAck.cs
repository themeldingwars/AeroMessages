using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Control
{
    [Aero]
    [AeroMessageId(MsgType.Control, MsgSrc.Both, 2)]
    public partial class Control_MatrixAck
    {
        public ushort NextSeqNum;
        public ushort AckForNum;
    }
}