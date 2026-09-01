using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Vehicle.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssVehicleCommand.SetWaterLevelAndDesc, GssVehicleView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class SetWaterLevelAndDesc
    {
        public byte Value;
    }
}