using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, MatrixMessage.WelcomeToTheMatrix, MatrixVersion.V1, MatrixVersion.V26)]
    public partial class WelcomeToTheMatrix
    {
        public ulong PlayerID;
        [AeroArray(typeof(ushort))] public byte[] Unk1; // FUN_016eed70, not 100%
        [AeroArray(typeof(ushort))] public byte[] Unk2; // FUN_016eed70, not 100%
    }
}