[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 31, 86, Ver: 1962)]
public partial class VehicleMovementViewCurrentPoseUpdate : AeroBase
{
    public byte Flags;
    public ushort ShortTime;

    [AeroIf(Flags, 0x00)]
    AllContents Data;
}


[Aero(AeroType.Block)]
public partial class AllContents : AeroBase
{
    public byte Unk1;
    public ushort MovementState;
    public Vector3 Position;

    [AeroArray(4)]
    public ushort[] PackedRotation; // TODO: Unpack ushorts to quaternion

    [AeroArray(3)]
    public ushort[] PackedDirection; // TODO: Unpack ushorts to vector3
}