/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 31
    TypeName: Vehicle::MovementView
    MsgId: 86
    MsgName: CurrentPoseUpdate
META_END
 */
using Aero.Gen.Attributes;
using AeroMessages.Common;
using System.Numerics;
namespace AeroMessages.GSS.Vehicle
{
    [Aero]
    public partial class Vehicle_Event_CurrentPoseUpdate
    {
        public byte Flags;
        public ushort ShortTime;

        [AeroIf(nameof(Flags), 0x00)]
        public AllContents Data;
    }


    [AeroBlock]
    public struct AllContents
    {
        public byte Unk1;
        public ushort MovementState;
        public Vector3 Position;
        public QuantisedQuaternion Rotation;
        public QuantisedVector3 Direction;
    }
}