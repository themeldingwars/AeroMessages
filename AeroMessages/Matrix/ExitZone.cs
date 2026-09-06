using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, MatrixMessage.ExitZone, MatrixVersion.V1, MatrixVersion.V32)]
    public partial class ExitZone
    {
        // Nothing to parse
    }
}