using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, MatrixMessage.ChallengeInvitationResponse, MatrixVersion.V5, MatrixVersion.V26)]
    public partial class ChallengeInvitationResponse
    {
        public ulong ChallengeId; // Assumption
        [AeroString] public string Unk1; // Assumption
        public sbyte Unk2;
    }
}