using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 28, 83, true)]
    public class VehicleCombatControllerAbilityActivated : BaseScript
    {
        public uint AbilityId;
        public uint Time;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            AbilityId = Stream.Read.UInt();
            Time = Stream.Read.UInt();
        }
    }
}