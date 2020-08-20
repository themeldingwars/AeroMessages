using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 5, 125, true)]
    public class CharacterCombatControllerInteractionProgressed : BaseScript
    {
        public uint Time;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Time = Stream.Read.UInt();
        }
    }
}