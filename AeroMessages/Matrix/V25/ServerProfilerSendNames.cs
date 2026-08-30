using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, MatrixMessage.ServerProfiler_SendNames, MatrixVersion.V5, MatrixVersion.V26)]
    public partial class ServerProfilerSendNames
    {
        [AeroArray(typeof(byte))] public ServerProfilerSendNamesData[] Unk1;
        [AeroArray(typeof(byte))] public ServerProfilerSendNamesData[] Unk2;
    }

    [AeroBlock]
    public struct ServerProfilerSendNamesData
    {
        public ushort Unk1;
        [AeroString] public string Unk2;
    }
}