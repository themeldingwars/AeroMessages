using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 5, 121)]
    public partial class FireWeaponProjectile
    {
        public uint Time;
        public Vector3 AimDirection;

        public byte HaveUnkVector;
        [AeroIf(nameof(HaveUnkVector), 1)] // != 0
        public Vector3 UnkVector;
    }
}