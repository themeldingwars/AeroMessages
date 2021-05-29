/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 31
    TypeName: Vehicle::MovementView
    MsgId: 3
    MsgName: Keyframe
META_END
 */
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.GSS.Vehicle
{
    [Aero]
    public partial class Vehicle_MovementView_Keyframe
    {
        public CurrentPoseData CurrentPose;
        public Vector3 SpawnVelocity;
    }
}