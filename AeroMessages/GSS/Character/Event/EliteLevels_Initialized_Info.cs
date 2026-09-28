using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.EliteLevels_Initialized_Info, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class EliteLevels_Initialized_Info
    {
        public uint LevelsPerRare; // levels_per_rare
        public uint AwardFrameMinLevel; // award_frame_min_level
        public uint RevertCost; // revert_cost
        public uint RerollCost; // reroll_cost
    }
}