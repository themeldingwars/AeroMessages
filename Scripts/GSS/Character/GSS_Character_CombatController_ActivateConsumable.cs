using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 5, 138, false)]
    public class CharacterCombatControllerActivateConsumable : BaseScript
    {
        public uint Time;
        public uint ItemSdbId;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Time = Stream.Read.UInt();
            ItemSdbId = Stream.Read.UInt();
        }
    }
}