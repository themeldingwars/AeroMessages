using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;

namespace AeroMessages.GSS.V66.Vehicle.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssVehicleCommand.SinAcquire_Source, GssVehicleView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class SinAcquireSource
    {
        public EntityId Target;
    }
}