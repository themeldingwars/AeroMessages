using Aero.Gen.Attributes;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 34)]
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