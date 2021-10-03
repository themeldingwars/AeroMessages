/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 0
    TypeName: Generic
    MsgId: 48
    MsgName: TempConsoleMessage
META_END
 */
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 48)]
    public partial class Generic_Event_TempConsoleMessage
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