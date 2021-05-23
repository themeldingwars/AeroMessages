/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 4
    TypeName: Character::MissionAndMarkerController
    MsgId: 169
    MsgName: RequestAchievementStatus
META_END
 */
using Aero.Gen.Attributes;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_Command_RequestAchievementStatus
    {
        public uint AchievementId;
    }
}