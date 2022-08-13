using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System;
using System.Numerics;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 177)]
    public partial class CameraPoseUpdate
    {
        public byte HaveEntity;
        [AeroIf(nameof(HaveEntity), 1)] // Should be != 0
        public EntityId FollowingEntity;

        // Assuming its position
        public byte HavePosition;
        [AeroIf(nameof(HavePosition), 1)] // Should be != 0
        public Vector3 Position;
    }
}