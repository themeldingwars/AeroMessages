using Aero.Gen.Attributes;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Turret.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 40, 83)]
    public partial class WeaponProjectileFired
    {
        public uint Time;
        public Vector3 Aim;
        public byte HaveMoreData;
        [AeroIf(nameof(HaveMoreData), 1)]
        public Vector3 MoreData;
    }
}