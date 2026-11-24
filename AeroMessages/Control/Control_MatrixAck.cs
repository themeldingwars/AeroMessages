using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Control
{
    [Aero]
    [AeroMessageId(MsgType.Control, MsgSrc.Both, 2)]
    public partial class MatrixAck
    {
        [AeroBigEndian] public ushort NextSeqNum;
        [AeroBigEndian] public ushort AckForNum;

        // Big-endian ushorts
        [AeroBlob] public byte[] AdditionalAcks = [];
    }
}