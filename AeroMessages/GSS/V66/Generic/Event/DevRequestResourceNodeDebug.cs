using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;

namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.DevRequestResourceNodeDebug, GssVersion.V1, GssVersion.V67)]
    public partial class DevRequestResourceNodeDebug
    {
        [AeroArray(typeof(byte))] public Vector3[] TestedPathLocations;
    }
}