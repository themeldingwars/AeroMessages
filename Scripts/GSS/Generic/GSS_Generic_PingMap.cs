using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 0, 110, true)]
    public class GenericPingMap : BaseScript
    {
        public float[] Position;
        public byte[] Unk1;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Position = Stream.Read.FloatArray(3);
            Unk1 = Stream.Read.ByteArray(4);
        }
    }
}