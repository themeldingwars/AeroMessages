using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.VotekickInitiated, GssVersion.V1, GssVersion.V74)]
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