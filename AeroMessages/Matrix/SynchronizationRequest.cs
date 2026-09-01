using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, MatrixMessage.SynchronizationRequest, MatrixVersion.V1, MatrixVersion.V26)]
    public partial class SynchronizationRequest
    {
        // TODO
    }
}