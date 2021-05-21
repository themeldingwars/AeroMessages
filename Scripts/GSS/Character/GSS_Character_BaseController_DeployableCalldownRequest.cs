[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Client, 2, 180, Ver: 1962)]
public partial class CharacterBaseControllerDeployableCalldownRequest : AeroBase
{
    [AeroSDB("dbcharacter:Deploable", "id")]
    public uint DeployableId;

    public Vector3 Position;
    public Quaternion Rotation;
}