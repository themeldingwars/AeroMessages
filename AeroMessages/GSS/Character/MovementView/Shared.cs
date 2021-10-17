using System.Numerics;
using Aero.Gen.Attributes;

namespace AeroMessages.GSS.Character.MovementView
{
    [AeroBlock]
    public struct MovementData
    {
        public Vector3    Position;
        public Quaternion Rotation;
        public Vector3    Aim;
        public ushort     MovementState;
        public uint       Time;
    }
}