using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.DebugLagSimulationSample, GssVersion.V1, GssVersion.V67)]
    public partial class DebugLagSimulationSample
    {
        public ushort ServerFrame;
        public ushort SimulationDuration;
        public ushort SimulatedObjects;
        public ushort TotalObjects;
        public ushort UpdateStarvedAverageMs;
        public ushort UpdateStarvedMaximumMs;
        public ushort LateUpdateAverageMs;
        public ushort LateUpdateMaximumMs;
        public ushort ReorederedObjects;
        public ushort PriorityInversions;
        public ushort DroppedPriorityUpdates;
        public ushort UpdateRequests;
        public ushort RejectedUpdateRequests;
    }
}