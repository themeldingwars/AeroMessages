using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, MatrixMessage.ChallengeKicked, MatrixVersion.V5, MatrixVersion.V32)]
    public partial class ChallengeKicked
    {
        public ulong ChallengeId;
        [AeroString] public string KickerName;
        public EntityId KickeeId; // the local character leaves the challenge when it's its own id
        [AeroString] public string KickeeName;
    }
}