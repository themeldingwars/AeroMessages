using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.ServerProfiler_SendFrame, GssVersion.V1, GssVersion.V74)]
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