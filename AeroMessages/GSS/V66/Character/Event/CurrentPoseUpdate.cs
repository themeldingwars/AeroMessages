using Aero.Gen.Attributes;
using System.Numerics;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using static Aero.Gen.Attributes.AeroIfAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 12, 110)]
    public partial class CurrentPoseUpdate
    {   
        public enum CurrentPoseUpdateFlags: byte
        {
            ShortTime = 0x00,
            MovementState = 0x02,
            Position = 0x0c,
            Rotation = 0x30,
            Aim = 0xc0,
        }

        public CurrentPoseUpdateFlags Flags;

        public byte CalcFlagValue1 => ((byte)(Flags & CurrentPoseUpdateFlags.Rotation));
        public byte CalcFlagValue2 => ((byte)(Flags & CurrentPoseUpdateFlags.Aim));

        // ShortTime
        [AeroIf(nameof(Flags), Ops.DoesntHaveFlag, CurrentPoseUpdateFlags.ShortTime)]
        public ushort ShortTime;

        [AeroIf(nameof(Flags), Ops.HasFlag, CurrentPoseUpdateFlags.ShortTime)]
        public byte ShortTimeAlt;

        // Unknown byte
        public byte UnkAlwaysPresent;

        // Movement State
        [AeroIf(nameof(Flags), Ops.DoesntHaveFlag, CurrentPoseUpdateFlags.MovementState)]
        public ushort MovementState;

        // Position
        [AeroIf(nameof(Flags), Ops.DoesntHaveFlag, CurrentPoseUpdateFlags.Position)]
        public Vector3 Position;

        [AeroIf(nameof(Flags), Ops.HasFlag, CurrentPoseUpdateFlags.Position)]
        [AeroArray(3)]
        public byte[] PositionAlt;

        // Rotation
        [AeroIf(nameof(CalcFlagValue1), 0x00)]
        public QuantisedQuaternion Rotation;

        [AeroIf(nameof(CalcFlagValue1), 0x10)]
        public byte RotAltLastByte_1; // Same byte, just difficulties with logic

        [AeroIf(nameof(CalcFlagValue1), 0x20)]
        [AeroArray(2)] public byte[] RotAltBytes;

        [AeroIf(nameof(CalcFlagValue1), 0x20)]
        public byte RotAltLastByte_2; // Same byte, just difficulties with logic

        // Aim
        [AeroIf(nameof(Flags), Ops.DoesntHaveFlag, CurrentPoseUpdateFlags.Aim)]
        public QuantisedVector3 Aim;

        [AeroIf(nameof(Flags), Ops.HasFlag, CurrentPoseUpdateFlags.Aim)]
        [AeroIf(nameof(CalcFlagValue2), Ops.NotEqual, (byte) CurrentPoseUpdateFlags.Aim)]
        [AeroArray(3)]
        public byte[] AimAlt;
    }

    /*
    [AeroBlock]
    public struct FullDataVersion
    {
        public byte Unk1;
        public ushort MovementState;
        public Vector3 Position;
        public QuantisedQuaternion Rotation;
        public QuantisedVector3 Aim;
    }
    */
}