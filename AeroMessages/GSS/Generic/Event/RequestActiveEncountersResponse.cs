using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.RequestActiveEncounters_Response, GssVersion.V1, GssVersion.V74)]
    public partial class RequestActiveEncountersResponse
    {
        [AeroString] public string JSON; // Assumption, consume all data
    }
}