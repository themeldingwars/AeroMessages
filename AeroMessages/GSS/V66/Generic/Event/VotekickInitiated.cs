using Aero.Gen.Attributes;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 33)]
    public partial class VotekickInitiated
    {
        public ulong DefendantId;
        [AeroString] public string Defendant;
        [AeroString] public string Initiator;
        public uint NumVoters;
        public ulong Timeout; // Double
        public sbyte IsParticipant;
    }
}