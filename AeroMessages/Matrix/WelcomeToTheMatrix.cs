using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, MatrixMessage.WelcomeToTheMatrix, MatrixVersion.V1, MatrixVersion.V32)]
    public partial class WelcomeToTheMatrix
    {
        public ulong PlayerID; // Also sent as the owner id in controller keyframes and controller removes
        [AeroBlob(typeof(ushort))] public byte[] Unk1; // copied into a connection buffer, not read otherwise
        [AeroBlob(typeof(ushort))] public byte[] Unk2; // never read by the 1962 client
    }
}