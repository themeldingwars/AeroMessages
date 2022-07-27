using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Command, 28)]
    public partial class SuperPing
    { 
        [AeroArray(typeof(byte))]
        public ulong[] TimestampMicro; // Microseconds UNIX Epoch (Client follows server time from TimeSync)
        public EntityId Requester;
        public uint Unk;
    }
}