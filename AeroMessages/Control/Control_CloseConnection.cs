using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Control
{
    [Aero]
    [AeroMessageId(MsgType.Control, MsgSrc.Both, 0)]
    public partial class CloseConnection
    {
        // Big-endian on the wire, swap the bytes after reading. 0 when the sender gives no code.
        // From the server, 0 makes the client reconnect the Matrix (transfer), any other code ends the session.
        public uint ShutdownCode;

        // Optional ASCII text, up to 243 bytes, no length prefix and no terminator
        [AeroBlob] public byte[] Reason = [];
    }
}