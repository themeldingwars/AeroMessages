using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Command, MatrixMessage.StressTestMasterObject, MatrixVersion.V5, MatrixVersion.V32)]
    public partial class StressTestMasterObject
    {
        [AeroBlob(typeof(ushort))] public byte[] Unk1;
    }
}