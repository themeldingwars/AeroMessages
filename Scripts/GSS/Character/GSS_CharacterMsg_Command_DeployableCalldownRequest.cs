/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 180
    MsgName: DeployableCalldownRequest
META_END
 */
[Aero]
public partial class Character_Command_DeployableCalldownRequest
{
    [AeroSDB("dbcharacter:Deploable", "id")]
    public uint DeployableId;

    public Vector3 Position;
    public Quaternion Rotation;
}