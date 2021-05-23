/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 117
    MsgName: CameraPoseUpdate
META_END
 */
using Aero.Gen.Attributes;
using AeroMessages.Common;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_Command_CameraPoseUpdate
    {
        public byte Unk1;
        public EntityId FollowingEntity;
    }
}