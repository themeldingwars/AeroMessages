using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.SetPreloadPosition, GssVersion.V1, GssVersion.V74)]
    public partial class SetPreloadPosition
    {
        [AeroArray(4)] public Vector4[] Location; // 4x4 transform matrix, row 3 is the position
    }
}