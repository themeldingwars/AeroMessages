using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, MatrixMessage.SigscanData, MatrixVersion.V18, MatrixVersion.V32)]
    public partial class SigscanData
    {
        [AeroBlob(typeof(ushort))] public byte[] Data; // chunk, appended until IsLastChunk
        public byte IsLastChunk;
    }
}