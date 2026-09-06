using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.DebugWeaponStats, GssCharacterView.CombatController, GssVersion.V1, GssVersion.V74)]
    public partial class DebugWeaponStats
    {
        public ushort Spawned;
        public ushort Reported1;
        public ushort Late;
        public ushort Dropped;
        public ushort Validated;
        public ushort Succeeded1;
        public ushort Reported2;
        public ushort Succeeded2;
    }
}