using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Vehicle.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssVehicleMessage.ForcedMovementCancelled, GssVehicleView.CombatController, GssVersion.V1, GssVersion.V74)]
    public partial class ForcedMovementCancelled
    {
        [AeroSdb("apt::BaseCommandDef", "id")]
        public uint CommandId;
        public ushort ShortTime;
    }
}