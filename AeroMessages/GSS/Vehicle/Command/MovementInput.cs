using Aero.Gen.Attributes;
using Aero.Protocol;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Vehicle.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssVehicleCommand.MovementInput, GssVehicleView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class MovementInput
    {
        public Vector3 Position;
        public Quaternion Rotation;
        public Vector3 Direction;
        public ushort MovementState;
        public uint Time;
    }
}