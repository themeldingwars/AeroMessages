/*
META_BEGIN
    MsgType: Control
    MsgId: 4
    MsgName: TimeSyncRequest
META_END
 */
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Control
{
    [Aero]
    [AeroMessageId(MsgType.Control, MsgSrc.Both, 4)]
    public partial class Control_TimeSyncRequest
    {
        public ulong ClientTime; // Microseconds Client System Uptime (hrtime)
    }
}