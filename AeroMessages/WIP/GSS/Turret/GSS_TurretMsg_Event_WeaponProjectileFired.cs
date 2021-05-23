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
namespace AeroMessages.GSS.Turret
{
    [Aero]
    public partial class Turret_Event_ProjectileFired
    {
        public uint Time;
        public Vector3 Aim;
        public byte Unk;
    }
}