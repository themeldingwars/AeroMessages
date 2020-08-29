using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 151, false)]
    public class CharacterBaseControllerCallForHelp : BaseScript
    {
        public uint Time;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Time = Stream.Read.UInt();
        }
    }
}