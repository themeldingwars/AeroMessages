using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 25, 3, true)]
    public class AreaVisualDataForceShieldViewKeyframe : BaseScript
    {
        // Just quickly scoping this out
        public byte[] Unk1; // Content flags
        public float[] Position;
        public byte[] Unk2;
        
        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Unk1 = Stream.Read.ByteArray(4);
            Position = Stream.Read.FloatArray(3);
            Unk2 = Stream.Read.ByteArray(8);
        }
    }
}