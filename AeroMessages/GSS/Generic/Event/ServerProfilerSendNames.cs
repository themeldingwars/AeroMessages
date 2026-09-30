using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.ServerProfiler_SendNames, GssVersion.V1, GssVersion.V74)]
    public partial class ServerProfilerSendNames
    {
        [AeroArray(typeof(byte))] public ServerProfilerNamesData[] FrameNames; // for ServerProfilerFrameData.Id
        [AeroArray(typeof(byte))] public ServerProfilerNamesData[] NodeNames; // for ServerProfilerStruct.Id
    }

    [AeroBlock]
    public struct ServerProfilerNamesData
    {
        public ushort Id;
        [AeroString] public string Name;
    }
}