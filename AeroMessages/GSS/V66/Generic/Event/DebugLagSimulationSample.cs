using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
using AeroMessages.Common;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 95)]
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