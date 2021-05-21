[Aero(AeroType.Msg, MsgType.Control, 5, Ver: 1962)]
public partial class TimeSyncResponse : AeroBase
{
    public ulong ClientTime; // Microseconds Client System Uptime (hrtime)
    public ulong ServerTime; // Microseconds UNIX Epoch
}