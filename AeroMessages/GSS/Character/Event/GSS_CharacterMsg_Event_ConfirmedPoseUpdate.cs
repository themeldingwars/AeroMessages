using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 111)]
    public partial class Character_Event_ConfirmedPoseUpdate
    {
        public ushort           ShortTime1;
        public MovementDataType Flags;
        public byte             Unk3;
        
        [AeroIf(nameof(Flags), Ops.HasFlag, MovementDataType.PosAndRot)]
        public MovementPosAndRot PosAndRot;
        
        public Vector3 Velocity;
        
        [AeroIf(nameof(Flags), Ops.HasFlag, MovementDataType.Aim)]
        public Vector3 Aim;
        
        public ushort Unk5;
        public short GroundTimePositiveAirTimeNegative;
        public short TimeSinceLastJump;
    }
}