/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 0
    TypeName: Generic
    MsgId: 98
    MsgName: Trail
META_END
 */
[Aero]
public partial class Generic_Event_Trail
{
    [AeroArray(5)]
    public byte[] Unk;

    [AeroArray(typeof(byte))]
    public Vector3[] Points;
}