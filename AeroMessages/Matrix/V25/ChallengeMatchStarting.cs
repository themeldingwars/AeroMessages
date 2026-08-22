using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, 55)]
    public partial class ChallengeMatchStarting
    {
        public ulong ChallengeId; // Assumption
    }
}