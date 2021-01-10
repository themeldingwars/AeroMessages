using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 5, 123, false)]
    public class CharacterCombatControllerSelectFireMode : BaseScript
    {
        public uint Time;
        public byte FireMode;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Time = Stream.Read.UInt();
            FireMode = Stream.Read.Byte();
        }
    }
}