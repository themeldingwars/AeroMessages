using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 5, 105, true)]
    public class CharacterCombatControllerTookHit : BaseScript
    {
        
        // There are some variations of this message that don't include dealer entity.
        // DealtHit has similiar variations.
        // Maybe for fall dmg or similiar in this case.
        // If Unk_1_byte is not 1 then there won't be a dealer entity.`
        public byte Unk_1_byte;

        public byte[] DealerEntity;

        public byte Unk_2_byte;

        public uint DamageValue;
        public byte DamageType; // Sdb table 330, id column
        public byte Unk_3_byte;

        // Damage Response Flags
        // 1 - Critical
        // 2 - ???
        // 4 - Effective
        // 8 - Resisted
        // (Effective+Resisted => Immune)
        public byte DamageFlags;

        public byte[] Unk_Type0;

        public ushort Unk_ShortTime;
        public byte[] Unk_4;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            
            Unk_1_byte = Stream.Read.Byte();

            if (Unk_1_byte == 1)
            {
                DealerEntity = Stream.Read.ByteArray(8);

                Unk_2_byte = Stream.Read.Byte();

                DamageValue = Stream.Read.UInt();
                DamageType = Stream.Read.Byte(); // Just assuming its like DealtHit
                Unk_3_byte = Stream.Read.Byte(); // Just assuming its like DealtHit
                DamageFlags = Stream.Read.Byte(); // Just assuming its like DealtHit
            }
            else
            {
                Unk_Type0 = Stream.Read.ByteArray(2);
            }

            Unk_ShortTime = Stream.Read.UShort();
            Unk_4 = Stream.Read.ByteArray(1);
        }
    }
}