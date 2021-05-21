[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 5, 95, Ver: 1962)]
public partial class CharacterCombatControllerWeaponProjectileFired : AeroBase
{
    public ushort ShortTime;

    [AeroArray(3)]
    public ushort[] PackedAim; // TODO: Aero needs to unpack to Vector3

    public byte Unk;
}