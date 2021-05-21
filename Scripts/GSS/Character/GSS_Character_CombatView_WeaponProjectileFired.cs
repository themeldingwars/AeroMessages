[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 11, 95, Ver: 1962)]
public partial class CharacterCombatViewWeaponProjectileFired : AeroBase
{
    public ushort ShortTime;
    public ushort[] PackedAim; // TODO: Aero needs to unpack to Vector3
    public byte Unk;

}