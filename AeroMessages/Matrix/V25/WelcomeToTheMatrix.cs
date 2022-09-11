using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, 35)]
    public partial class WelcomeToTheMatrix
    {
        public ulong PlayerID;
        [AeroArray(typeof(ushort))] public byte[] Unk1; // FUN_016eed70, not 100%
        [AeroArray(typeof(ushort))] public byte[] Unk2; // FUN_016eed70, not 100%
    }
}