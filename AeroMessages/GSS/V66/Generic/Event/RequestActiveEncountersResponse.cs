using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.RequestActiveEncounters_Response, GssVersion.V1, GssVersion.V67)]
    public partial class RequestActiveEncountersResponse
    {
        [AeroString] public string JSON; // Assumption, consume all data
    }
}