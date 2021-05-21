[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 28, 83, Ver: 1962)]
public partial class VehicleCombatControllerAbilityActivated : AeroBase
{
    [AeroSDB("apt::AbilityData", "id")]
    public uint AbilityId;

    public uint Time;
}