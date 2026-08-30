using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.EncDebugChatMessage, GssVersion.V1, GssVersion.V67)]
    public partial class EncDebugChatMessage
    {
        [AeroString] public string Message;
    }
}