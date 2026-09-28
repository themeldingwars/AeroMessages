using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Command, MatrixMessage.KeyframeRequest, MatrixVersion.V1, MatrixVersion.V32)]
    public partial class KeyframeRequest
    {
        public byte HaveRequestByEntityID;

        // TODO: Aero needs support for handling additional entries if size is 255
        // TEMP: Hack that supports up to 765 entity requests
        [AeroIf(nameof(HaveRequestByEntityID), 1)]
        [AeroArray(typeof(byte))]
        public RequestByEntity[] EntityRequestsPart1; // mRequestingKeyframes?

        [AeroIf(nameof(HaveRequestByEntityID), 1)]
        [AeroIf("EntityRequestsPart1.Length", 255)]
        [AeroArray(typeof(byte))]
        public RequestByEntity[] EntityRequestsPart2 = [];

        [AeroIf(nameof(HaveRequestByEntityID), 1)]
        [AeroIf("EntityRequestsPart1.Length", 255)]
        [AeroIf("EntityRequestsPart2.Length", 255)]
        [AeroArray(typeof(byte))]
        public RequestByEntity[] EntityRequestsPart3 = [];

        public byte HaveRequestByRefID;
        [AeroIf(nameof(HaveRequestByRefID), 1)]
        [AeroArray(typeof(byte))]
        public ushort[] RefRequests; // mRequestingViewIndices?
    }

    [AeroBlock]
    public struct RequestByEntity
    {
        public ulong Entity;
        public ushort RefID; // 0xFFFF when the client has no ref id for the entity
        public byte ChecksumStatus; // 0 = no checksum (Checksum is 0), 1 = client checksum differs from the server's, 2 = matches
        public uint Checksum;
    }
}