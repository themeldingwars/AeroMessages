using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.ProjectileHitReported, GssCharacterView.CombatController, GssVersion.V1, GssVersion.V74)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.ProjectileHitReported, GssCharacterView.CombatView, GssVersion.V1, GssVersion.V74)]
    public partial class ProjectileHitReported
    {
        public ushort TraceRef; // Part of the uint used to group trace data in debugweapon.
        public ushort ShortTime;
        public byte SegmentFraction; // Hit time within the ShortTime..ShortTime + 50 window as a fraction, value * 0.02 / 255
        public byte Unk3; // impact kind 0..3, picks the projectile's impact definition
    }
}