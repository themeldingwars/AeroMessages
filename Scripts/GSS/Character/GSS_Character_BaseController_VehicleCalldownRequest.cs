[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Client, 2, 179, Ver: 1962)]
public partial class CharacterBaseControllerVehicleCalldownRequest : AeroBase
{
    [AeroSDB("vcs::VehicleInfo", "id")]
    public ushort VehicleID;

    public Vector3 Position;
    public Quaternion Rotation;
}
