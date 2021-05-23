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
[Aero]
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