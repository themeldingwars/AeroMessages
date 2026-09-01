using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Both, GssMessage.RequestLeaveZone, GssVersion.V1, GssVersion.V67)]
    public partial class RequestLeaveZone
    {
        // Nothing to parse
    }
}