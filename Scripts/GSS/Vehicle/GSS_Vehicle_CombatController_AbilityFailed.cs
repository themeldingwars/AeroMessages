[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 28, 84, Ver: 1962)]
public partial class VehicleCombatControllerAbilityFailed : AeroBase
{
    [AeroSDB("apt::AbilityData", "id")]
    public uint AbilityId;

    [AeroArray(4)]
    public byte[] Unk;
}