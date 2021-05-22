/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 0
    TypeName: Generic
    MsgId: 77
    MsgName: BountyListPreviousAck
META_END
 */
[Aero]
public partial class Generic_Event_BountyListPreviousAck
{
    [AeroArray(3)]
    public byte[] Unk;

    [AeroString]
    public string JSON;
}