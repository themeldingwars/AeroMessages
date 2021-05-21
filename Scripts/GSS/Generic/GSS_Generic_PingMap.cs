[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 0, 110, Ver: 1962)]
public partial class GenericPingMap : AeroBase
{   
    public Vector3 Position;

    [AeroArray(4)]
    public byte[] Unk1;
}