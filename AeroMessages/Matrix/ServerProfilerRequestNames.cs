using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Command, MatrixMessage.ServerProfiler_RequestNames, MatrixVersion.V5, MatrixVersion.V26)]
    public partial class ServerProfilerRequestNames
    {
        [AeroArray(typeof(byte))] public ushort[] Unk1;
        [AeroArray(typeof(byte))] public ushort[] Unk2;
    }
}