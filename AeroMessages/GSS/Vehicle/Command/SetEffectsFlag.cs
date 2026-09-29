using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Vehicle.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssVehicleCommand.SetEffectsFlag, GssVehicleView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class SetEffectsFlag
    {
        public byte Flag; // Effect flag being set, 1 = headlights (only value seen)
        public byte Headlights; // New state, copied into ObserverView.EffectsFlags
    }
}