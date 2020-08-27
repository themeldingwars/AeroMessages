using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 251, 22, false)]
    public class GenericTrailRequest : BaseScript
    {

        public byte[] Unk;
        public float[] Position1;
        public float[] Position2;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
    
            Unk = Stream.Read.ByteArray(5);
            Position1 = Stream.Read.FloatArray(3);
            Position2 = Stream.Read.FloatArray(3);
        }
    }
}