using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 5, 124, false)]
    public class CharacterCombatControllerUseScope : BaseScript
    {
        public uint Time;
        public byte InScope;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Time = Stream.Read.UInt();
            InScope = Stream.Read.Byte();
        }
    }
}