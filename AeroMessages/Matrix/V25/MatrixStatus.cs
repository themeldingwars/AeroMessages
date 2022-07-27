using System.Numerics;
using System.Runtime.InteropServices;
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, 41)]
    public partial class MatrixStatus
    {
        public uint Unk1;
        public uint Unk2;
        public byte Unk3;
        public byte Unk4;
        public ushort Unk5;
        public byte Unk6;
        public byte Unk7; // Something different
        public ushort Unk8;
    }
}