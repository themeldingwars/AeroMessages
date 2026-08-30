using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Both, GssMessage.RequestEncounterInfo, GssVersion.V1, GssVersion.V67)]
    public partial class RequestEncounterInfo
    {
        public EntityId EncounterId;
    }
}