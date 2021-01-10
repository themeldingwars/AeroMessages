using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 27, 86, false)]
    public class VehicleBaseControllerReceiveCollisionDamage : BaseScript
    {
        public ushort Unk1_DamageValue; // Not really sure about this value
        public byte Unk2; // Possible number of entities we collided with, or just if we collided with one
        public byte[] CollidedWithEntity;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Unk1_DamageValue = Stream.Read.UShort();
            Unk2 = Stream.Read.Byte();
            if (Unk2 > 0)
            {
                CollidedWithEntity = Stream.Read.ByteArray(8);
            }
        }
    }
}