/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 11
    TypeName: Character::CombatView
    MsgId: 95
    MsgName: WeaponProjectileFired
META_END
 */
using Aero.Gen.Attributes;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_Event_WeaponProjectileFired_View
    {
        public ushort ShortTime;

        [AeroArray(3)]
        public ushort[] PackedAim; // TODO: Aero needs to unpack to Vector3

        public byte Unk;
    }
}