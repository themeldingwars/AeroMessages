using Aero.Gen;
using Aero.Gen.Attributes;

namespace AeroMessages.GSS.V66.Generic.Event.EncounterView
{
    [Aero(AeroGenTypes.View)]
    [AeroEncounter("race")]
    public partial class RaceView
    {
        private ushort race_type;

        private uint track_name;

        private uint challenge_name;

        private ushort waypoint_counter;

        private ushort waypoint_goal;

        private ushort lap_counter;

        private ushort lap_goal;

        private Timer objective_timer;

        private ushort race_started;
    }
}
