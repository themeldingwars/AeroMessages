using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 40, 3, true)]
    public class TurretObserverViewKeyframe : BaseScript
    {
        // Just quickly scoping this out but it probably isnt that interesting
        public byte[] Unk1;
        public byte[] Entity1;
        public byte Unk2;
        public byte[] Entity2;
        public uint Time1;
        public uint Time2;
        public byte[] Unk3;
        public byte[] Unk4;
        public byte[] Faction;
        
        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Unk1 = Stream.Read.ByteArray(5);
            Entity1 = Stream.Read.ByteArray(8);
            Unk2 = Stream.Read.Byte();
            Entity2 = Stream.Read.ByteArray(8);
            Unk3 = Stream.Read.ByteArray(14);
            Time1 = Stream.Read.UInt();
            Time2 = Stream.Read.UInt();
            Unk4 = Stream.Read.ByteArray(5);
            Faction = Stream.Read.ByteArray(2);
            // More stuff in some variations
        }
    }
}