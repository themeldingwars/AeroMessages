using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
using Aero.Gen;

namespace AeroMessages.GSS.V66.Vehicle.View
{
    [Aero(AeroGenTypes.View)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 31, 1)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 31, 3)]
    public partial class MovementView
    {
        private CurrentPoseData CurrentPose;
        private Vector3 SpawnVelocity;
    }
}