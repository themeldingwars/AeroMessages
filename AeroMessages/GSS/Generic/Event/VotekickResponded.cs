using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.VotekickResponded, GssVersion.V1, GssVersion.V74)]
    public partial class VotekickResponded
    {
        public ulong DefendantId;
        [AeroString] public string Defendant;
        [AeroString] public string Respondant;
        public sbyte ShouldKick;
        public ushort VotesFor;
        public ushort VotesAgainst;
    }
}