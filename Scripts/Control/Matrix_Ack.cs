[Aero(AeroType.Msg, MsgType.Control, 2, Ver: 1962)]
public partial class MatrixAck : AeroBase
{
    public ushort NextSeqNum;
    public ushort AckForNum;
}