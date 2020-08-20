using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 5, 134, false)]
    public class CharacterCombatControllerActivateAbility : BaseScript
    {
        public uint Time;
        public byte AbilitySlotIndex;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Time = Stream.Read.UInt();
            AbilitySlotIndex = Stream.Read.Byte();
        }
    }
}