using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.GSS.V66.Vehicle
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

    [AeroBlock]
    public struct ConfigurationData
    {
        [AeroArray(8)] public uint[] Data;
    }

    [AeroBlock]
    public struct DeployableIdsData
    {
        public EntityId Target;
        public uint Unk1;
        public byte Unk2;
    }
}