using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.MatchAccept, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class MatchAccept
    {
        public uint Matchmaker;
        public ulong MatchId;
        public sbyte Accept;
    }
}