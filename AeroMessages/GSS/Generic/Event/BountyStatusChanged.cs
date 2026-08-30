using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.BountyStatusChanged, GssVersion.V1, GssVersion.V67)]
    public partial class BountyStatusChanged
    {
        public uint BountyDefId;
        public byte Status;
    }
}