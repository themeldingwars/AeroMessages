/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 27
    TypeName: Vehicle::BaseController
    MsgId: 86
    MsgName: ReceiveCollisionDamage
META_END
 */
using Aero.Gen.Attributes;
using AeroMessages.Common;
namespace AeroMessages.GSS.Vehicle
{
    [Aero]
    public partial class Vehicle_Command_ReceiveCollisionDamage
    {
        public ushort Unk1_DamageValue; // Not really sure about this value
        public byte Unk2; // Possibly number of entities we collided with, or just if we collided with one
        public EntityId CollidedWithEntity;
    }
}