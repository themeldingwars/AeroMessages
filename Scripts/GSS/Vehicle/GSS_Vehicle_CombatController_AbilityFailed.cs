using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 28, 84, true)]
    public class VehicleCombatControllerAbilityFailed : BaseScript
    {
        public uint AbilityId;
        public byte[] Unk;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            AbilityId = Stream.Read.UInt();
            Unk = Stream.Read.ByteArray(4);
        }
    }
}