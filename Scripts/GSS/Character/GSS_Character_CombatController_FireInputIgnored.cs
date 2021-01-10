using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 5, 117, false)]
    public class CharacterCombatControllerFireInputIgnored : BaseScript
    {
        public uint Time;
        public byte Ignored;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Time = Stream.Read.UInt();
            Ignored = Stream.Read.Byte();
        }
    }
}