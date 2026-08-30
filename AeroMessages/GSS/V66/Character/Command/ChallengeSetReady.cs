using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.ChallengeSetReady, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class ChallengeSetReady
    {
        public ulong Unk1;
        public sbyte Unk2; // Ready state?
    }
}