/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 190
    MsgName: EliteLevels_IncreaseXp
META_END
 */
using Aero.Gen.Attributes;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_Event_EliteLevels_IncreaseXp
    {
        public uint XP;
    }
}