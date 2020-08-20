using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 27, 87, false)]
    public class VehicleBaseControllerActivateAbility : BaseScript
    {
        public uint Time;
        public byte Unk_AbilityIdx; // 0x05 == Honk, 0x08 == SIN
        public byte[] Unk3; // 0x00, 0x00 for Honk

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            Time = Stream.Read.UInt();
            Unk_AbilityIdx = Stream.Read.Byte();
            Unk3 = Stream.Read.ByteArray(2);
        }
    }
}