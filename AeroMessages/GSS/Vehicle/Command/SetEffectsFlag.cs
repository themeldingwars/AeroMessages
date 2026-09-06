using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Vehicle.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssVehicleCommand.SetEffectsFlag, GssVehicleView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class SetEffectsFlag
    {
        public byte UnkByte1; // Not sure if this indicates the flag being toggled or if it's something that can be toggled in general.
        public byte UnkByte2_HeadlightEnabled; // At least when UnkByte1 is 0x01, this value is 0x00 if the headlights are turned off and 0x01 when turned on
    }
}