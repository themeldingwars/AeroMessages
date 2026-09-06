using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Vehicle.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssVehicleCommand.ReceiveCollisionDamage, GssVehicleView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class ReceiveCollisionDamage
    {
        public ushort ShortTime; // Time when this collision is reported
        public byte HaveEntity; // 0 or 1; separate messages are sent if collided with multiple entities at once
        [AeroIf(nameof(HaveEntity), 1)]
        public EntityId CollidedWithEntity;
    }
}