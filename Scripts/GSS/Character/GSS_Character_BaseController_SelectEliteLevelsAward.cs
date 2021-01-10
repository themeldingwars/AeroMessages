using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 229, false)]
    public class CharacterBaseControllerSelectEliteLevelsAward : BaseScript
    {
        public uint Index;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            Index = Stream.Read.UInt();
        }
    }
}