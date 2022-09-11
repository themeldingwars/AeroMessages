using System.Numerics;
using System.Runtime.InteropServices;
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, 38)]
    public partial class UpdateZoneTimeSync
    {
        public ulong Unk1;
        public float Unk2;
        public float Unk3;
    }
}