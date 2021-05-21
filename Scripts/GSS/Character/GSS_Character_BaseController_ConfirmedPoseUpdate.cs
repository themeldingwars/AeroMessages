[Aero(AeroType.Msg, MsgType.GSS, 2, 111, Ver: 1946)]
public partial class ConfirmedPoseUpdate : AeroBase
{
    [Flags]
    public Enum PoseType : byte
    {
        Velocity = 0,
        PosAndRot = 1,
        Aim = 2
    }
    
    [Aero(AeroType.Block)]
    public struct PosAndRotData
    {
        public Vector3 Pos;
        public Quaterion Rot;
        public short MovementState;
    }

    public ushort ShortTime1;
    public PoseType Flags;
    public byte Unk3;
    
    [AeroIf(nameof(Flags), PoseType.PosAndRot)]
    public PosAndRotData PosAndRot;
    
    public Vector3 Velocity;
    
    [AeroIf(nameof(Flags), PoseType.Aim)]
    public Vector3 Aim;
    
    public ushort Unk5;
    public short GroundTimePositiveAirTimeNegative;
    public short TimeSinceLastJump;
}