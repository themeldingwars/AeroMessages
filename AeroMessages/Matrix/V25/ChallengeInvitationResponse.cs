using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, 49)]
    public partial class ChallengeInvitationResponse
    {
        public ulong ChallengeId; // Assumption
        [AeroString] public string Unk1; // Assumption
        public byte Unk2;
    }
}