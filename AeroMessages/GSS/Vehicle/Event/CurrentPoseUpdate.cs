using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Vehicle.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssVehicleMessage.CurrentPoseUpdate, GssVehicleView.MovementView, GssVersion.V16, GssVersion.V74)]
    public partial class CurrentPoseUpdate
    {
        public CurrentPoseUpdateData Data;
    }
}