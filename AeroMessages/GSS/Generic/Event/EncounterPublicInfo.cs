using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.EncounterPublicInfo, GssVersion.V1, GssVersion.V67)]
    public partial class EncounterPublicInfo
    {
        public EntityId EncounterId;

        [AeroString]
        public string EncounterJSON;
    }
}