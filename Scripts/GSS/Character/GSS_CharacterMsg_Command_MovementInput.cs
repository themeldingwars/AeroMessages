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


    [AeroIf(MovementType & 1, 1)]
    public Vector3 MovementType1_Position;
    public Quaternion MovementType1_Rotation;
    public short MovementType1_State;

    public Vector3 Velocity;

    [AeroIf(MovementType & 2 >> 1, 1)]
    public Vector3 MovementType2_AimDirection;

    public ushort JetpackEnergy;
    public short GroundTimePositiveAirTimeNegative;
    public short TimeSinceLastJump;

    public ushort EndShort;
}