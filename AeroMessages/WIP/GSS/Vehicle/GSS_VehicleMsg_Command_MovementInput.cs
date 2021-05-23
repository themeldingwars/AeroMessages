/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 27
    TypeName: Vehicle::BaseController
    MsgId: 83
    MsgName: MovementInput
META_END
 */
using Aero.Gen.Attributes;
using System.Numerics;
namespace AeroMessages.GSS.Vehicle
{
    [Aero]
    public partial class Vehicle_Event_MovementInput
    {   
        public Vector3 Position;
        public Quaternion Rotation;
        public Vector3 Direction;
        public ushort MovementState;
        public uint Time;
    }
}