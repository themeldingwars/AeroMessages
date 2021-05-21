[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Client, 27, 90, Ver: 1962)]
public partial class VehicleBaseControllerSetEffectsFlag : AeroBase
{
    public byte UnkByte1; // Not sure if this indicates the flag being toggled or if it's something that can be toggled in general.
    public byte UnkByte2_HeadlightEnabled; // At least when UnkByte1 is 0x01, this value is 0x00 if the headlights are turned off and 0x01 when turned on
}