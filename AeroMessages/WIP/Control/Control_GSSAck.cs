/*
META_BEGIN
    MsgType: Control
    MsgId: 3
    MsgName: GSSAck
META_END
 */
using Aero.Gen.Attributes;
namespace AeroMessages.Control
{
    [Aero]
    public partial class Control_GSSAck
    {
        public ushort NextSeqNum;
        public ushort AckForNum;
    }
}