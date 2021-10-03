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
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 5, 95)]
    public partial class Character_Event_WeaponProjectileFired_Controller
    {
        public ushort ShortTime;
        public QuantisedVector3 Aim;
        public byte Unk;
    }
}