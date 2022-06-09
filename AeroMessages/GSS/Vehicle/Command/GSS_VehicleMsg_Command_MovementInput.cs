using Aero.Gen.Attributes;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Vehicle
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 27, 83)]
    public partial class Vehicle_Event_MovementInput
    {   
        public Vector3 Position;
        public Quaternion Rotation;
        public Vector3 Direction;
        public ushort MovementState;
        public uint Time;
    }
}