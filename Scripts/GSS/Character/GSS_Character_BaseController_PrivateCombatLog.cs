[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 2, 92, Ver: 1962)]
public partial class CharacterBaseControllerPrivateCombatLog : AeroBase
{
    [AeroArray(4)]
    public byte[] Unk1;

    [AeroArray(typeof(ushort))]
    public byte[] Data; // Multiple variations, often gametime towards the end of a row.
}