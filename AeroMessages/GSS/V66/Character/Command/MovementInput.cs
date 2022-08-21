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
        public MovementInputData Data;
        public ushort EndShort;
        public byte EndByte;
    }

    [AeroBlock]
    public struct MovementInputData
    {
        // FUN_009f04d0
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

        // Looks like 1 more byte should be read here and based on it a lot of more shit can happen
        //   FUN_00a00700
        public byte HaveMoreData;
        [AeroIf(nameof(HaveMoreData), 1)] // != 0
        public MovInputMoreData UnkData;
        //   --
        // --
    }

    [AeroBlock]
    public struct MovInputMoreData
    {
        // FUN_00a00570
        public MovInputMoreDataGroup Unk1;
        public MovInputMoreDataGroup Unk2;
        public MovInputMoreDataGroup Unk3;
        public MovInputMoreDataGroup Unk4;
        public MovInputMoreDataGroup Unk5;
        public MovInputMoreDataGroup Unk6;
        public MovInputMoreDataGroup Unk7;
    }

    [AeroBlock]
    public struct MovInputMoreDataGroup
    {
        // Just making an assumption and trying to stay sane
        public ushort Unk1;
        public UnkMovInput1 Unk2;
        public ushort Unk3;
        public UnkMovInput2 Unk4;
    }

    [AeroBlock]
    public struct UnkMovInput1
    {
        // FUN_00a08f70
        public Vector3 Unk1;
        public Quaternion Unk2;
        public Vector3 Unk3;
    }

    [AeroBlock]
    public struct UnkMovInput2
    {
        // FUN_00a00360
        public byte HaveData;
        [AeroIf(nameof(HaveData), 1)]
        public UnkMovInput2Inner Data;
    }

    [AeroBlock]
    public struct UnkMovInput2Inner
    {
        // FUN_00a00120
        public ushort Unk1;
        public Vector3 Unk2;
        public byte Unk3;
        public byte Unk4;
        public ushort Unk5;
        public short Unk6;
        public short Unk7;

        //  FUN_009ffed0
        public byte HaveUnk8;
        [AeroIf(nameof(HaveUnk8), 1)]
        public UnkMovInput2InnerUnk8Data Unk8;
        // --
        public Vector3 Unk9;
        public Vector3 Unk10;
        public byte Unk11;
    }

    [AeroBlock]
    public struct UnkMovInput2InnerUnk8Data
    {
        [AeroArray(typeof(byte))] UnkMovInput2InnerUnk8Data1[] Unk1;
        [AeroArray(typeof(byte))] float[] Unk2; // Not certain that its floats
    }

    [AeroBlock]
    public struct UnkMovInput2InnerUnk8Data1
    {
        // FUN_009ff520
        // 6x4, assuming two vectors
        public Vector3 Unk1;
        public Vector3 Unk2;
    }
}