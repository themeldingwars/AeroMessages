/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 251
    TypeName: Generic
    MsgId: 22
    MsgName: TrailRequest
META_END
 */
[Aero]
public partial class Generic_Command_TrailRequest
{
    [AeroArray(5)]
    public byte[] Unk;

    public Vector3 Position1;
    public Vector3 Position2;
}