using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Command, MatrixMessage.StressTestMasterObject, MatrixVersion.V5, MatrixVersion.V26)]
    public partial class StressTestMasterObject
    {
        [AeroArray(typeof(ushort))] public byte[] Unk1; // FUN_016eed70, not 100%
    }
}