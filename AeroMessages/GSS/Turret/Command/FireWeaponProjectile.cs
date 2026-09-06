using Aero.Gen.Attributes;
using Aero.Protocol;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Turret.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssTurretCommand.FireWeaponProjectile, GssTurretView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class FireWeaponProjectile
    {
        public uint Time;
        public Vector3 Aim;
        public byte HaveMoreData;
        [AeroIf(nameof(HaveMoreData), 1)]
        public Vector3 MoreData;
    }
}