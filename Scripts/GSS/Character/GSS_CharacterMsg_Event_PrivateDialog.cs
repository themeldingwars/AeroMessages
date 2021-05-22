/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 121
    MsgName: PrivateDialog
META_END
 */
[Aero]
public partial class Character_Event_PrivateDialog
{
    public uint Time;
    public ulong Entity;
    public uint DialogId; // TODO: "dbdialogdata::DialogScript" ?
}