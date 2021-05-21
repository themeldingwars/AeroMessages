[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 0, 32, Ver: 1962)]
public partial class GenericEncounterToUIMessage : AeroBase
{
    public ulong EncounterId;

    [AeroNullTermString]
    public string Header;

    [AeroNullTermString]
    public string JSON;
}