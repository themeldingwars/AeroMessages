/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 0
    TypeName: Generic
    MsgId: 110
    MsgName: PingMap
META_END
 */
[Aero]
public partial class Generic_Event_PingMap
{   
    public Vector3 Position;

    [AeroArray(4)]
    public byte[] Unk1;
}