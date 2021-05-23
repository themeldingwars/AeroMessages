/*
META_BEGIN
    MsgType: Control
    MsgId: 2
    MsgName: MatrixAck
META_END
 */
using Aero.Gen.Attributes;
namespace AeroMessages.Control
{
    [Aero]
    public partial class Control_MatrixAck
    {
        public ushort NextSeqNum;
        public ushort AckForNum;
    }
}