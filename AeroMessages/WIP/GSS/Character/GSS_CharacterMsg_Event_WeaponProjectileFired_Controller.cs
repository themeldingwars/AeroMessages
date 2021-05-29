/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 5
    TypeName: Character::CombatController
    MsgId: 95
    MsgName: WeaponProjectileFired
META_END
 */
using Aero.Gen.Attributes;
using AeroMessages.Common;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_Event_WeaponProjectileFired_Controller
    {
        public ushort ShortTime;
        public QuantisedVector3 Aim;
        public byte Unk;
    }
}