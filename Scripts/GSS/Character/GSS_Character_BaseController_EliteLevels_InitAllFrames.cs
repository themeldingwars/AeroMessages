using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 186, true)]
    public class CharacterBaseControllerEliteLevelsInitAllFrames : BaseScript
    {
        public uint ChassisId; // dunno, its repeated

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            //ChassisId = Stream.Read.UInt();
        }
    }
}
