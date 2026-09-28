using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, MatrixMessage.SynchronizationRequest, MatrixVersion.V1, MatrixVersion.V32)]
    public partial class SynchronizationRequest
    {
        // RedHanded anti-cheat payload. The first one per session is zlib data + uint32 inflated length + 16 bytes, later ones look encrypted
        [AeroBlob] public byte[] Data;
    }
}