using Aero.Gen;
using Aero.Gen.Attributes;

namespace AeroMessages.GSS.V66.Generic.Event.EncounterView
{
    [Aero(AeroGenTypes.View)]
    [AeroEncounter("default")]
    public partial class HudTimerView
    {
        private Timer hudtimer_timer;

        private uint hudtimer_label;
    }
}
