using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 193)]
    public partial class EliteLevels_Initialized_Info
    {
        public uint LevelsPerRare; // award_frame_min_level
        public uint AwardFrameMinLevel; // levels_per_rare
        public uint RevertCost; // revert_cost
        public uint RerollCost; // reroll_cost
    }
}