using Aero.Gen.Attributes;
using Aero.Protocol;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.PingMap, GssVersion.V1, GssVersion.V74)]
    public partial class PingMap
    {
        public enum PingMapType : uint
        {
            Normal = 1, // orange
            Dynamic = 2, // purple
            // anything else => white
        }

        public Vector3 Position;

        [AeroSdb("dbcharacter::UiPingType", "id")]
        public PingMapType Type;
    }
}