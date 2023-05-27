using System.Numerics;
using System.Runtime.InteropServices;
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, 64)]
    public partial class DebugLagSampleClient
    {
        public ushort TotalBudgetBytes;
        public ushort KeyframesBudgetBytes;
        public ushort ReservedBudgetBytes;
        public ushort UnreliableBudgetBytes;
        public ushort KeyframesRequested;
        public ushort KeyframesQueued;
        public ushort BatchingDelayMs;
    }
}