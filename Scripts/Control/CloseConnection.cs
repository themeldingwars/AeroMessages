namespace PacketPeepScript
{
    // Script also runs for Jack which is missleading
    [Script(MessageType.Control, 0)]
    public class CloseConnection : BaseScript
    {
        public float[] Unk;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Unk = Stream.Read.FloatArray(3);
        }
    }
}