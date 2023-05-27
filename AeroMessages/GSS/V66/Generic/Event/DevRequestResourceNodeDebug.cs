using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
using AeroMessages.Common;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 63)]
    public partial class DevRequestResourceNodeDebug
    {
        [AeroArray(typeof(byte))] public Vector3[] TestedPathLocations;
    }
}