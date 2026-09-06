using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.TempConsoleMessage, GssVersion.V1, GssVersion.V74)]
    public partial class TempConsoleMessage
    {
        [AeroString]
        public string ConsoleCommand;

        [AeroString]
        public string ChatNotification;

        [AeroString]
        public string ConsoleNoticeMessage;

        [AeroString]
        public string DebugReportArgType;

        [AeroString(typeof(ushort))]
        public string DebugReportArgData;
    }
}