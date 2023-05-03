using System.Numerics;
using System.Runtime.InteropServices;
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System;
using AeroMessages.Common;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Command, 25)]
    public partial class ClientStatus
    {
        public uint Unk1; // Some form of uptime

        public ushort RoundTripTime;
        public ushort ElapsedMs;
        public uint BytesDown;
        public uint BytesUp;
        public HalfFloat QualityOfServiceDown;
        public HalfFloat QualityOfServiceUp;

        [AeroArray(typeof(ushort))] public byte[] Unk8; // FUN_016eed70, not 100%
    }
}