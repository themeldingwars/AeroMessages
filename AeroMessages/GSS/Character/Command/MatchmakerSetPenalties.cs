using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.MatchmakerSetPenalties, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class MatchmakerSetPenalties
    {
        public uint Unk1;
        public byte Unk2;
        public uint Unk3;
        public byte Unk4;
    }
}