using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 22, 3, true)]
    public class AreaVisualDataMapMarkerViewKeyframe : BaseScript
    {
        // Just quickly scoping this out
        public byte[] Unk1;
        public byte Unk2; // Probably some kind of marker type
        public float[] Position;
        
        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Unk1 = Stream.Read.ByteArray(4);
            Unk2 = Stream.Read.Byte();
            Position = Stream.Read.FloatArray(3);
        }
    }
}