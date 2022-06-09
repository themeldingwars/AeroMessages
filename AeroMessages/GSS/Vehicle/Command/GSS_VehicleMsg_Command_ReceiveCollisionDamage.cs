using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Vehicle
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 27, 86)]
    public partial class Vehicle_Command_ReceiveCollisionDamage
    {
        public ushort Unk1_DamageValue; // Not really sure about this value
        public byte HaveEntity; // Possibly number of entities we collided with, or just if we collided with one

        [AeroIf(nameof(HaveEntity), 1)]
        public EntityId CollidedWithEntity;
    }
}