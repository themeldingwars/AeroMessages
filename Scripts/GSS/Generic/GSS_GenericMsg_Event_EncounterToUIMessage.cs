/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 0
    TypeName: Generic
    MsgId: 32
    MsgName: EncounterToUIMessage
META_END
 */
[Aero]
public partial class Generic_Event_EncounterToUIMessage
{
    public ulong EncounterId;

    [AeroString]
    public string Header;

    [AeroString]
    public string JSON;
}