using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 113)]
    public partial class RequestActiveEncountersResponse
    {   
        [AeroString] public string JSON; // Assumption, consume all data
    }
}