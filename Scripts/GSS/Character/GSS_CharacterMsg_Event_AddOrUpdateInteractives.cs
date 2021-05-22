[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 5, 123, Ver: 1962)]
public partial class CharacterCombatControllerAddOrUpdateInteractives
{
    [AeroArray(typeof(byte))]
    public ulong[] Entities;

    [AeroArray(typeof(byte))]
    public byte[] InteractionTypes;

    [AeroArray(typeof(byte))]
    public uint[] InteractionDurationsMs;

}