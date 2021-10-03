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
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 249)]
    public partial class Character_Command_UpdateFriendStatus
    {
        [AeroString]
        public string TargetName;

        [AeroArray(2)]
        public byte[] Unk_Status;
    }
}