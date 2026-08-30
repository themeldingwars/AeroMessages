using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.ChallengeSwapTeam, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class ChallengeSwapTeam
    {
        public ulong Unk1;
        public ulong Unk2;
        public ulong Unk3;
    }
}