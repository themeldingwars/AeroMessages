/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 193
    MsgName: EliteLevels_Initialized_Info
META_END
 */
using Aero.Gen.Attributes;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_Event_EliteLevels_Initialized_Info
    {
        public uint LevelsPerRare; // award_frame_min_level
        public uint AwardFrameMinLevel; // levels_per_rare
        public uint RevertCost; // revert_cost
        public uint RerollCost; // reroll_cost
    }
}