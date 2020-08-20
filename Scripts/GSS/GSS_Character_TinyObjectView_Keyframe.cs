using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 13, 3, true)]
    public class CharacterTinyObjectViewKeyframe : BaseScript
    {
        // Just quickly scoping this out
        public byte[] Unk1;
        //public byte[] Unk2;
        public ushort Unk2_Id; // This is the id but not sure if it can be found in SDB.
        public float[] Position;
        public byte[] Unk3; // Faction?

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Unk1 = Stream.Read.ByteArray(4);
            Unk2_Id = Stream.Read.UShort();
            Position = Stream.Read.FloatArray(3);
            Unk3 = Stream.Read.ByteArray(2);
        }
    }
}