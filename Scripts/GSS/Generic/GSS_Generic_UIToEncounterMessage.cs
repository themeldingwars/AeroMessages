[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Client, 251, 17, Ver: 1962)]
public partial class GenericUIToEncounterMessage : AeroBase
{
    [AeroNullTermString]
    public string Key1;

    [AeroNullTermString]
    public string Key2;

    [AeroNullTermString]
    public string JSON;
}