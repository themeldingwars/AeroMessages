using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 193, true)]
    public class CharacterBaseControllerEliteLevelsInitializedInfo : BaseScript
    {
        public uint LevelsPerRare; // award_frame_min_level
        public uint AwardFrameMinLevel; // levels_per_rare
        public uint RevertCost; // revert_cost
        public uint RerollCost; // reroll_cost

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            LevelsPerRare = Stream.Read.UInt();
            AwardFrameMinLevel = Stream.Read.UInt();
            RevertCost = Stream.Read.UInt();
            RerollCost = Stream.Read.UInt();
        }
    }
}