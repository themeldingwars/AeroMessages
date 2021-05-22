/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 0
    TypeName: Generic
    MsgId: 69
    MsgName: BountyListPreviousAck
META_END
 */
[Aero]
public partial class Generic_Event_BountyListPreviousAck
{
    public uint BountyId; // Unsure how this id works
    public byte Status;
}