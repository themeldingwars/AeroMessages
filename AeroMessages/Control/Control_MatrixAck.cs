using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Control
{
    [Aero]
    [AeroMessageId(MsgType.Control, MsgSrc.Both, 2)]
    public partial class MatrixAck
    {
        // Sequence numbers are big-endian on the wire, swap the bytes after reading
        public ushort NextSeqNum; // Next in-order sequence number expected from the peer
        public ushort AckForNum;
    }
}