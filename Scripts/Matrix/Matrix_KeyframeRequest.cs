/*
META_BEGIN
    MsgType: Matrix
    MsgId: 20
    MsgName: KeyframeRequest
META_END
 */
[Aero]
public partial class Matrix_KeyframeRequest
{
    public byte HaveRequestByEntityID;
    [AeroIf(HaveRequestByEntityID, true)]
    [AeroArray(typeof(byte))]
    public RequestByEntity[] EntityRequests;

    public byte HaveRequestByRefID;
    [AeroIf(HaveRequestByRefID, true)]
    [AeroArray(typeof(byte))]
    public ushort[] RefRequests;

}

[AeroBlock]
public struct RequestByEntity
{
    public string Entity;
    public ushort RefID;
    public byte Unk2;
    public uint Checksum;
}