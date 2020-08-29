using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 4, 169, false)]
    public class CharacterMissionAndMarkerControllerRequestAchievementStatus : BaseScript
    {
        public uint AchievementId;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            AchievementId = Stream.Read.UInt();
        }
    }
}