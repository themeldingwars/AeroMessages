using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Command, 26)]
    public partial class ClientPreferences
    {
        public uint MaxBytesPerSecond; // network.maxKBitPerSecond, value is sent as bytes rather than bits
        public uint MinBatchDelay; // network.minBatchDelay
        public ushort TargetMTU; // network.targetMTU, value sent caps at 1168 which is equiv to setting 1492 in the console.
        public byte MatrixDebugFlags; // When debuglag.matrixDev is set to 1, MatrixDebugFlags -> 2. Otherwise -> 0.
    }
}