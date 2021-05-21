[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Client, 251, 22, Ver: 1962)]
public partial class GenericTrailRequest : AeroBase
{
    [AeroArray(5)]
    public byte[] Unk;

    public Vector3 Position1;
    public Vector3 Position2;
}