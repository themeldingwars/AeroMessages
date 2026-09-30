using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, MatrixMessage.ChallengeInvitationSquadInfoAck, MatrixVersion.V5, MatrixVersion.V32)]
    public partial class ChallengeInvitationSquadInfoAck
    {
        public ulong ChallengeId;
        public EntityId FromEntity; // same as ChallengeInvitation, but never auto accepted
        [AeroString] public string FromName;
    }
}