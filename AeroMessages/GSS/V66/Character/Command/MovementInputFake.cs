using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
using AeroMessages.Common;
using AeroMessages.GSS.V66.Character;

namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 116)]
    public partial class MovementInputFake
    {
        // First part parses the same as MovementInput (Assuming same things then)
        public ushort ShortTime;
        public sbyte HorizontalInput;
        public sbyte VerticalInput;
        public HalfFloat HeadingPitch;
        public HalfFloat HeadingYaw;
        public MovementInputFlags InputFlags;

        // not the same~
        public sbyte Unk7;
        public sbyte Unk8;
        public sbyte Unk9;
        public sbyte Unk10;
        public sbyte Unk11;
        public sbyte Unk12;
        public sbyte Unk13;

        // FUN_009c1930
        // Optional MovementPoseData
        public byte HaveMovementPoseData;
        [AeroIf(nameof(HaveMovementPoseData), 1)]
        public MovementPoseData Data;
        // --
        
        // Last part same as MovementInput
        public ushort EndShort;
        public byte InterpolationDelay; // Assumption based on MovementInput
    }
}