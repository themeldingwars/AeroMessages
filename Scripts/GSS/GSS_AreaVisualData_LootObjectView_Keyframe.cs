using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 24, 3, true)]
    public class AreaVisualDataLootObjectViewKeyframe : BaseScript
    {
        // Just quickly scoping this out
        public byte[] Unk1;
        public uint Time1;
        public byte Unk2;
        public byte[] Entity;
        public byte Unk3;

        public float[] Position;
        
        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Unk1 = Stream.Read.ByteArray(3);
            Time1 = Stream.Read.UInt();

            Unk2 = Stream.Read.Byte();
            if (Unk2 == 1)
            {
                Entity = Stream.Read.ByteArray(8);
            }

            Unk3 = Stream.Read.Byte();
            if (Unk3 == 1) {
                Stream.baseStream.ByteOffset += 8;
            }
            else {
                Stream.baseStream.ByteOffset += 6;
            }

            Position = Stream.Read.FloatArray(3);
        }
    }
}