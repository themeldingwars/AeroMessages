using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 210, false)]
    public class CharacterBaseControllerRequestTeleport : BaseScript
    {
        public uint PosX;
        public uint PosY;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.BigEndian; // NOTE~! Client sends the coords in big endian

            PosX = Stream.Read.UInt();
            PosY = Stream.Read.UInt();
        }
    }
}