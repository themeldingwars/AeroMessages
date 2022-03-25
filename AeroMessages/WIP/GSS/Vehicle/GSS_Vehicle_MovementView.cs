using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
using Aero.Gen;

namespace AeroMessages.GSS.Vehicle
{
    [Aero(AeroGenTypes.View)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 31, 1)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 31, 3)]
    public partial class Vehicle_MovementView
    {
        private CurrentPoseData CurrentPose;
        private Vector3 SpawnVelocity;
    }
}