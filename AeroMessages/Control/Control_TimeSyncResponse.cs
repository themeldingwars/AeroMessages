using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Control
{
    [Aero]
    [AeroMessageId(MsgType.Control, MsgSrc.Both, 5)]
    public partial class TimeSyncResponse
    {
        public ulong ClientTime; // Microseconds Client System Uptime (hrtime)
        public ulong ServerTime; // Microseconds UNIX Epoch
    }
}
