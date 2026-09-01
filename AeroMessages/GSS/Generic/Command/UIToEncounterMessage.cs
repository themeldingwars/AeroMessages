using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Both, GssMessage.UIToEncounterMessage, GssVersion.V1, GssVersion.V67)]
    public partial class UIToEncounterMessage
    {
        [AeroString]
        public string Key1;

        [AeroString]
        public string Key2;

        [AeroString]
        public string JSON;
    }
}