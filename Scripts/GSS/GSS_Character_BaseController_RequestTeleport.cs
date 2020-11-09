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
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            PosX = Stream.Read.UInt();
            PosY = Stream.Read.UInt();
        }
    }
}