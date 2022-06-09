using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 185)]
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