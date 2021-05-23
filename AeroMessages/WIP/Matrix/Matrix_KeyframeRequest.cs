/*
META_BEGIN
    MsgType: Matrix
    MsgId: 20
    MsgName: KeyframeRequest
META_END
 */
using System.Numerics;
using System.Runtime.InteropServices;
using Aero.Gen.Attributes;
namespace AeroMessages.Matrix
{
    [AeroBlock]
    public struct RequestByEntity
    {
        public ulong Entity;
        public ushort RefID;
        public byte Unk2;
        public uint Checksum;
    }

    [Aero]
    public partial class Matrix_KeyframeRequest
    {
        public byte HaveRequestByEntityID;
        //[AeroIf(nameof(HaveRequestByEntityID), 1)]
        //[AeroArray(typeof(byte))]
        //public RequestByEntity[] EntityRequests; // TODO: FIXME: Gen issue

        public byte HaveRequestByRefID;
        [AeroIf(nameof(HaveRequestByRefID), 1)]
        [AeroArray(typeof(byte))]
        public ushort[] RefRequests;

    }
}