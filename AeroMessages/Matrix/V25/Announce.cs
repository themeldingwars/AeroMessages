using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, MatrixMessage.Announce, MatrixVersion.V1, MatrixVersion.V26)]
    public partial class Announce
    {
        [AeroString] public string Type; // 'sysmsg'
        [AeroString] public string Data;
    }
}