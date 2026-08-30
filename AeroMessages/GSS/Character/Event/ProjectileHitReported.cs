using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.ProjectileHitReported, GssCharacterView.CombatController, GssVersion.V1, GssVersion.V67)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.ProjectileHitReported, GssCharacterView.CombatView, GssVersion.V1, GssVersion.V67)]
    public partial class ProjectileHitReported
    {
        public ushort TraceRef; // Part of the uint used to group trace data in debugweapon.
        public ushort ShortTime;
        public byte Unk2;
        public byte Unk3;
    }
}