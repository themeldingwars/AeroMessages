using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 11, 97, true)]
    public class CharacterCombatViewProjectileHitReported : BaseScript
    {
        public ushort Unk1; // Matches Unk1 in ReportProjectileHit?
        public ushort ShortTime; 
        public byte Unk2;
        public byte Unk3_Always1; // 
        public ushort Alt_Unk2and3_UShort;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Unk1 = Stream.Read.UShort(); // Stream.Read.ByteArray(2);
            ShortTime = Stream.Read.UShort();
            Unk2 = Stream.Read.Byte();
            Unk3_Always1 = Stream.Read.Byte();
            Stream.baseStream.ByteOffset -= 2;
            Alt_Unk2and3_UShort = Stream.Read.UShort();
        }
    }
}