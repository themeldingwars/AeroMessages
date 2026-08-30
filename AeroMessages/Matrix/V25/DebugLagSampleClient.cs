using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, MatrixMessage.DebugLagSampleClient, MatrixVersion.V8, MatrixVersion.V26)]
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