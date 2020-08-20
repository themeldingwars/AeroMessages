using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 5, 119, false)]
    public class CharacterCombatControllerFireEnd : BaseScript
    {
        public uint Time;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Time = Stream.Read.UInt();
        }
    }
}