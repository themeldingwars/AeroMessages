[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 5, 124, Ver: 1962)]
public partial class CharacterCombatControllerRemoveInteractives : AeroBase
{
    //[AeroArray(typeof(byte))]
    //public ulong[] Entity;
    
    public byte Unk1; // TODO: Test if length
    public ulong Entity;
}