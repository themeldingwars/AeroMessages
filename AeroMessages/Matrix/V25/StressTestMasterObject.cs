using System.Numerics;
using System.Runtime.InteropServices;
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Command, 29)]
    public partial class StressTestMasterObject
    {
        [AeroArray(typeof(ushort))] public byte[] Unk1; // FUN_016eed70, not 100%
    }
}