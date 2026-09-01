using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Command, MatrixMessage.SuperPing, MatrixVersion.V1, MatrixVersion.V26)]
    public partial class SuperPing
    {
        [AeroArray(typeof(byte))]
        public ulong[] TimestampMicro; // Microseconds UNIX Epoch (Client follows server time from TimeSync)
        public EntityId Requester;
        public uint Unk;
    }
}