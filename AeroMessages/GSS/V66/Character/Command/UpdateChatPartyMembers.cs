using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 185)]
    public partial class UpdateChatPartyMembers
    {
        [AeroArray(typeof(byte))] public ChatPartyMember[] Data;
        public EntityId InvitingEntity;
    }
}