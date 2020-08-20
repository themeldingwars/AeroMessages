using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 21, 3, true)]
    public class AreaVisualDataParticleEffectsViewKeyframe : BaseScript
    {
        // Just quickly scoping this out
        public byte[] Unk1;
        public byte[] Unk2;
        public float[] Position;
        
        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Unk1 = Stream.Read.ByteArray(4);
            Unk2 = Stream.Read.ByteArray(11);
            Position = Stream.Read.FloatArray(3);
        }
    }
}