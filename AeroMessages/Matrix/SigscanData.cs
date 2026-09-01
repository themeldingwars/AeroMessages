using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, MatrixMessage.SigscanData, MatrixVersion.V18, MatrixVersion.V26)]
    public partial class SigscanData
    {
        [AeroArray(typeof(ushort))] public byte[] Unk1; // FUN_016eed70, not 100%
        public byte Unk2;
    }
}