[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 0, 112, Ver: 1962)]
public partial class GenericEncounterPublicInfo : AeroBase
{
    public ulong EncounterId;

    [AeroFixedString(-1)]
    public string EncounterJSON;
}