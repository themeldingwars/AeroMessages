/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 0
    TypeName: Generic
    MsgId: 108
    MsgName: PlayDialogScriptMessage
META_END
 */
[Aero]
public partial class Generic_Event_PlayDialogScriptMessage
{   
    [AeroSDB("dbdialogdata::DialogScript", "id")]
    public uint DialogId;
    public byte Unk1;
}