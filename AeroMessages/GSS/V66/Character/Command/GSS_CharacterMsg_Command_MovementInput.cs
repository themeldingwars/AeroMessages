using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
using AeroMessages.Common;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 115)]
    public partial class MovementInput
    {
        public ushort ShortTime;
        public byte Unk2;
        public byte Unk3;
        public short Unk4;
        public short Unk5;
        public byte Unk6;

        // Movement state
        // TODO: Break this out into its own block and share with Character_Event_ConfirmedPoseUpdate?
        public ushort           MovementUnk1;
        public MovementDataType MovementType;
        public byte             MovementUnk3;


        [AeroIf(nameof(MovementType), Ops.HasFlag, MovementDataType.PosAndRot)]
        public MovementPosAndRot PosAndRot;

        public Vector3 Velocity;

        [AeroIf(nameof(MovementType), Ops.HasFlag, MovementDataType.Aim)]
        public Vector3 Aim;

        public ushort JetpackEnergy;
        public short GroundTimePositiveAirTimeNegative;
        public short TimeSinceLastJump;

        public ushort EndShort;
    }
}