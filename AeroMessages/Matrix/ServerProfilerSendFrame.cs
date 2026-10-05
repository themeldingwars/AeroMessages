using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, MatrixMessage.ServerProfiler_SendFrame, MatrixVersion.V5, MatrixVersion.V32)]
    public partial class ServerProfilerSendFrame
    {
        [AeroArray(typeof(byte))] public ServerProfilerFrameData[] Data;
    }

    [AeroBlock]
    public struct ServerProfilerFrameData
    {
        public ushort Id; // named by ServerProfilerSendNames.FrameNames
        [AeroArray(typeof(byte))] public ServerProfilerStruct[] Nodes;
    }

    [AeroBlock]
    public struct ServerProfilerStruct
    {
        public ushort Id; // named by ServerProfilerSendNames.NodeNames
        public ushort CallCount;
        public HalfFloat TotalCallTime;
        public HalfFloat MinCallTime;
        public HalfFloat MaxCallTime;
        public ushort Unk6;
        public ushort Unk7;
        public HalfFloat Unk8;
        public HalfFloat Unk9;
        public byte FIXME_Unk10ArrayCount; // 0074ca80 FIXME: Aero doesnt handle an array of the same struct inside the struct
    }
}