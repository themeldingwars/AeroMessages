using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Control
{
    [Aero]
    [AeroMessageId(MsgType.Control, MsgSrc.Both, 6)]
    public partial class MTUProbe
    {
        // One byte value repeated to pad the packet to the size being probed
        [AeroBlob] public byte[] Fill = [];
    }
}