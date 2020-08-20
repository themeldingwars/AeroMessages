using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 5, 122, false)]
    public class CharacterCombatControllerReportProjectileHit : BaseScript
    {
        public byte[] Unk1;
        public ushort ShortTime;
        public byte[] Unk2;
        public byte Unk3_TravelTime; // Appears related to the distance/time projectile travelled before hitting.
        public byte Unk4_BodyPartHit; // Appears related to the body part, the value might reference a bone/hardpoint or something.
        public byte Unk5;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Unk1 = Stream.Read.ByteArray(2);
            ShortTime = Stream.Read.UShort();
            Unk2 = Stream.Read.ByteArray(2);
            Unk3_TravelTime = Stream.Read.Byte();
            Unk4_BodyPartHit = Stream.Read.Byte();
            Unk5 = Stream.Read.Byte();
        }
    }
}