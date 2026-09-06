using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.DebugLagPlayerSample, GssVersion.V1, GssVersion.V74)]
    public partial class DebugLagPlayerSample
    {
        // These three seem to be timestamps relative to the gameclock timer but also each other.
        public ushort ShortTime_InputResponseReceivedAtMs; // Compared to InputRequestAt to find Server Player Input Delay
        public ushort ShortTime_InputResponseSentAtMs; // Compared to clock to find Server Application Ping
        public ushort ShortTime_InputRequestAtMs; // Compared to clock to find Client Application Ping (Client also uses PingTime on BaseController as data for this measurement)

        // These two are regular values
        public ushort ServerInputDelaySampleMs;
        public ushort ServerLatenessMs;
    }
}