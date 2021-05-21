[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Client, 28, 88, Ver: 1962)]
public partial class VehicleCombatControllerActivateAbility : AeroBase
{
    public uint Time;
    public byte AbilityIdx; // 0x05 == Honk, 0x08 == SIN, lookup in vehicle components

}