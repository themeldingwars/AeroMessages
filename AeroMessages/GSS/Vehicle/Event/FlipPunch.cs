using Aero.Gen.Attributes;
using Aero.Protocol;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Vehicle.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssVehicleMessage.FlipPunch, GssVehicleView.CombatController, GssVersion.V1, GssVersion.V74)]
    public partial class FlipPunch
    {
        // Forwarded as vehicle message type 6 to the vehicle's listeners, consumer not found
        public Vector3 Unk1;
        public Vector3 Unk2;
    }
}