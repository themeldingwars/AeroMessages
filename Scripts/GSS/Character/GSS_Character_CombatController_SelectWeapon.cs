[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Client, 5, 125, Ver: 1962)]
public partial class CharacterCombatControllerSelectWeapon : AeroBase
{
    public uint Time;
    public byte SelectedWeaponIndex;
    public byte Unk3; // This is related to the selected weapon but idk what it is, maybe slot that we are selecting weapon for or something (not that we have multiple slots that are swappable?) Firemode?
}