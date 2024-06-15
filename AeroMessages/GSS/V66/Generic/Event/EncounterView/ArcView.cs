using Aero.Gen;
using Aero.Gen.Attributes;
using AeroMessages.Common;

namespace AeroMessages.GSS.V66.Generic.Event.EncounterView
{
    [Aero(AeroGenTypes.View)]
    [AeroEncounter("arc")]
    public partial class ArcView
    {
        [AeroSdb("dblocalization::LocalizedText", "id")]
        private uint arc_name;

        [AeroSdb("dblocalization::LocalizedText", "id")]
        private uint activity_string;

        private ushort activity_visible;

        private ushort healthbar_1_visible;

        [AeroNullable]
        private EntityId healthbar_1;
    }
}
