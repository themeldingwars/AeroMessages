/*
META_BEGIN
    MsgType: Control
    MsgId: 4
    MsgName: TimeSyncRequest
META_END
 */
[Aero]
public partial class Control_TimeSyncRequest
{
    public ulong ClientTime; // Microseconds Client System Uptime (hrtime)
}