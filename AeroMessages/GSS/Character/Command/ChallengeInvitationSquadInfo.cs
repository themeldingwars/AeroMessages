using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.ChallengeInvitationSquadInfo, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class ChallengeInvitationSquadInfo
    {
        public ulong ChallengeId;
        public ulong InviterId;
        [AeroString] public string InviterName;
        [AeroArray(typeof(byte))] public ulong[] SquadMemberIds;
    }
}