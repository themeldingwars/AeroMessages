using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, MatrixMessage.ChallengeMatchParametersUpdate, MatrixVersion.V5, MatrixVersion.V26)]
    public partial class ChallengeMatchParametersUpdate
    {
        public ulong ChallengeId; // Assumption
        public uint Unk1;
    }
}