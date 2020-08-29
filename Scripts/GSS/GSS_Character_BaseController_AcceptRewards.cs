using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 225, false)]
    public class CharacterBaseControllerAcceptRewards : BaseScript
    {
        public uint IndexId;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            IndexId = Stream.Read.UInt();
        }
    }
}