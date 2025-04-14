using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 97)]
    public partial class ChallengeInvitationResponse
    {
        public ulong ChallengeId; // Assumption
        public sbyte Unk2;
    }
}