using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Vehicle.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 27, 86)]
    public partial class ReceiveCollisionDamage
    {
        public ushort ShortTime; // Time when this collision is reported
        public byte HaveEntity; // 0 or 1; separate messages are sent if collided with multiple entities at once
        [AeroIf(nameof(HaveEntity), 1)]
        public EntityId CollidedWithEntity;
    }
}