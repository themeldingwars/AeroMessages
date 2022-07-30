using System.Numerics;
using System.Runtime.InteropServices;
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Command, 30)]
    public partial class ServerProfilerRequestNames
    {
        [AeroArray(typeof(byte))] public ushort[] Unk1;
        [AeroArray(typeof(byte))] public ushort[] Unk2;
    }
}