using System.Numerics;
using System.Runtime.InteropServices;
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, 61)]
    public partial class ServerProfilerSendFrame
    {
        [AeroArray(typeof(byte))] public ushort[] Unk1;
    }
}