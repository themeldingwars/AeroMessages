/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 193
    MsgName: EliteLevelsIncreaseXP
META_END
 */
[Aero]
public partial class Character_Event_EliteLevelsIncreaseXP
{
    public uint LevelsPerRare; // award_frame_min_level
    public uint AwardFrameMinLevel; // levels_per_rare
    public uint RevertCost; // revert_cost
    public uint RerollCost; // reroll_cost
}