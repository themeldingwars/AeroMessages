using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, MatrixMessage.ChallengeInvitationSquadInfoAck, MatrixVersion.V5, MatrixVersion.V26)]
    public partial class ChallengeInvitationSquadInfoAck
    {
        public ulong ChallengeId; // Assumption
        public ulong Unk1;
        [AeroString] public string Unk2;
    }
}