[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 0, 98, Ver: 1962)]
public partial class GenericTrail : AeroBase
{
    [AeroArray(5)]
    public byte[] Unk;

    [AeroArray(typeof(byte))]
    public Vector3[] Points;
}