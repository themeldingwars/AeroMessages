using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;

namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 115)]
    public partial class MovementInput
    {
        public ushort ShortTime;
        public sbyte HorizontalInput; // (negative = left, positive = right)
        public sbyte VerticalInput; // (negative = backwards, positive = forward)
        public HalfFloat HeadingPitch;
        public HalfFloat HeadingYaw;
        public MovementInputFlags InputFlags;
        public MovementPoseData PoseData;
        public ushort EndShort; // Also a ShortTime
        public byte InterpolationDelay; // Math.min(50, Math.max(1, Math.ceil(network.interpolationDelay / 5)))
    }
}