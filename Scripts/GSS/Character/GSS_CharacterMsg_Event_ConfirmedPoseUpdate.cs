/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 111
    MsgName: ConfirmedPoseUpdate
META_END
 */
[Aero]
public partial class Character_Event_ConfirmedPoseUpdate
{
    [Flags]
    public Enum PoseType : byte
    {
        Velocity = 0,
        PosAndRot = 1,
        Aim = 2
    }
    
    [AeroBlock]
    public struct PosAndRotData
    {
        public Vector3 Pos;
        public Quaterion Rot;
        public short MovementState;
    }

    public ushort ShortTime1;
    public PoseType Flags;
    public byte Unk3;
    
    [AeroIf(nameof(Flags), Op.HasFlag, PoseType.PosAndRot)]
    public PosAndRotData PosAndRot;
    
    public Vector3 Velocity;
    
    [AeroIf(nameof(Flags), Op.HasFlag, PoseType.Aim)]
    public Vector3 Aim;
    
    public ushort Unk5;
    public short GroundTimePositiveAirTimeNegative;
    public short TimeSinceLastJump;
}