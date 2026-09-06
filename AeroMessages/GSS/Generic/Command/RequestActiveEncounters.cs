using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Both, GssMessage.RequestActiveEncounters, GssVersion.V1, GssVersion.V74)]
    public partial class RequestActiveEncounters
    {
        // Nothing to parse
    }
}