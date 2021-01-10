using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 135, true)]
    public class CharacterBaseControllerTrackerPulse : BaseScript
    {
        // Nothing concrete
        public byte[] Entity;
        public byte[] Unk1;
        public float[] FloatArray1;
        public byte[] Unk2;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Entity = Stream.Read.ByteArray(8);
            Unk1 = Stream.Read.ByteArray(28);
            FloatArray1 = Stream.Read.FloatArray(3);
            Unk2 = Stream.Read.ByteArray(8);
        }
    }
}