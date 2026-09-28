using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.ChallengeSwapTeam, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class ChallengeSwapTeam
    {
        public ulong ChallengeId;
        public ulong Member1Id;
        public ulong Member2Id;
    }
}