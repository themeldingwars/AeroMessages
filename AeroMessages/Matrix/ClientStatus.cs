using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;

namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Command, MatrixMessage.ClientStatus, MatrixVersion.V1, MatrixVersion.V26)]
    public partial class ClientStatus
    {
        public uint ClientTime; // Miliseconds Client System Uptime (like TimeSyncRequest)
        public ushort RoundTripTime;
        public ushort ElapsedMs;
        public uint BytesDown;
        public uint BytesUp;
        public HalfFloat QualityOfServiceDown;
        public HalfFloat QualityOfServiceUp;

        [AeroBlob(typeof(ushort))] public byte[] Unk8;
    }
}