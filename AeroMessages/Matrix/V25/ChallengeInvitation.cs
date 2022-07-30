using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, 46)]
    public partial class ChallengeInvitation
    {
        public ulong ChallengeId;
        public EntityId FromEntity; // Assumption
        [AeroString] public string FromName;
    }
}