using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Vehicle.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssVehicleMessage.ForcedMovement, GssVehicleView.CombatController, GssVersion.V1, GssVersion.V67)]
    public partial class ForcedMovement
    {
        public ForcedMovementData Data;
    }
}