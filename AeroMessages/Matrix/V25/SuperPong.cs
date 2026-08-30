using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, MatrixMessage.SuperPong, MatrixVersion.V1, MatrixVersion.V26)]
    public partial class SuperPong
    {
        [AeroArray(typeof(byte))]
        public ulong[] TimestampMicro; // Microseconds UNIX Epoch (Client follows server time from TimeSync)
        public uint Unk;
    }
}