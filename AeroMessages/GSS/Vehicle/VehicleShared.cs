using Aero.Gen.Attributes;
using AeroMessages.Common;
using System.Numerics;

namespace AeroMessages.GSS.V66.Vehicle
{
    public enum AbilitySlotIndex : byte
    {
        Honk = 5,
        Boost = 6,
        Utility = 7,
        SIN = 8,
    }

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