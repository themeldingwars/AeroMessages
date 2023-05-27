using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
using AeroMessages.Common;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 94)]
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