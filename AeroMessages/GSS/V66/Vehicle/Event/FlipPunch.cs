using Aero.Gen.Attributes;
using Aero.Protocol;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Vehicle.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssVehicleMessage.FlipPunch, GssVehicleView.CombatController, GssVersion.V1, GssVersion.V67)]
    public partial class FlipPunch
    {
        public Vector3 Unk1;
        public Vector3 Unk2;
    }
}