using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, MatrixMessage.ChallengeInvitationResponse, MatrixVersion.V5, MatrixVersion.V32)]
    public partial class ChallengeInvitationResponse
    {
        public ulong ChallengeId;
        [AeroString] public string InviteeName;
        public ChallengeInvitationResult Result;
    }

    public enum ChallengeInvitationResult : byte
    {
        Accepted = 0,
        Declined = 1,
        DoesNotExist = 2,
        Offline = 3,
        TeamFull = 4,
        MatchStarting = 5,
        TargetNotChallengeable = 6,
        SquadTeamFull = 7,
    }
}