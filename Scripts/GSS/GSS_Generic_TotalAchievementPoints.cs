using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 0, 82, true)]
    public class GenericTotalAchievementPoints : BaseScript
    {
        public uint Points;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Points = Stream.Read.UInt();
        }
    }
}