using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.ServerProfiler_SendNames, GssVersion.V1, GssVersion.V67)]
    public partial class ServerProfilerSendNames
    {
        [AeroArray(typeof(byte))] public ServerProfilerNamesData[] Data1;
        [AeroArray(typeof(byte))] public ServerProfilerNamesData[] Data2;
    }

    [AeroBlock]
    public struct ServerProfilerNamesData
    {
        public ushort Unk1;
        [AeroString] public string Name; // Assumption
    }
}