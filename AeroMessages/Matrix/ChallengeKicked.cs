using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, MatrixMessage.ChallengeKicked, MatrixVersion.V5, MatrixVersion.V26)]
    public partial class ChallengeKicked
    {
        public ulong ChallengeId; // Assumption
        [AeroString] public string Unk1;
        public ulong Unk2;
        [AeroString] public string Unk3;
    }
}