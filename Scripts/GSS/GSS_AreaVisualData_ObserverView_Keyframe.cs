using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 20, 3, true)]
    public class AreaVisualDataObserverViewKeyframe : BaseScript
    {
        // Just quickly scoping this out
        public byte[] Unk1;
        public float[] Position;
        
        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Unk1 = Stream.Read.ByteArray(4);
            Position = Stream.Read.FloatArray(3);
        }
    }
}