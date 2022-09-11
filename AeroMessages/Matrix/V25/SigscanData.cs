using System.Numerics;
using System.Runtime.InteropServices;
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, 34)]
    public partial class SigscanData
    {
        [AeroArray(typeof(ushort))] public byte[] Unk1; // FUN_016eed70, not 100%
        public byte Unk2;
    }
}