/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 115
    MsgName: MovementInput
META_END
 */
[Aero]
public partial class Character_Command_MovementInput
{
    public ushort ShortTime;
    public byte Unk2;
    public byte Unk3;
    public short Unk4;
    public short Unk5;
    public byte Unk6;

    // Movement state
    public ushort MovementUnk1;
    public byte MovementType;
    public byte MovementUnk3;


    [AeroIf(nameof(MovementType), Op.HasFlag, 1)]
    public MovementType1 Data1;

    public Vector3 Velocity;

    [AeroIf(nameof(MovementType), Op.HasFlag, 2)]
    public MovementType2 Data2;

    public ushort JetpackEnergy;
    public short GroundTimePositiveAirTimeNegative;
    public short TimeSinceLastJump;

    public ushort EndShort;
}

[AeroBlock]
public struct MovementType1
{
    public Vector3 MovementType1_Position;
    public Quaternion MovementType1_Rotation;
    public short MovementType1_State;
}

[AeroBlock]
public struct MovementType2
{
    public Vector3 MovementType2_AimDirection;
}
