using System.Numerics;
using System.Runtime.InteropServices;
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, 66)]
    public partial class LFGLeaderChange
    {
        public ulong Unk1;
        public ulong Unk2;
        [AeroString] public string Unk3;
    }
}