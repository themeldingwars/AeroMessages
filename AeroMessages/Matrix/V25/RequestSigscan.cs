using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Command, MatrixMessage.RequestSigscan, MatrixVersion.V18, MatrixVersion.V26)]
    public partial class RequestSigscan
    {
        public uint Unk1;
        public byte Unk2;
    }
}