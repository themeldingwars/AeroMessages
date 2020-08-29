using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 205, false)]
    public class CharacterBaseControllerUnslotAllModulesRequest : BaseScript
    {
        public ulong ItemGUID;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            ItemGUID = Stream.Read.ULong();
        }
    }
}