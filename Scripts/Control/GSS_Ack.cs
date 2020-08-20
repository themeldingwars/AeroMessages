namespace PacketPeepScript
{
    [Script(MessageType.Control, 3)]
    public class GSS_ACK : BaseScript
    {
        public ushort NextSeqNum;
        public ushort AckFor;

        public override void Read(Bitter.BinaryStream Stream)
        {
            NextSeqNum = Stream.Read.UShort();
            AckFor     = Stream.Read.UShort();
        }
    }
}