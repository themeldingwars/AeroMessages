/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 31
    TypeName: Vehicle::MovementView
    MsgId: 86
    MsgName: CurrentPoseUpdate
META_END
 */
[Aero]
public partial class Vehicle_Event_CurrentPoseUpdate
{
    public byte Flags;
    public ushort ShortTime;

    [AeroIf(Flags, 0x00)]
    AllContents Data;
}


[AeroBlock]
public partial class AllContents
{
    public byte Unk1;
    public ushort MovementState;
    public Vector3 Position;

    [AeroArray(4)]
    public ushort[] PackedRotation; // TODO: Unpack ushorts to quaternion

    [AeroArray(3)]
    public ushort[] PackedDirection; // TODO: Unpack ushorts to vector3
}