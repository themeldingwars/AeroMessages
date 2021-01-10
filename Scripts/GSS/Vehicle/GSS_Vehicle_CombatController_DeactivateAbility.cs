using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 28, 88, false)]
    public class VehicleCombatControllerDectivateAbility : BaseScript
    {
        public uint Time;
        public byte Unk_AbilityIdx; // 0x05 == Honk

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            Time = Stream.Read.UInt();
            Unk_AbilityIdx = Stream.Read.Byte();
        }
    }
}