using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Vehicle.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssVehicleMessage.AbilityActivated, GssVehicleView.CombatController, GssVersion.V1, GssVersion.V74)]
    public partial class AbilityActivated
    {
        [AeroSdb("apt::AbilityData", "id")]
        public uint AbilityId;
        public uint Time;
    }
}