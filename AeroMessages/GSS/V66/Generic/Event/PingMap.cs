using Aero.Gen.Attributes;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 110)]
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