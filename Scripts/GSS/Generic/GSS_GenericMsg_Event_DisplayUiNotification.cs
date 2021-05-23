/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 0
    TypeName: Generic
    MsgId: 103
    MsgName: DisplayUiNotification
META_END
 */
[Aero]
public partial class Generic_Event_DisplayUiNotification
{
    [AeroSDB(31,8)]
    public uint LocalizedTextId; // Sdb table 31, id column.

    [AeroArray(6)]
    public byte[] Unk;
}