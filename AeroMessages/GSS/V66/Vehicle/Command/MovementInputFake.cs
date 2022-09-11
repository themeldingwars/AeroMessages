using Aero.Gen.Attributes;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Vehicle.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 27, 84)]
    public partial class MovementInputFake
    {   
        public Vector3 Position;
        public Quaternion Rotation;
        public Vector3 Direction;
        public sbyte Unk;
        public ushort MovementState;
        public uint Time;
    }
}