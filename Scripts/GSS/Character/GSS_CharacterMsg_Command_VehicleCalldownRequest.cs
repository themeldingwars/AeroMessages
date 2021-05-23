/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 179
    MsgName: VehicleCalldownRequest
META_END
 */
[Aero]
public partial class Character_Command_VehicleCalldownRequest
{
    [AeroSDB("vcs::VehicleInfo", "id")]
    public ushort VehicleID;

    public Vector3 Position;
    public Quaternion Rotation;
}