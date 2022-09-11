using System.Numerics;
using System.Runtime.InteropServices;
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, 67)]
    public partial class ReceiveEmergencyChat
    {
        public ulong Unk1;
        [AeroString] public string Unk2;
        [AeroString] public string Unk3;
        public uint Unk4;
    }
}