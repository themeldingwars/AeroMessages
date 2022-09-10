using Aero.Gen.Attributes;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Vehicle.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 28, 90)]
    public partial class FlipPunch
    {   
        public Vector3 Unk1;
        public Vector3 Unk2;
    }
}