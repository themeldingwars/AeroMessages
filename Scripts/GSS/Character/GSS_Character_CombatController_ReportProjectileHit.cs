using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 5, 122, false)]
    public class CharacterCombatControllerReportProjectileHit : BaseScript
    {

        public ushort Unk1;

        public ushort ShortTime; // Time when this hit is reported
        public byte Unk2_Always1;

        public ushort Unk3_1;
        public ushort Unk3_2;
        public float Unk3_1_Float; // Could it be weapon recoil/shake values?
        public float Unk3_2_Float; // Could it be weapon recoil/shake values?

        public byte TravelTime; // Appears related to the distance/time projectile travelled before hitting.
        public byte BodyPartHit; // Appears related to the body part, the value might reference a bone/hardpoint or something.
        public byte Unk4_Always39; // 0x27

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Unk1 = Stream.Read.UShort(); // Stream.Read.ByteArray(2);
            
            ShortTime = Stream.Read.UShort();
            Unk2_Always1 = Stream.Read.Byte();

            Unk3_1 = Stream.Read.UShort(); //Stream.Read.ByteArray(2);
            Unk3_2 = Stream.Read.UShort(); //Stream.Read.ByteArray(2);
            Unk3_1_Float = UnpackFloat(Unk3_1);
            Unk3_2_Float = UnpackFloat(Unk3_2);

            TravelTime = Stream.Read.Byte();
            BodyPartHit = Stream.Read.Byte();
            Unk4_Always39 = Stream.Read.Byte();
        }

        private float UnpackFloat(ushort val)
        {
            float result = (1.0f / 32767f) * val;
            if (result >= 0) {
                result = (result -1f) * -1f; 
            }
            return result;
        }
    }
}