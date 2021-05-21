[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Client, 2, 142, Ver: 1962)]
public partial class CharacterBaseControllerPerformEmote : AeroBase
{
    public uint Time;

    [AeroSDB("dbcharacter::EmoteRecord", "id")]
    public ushort EmoteId;
}
