using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Control
{
    [Aero]
    [AeroMessageId(MsgType.Control, MsgSrc.Both, 3)]
    public partial class GSSAck
    {
        // Sequence numbers are big-endian on the wire, swap the bytes after reading
        public ushort NextSeqNum; // Next in-order sequence number expected from the peer
        public ushort AckForNum;

        // More acked sequence numbers (big-endian ushorts) when several reliable GSS packets are acked at once
        [AeroBlob] public byte[] AdditionalAcks = [];
    }
}