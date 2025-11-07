using System.Numerics;
using System.Runtime.InteropServices;
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Command, 20)]
    public partial class KeyframeRequest
    {
        public byte HaveRequestByEntityID;
        [AeroIf(nameof(HaveRequestByEntityID), 1)]
        [AeroArray(typeof(byte))]
        public RequestByEntity[] EntityRequests; // mRequestingKeyframes?

        public byte HaveRequestByRefID;
        [AeroIf(nameof(HaveRequestByRefID), 1)]
        [AeroArray(typeof(byte))]
        public ushort[] RefRequests; // mRequestingViewIndices?
    }

    [AeroBlock]
    public struct RequestByEntity
    {
        public ulong Entity;
        public ushort RefID;
        public byte Unk2;
        public uint Checksum;
    }
}