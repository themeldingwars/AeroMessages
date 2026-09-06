using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Both, GssMessage.ServerProfiler_RequestNames, GssVersion.V1, GssVersion.V74)]
    public partial class ServerProfilerRequestNames
    {
        [AeroArray(typeof(byte))] public ushort[] Unk1;
        [AeroArray(typeof(byte))] public ushort[] Unk2;
    }
}