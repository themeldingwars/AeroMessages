using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, MatrixMessage.ChallengeInvitation, MatrixVersion.V5, MatrixVersion.V26)]
    public partial class ChallengeInvitation
    {
        public ulong ChallengeId;
        public EntityId FromEntity; // Assumption
        [AeroString] public string FromName;
    }
}