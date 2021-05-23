/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 0
    TypeName: Generic
    MsgId: 112
    MsgName: DisplayUiNotification
META_END
 */
[Aero]
public partial class Generic_Event_EncounterPublicInfo
{
    public ulong EncounterId;

    [AeroString(-1)]
    public string EncounterJSON;
}