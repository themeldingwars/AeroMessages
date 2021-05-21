[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 5, 114, Ver: 1962)]
public partial class CharacterCombatControllerForcedMovementCancelled : AeroBase
{

    [AeroSDB("apt::BaseCommandDef")]
    public uint CommandId;

    public ushort ShortTime;
}