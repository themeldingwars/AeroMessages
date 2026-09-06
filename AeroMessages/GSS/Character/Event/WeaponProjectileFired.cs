using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.WeaponProjectileFired, GssCharacterView.CombatView, GssVersion.V1, GssVersion.V74)]
    public partial class WeaponProjectileFired
    {
        public ushort ShortTime;
        public QuantisedVector3 Aim;

        public byte HaveShooterVelocity; // ShooterVelocity is an assumption but it would match FireWeaponProjectile
        [AeroIf(nameof(HaveShooterVelocity), 1)]
        public HalfVector3 ShooterVelocity;
    }
}