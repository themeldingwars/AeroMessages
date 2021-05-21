[Aero(AeroType.Msg, MsgType.Matrix, 20, Ver: 1962)]
public partial class KeyframeRequest : AeroBase
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

[Aero(AeroType.Block)]
public struct RequestByEntity
{
    public string Entity;
    public ushort RefID;
    public byte Unk2;
    public uint Checksum;
}