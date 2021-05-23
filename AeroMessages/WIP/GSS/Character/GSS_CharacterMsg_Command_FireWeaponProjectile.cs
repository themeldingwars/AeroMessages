/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 5
    TypeName: Character::CombatController
    MsgId: 121
    MsgName: FireWeaponProjectile
META_END
 */
using Aero.Gen.Attributes;
using System.Numerics;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_Command_FireWeaponProjectile
    {
        public uint Time;
        public Vector3 AimDirection;
        public byte Unk_Always0;
    }
}