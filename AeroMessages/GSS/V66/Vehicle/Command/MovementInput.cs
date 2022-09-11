using Aero.Gen.Attributes;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Vehicle.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 27, 83)]
    public partial class MovementInput
    {   
        public Vector3 Position;
        public Quaternion Rotation;
        public Vector3 Direction;
        public ushort MovementState;
        public uint Time;
    }
}