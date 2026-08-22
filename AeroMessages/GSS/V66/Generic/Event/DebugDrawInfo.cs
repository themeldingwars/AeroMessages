using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 59)]
    public partial class DebugDrawInfo
    {
        [AeroArray(typeof(byte))] public byte[] Unk;
    }
}