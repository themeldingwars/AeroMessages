using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 20, 3, true)]
    public class AreaVisualDataObserverViewKeyframe : BaseScript
    {
        public byte[] Unk_Bitfield;
        public float[] Position;
        
        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Unk_Bitfield = Stream.Read.ByteArray(4);
            Position = Stream.Read.FloatArray(3);
        }
    }
}