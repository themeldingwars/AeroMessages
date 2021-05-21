[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 0, 48, Ver: 1962)]
public partial class GenericTempConsoleMessage : AeroBase
{   
    [AeroNullTermString]
    public string ConsoleCommand;

    [AeroNullTermString]
    public string ChatNotification;

    [AeroNullTermString]
    public string ConsoleNoticeMessage;

    [AeroNullTermString]
    public string DebugReportArgType;

    [AeroFixedString(typeof(ushort))]
    public string DebugReportArgData;
}