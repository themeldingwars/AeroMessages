using System.Numerics;
using System.Runtime.InteropServices;
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, 56)]
    public partial class ForceUnqueue
    {
        public byte Unk1;
        [AeroArray(typeof(byte))] public ulong[] Unk2;
        public uint Unk3;
    }
}