using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Vehicle.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssVehicleMessage.PublicCombatLog, GssVehicleView.CombatController, GssVersion.V1, GssVersion.V67)]
    public partial class PublicCombatLog
    {
        public int HaveData;
        [AeroIf(nameof(HaveData), 1)]
        public CombatLogMessage Data;
    }
}