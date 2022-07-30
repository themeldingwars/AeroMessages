using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, 47)]
    public partial class ChallengeInvitationSquadInfoAck
    {
        public ulong ChallengeId; // Assumption
        public ulong Unk1;
        public string Unk2;
    }
}