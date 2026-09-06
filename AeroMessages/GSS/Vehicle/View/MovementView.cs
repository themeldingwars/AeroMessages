using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
using Aero.Gen;

namespace AeroMessages.GSS.Vehicle.View
{
    [Aero(AeroGenTypes.View)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssVehicleView.MovementView, GssVersion.V1, GssVersion.V74)]
    public partial class MovementView
    {
        private CurrentPoseData CurrentPose;
        private Vector3 SpawnVelocity;
    }
}