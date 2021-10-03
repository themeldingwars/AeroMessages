/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 40
    TypeName: Turret::ObserverView
    MsgId: 83
    MsgName: WeaponProjectileFired
META_END
 */
using Aero.Gen.Attributes;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Turret
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 40, 83)]
    public partial class Turret_Event_ProjectileFired
    {
        public uint Time;
        public Vector3 Aim;
        public byte Unk;
    }
}