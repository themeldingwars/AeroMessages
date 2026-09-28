using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.AbilityProjectileFired, GssCharacterView.CombatView, GssVersion.V1, GssVersion.V74)]
    public partial class AbilityProjectileFired
    {
        public ushort ShortTime;
        public HalfVector3 OriginOffset; // Projectile origin relative to the shooter position, world axes
        public QuantisedVector3 Aim;

        [AeroSdb("dbitems::Ammo", "id")] // Definition
        //[AeroSdb("aptfs::FireProjectileCommandDef", "ammotype")] // Reference values, eg Range
        public ushort AmmoType;
        public float Range;
        public int Damage;
        public byte BurstCount;
        public float Spread;
        public byte Unk4; // Fixed per FireProjectileCommandDef, not a column of it
        public uint Unk5; // Always 0
        public uint Hardpoint;

        public byte HaveHomingTarget;
        [AeroIf(nameof(HaveHomingTarget), 1)]
        public EntityId HomingTarget;
    }
}