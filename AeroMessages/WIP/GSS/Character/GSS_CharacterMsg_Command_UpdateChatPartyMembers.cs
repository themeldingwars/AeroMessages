/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 185
    MsgName: UpdateChatPartyMembers
META_END
 */
using Aero.Gen.Attributes;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_Command_UpdateChatPartyMembers
    {
        [AeroArray(9)]
        public byte[] Unk1;

        [AeroString]
        public string InvitedCharacterName;

        public byte Unk2; // I'm seeing 0b, it could be chat channel for squad
        public ulong InvitingEntity;
    }
}