using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, MatrixMessage.ChallengeInvitationCancel, MatrixVersion.V5, MatrixVersion.V32)]
    public partial class ChallengeInvitationCancel
    {
        public ulong ChallengeId; // Assumption
    }
}