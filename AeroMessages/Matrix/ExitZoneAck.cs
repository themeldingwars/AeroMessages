using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Command, MatrixMessage.ExitZoneAck, MatrixVersion.V1, MatrixVersion.V32)]
    public partial class ExitZoneAck
    {
        // Nothing to parse
    }
}