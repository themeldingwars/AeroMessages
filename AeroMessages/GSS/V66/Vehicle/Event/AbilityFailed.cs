using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Vehicle.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssVehicleMessage.AbilityFailed, GssVehicleView.CombatController, GssVersion.V1, GssVersion.V67)]
    public partial class AbilityFailed
    {
        [AeroSdb("apt::AbilityData", "id")]
        public uint AbilityId;
        public uint Time;
    }
}