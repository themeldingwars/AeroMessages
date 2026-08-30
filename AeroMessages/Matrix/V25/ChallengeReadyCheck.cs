using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, MatrixMessage.ChallengeReadyCheck, MatrixVersion.V5, MatrixVersion.V26)]
    public partial class ChallengeReadyCheck
    {
        public ulong ChallengeId; // Assumption
    }
}