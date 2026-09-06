using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.DebugDrawInfo, GssVersion.V1, GssVersion.V74)]
    public partial class DebugDrawInfo
    {
        [AeroArray(typeof(byte))] public byte[] Unk;
    }
}