/*
META_BEGIN
    MsgType: Control
    MsgId: 5
    MsgName: TimeSyncResponse
META_END
 */
using Aero.Gen.Attributes;
namespace AeroMessages.Control
{
    [Aero]
    public partial class Control_TimeSyncResponse
    {
        public ulong ClientTime; // Microseconds Client System Uptime (hrtime)
        public ulong ServerTime; // Microseconds UNIX Epoch
    }
}
