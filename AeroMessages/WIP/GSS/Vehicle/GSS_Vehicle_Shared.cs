using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.GSS.Vehicle
{
    [AeroBlock]
    public struct CurrentPoseData
    {
        public Vector3 Position;
        public Quaternion Rotation;
        public Vector3 Direction;
        public ushort State;
        public uint Time;
    }
}