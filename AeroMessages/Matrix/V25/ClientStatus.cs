using System.Numerics;
using System.Runtime.InteropServices;
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Command, 25)]
    public partial class ClientStatus
    {
        public uint Unk1;
        public ushort Unk2;
        public ushort Unk3;
        public uint Unk4;
        public uint Unk5;
        public ushort Unk6;
        public ushort Unk7;
        [AeroArray(typeof(ushort))] public byte[] Unk8; // FUN_016eed70, not 100%
    }
}