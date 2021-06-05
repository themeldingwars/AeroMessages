using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.GSS.Vehicle
{
    [AeroBlock]
    public struct Vehicle_MovementView_ShadowFieldUpdate
    {
        public enum ShadowFieldIndex : byte
        {
            CurrentPose = 0x00,
            SpawnVelocity = 0x01,
        }

        public ShadowFieldIndex Idx;

        [AeroIf(nameof(Idx), ShadowFieldIndex.CurrentPose)]
        public CurrentPoseData CurrentPose;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SpawnVelocity)]
        public Vector3 SpawnVelocity;
    }

    [Aero]
    public partial class Vehicle_MovementView_Update
    {
        [AeroArray(-4)]
        public Vehicle_MovementView_ShadowFieldUpdate[] Updates;
    }
}