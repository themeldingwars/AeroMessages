using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, 48)]
    public partial class ChallengeInvitationCancel
    {
        public ulong ChallengeId; // Assumption
    }
}