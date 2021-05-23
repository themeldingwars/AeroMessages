/*
META_BEGIN
    MsgType: Control
    MsgId: 2
    MsgName: MatrixAck
META_END
 */
[Aero]
public partial class Control_MatrixAck
{
    public ushort NextSeqNum;
    public ushort AckForNum;
}