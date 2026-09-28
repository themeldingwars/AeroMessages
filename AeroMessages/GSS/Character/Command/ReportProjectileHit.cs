using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.ReportProjectileHit, GssCharacterView.CombatController, GssVersion.V1, GssVersion.V74)]
    public partial class ReportProjectileHit
    {
        public ushort TraceRef; // Part of the uint used to group trace data in debugweapon.
        public ushort ShortTime; // Low 16 bits of the FireWeaponProjectile time of the projectile that hit
        public byte StepCount; // Number of 50 ms steps the tested trace segment covers

        // Seems to be the direction onto the part of the ragdoll that was hit.
        public sbyte QuantisedDirectionX;
        public sbyte QuantisedDirectionY;
        public sbyte QuantisedDirectionZ;

        public HalfFloat Distance; // Hit time within the segment, normalised by StepCount * 50 ms, not a distance
        public ushort PhysicsMaterialId; // Userdata of the ragdoll part that was hit
    }
}