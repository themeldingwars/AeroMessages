using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, MatrixMessage.ServerProfiler_SendNames, MatrixVersion.V5, MatrixVersion.V32)]
    public partial class ServerProfilerSendNames
    {
        [AeroArray(typeof(byte))] public ServerProfilerSendNamesData[] FrameNames; // for ServerProfilerFrameData.Id
        [AeroArray(typeof(byte))] public ServerProfilerSendNamesData[] NodeNames; // for ServerProfilerStruct.Id
    }

    [AeroBlock]
    public struct ServerProfilerSendNamesData
    {
        public ushort Id;
        [AeroString] public string Name;
    }
}