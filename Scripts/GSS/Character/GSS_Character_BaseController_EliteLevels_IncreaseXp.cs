using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 190, true)]
    public class CharacterBaseControllerEliteLevelsIncreaseXP : BaseScript
    {
        public uint XP;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            XP = Stream.Read.UInt();
        }
    }
}