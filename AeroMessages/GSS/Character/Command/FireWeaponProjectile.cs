using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.FireWeaponProjectile, GssCharacterView.CombatController, GssVersion.V1, GssVersion.V74)]
    public partial class FireWeaponProjectile
    {
        public uint Time;
        public Vector3 AimDirection;

        public byte HaveShooterVelocity;
        [AeroIf(nameof(HaveShooterVelocity), 1)] // != 0
        public Vector3 ShooterVelocity;
    }
}