/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 249
    MsgName: UpdateFriendStatus
META_END
 */
using Aero.Gen.Attributes;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_Command_UpdateFriendStatus
    {
        [AeroString]
        public string TargetName;

        [AeroArray(2)]
        public byte[] Unk_Status;
    }
}