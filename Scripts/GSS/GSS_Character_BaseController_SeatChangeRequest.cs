using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 216, false)]
    public class CharacterBaseControllerSeatChangeRequest : BaseScript
    {
        public byte RequestedSeatIndex;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            RequestedSeatIndex = Stream.Read.Byte();
        }
    }
}