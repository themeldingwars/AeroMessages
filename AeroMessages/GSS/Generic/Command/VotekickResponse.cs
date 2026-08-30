using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Both, GssMessage.VotekickResponse, GssVersion.V1, GssVersion.V67)]
    public partial class VotekickResponse
    {
        public ulong Unk1;
        public sbyte Unk2;
    }
}