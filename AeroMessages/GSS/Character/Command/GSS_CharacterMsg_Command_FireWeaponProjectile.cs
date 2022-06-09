using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 5, 121)]
    public partial class Character_Command_FireWeaponProjectile
    {
        public uint Time;
        public Vector3 AimDirection;
        public byte Unk_Always0;
    }
}