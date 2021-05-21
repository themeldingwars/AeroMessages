[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 0, 101, Ver: 1962)]
public partial class GenericEncounterUIUpdate : AeroBase
{
    public ulong EncounterId;

    [AeroArray(-1)]
    public byte[] Unk;
}