[Aero(AeroType.Msg, MsgType.Control, 4, Ver: 1962)]
public partial class TimeSyncRequest : AeroBase
{
    public ulong ClientTime; // Microseconds Client System Uptime (hrtime)
}