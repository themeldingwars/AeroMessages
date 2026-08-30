using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Vehicle.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssVehicleCommand.DeactivateAbility, GssVehicleView.CombatController, GssVersion.V1, GssVersion.V67)]
    public partial class DeactivateAbility
    {
        public uint Time;
        public AbilitySlotIndex AbilitySlotIndex;
    }
}