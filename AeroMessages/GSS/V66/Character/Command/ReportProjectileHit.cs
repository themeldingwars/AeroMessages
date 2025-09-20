using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 5, 122)]
    public partial class ReportProjectileHit
    {
        public ushort TraceRef; // Part of the uint used to group trace data in debugweapon.
        public ushort ShortTime; // Time when this hit is reported
        public byte Unk2; // Usually 1, capture has a few cases of 2 or 3. Maybe like CombatLogSource? Or related to the hitreg/prediction?

        // Seems to be the direction onto the part of the ragdoll that was hit.
        public sbyte QuantisedDirectionX;
        public sbyte QuantisedDirectionY;
        public sbyte QuantisedDirectionZ;

        public HalfFloat Distance; // Possibly the delta of the ray segment at which it hits (caps around 1 and loops)
        public ushort PhysicsMaterialId; // Userdata of the ragdoll part that was hit
    }
}