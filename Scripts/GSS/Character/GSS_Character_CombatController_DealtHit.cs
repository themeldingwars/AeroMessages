using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 5, 107, true)]
    public class CharacterCombatControllerDealtHit : BaseScript
    {
        // There are some variations of this message that don't include target and/or dealer entity and I don't know how to parse those yet.
        // TookHit has similiar variation.
        // If Unk_1_byte is not 1 then there won't be a target entity and similiar to Unk_2_byte if Unk_1_byte is 1.

        public byte Unk_1_byte;

        public byte[] TargetEntity;

        public byte Unk_2_byte;

        public byte[] DealerEntity;

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

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            
            Unk_1_byte = Stream.Read.Byte();

            if (Unk_1_byte == 1)
            {
                TargetEntity = Stream.Read.ByteArray(8);

                Unk_2_byte = Stream.Read.Byte();
                if (Unk_2_byte == 1)
                {
                    DealerEntity = Stream.Read.ByteArray(8);

                    DamageValue = Stream.Read.UInt();
                    DamageType = Stream.Read.Byte();
                    Unk_3_byte = Stream.Read.Byte();
                    DamageFlags = Stream.Read.Byte();
                }
            }
        }
    }
}