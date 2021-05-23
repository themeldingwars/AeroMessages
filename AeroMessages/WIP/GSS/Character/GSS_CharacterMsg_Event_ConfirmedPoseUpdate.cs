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
using Aero.Gen.Attributes;
using System.Numerics;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_Event_ConfirmedPoseUpdate
    {
        [System.Flags]
        public enum PoseType : byte
        {
            Velocity = 0,
            PosAndRot = 1,
            Aim = 2
        }
        
        public ushort ShortTime1;
        public PoseType Flags;
        public byte Unk3;
        
        [AeroIf(nameof(Flags), AeroIfAttribute.Ops.HasFlag, PoseType.PosAndRot)]
        public PosAndRotData PosAndRot;
        
        public Vector3 Velocity;
        
        [AeroIf(nameof(Flags), AeroIfAttribute.Ops.HasFlag, PoseType.Aim)]
        public Vector3 Aim;
        
        public ushort Unk5;
        public short GroundTimePositiveAirTimeNegative;
        public short TimeSinceLastJump;
    }

    [AeroBlock]
    public struct PosAndRotData
    {
        public Vector3 Pos;
        public Quaternion Rot;
        public short MovementState;
    }
}