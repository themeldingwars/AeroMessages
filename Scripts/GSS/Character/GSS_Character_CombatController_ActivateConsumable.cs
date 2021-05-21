[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 5, 138, Ver: 1962)]
public partial class CharacterCombatControllerActivateConsumable : AeroBase
{
    public uint Time;

    [AeroSDB("dbitems::RootItem", "sdb_id")]
    public uint ItemSdbId;
}