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
        [AeroBlob(typeof(ushort))] public byte[] Unk1;
        [AeroBlob(typeof(ushort))] public byte[] Unk2;
    }
}