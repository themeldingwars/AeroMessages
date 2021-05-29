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
using AeroMessages.Common;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_Event_WeaponProjectileFired_View
    {
        public ushort ShortTime;
        public QuantisedVector3 Aim;
        public byte Unk;
    }
}