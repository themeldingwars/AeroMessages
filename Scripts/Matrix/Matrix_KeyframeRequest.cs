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
    [AeroIf(nameof(HaveRequestByEntityID), true)]
    [AeroArray(typeof(byte))]
    public RequestByEntity[] EntityRequests;

    public byte HaveRequestByRefID;
    [AeroIf(nameof(HaveRequestByRefID), true)]
    [AeroArray(typeof(byte))]
    public ushort[] RefRequests;

}

[AeroBlock]
public struct RequestByEntity
{
    public ulong Entity;
    public ushort RefID;
    public byte Unk2;
    public uint Checksum;
}