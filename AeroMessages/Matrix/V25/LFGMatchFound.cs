using System.Numerics;
using System.Runtime.InteropServices;
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, 65)]
    public partial class LFGMatchFound
    {
        public ulong Unk1;
        public uint Unk2;
        public ulong Unk3;
        [AeroString] public string Unk4;

        [AeroArray(typeof(byte))]
        [AeroString] public string[] Unk5;
    }
}