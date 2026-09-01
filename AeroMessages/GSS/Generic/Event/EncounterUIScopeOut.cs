using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.EncounterUIScopeOut, GssVersion.V1, GssVersion.V67)]
    public partial class EncounterUIScopeOut
    {
        public EntityId EncounterId;
    }
}