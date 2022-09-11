using Aero.Gen.Attributes;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Turret.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 39, 86)]
    public partial class FireWeaponProjectile
    {
        public uint Time;
        public Vector3 Aim;
        public byte HaveMoreData;
        [AeroIf(nameof(HaveMoreData), 1)]
        public Vector3 MoreData;
    }
}