using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Vehicle.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 27, 86)]
    public partial class ReceiveCollisionDamage
    {
        public ushort Value; // Not really sure about this value
        public byte HaveEntity; // Possibly number of entities we collided with, or just if we collided with one
        [AeroIf(nameof(HaveEntity), 1)]
        public EntityId CollidedWithEntity;
    }
}