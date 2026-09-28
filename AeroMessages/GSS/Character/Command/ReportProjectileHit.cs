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
        public byte Unk2; // 1 for weapon projectiles, 2 or 3 seen only for ability projectiles

        // Seems to be the direction onto the part of the ragdoll that was hit.
        public sbyte QuantisedDirectionX;
        public sbyte QuantisedDirectionY;
        public sbyte QuantisedDirectionZ;

        public HalfFloat Distance; // Possibly the delta of the ray segment at which it hits (caps around 1 and loops)
        public ushort PhysicsMaterialId; // Userdata of the ragdoll part that was hit
    }
}