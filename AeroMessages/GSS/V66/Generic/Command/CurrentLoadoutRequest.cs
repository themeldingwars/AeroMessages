using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Both, GssMessage.CurrentLoadoutRequest, GssVersion.V1, GssVersion.V67)]
    public partial class CurrentLoadoutRequest
    {
        public EntityId Target; // Assumption
    }
}