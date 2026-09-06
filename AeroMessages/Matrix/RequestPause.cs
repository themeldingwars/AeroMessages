using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Command, MatrixMessage.RequestPause, MatrixVersion.V5, MatrixVersion.V32)]
    public partial class RequestPause
    {
        public EntityId Sender;
    }
}